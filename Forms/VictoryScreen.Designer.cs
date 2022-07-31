
namespace MemoryGame
{
    partial class VictoryScreen
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
            this.Label_MainMessage = new System.Windows.Forms.Label();
            this.Button_Retry = new System.Windows.Forms.Button();
            this.Button_MainMenu = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_MainMessage
            // 
            this.Label_MainMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_MainMessage.Location = new System.Drawing.Point(7, 5);
            this.Label_MainMessage.Margin = new System.Windows.Forms.Padding(2, 0, 11, 0);
            this.Label_MainMessage.Name = "Label_MainMessage";
            this.Label_MainMessage.Size = new System.Drawing.Size(423, 165);
            this.Label_MainMessage.TabIndex = 3;
            this.Label_MainMessage.Text = "Label_MainMessage";
            this.Label_MainMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Retry
            // 
            this.Button_Retry.AutoSize = true;
            this.Button_Retry.Location = new System.Drawing.Point(18, 196);
            this.Button_Retry.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Retry.Name = "Button_Retry";
            this.Button_Retry.Size = new System.Drawing.Size(80, 30);
            this.Button_Retry.TabIndex = 1;
            this.Button_Retry.Text = "New Round";
            this.Button_Retry.UseVisualStyleBackColor = true;
            this.Button_Retry.Click += new System.EventHandler(this.Button_Retry_Click);
            // 
            // Button_MainMenu
            // 
            this.Button_MainMenu.AutoSize = true;
            this.Button_MainMenu.Location = new System.Drawing.Point(329, 196);
            this.Button_MainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.Button_MainMenu.Name = "Button_MainMenu";
            this.Button_MainMenu.Size = new System.Drawing.Size(88, 32);
            this.Button_MainMenu.TabIndex = 0;
            this.Button_MainMenu.Text = "Main Menu";
            this.Button_MainMenu.UseVisualStyleBackColor = true;
            this.Button_MainMenu.Click += new System.EventHandler(this.Button_MainMenu_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.AutoSize = true;
            this.Button_Exit.Location = new System.Drawing.Point(170, 209);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(93, 23);
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.Text = "Quit Program";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // VictoryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 244);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_MainMenu);
            this.Controls.Add(this.Button_Retry);
            this.Controls.Add(this.Label_MainMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VictoryScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Victory Screen";
            this.Load += new System.EventHandler(this.VictoryScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_MainMessage;
        private System.Windows.Forms.Button Button_Retry;
        private System.Windows.Forms.Button Button_MainMenu;
        private System.Windows.Forms.Button Button_Exit;
    }
}