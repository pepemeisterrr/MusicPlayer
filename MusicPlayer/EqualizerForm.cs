using System;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using Guna.UI2.WinForms;
using Dark.Net;

namespace MusicPlayer
{
    public partial class EqualizerForm : Form
    {
        private int _currentChannel;

        public EqualizerForm(int currentChannel)
        {
            InitializeComponent();
            _currentChannel = currentChannel;
            InitializeEqualizer();
        }

        private void InitializeEqualizer()
        {

            EqBand1.Scroll += (sender, e) => { SetEqualizerBand(0, EqBand1.Value); };
            EqBand2.Scroll += (sender, e) => { SetEqualizerBand(1, EqBand2.Value); };
            EqBand3.Scroll += (sender, e) => { SetEqualizerBand(2, EqBand3.Value); };
            EqBand4.Scroll += (sender, e) => { SetEqualizerBand(3, EqBand4.Value); };
            EqBand5.Scroll += (sender, e) => { SetEqualizerBand(4, EqBand5.Value); };
            EqBand6.Scroll += (sender, e) => { SetEqualizerBand(5, EqBand6.Value); };
            EqBand7.Scroll += (sender, e) => { SetEqualizerBand(6, EqBand7.Value); };
            EqBand8.Scroll += (sender, e) => { SetEqualizerBand(7, EqBand8.Value); };
            EqBand9.Scroll += (sender, e) => { SetEqualizerBand(8, EqBand9.Value); };
            EqBand10.Scroll += (sender, e) => { SetEqualizerBand(9, EqBand10.Value); };

            BarBass.Scroll += (sender, e) => { SetBass(BarBass.Value); };
            BarTreble.Scroll += (sender, e) => { SetTreble(BarTreble.Value); };
            BarReverb.Scroll += (sender, e) => { SetReverb(BarReverb.Value); };

            EqBand1.Value = (int)EqualizerSettings.Bands[0].Gain;
            EqBand2.Value = (int)EqualizerSettings.Bands[1].Gain;
            EqBand3.Value = (int)EqualizerSettings.Bands[2].Gain;
            EqBand4.Value = (int)EqualizerSettings.Bands[3].Gain;
            EqBand5.Value = (int)EqualizerSettings.Bands[4].Gain;
            EqBand6.Value = (int)EqualizerSettings.Bands[5].Gain;
            EqBand7.Value = (int)EqualizerSettings.Bands[6].Gain;
            EqBand8.Value = (int)EqualizerSettings.Bands[7].Gain;
            EqBand9.Value = (int)EqualizerSettings.Bands[8].Gain;
            EqBand10.Value = (int)EqualizerSettings.Bands[9].Gain;
            BarBass.Value = (int)EqualizerSettings.Bands[0].Gain;
            BarTreble.Value = (int)EqualizerSettings.Bands[9].Gain;
            BarReverb.Value = (int)EqualizerSettings.ReverbLevel;
        }

        private void SetEqualizerBand(int bandIndex, int value)
        {
            if (_currentChannel != 0)
            {
                var eq = EqualizerSettings.Bands[bandIndex];
                eq.Gain = value;
                BASS_DX8_PARAMEQ eqParam = new BASS_DX8_PARAMEQ()
                {
                    fBandwidth = eq.Bandwidth,
                    fCenter = eq.Center,
                    fGain = eq.Gain
                };
                Bass.BASS_FXSetParameters(eq.FXHandle, eqParam);
            }
        }

        private void SetBass(int value)
        {
            if (_currentChannel != 0)
            {
                var eq = EqualizerSettings.Bands[0]; 
                eq.Gain = value;
                BASS_DX8_PARAMEQ eqParam = new BASS_DX8_PARAMEQ()
                {
                    fBandwidth = eq.Bandwidth,
                    fCenter = eq.Center,
                    fGain = eq.Gain
                };
                Bass.BASS_FXSetParameters(eq.FXHandle, eqParam);
            }
        }

        private void SetTreble(int value)
        {
            if (_currentChannel != 0)
            {
                var eq = EqualizerSettings.Bands[9]; 
                eq.Gain = value;
                BASS_DX8_PARAMEQ eqParam = new BASS_DX8_PARAMEQ()
                {
                    fBandwidth = eq.Bandwidth,
                    fCenter = eq.Center,
                    fGain = eq.Gain
                };
                Bass.BASS_FXSetParameters(eq.FXHandle, eqParam);
            }
        }

        private void SetReverb(int value)
        {
            if (_currentChannel != 0)
            {
                EqualizerSettings.ReverbLevel = value;
                BASS_DX8_REVERB reverbParam = new BASS_DX8_REVERB()
                {
                    fReverbMix = value
                };
                Bass.BASS_FXSetParameters(EqualizerSettings.ReverbHandle, reverbParam);
            }
        }

        private void EqBand3_Scroll(object sender, ScrollEventArgs e)
        {

        }

    }
}
