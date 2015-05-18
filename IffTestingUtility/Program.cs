using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Waverunner.Swg.IO;

namespace Waverunner.Swg.IO.IffTestingUtility
{
    class Program
    {
        private static string FilePath = @"wp_mle_lance_lightsaber_blade_s02.lsb";
        static void Main(string[] args)
        {
            var iff = new SwgIff(FilePath);

            var lsb = new LightsaberAppearance();

            iff.Open(lsb);

            Console.WriteLine("LSB " + lsb.AppearanceTemplate);
            Console.WriteLine("Sound: " + lsb.Sound);

            Console.WriteLine("Flicker: " + lsb.Flicker);
            foreach (LightsaberBlade blade in lsb.Blades) {
                Console.WriteLine("Blade - " + blade);
            }
            Console.ReadLine();
        }
    }

    public class LightsaberAppearance : ISwgIffHandler
    {
        private int _bladeIndex { get; set; }

        public string AppearanceTemplate { get; set; }
        public string Sound { get; set; }
        public LightsaberFlicker Flicker { get; set; }
        public List<LightsaberBlade> Blades { get; set; }

        public LightsaberAppearance() { Blades = new List<LightsaberBlade>(); }

        #region ISwgIffHandler
        public void OnEnterForm(string oldForm, string newForm, int size)
        {
            switch (newForm)
            {
                case "LGHT":
                    Flicker = new LightsaberFlicker();
                    break;
                case "BLAD":
                    LightsaberBlade blade = new LightsaberBlade();
                    Blades.Add(blade);
                    _bladeIndex = Blades.IndexOf(blade);
                    break;
                default: break;
            }
        }

        public void OnEnterChunk(IffDataStream chunkStream, string chunk, string currentForm, int size)
        {
            switch (currentForm)
            {
                case "0000": PopulateBase(chunkStream, chunk); break;
                case "LGHT": PopulateFlicker(chunkStream, chunk); break;
                case "BLAD": PopulateBlade(chunkStream, chunk); break;
                default: break;
            }
        }

        public bool CanHandleType(string type)
        {
            if (type.Equals("LSAT"))
                return true;
            else return false;
        }
        #endregion

        public void PopulateBase(IffDataStream data, string chunk)
        {
            switch (chunk)
            {
                case "BASE": AppearanceTemplate = data.ReadAscii(); break;
                case "ASND": Sound = data.ReadAscii(); break;
                default: break;
            }
        }

        public void PopulateBlade(IffDataStream data, string chunk)
        {
            LightsaberBlade blade = Blades[_bladeIndex];
            if (blade == null)
                return;

            switch (chunk)
            {
                case "SHDR": blade.Shader = data.ReadAscii(); break;
                case "LGTH": blade.Length = data.ReadFloat(); break;
                case "WDTH": blade.Width = data.ReadFloat(); break;
                case "OPEN": blade.OpenRate = data.ReadFloat(); break;
                case "CLOS": blade.CloseRate = data.ReadFloat(); break;
                default: break;
            }
        }

        public void PopulateFlicker(IffDataStream data, string chunk)
        {
            switch (chunk)
            {
                case "COLR": 
                    Flicker.Color = data.ReadRgba(); 
                    break;
                case "RANG":
                    Flicker.MinRange = data.ReadFloat();
                    Flicker.MaxRange = data.ReadFloat();
                    break;
                case "TIME":
                    Flicker.MinTime = data.ReadFloat();
                    Flicker.MaxTime = data.ReadFloat();
                    break;
                case "DAYN":
                    Flicker.IsDayNightAware = data.ReadBool();
                    break;
                default: break;
            }
        }
    }

    public class LightsaberBlade
    {
        public string Shader { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float OpenRate { get; set; }
        public float CloseRate { get; set; }

        public LightsaberBlade() { }

        public override string ToString()
        {
            return String.Format("Shader {0} with a length of {1} and an open rate of {2}", Shader, Length, OpenRate);
        }
    }

    public class LightsaberFlicker
    {
        public Color Color { get; set; }
        public float MinRange { get; set; }
        public float MaxRange { get; set; }
        public float MinTime { get; set; }
        public float MaxTime { get; set; }
        public bool IsDayNightAware { get; set; }

        public LightsaberFlicker() { }

        public override string ToString()
        {
            return String.Format("Color {0} with a max time of {1} and is this day/night aware? {2}", Color.ToString(), MaxTime, IsDayNightAware);
        }
    }
}
