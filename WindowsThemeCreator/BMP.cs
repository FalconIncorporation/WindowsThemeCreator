using System.IO;
using System.Collections.Generic;
using System.Drawing;


namespace WindowsThemeCreator
{
    public class BMP
    {
        private const string PATH = @"../../bitmaps/";
        private Dictionary<string, string> FILES = 
        #region files
            new Dictionary<string, string>()
            {
                { "Regedit", "regedit.bmp" }, { "Notepad", "notepad.bmp" }, { "MessageBox", "messagebox.bmp" }, { "Paint", "paint.bmp" }, { "Run", "run.bmp" }
            };
        #endregion
        private Dictionary<string, string> FILES_OUT =
        #region files_out
            new Dictionary<string, string>()
            {
                { "Regedit", "regeditOut.bmp" }, { "Notepad", "notepadOut.bmp" }, { "MessageBox", "messageboxOut.bmp" }, { "Paint", "paintOut.bmp" }, { "Run", "runOut.bmp" }
            };
        #endregion

        public BMP(Theme theme, string app = "Notepad", string path = PATH)
        {
            this.path = path;
            Init(app);
            CreateView(app, theme);
            this.Output = new Bitmap(path + FILES_OUT[app]);
            
        }

        private void Init(string app)
        {
            var di = Directory.CreateDirectory(Path.GetDirectoryName(this.path + FILES_OUT[app]));
            if (di.Exists)
            {
                //Log to file that it was already there
            }
            else
            {
                //Log to file that folder and file was created
            }
        }
        public void CreateView(string App, Theme theme)
        {
            var path = PATH + FILES[App];
            var imageOrigin = new Bitmap(path);
            var imageOutput = imageOrigin;

            int x, y;
            for(x=1; x<imageOrigin.Width-1; x++)
            {
                for(y=1; y<imageOrigin.Height-1; y++)
                {
                    Color pixelOrigin = imageOrigin.GetPixel(x, y);
                    var newColorKey = theme.ColorToStringKey(pixelOrigin, x, y);
                    if (newColorKey.Equals("Unknown")) continue;
                    imageOutput.SetPixel(x, y, theme.StringKeyToColor(newColorKey));
                }
            }

            imageOutput.Save(this.path + FILES_OUT[App]);
        }

        public string path { get; set; }
        public Bitmap Output { get; set; }
    }
}
