using System.Collections.Generic;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;

namespace MusicPlayer
{
    public static class EqualizerSettings
    {
        public static List<EQBand> Bands = new List<EQBand>()
        {
            new EQBand() { Bandwidth = 18f, Center = 80f, Gain = 0f },   // Band 1: 80 Hz
            new EQBand() { Bandwidth = 18f, Center = 170f, Gain = 0f },  // Band 2: 170 Hz
            new EQBand() { Bandwidth = 18f, Center = 310f, Gain = 0f },  // Band 3: 310 Hz
            new EQBand() { Bandwidth = 18f, Center = 600f, Gain = 0f },  // Band 4: 600 Hz
            new EQBand() { Bandwidth = 18f, Center = 1000f, Gain = 0f }, // Band 5: 1 kHz
            new EQBand() { Bandwidth = 18f, Center = 3000f, Gain = 0f }, // Band 6: 3 kHz
            new EQBand() { Bandwidth = 18f, Center = 6000f, Gain = 0f }, // Band 7: 6 kHz
            new EQBand() { Bandwidth = 18f, Center = 12000f, Gain = 0f },// Band 8: 12 kHz
            new EQBand() { Bandwidth = 18f, Center = 14000f, Gain = 0f },// Band 9: 14 kHz
            new EQBand() { Bandwidth = 18f, Center = 16000f, Gain = 0f } // Band 10: 16 kHz
        };

        public static float BassGain = 0f;
        public static float TrebleGain = 0f;
        public static float ReverbLevel { get; set; } = -96f;
        public static int ReverbHandle { get; set; } = 0;
    }

    public class EQBand
    {
        public float Bandwidth { get; set; }
        public float Center { get; set; }
        public float Gain { get; set; }
        public int FXHandle { get; set; } // FX handle for this band
    }
}
