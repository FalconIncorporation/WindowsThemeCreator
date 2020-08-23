using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsThemeCreator
{
    public class Theme
    {
        private const string PATH = @"../../themes/";

        public Theme(string name = "TestColors")
        {
            this.name = name + ".reg";
            this.path = PATH + this.name;
            this.fileData = ReadFile(this.path);
            this.keyColorPairs = GetComponents(this.fileData);
            Init();
        }

        private void Init()
        {
            var di = Directory.CreateDirectory(Path.GetDirectoryName(this.path));
            if(di.Exists)
            {
                //Log to file that it was already there
            }
            else
            {
                //Log to file that folder and file was created
            }
        }
        public List<string> ReadFile(string path)
        {
            var data = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            return data.ToList();
        }
        public Dictionary<string, Color> GetComponents(List<string> lines)
        {
            var pat = @".(\w+).{3}(\d+\s+\d+\s+\d+).";
            var result = new Dictionary<string, Color>();

            foreach (var line in lines)
            {
                var lineMatch = Regex.Match(line, pat, RegexOptions.IgnoreCase);
                if (lineMatch.Success)
                {
                    var colorSplit = lineMatch.Groups[2].Value.Split(' ');
                    var color = StringTabToColor(colorSplit);
                    result.Add(lineMatch.Groups[1].Value, color);
                }
            }

            return result;
        }
        public Color StringTabToColor(string[] colorSplit)
        {
            if (colorSplit.Length == 3)
            {
                var colorTab = new[] { int.Parse(colorSplit[0]), int.Parse(colorSplit[1]), int.Parse(colorSplit[2]) };
                return Color.FromArgb(colorTab[0], colorTab[1], colorTab[2]);
            }
            else
            {
                return Color.Black;
            }
        }
        public string ColorToStringKey(Color color, int x, int y)
        {
            int colorNumber = 0;
            colorNumber |= (color.R << 16) + (color.G << 8) + (color.B << 0);
            if      (colorNumber == 0xFF_80_80) return "ActiveBorder";
            else if (colorNumber == 0x80_FF_80) return "ActiveTitle";
            else if (colorNumber == 0xD7_D7_D7) return "AppWorkspace";
            else if (colorNumber == 0xFF_00_00) return "Background";
            else if (colorNumber == 0xFF_00_FF) return "ButtonAlternateFace";
            else if (colorNumber == 0xFF_80_40) return "ButtonDkShadow";
            else if (colorNumber == 0x00_40_80) return "ButtonFace";
            else if (colorNumber == 0xFF_00_80) return "ButtonHilight";
            else if (colorNumber == 0xFF_FF_80) return "ButtonLight";
            else if (colorNumber == 0x80_FF_FF) return "ButtonShadow";
            else if (colorNumber == 0xFF_80_C0) return "ButtonText";
            else if (colorNumber == 0x80_80_C0) return "GradientActiveTitle";
            else if (colorNumber == 0x80_40_40) return "GradientInactiveTitle";
            else if (colorNumber == 0x00_80_80) return "GrayText";
            else if (colorNumber == 0x80_00_40) return "Hilight";
            else if (colorNumber == 0x00_00_00) return "HilightText";
            else if (colorNumber == 0x40_FF_40) return "HotTrackingColor";
            else if (colorNumber == 0xC0_00_40) return "InactiveBorder";
            else if (colorNumber == 0xFF_FF_40) return "InactiveTitle";
            else if (colorNumber == 0x80_40_00) return "InactiveTitleText";
            else if (colorNumber == 0x40_C0_00) return "InfoText";
            else if (colorNumber == 0xC0_40_C0) return "InfoWindow";
            else if (colorNumber == 0x00_40_FF) return "Menu";
            else if (colorNumber == 0x40_C0_80) return "MenuBar";
            else if (colorNumber == 0x00_40_C0) return "MenuHilight";
            else if (colorNumber == 0xFF_C0_40) return "MenuText";
            else if (colorNumber == 0x40_40_40) return "Scrollbar";
            else if (colorNumber == 0xFF_40_40) return "TitleText";
            else if (colorNumber == 0xFF_FF_FF) return "Window";
            else if (colorNumber == 0xC0_C0_C0) return "WindowFrame";
            else if (colorNumber == 0x80_80_80) return "WindowText";
            else return "Unknown";
        }
        public Color StringKeyToColor(string key)
        {
            if (key.Equals("Unknown")) return Color.Black;
            return keyColorPairs[key];
        }

        public string name { get; set; }
        public string path { get; set; }
        public List<string> fileData { get; set; }
        public Dictionary<string, Color> keyColorPairs { get; set; }
    }
}
