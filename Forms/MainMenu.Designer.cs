
namespace MemoryGame
{
    partial class MainMenu
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
            this.Button_StartTwoPlayers = new System.Windows.Forms.Button();
            this.Button_StartSinglePlayer = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_ScoreBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_StartTwoPlayers
            // 
            this.Button_StartTwoPlayers.Location = new System.Drawing.Point(153, 167);
            this.Button_StartTwoPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.Button_StartTwoPlayers.Name = "Button_StartTwoPlayers";
            this.Button_StartTwoPlayers.Size = new System.Drawing.Size(130, 36);
            this.Button_StartTwoPlayers.TabIndex = 1;
            this.Button_StartTwoPlayers.Text = "1v1 Game";
            this.Button_StartTwoPlayers.UseVisualStyleBackColor = true;
            this.Button_StartTwoPlayers.Click += new System.EventHandler(this.Btn_startTwoPlayerGameB_Click);
            // 
            // Button_StartSinglePlayer
            // 
            this.Button_StartSinglePlayer.Location = new System.Drawing.Point(153, 127);
            this.Button_StartSinglePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.Button_StartSinglePlayer.Name = "Button_StartSinglePlayer";
            this.Button_StartSinglePlayer.Size = new System.Drawing.Size(130, 36);
            this.Button_StartSinglePlayer.TabIndex = 0;
            this.Button_StartSinglePlayer.Text = "Single-Player";
            this.Button_StartSinglePlayer.UseVisualStyleBackColor = true;
            this.Button_StartSinglePlayer.Click += new System.EventHandler(this.Button_StartSinglePlayer_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(153, 297);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(130, 36);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_ScoreBoard
            // 
            this.Button_ScoreBoard.Location = new System.Drawing.Point(153, 242);
            this.Button_ScoreBoard.Margin = new System.Windows.Forms.Padding(2);
            this.Button_ScoreBoard.Name = "Button_ScoreBoard";
            this.Button_ScoreBoard.Size = new System.Drawing.Size(130, 36);
            this.Button_ScoreBoard.TabIndex = 2;
            this.Button_ScoreBoard.Text = "1v1\r\nLeaderboard";
            this.Button_ScoreBoard.UseVisualStyleBackColor = true;
            this.Button_ScoreBoard.Click += new System.EventHandler(this.Button_Leaderboard_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.Internal_Asset_MenuBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 361);
            this.Controls.Add(this.Button_ScoreBoard);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_StartSinglePlayer);
            this.Controls.Add(this.Button_StartTwoPlayers);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainMenu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_StartTwoPlayers;
        private System.Windows.Forms.Button Button_StartSinglePlayer;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_ScoreBoard;
    }
}

