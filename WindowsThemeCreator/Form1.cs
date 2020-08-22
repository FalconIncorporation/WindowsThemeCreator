using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Drawing;

namespace WindowsThemeCreator
{
    public partial class Form1 : Form
    {
        private const string PATH = "../../themes/TestColors.reg";

        public Form1()
        {
            InitializeComponent();
            Main();
        }

        private void Main()
        {
            var fileLines = ReadFile(PATH);
            var componentDict = GetComponents(fileLines);
            UseTheme(componentDict);
        }

        private void Main(string path)
        {
            var fileLines = ReadFile(path);
            var componentDict = GetComponents(fileLines);
            UseTheme(componentDict);
        }

        public void UseTheme(Dictionary<string, string> theme)
        {
            foreach(var option in theme.Keys)
            {
                var colorSplit = theme[option].Split(' ');
                var colorTab = new[] { int.Parse(colorSplit[0]), int.Parse(colorSplit[1]), int.Parse(colorSplit[2]) };
                var color = Color.FromArgb(colorTab[0], colorTab[1], colorTab[2]);

                switch (option)
                {
                    //case "ActiveBorder": break;
                    //case "ActiveTitle": break;
                    //case "AppWorkspace": break;
                    //case "Background": break;
                    //case "ButtonAlternateFace": break;
                    //case "ButtonDkShadow": break;
                    //case "ButtonFace": break;
                    //case "ButtonHilight": break;
                    //case "ButtonLight": break;
                    //case "ButtonShadow": break;
                    //case "ButtonText": break;
                    //case "GradientActiveTitle": break;
                    //case "GradientInactiveTitle": break;
                    //case "GrayText": break;
                    //case "Hilight": break;
                    //case "HilightText": break;
                    //case "HotTrackingColor": break;
                    //case "InactiveBorder": break;
                    //case "InactiveTitle": break;
                    //case "InactiveTitleText": break;
                    //case "InfoText": break;
                    //case "InfoWindow": break;
                    //case "Menu": break;
                    //case "MenuBar": break;
                    //case "MenuHilight": break;
                    //case "MenuText": break;
                    //case "Scrollbar": break;
                    //case "TitleText": break;
                    case "Window": window.BackColor = color; break;
                    case "WindowFrame": frame.BackColor = color; break;
                    case "WindowText": window.ForeColor = color; break;
                    default: continue;
                }
            }
        }

        public List<string> ReadFile (string path)
        {
            var data = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            return data.ToList();
        }

        public Dictionary<string, string> GetComponents(List<string> lines)
        {
            var pat = @".(\w+).{3}(\d+\s+\d+\s+\d+).";
            var result = new Dictionary<string, string>();

            foreach(var line in lines)
            {
                var lineMatch = Regex.Match(line, pat, RegexOptions.IgnoreCase);
                if(lineMatch.Success)
                {
                    result.Add(lineMatch.Groups[1].Value, lineMatch.Groups[2].Value);
                }
            }
            
            return result;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Main();
        }
    }
}
