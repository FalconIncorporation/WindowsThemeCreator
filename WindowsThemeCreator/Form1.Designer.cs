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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.DarkRed;
            this.frame.Location = new System.Drawing.Point(16, 15);
            this.frame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.frame.Multiline = true;
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(283, 237);
            this.frame.TabIndex = 0;
            // 
            // window
            // 
            this.window.BackColor = System.Drawing.Color.Lime;
            this.window.ForeColor = System.Drawing.SystemColors.Highlight;
            this.window.Location = new System.Drawing.Point(29, 30);
            this.window.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.window.Multiline = true;
            this.window.Name = "window";
            this.window.Size = new System.Drawing.Size(256, 206);
            this.window.TabIndex = 1;
            this.window.Text = "Some tempurary text :D";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 511);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(306, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 332);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.window);
            this.Controls.Add(this.frame);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox frame;
        private System.Windows.Forms.TextBox window;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

