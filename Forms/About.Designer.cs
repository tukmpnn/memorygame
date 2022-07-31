
namespace MemoryGame
{
    partial class About
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
            this.Label_About = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_About
            // 
            this.Label_About.AutoSize = true;
            this.Label_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_About.Location = new System.Drawing.Point(21, 20);
            this.Label_About.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_About.Name = "Label_About";
            this.Label_About.Size = new System.Drawing.Size(140, 153);
            this.Label_About.TabIndex = 1;
            this.Label_About.Text = "Hotkeys:\r\nSpacebar = Pause\r\nPause = Pause\r\nEnter = Pause\r\nAlt + Q = Quit Game\r\n\r\n" +
    "\r\nCreated By: tukmpnn\r\nDate: Late 2021\r\n";
            // 
            // Button_OK
            // 
            this.Button_OK.AutoSize = true;
            this.Button_OK.Location = new System.Drawing.Point(76, 208);
            this.Button_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(106, 23);
            this.Button_OK.TabIndex = 0;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 241);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Label_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_About;
        private System.Windows.Forms.Button Button_OK;
    }
}