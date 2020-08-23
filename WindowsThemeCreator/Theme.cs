using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsThemeCreator
{
    public class Theme
    {
        private const string PATH = "../../themes/";

        public Theme(string name = "TestColors")
        {
            this.name = name + ".reg";
            this.path = PATH + this.name;
            this.fileData = ReadFile(this.path);
            this.keyColorPairs = GetComponents(this.fileData);
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
                    var colorTab = new[] { int.Parse(colorSplit[0]), int.Parse(colorSplit[1]), int.Parse(colorSplit[2]) };
                    var color = Color.FromArgb(colorTab[0], colorTab[1], colorTab[2]);
                    result.Add(lineMatch.Groups[1].Value, color);
                }
            }

            return result;
        }

        public string name { get; set; }
        public string path { get; set; }
        public List<string> fileData { get; set; }
        public Dictionary<string, Color> keyColorPairs { get; set; }
    }
}
