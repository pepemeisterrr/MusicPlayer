using Guna.UI2.WinForms;

namespace MusicPlayer
{
    partial class EqualizerForm
    {
        private Guna2VTrackBar EqBand1;
        private Guna2VTrackBar EqBand2;
        private Guna2VTrackBar EqBand4;
        private Guna2VTrackBar EqBand5;
        private Guna2VTrackBar EqBand6;
        private Guna2VTrackBar EqBand7;
        private Guna2VTrackBar EqBand8;
        private Guna2VTrackBar EqBand9;
        private Guna2VTrackBar EqBand10;
        private Guna2VTrackBar BarBass;
        private Guna2VTrackBar BarTreble;

        private void InitializeComponent()
        {
            EqBand1 = new Guna2VTrackBar();
            EqBand2 = new Guna2VTrackBar();
            EqBand3 = new Guna2VTrackBar();
            EqBand4 = new Guna2VTrackBar();
            EqBand5 = new Guna2VTrackBar();
            EqBand6 = new Guna2VTrackBar();
            EqBand7 = new Guna2VTrackBar();
            EqBand8 = new Guna2VTrackBar();
            EqBand9 = new Guna2VTrackBar();
            EqBand10 = new Guna2VTrackBar();
            BarBass = new Guna2VTrackBar();
            BarTreble = new Guna2VTrackBar();
            BarReverb = new Guna2VTrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // EqBand1
            // 
            EqBand1.Cursor = Cursors.Hand;
            EqBand1.Location = new Point(30, 43);
            EqBand1.Maximum = 20;
            EqBand1.Minimum = -20;
            EqBand1.Name = "EqBand1";
            EqBand1.Size = new Size(30, 200);
            EqBand1.TabIndex = 0;
            EqBand1.ThumbColor = Color.Aquamarine;
            EqBand1.Value = 0;
            // 
            // EqBand2
            // 
            EqBand2.Cursor = Cursors.Hand;
            EqBand2.Location = new Point(66, 43);
            EqBand2.Maximum = 20;
            EqBand2.Minimum = -20;
            EqBand2.Name = "EqBand2";
            EqBand2.Size = new Size(30, 200);
            EqBand2.TabIndex = 1;
            EqBand2.ThumbColor = Color.Aquamarine;
            EqBand2.Value = 0;
            // 
            // EqBand3
            // 
            EqBand3.Cursor = Cursors.Hand;
            EqBand3.Location = new Point(102, 43);
            EqBand3.Maximum = 20;
            EqBand3.Minimum = -20;
            EqBand3.Name = "EqBand3";
            EqBand3.Size = new Size(30, 200);
            EqBand3.TabIndex = 2;
            EqBand3.ThumbColor = Color.Aquamarine;
            EqBand3.Value = 0;
            EqBand3.Scroll += EqBand3_Scroll;
            // 
            // EqBand4
            // 
            EqBand4.Cursor = Cursors.Hand;
            EqBand4.Location = new Point(138, 43);
            EqBand4.Maximum = 20;
            EqBand4.Minimum = -20;
            EqBand4.Name = "EqBand4";
            EqBand4.Size = new Size(30, 200);
            EqBand4.TabIndex = 3;
            EqBand4.ThumbColor = Color.Aquamarine;
            EqBand4.Value = 0;
            // 
            // EqBand5
            // 
            EqBand5.Cursor = Cursors.Hand;
            EqBand5.Location = new Point(174, 43);
            EqBand5.Maximum = 20;
            EqBand5.Minimum = -20;
            EqBand5.Name = "EqBand5";
            EqBand5.Size = new Size(30, 200);
            EqBand5.TabIndex = 4;
            EqBand5.ThumbColor = Color.Aquamarine;
            EqBand5.Value = 0;
            // 
            // EqBand6
            // 
            EqBand6.Cursor = Cursors.Hand;
            EqBand6.Location = new Point(210, 43);
            EqBand6.Maximum = 20;
            EqBand6.Minimum = -20;
            EqBand6.Name = "EqBand6";
            EqBand6.Size = new Size(30, 200);
            EqBand6.TabIndex = 5;
            EqBand6.ThumbColor = Color.Aquamarine;
            EqBand6.Value = 0;
            // 
            // EqBand7
            // 
            EqBand7.Cursor = Cursors.Hand;
            EqBand7.Location = new Point(246, 43);
            EqBand7.Maximum = 20;
            EqBand7.Minimum = -20;
            EqBand7.Name = "EqBand7";
            EqBand7.Size = new Size(30, 200);
            EqBand7.TabIndex = 6;
            EqBand7.ThumbColor = Color.Aquamarine;
            EqBand7.Value = 0;
            // 
            // EqBand8
            // 
            EqBand8.Cursor = Cursors.Hand;
            EqBand8.Location = new Point(282, 43);
            EqBand8.Maximum = 20;
            EqBand8.Minimum = -20;
            EqBand8.Name = "EqBand8";
            EqBand8.Size = new Size(30, 200);
            EqBand8.TabIndex = 7;
            EqBand8.ThumbColor = Color.Aquamarine;
            EqBand8.Value = 0;
            // 
            // EqBand9
            // 
            EqBand9.Cursor = Cursors.Hand;
            EqBand9.Location = new Point(318, 43);
            EqBand9.Maximum = 20;
            EqBand9.Minimum = -20;
            EqBand9.Name = "EqBand9";
            EqBand9.Size = new Size(30, 200);
            EqBand9.TabIndex = 8;
            EqBand9.ThumbColor = Color.Aquamarine;
            EqBand9.Value = 0;
            // 
            // EqBand10
            // 
            EqBand10.Cursor = Cursors.Hand;
            EqBand10.Location = new Point(354, 43);
            EqBand10.Maximum = 20;
            EqBand10.Minimum = -20;
            EqBand10.Name = "EqBand10";
            EqBand10.Size = new Size(30, 200);
            EqBand10.TabIndex = 9;
            EqBand10.ThumbColor = Color.Aquamarine;
            EqBand10.Value = 0;
            // 
            // BarBass
            // 
            BarBass.Cursor = Cursors.Hand;
            BarBass.Location = new Point(395, 43);
            BarBass.Maximum = 20;
            BarBass.Minimum = -20;
            BarBass.Name = "BarBass";
            BarBass.Size = new Size(30, 200);
            BarBass.TabIndex = 10;
            BarBass.ThumbColor = Color.DarkOrange;
            BarBass.Value = 0;
            // 
            // BarTreble
            // 
            BarTreble.Cursor = Cursors.Hand;
            BarTreble.Location = new Point(448, 43);
            BarTreble.Maximum = 20;
            BarTreble.Minimum = -20;
            BarTreble.Name = "BarTreble";
            BarTreble.Size = new Size(30, 200);
            BarTreble.TabIndex = 11;
            BarTreble.ThumbColor = Color.DarkOrange;
            BarTreble.Value = 0;
            // 
            // BarReverb
            // 
            BarReverb.Cursor = Cursors.Hand;
            BarReverb.Location = new Point(510, 43);
            BarReverb.Maximum = 1;
            BarReverb.Minimum = -96;
            BarReverb.Name = "BarReverb";
            BarReverb.Size = new Size(30, 200);
            BarReverb.TabIndex = 12;
            BarReverb.ThumbColor = Color.DarkOrange;
            BarReverb.Value = -96;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(34, 256);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 13;
            label1.Text = "80";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aquamarine;
            label2.Location = new Point(64, 256);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 14;
            label2.Text = "170";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Aquamarine;
            label3.Location = new Point(100, 256);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 15;
            label3.Text = "310";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Aquamarine;
            label4.Location = new Point(138, 256);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 16;
            label4.Text = "600";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Aquamarine;
            label5.Location = new Point(180, 256);
            label5.Name = "label5";
            label5.Size = new Size(24, 17);
            label5.TabIndex = 17;
            label5.Text = "1k";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Aquamarine;
            label6.Location = new Point(216, 256);
            label6.Name = "label6";
            label6.Size = new Size(24, 17);
            label6.TabIndex = 18;
            label6.Text = "3k";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Aquamarine;
            label7.Location = new Point(252, 256);
            label7.Name = "label7";
            label7.Size = new Size(24, 17);
            label7.TabIndex = 19;
            label7.Text = "6k";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Aquamarine;
            label8.Location = new Point(280, 256);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 20;
            label8.Text = "12k";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Aquamarine;
            label9.Location = new Point(316, 256);
            label9.Name = "label9";
            label9.Size = new Size(32, 17);
            label9.TabIndex = 21;
            label9.Text = "14k";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Aquamarine;
            label10.Location = new Point(352, 256);
            label10.Name = "label10";
            label10.Size = new Size(32, 17);
            label10.TabIndex = 22;
            label10.Text = "16k";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkOrange;
            label11.Location = new Point(391, 256);
            label11.Name = "label11";
            label11.Size = new Size(40, 17);
            label11.TabIndex = 23;
            label11.Text = "bass";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkOrange;
            label12.Location = new Point(437, 256);
            label12.Name = "label12";
            label12.Size = new Size(56, 17);
            label12.TabIndex = 24;
            label12.Text = "treble";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkOrange;
            label13.Location = new Point(499, 256);
            label13.Name = "label13";
            label13.Size = new Size(56, 17);
            label13.TabIndex = 25;
            label13.Text = "reverb";
            // 
            // EqualizerForm
            // 
            BackColor = Color.Black;
            ClientSize = new Size(569, 316);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BarReverb);
            Controls.Add(EqBand1);
            Controls.Add(EqBand2);
            Controls.Add(EqBand3);
            Controls.Add(EqBand4);
            Controls.Add(EqBand5);
            Controls.Add(EqBand6);
            Controls.Add(EqBand7);
            Controls.Add(EqBand8);
            Controls.Add(EqBand9);
            Controls.Add(EqBand10);
            Controls.Add(BarBass);
            Controls.Add(BarTreble);
            MinimumSize = new Size(570, 325);
            Name = "EqualizerForm";
            Opacity = 0.99D;
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Equalizer";
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna2VTrackBar EqBand3;
        private Guna2VTrackBar BarReverb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
