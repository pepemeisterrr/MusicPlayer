using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using TagLib;
using Guna.UI2.WinForms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private List<string> _filePaths = new List<string>();
        private int _currentTrackIndex = -1;
        private int _currentChannel = 0;
        private bool _isPlaying = false;
        private System.Windows.Forms.Timer _timer;
        private SYNCPROC _syncProc;
        private int _syncHandle;
        private float _currentVolume = 1.0f;
        private List<int> _eqHandles = new List<int>();
        public Form1()
        {
            InitializeComponent();
            BassNet.Registration("kostya13022@gmail.com", "2X20241221152222");
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
            {
                MessageBox.Show("BASS initialization error!");
            }

            _syncProc = new SYNCPROC(EndTrackSync);
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            BassFx.BASS_FX_GetVersion();
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                playB.Image = Properties.Resources.play;
                Bass.BASS_ChannelPause(_currentChannel);
                _isPlaying = false;
                _timer.Stop();
            }
            else
            {
                playB.Image = Properties.Resources.pause;
                if (_currentChannel != 0)
                {
                    Bass.BASS_ChannelPlay(_currentChannel, false);
                    _isPlaying = true;
                    _timer.Start();
                }
                else if (_filePaths.Count > 0 && _currentTrackIndex == -1)
                {
                    PlayTrack(0);
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_filePaths.Count > 0)
            {
                int nextIndex = (_currentTrackIndex + 1) % _filePaths.Count;
                PlayTrack(nextIndex);
                listBoxSongs.SelectedIndex = nextIndex;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (_filePaths.Count > 0)
            {
                int prevIndex = (_currentTrackIndex - 1 + _filePaths.Count) % _filePaths.Count;
                PlayTrack(prevIndex);
                listBoxSongs.SelectedIndex = prevIndex;
            }
        }

        private void trackBarVolume_ValueChanged(object sender, EventArgs e)
        {
            if (_currentChannel != 0)
            {
                _currentVolume = VolumeBar.Value / 100f;
                Bass.BASS_ChannelSetAttribute(_currentChannel, BASSAttribute.BASS_ATTRIB_VOL, _currentVolume);
            }
        }

        private void TrackBarProgress_Scroll(object sender, ScrollEventArgs e)
        {
            if (_currentChannel != 0)
            {
                long position = Bass.BASS_ChannelSeconds2Bytes(_currentChannel, TrackBarProgress.Value);
                Bass.BASS_ChannelSetPosition(_currentChannel, position);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_currentChannel != 0)
            {
                long position = Bass.BASS_ChannelGetPosition(_currentChannel);
                double elapsedTime = Bass.BASS_ChannelBytes2Seconds(_currentChannel, position);
                lblCurrentTime.Text = TimeSpan.FromSeconds(elapsedTime).ToString(@"mm\:ss");

                long length = Bass.BASS_ChannelGetLength(_currentChannel);
                double totalDuration = Bass.BASS_ChannelBytes2Seconds(_currentChannel, length);
                lblTotalTime.Text = TimeSpan.FromSeconds(totalDuration).ToString(@"mm\:ss");
                TrackBarProgress.Maximum = (int)Math.Max(totalDuration, 1);
                TrackBarProgress.Value = (int)elapsedTime;
            }
        }

        private void PlayTrack(int index)
        {
            if (_currentChannel != 0)
            {
                Bass.BASS_ChannelStop(_currentChannel);
                Bass.BASS_StreamFree(_currentChannel);
            }

            _currentTrackIndex = index;
            _currentChannel = Bass.BASS_StreamCreateFile(_filePaths[index], 0, 0, BASSFlag.BASS_DEFAULT);

            if (_currentChannel == 0)
            {
                MessageBox.Show("Error loading track.");
                return;
            }

            Bass.BASS_ChannelSetAttribute(_currentChannel, BASSAttribute.BASS_ATTRIB_VOL, _currentVolume); // Apply the current volume

            _syncHandle = Bass.BASS_ChannelSetSync(_currentChannel, BASSSync.BASS_SYNC_END, 0, _syncProc, IntPtr.Zero);

            // Display song info
            var tagFile = TagLib.File.Create(_filePaths[index]);
            lblSongName.Text = string.IsNullOrWhiteSpace(tagFile.Tag.Title) ? System.IO.Path.GetFileName(_filePaths[index]) : tagFile.Tag.Title;
            lblArtistName.Text = string.IsNullOrWhiteSpace(tagFile.Tag.FirstPerformer) ? "Unknown Artist" : tagFile.Tag.FirstPerformer;

            if (tagFile.Tag.Pictures.Length > 0)
            {
                var bin = (byte[])(tagFile.Tag.Pictures[0].Data.Data);
                pictureBoxAlbumArt.Image = Image.FromStream(new System.IO.MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
            }
            else
            {
                pictureBoxAlbumArt.Image = null;
            }

            InitializeEqualizer();
            UpdateEqualizer();
            InitializeReverb();
            UpdateReverb();

            Bass.BASS_ChannelPlay(_currentChannel, false);
            _isPlaying = true;
            _timer.Start();
        }

        private void EndTrackSync(int handle, int channel, int data, IntPtr user)
        {
            this.BeginInvoke(new Action(() =>
            {
                int nextIndex = (_currentTrackIndex + 1) % _filePaths.Count;
                PlayTrack(nextIndex);
                listBoxSongs.SelectedIndex = nextIndex;
            }));
        }


        private void FileManager_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Audio Files|*.mp3;*.wav;*.flac";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                _filePaths.AddRange(openFileDialog.FileNames);
                foreach (var file in openFileDialog.FileNames)
                {
                    var tagFile = TagLib.File.Create(file);
                    string displayName = string.IsNullOrWhiteSpace(tagFile.Tag.Title)
                        ? System.IO.Path.GetFileName(file)
                        : $"{tagFile.Tag.Title} - {tagFile.Tag.FirstPerformer}";

                    listBoxSongs.Items.Add(displayName);
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex != -1)
            {
                PlayTrack(listBoxSongs.SelectedIndex);
                playB.Image = Properties.Resources.pause;
            }
        }

        private void InitializeEqualizer()
        {
            foreach (var eq in EqualizerSettings.Bands)
            {
                if (eq.FXHandle != 0)
                {
                    Bass.BASS_ChannelRemoveFX(_currentChannel, eq.FXHandle);
                }
            }

            _eqHandles.Clear();

            foreach (var eq in EqualizerSettings.Bands)
            {
                eq.FXHandle = Bass.BASS_ChannelSetFX(_currentChannel, BASSFXType.BASS_FX_DX8_PARAMEQ, 1);
                _eqHandles.Add(eq.FXHandle);

                BASS_DX8_PARAMEQ eqParam = new BASS_DX8_PARAMEQ()
                {
                    fBandwidth = eq.Bandwidth,
                    fCenter = eq.Center,
                    fGain = eq.Gain
                };
                Bass.BASS_FXSetParameters(eq.FXHandle, eqParam);
            }
        }

        private void UpdateEqualizer()
        {
            foreach (var eq in EqualizerSettings.Bands)
            {
                BASS_DX8_PARAMEQ eqParam = new BASS_DX8_PARAMEQ()
                {
                    fBandwidth = eq.Bandwidth,
                    fCenter = eq.Center,
                    fGain = eq.Gain
                };
                Bass.BASS_FXSetParameters(eq.FXHandle, eqParam);
            }
        }

        private void InitializeReverb()
        {
            if (EqualizerSettings.ReverbHandle != 0)
            {
                Bass.BASS_ChannelRemoveFX(_currentChannel, EqualizerSettings.ReverbHandle);
            }

            EqualizerSettings.ReverbHandle = Bass.BASS_ChannelSetFX(_currentChannel, BASSFXType.BASS_FX_DX8_REVERB, 1);

            BASS_DX8_REVERB reverbParam = new BASS_DX8_REVERB()
            {
                fReverbMix = EqualizerSettings.ReverbLevel
            };
            Bass.BASS_FXSetParameters(EqualizerSettings.ReverbHandle, reverbParam);
        }

        private void UpdateReverb()
        {
            BASS_DX8_REVERB reverbParam = new BASS_DX8_REVERB()
            {
                fReverbMix = EqualizerSettings.ReverbLevel
            };
            Bass.BASS_FXSetParameters(EqualizerSettings.ReverbHandle, reverbParam);
        }

        private void btnOpenEqualizer_Click(object sender, EventArgs e)
        {
            if (_currentChannel != 0)
            {
                EqualizerForm equalizerForm = new EqualizerForm(_currentChannel);
                equalizerForm.Show();
            }
            else
            {
                MessageBox.Show("No track is currently playing.");
            }
        }

        private void btnClearSongs_Click(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                MessageBox.Show("Please stop the song before clearing the list.");
                return;
            }

            if (_currentChannel != 0)
            {
                Bass.BASS_ChannelStop(_currentChannel);
                Bass.BASS_StreamFree(_currentChannel);
                _currentChannel = 0;
                _currentTrackIndex = -1;
            }

            _filePaths.Clear();
            listBoxSongs.Items.Clear();
            lblSongName.Text = string.Empty;
            lblArtistName.Text = string.Empty;
            pictureBoxAlbumArt.Image = null;
            TrackBarProgress.Value = 0;
            lblCurrentTime.Text = "00:00";
            lblTotalTime.Text = "00:00";

        }

        private void listBoxSongs_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkOrange), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(listBoxSongs.BackColor), e.Bounds);
            }

            // Draw the text
            e.Graphics.DrawString(listBoxSongs.Items[e.Index].ToString(), e.Font, new SolidBrush(listBoxSongs.ForeColor), e.Bounds);

            // Draw the focus rectangle
            e.DrawFocusRectangle();
        }
    }
}
