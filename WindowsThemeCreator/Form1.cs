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
        private Theme testTheme = new Theme();

        public Form1()
        {
            InitializeComponent();
            Main();
        }

        private void Main()
        {
            Bitmap image;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            image = new Bitmap("../../../tmp/smiley.ppm");
            pictureBox1.ClientSize = new Size(32, 32);
            pictureBox1.Image = (Image)image;
            UseTheme(testTheme);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Main();
        }

        public void UseTheme(Theme theme)
        {
            foreach(var option in theme.keyColorPairs.Keys)
            {
                var color = theme.keyColorPairs[option];

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
    }
}
