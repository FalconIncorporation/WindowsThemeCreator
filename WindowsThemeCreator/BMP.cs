using System.IO;
using System.Collections.Generic;


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

        public BMP(string path = PATH)
        {
            this.path = path;
        }

        private void Init()
        {
            var di = Directory.CreateDirectory(Path.GetDirectoryName(this.path));
            if (di.Exists)
            {
                //Log to file that it was already there
            }
            else
            {
                //Log to file that folder and file was created
            }
        }

        public string path { get; set; }
    }
}
