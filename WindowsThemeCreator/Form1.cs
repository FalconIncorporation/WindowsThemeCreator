using System.Windows.Forms;
using System.Drawing;

namespace WindowsThemeCreator
{
    public partial class Form1 : Form
    {
        Theme testTheme = new Theme();

        ToolStripMenuItem toolStripMenuItem;
        TextBox textBox;
        ushort value;

        public Form1()
        {
            InitializeComponent();
            Main();
        }

        void Main()
        {
            UseTheme(testTheme);
            AddEvents();
        }

        void UseTheme(Theme theme)
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
                    //case "Window": window.BackColor = color; break;
                    //case "WindowFrame": frame.BackColor = color; break;
                    //case "WindowText": window.ForeColor = color; break;
                    //default: continue;
                }
            }
        }

        void AddEvents()
        {
            helpToolStripMenuItem.Click += ToolStripMenuItem_Click;
            authorsToolStripMenuItem.Click += ToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ToolStripMenuItem_Click;

            textBox1.KeyPress += TextBox_KeyPress;
            textBox2.KeyPress += TextBox_KeyPress;
            textBox3.KeyPress += TextBox_KeyPress;
            textBox4.KeyPress += TextBox_KeyPress;
        }

        void ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            toolStripMenuItem = (ToolStripMenuItem)sender;

            if (toolStripMenuItem.Text == "Help")
                MessageBox.Show("Some help text", "Help");
            else if (toolStripMenuItem.Text == "Authors")
                MessageBox.Show("Marcin Sokołowski, Michał Skowron", "Authors");
            else
                Application.Exit();
        }

        void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox = (TextBox)sender;

            if (e.KeyChar == (char)Keys.Back)
                return;

            if (char.IsDigit(e.KeyChar))
            {
                value = ushort.Parse(string.Format("{0}{1}", textBox.Text, e.KeyChar));

                if (value >= 0 && value <= 255)
                {
                    textBox.Text = value.ToString();
                    textBox.SelectionStart = textBox.Text.Length;
                    label5.BackColor = Color.FromArgb(ushort.Parse(textBox1.Text), ushort.Parse(textBox2.Text), ushort.Parse(textBox3.Text), ushort.Parse(textBox4.Text));
                }
            }

            e.Handled = true;
        }
    }
}
