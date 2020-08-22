namespace WindowsThemeCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frame = new System.Windows.Forms.TextBox();
            this.window = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.DarkRed;
            this.frame.Location = new System.Drawing.Point(12, 12);
            this.frame.Multiline = true;
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(213, 193);
            this.frame.TabIndex = 0;
            // 
            // window
            // 
            this.window.BackColor = System.Drawing.Color.Lime;
            this.window.ForeColor = System.Drawing.SystemColors.Highlight;
            this.window.Location = new System.Drawing.Point(22, 24);
            this.window.Multiline = true;
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(193, 168);
            this.window.TabIndex = 1;
            this.window.Text = "Some tempurary text :D";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.window);
            this.Controls.Add(this.frame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frame;
        private System.Windows.Forms.TextBox window;
        private System.Windows.Forms.Button button1;
    }
}

