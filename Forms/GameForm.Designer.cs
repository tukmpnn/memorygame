
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Linq;

namespace MemoryGame
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.FlowLayoutPanel_Cards = new System.Windows.Forms.FlowLayoutPanel();
            this.Timer_CorrectPick = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip_Bottom = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_Bottom_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer_FailedPick = new System.Windows.Forms.Timer(this.components);
            this.Panel_GameIndcator = new System.Windows.Forms.Panel();
            this.ProgressBar_Panel_GameIndicator = new System.Windows.Forms.ProgressBar();
            this.Label_P1_Score = new System.Windows.Forms.Label();
            this.Label_P1_Name = new System.Windows.Forms.Label();
            this.Label_P2_Name = new System.Windows.Forms.Label();
            this.Label_P2_Score = new System.Windows.Forms.Label();
            this.flowLayoutPanel_leftPlayerPit = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_P1_ColorIndicator = new System.Windows.Forms.Label();
            this.Picturebox_P1_TurnIndicator = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel_rightPlayerPit = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_P2_ColorIndicator = new System.Windows.Forms.Label();
            this.Picturebox_P2_TurnIndicator = new System.Windows.Forms.PictureBox();
            this.Timer_TurnTimer = new System.Windows.Forms.Timer(this.components);
            this.Timer_TimeRanOutTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_Top_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Top_File_Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Top_File_Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Top_File_Main_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Top_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Top_About = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip_Bottom.SuspendLayout();
            this.Panel_GameIndcator.SuspendLayout();
            this.flowLayoutPanel_leftPlayerPit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_P1_TurnIndicator)).BeginInit();
            this.flowLayoutPanel_rightPlayerPit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_P2_TurnIndicator)).BeginInit();
            this.MenuStrip_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel_Cards
            // 
            this.FlowLayoutPanel_Cards.AutoSize = true;
            this.FlowLayoutPanel_Cards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel_Cards.Location = new System.Drawing.Point(7, 91);
            this.FlowLayoutPanel_Cards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 32);
            this.FlowLayoutPanel_Cards.MaximumSize = new System.Drawing.Size(1000, 0);
            this.FlowLayoutPanel_Cards.MinimumSize = new System.Drawing.Size(218, 200);
            this.FlowLayoutPanel_Cards.Name = "FlowLayoutPanel_Cards";
            this.FlowLayoutPanel_Cards.Size = new System.Drawing.Size(218, 200);
            this.FlowLayoutPanel_Cards.TabIndex = 4;
            // 
            // Timer_CorrectPick
            // 
            this.Timer_CorrectPick.Interval = 10;
            this.Timer_CorrectPick.Tick += new System.EventHandler(this.Timer_CorrectPick_Tick);
            // 
            // StatusStrip_Bottom
            // 
            this.StatusStrip_Bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusStrip_Bottom.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.StatusStrip_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_Bottom_StatusLabel});
            this.StatusStrip_Bottom.Location = new System.Drawing.Point(0, 312);
            this.StatusStrip_Bottom.Margin = new System.Windows.Forms.Padding(0, 54, 0, 0);
            this.StatusStrip_Bottom.Name = "StatusStrip_Bottom";
            this.StatusStrip_Bottom.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.StatusStrip_Bottom.Size = new System.Drawing.Size(322, 22);
            this.StatusStrip_Bottom.TabIndex = 5;
            this.StatusStrip_Bottom.Text = "statusStrip1";
            // 
            // StatusStrip_Bottom_StatusLabel
            // 
            this.StatusStrip_Bottom_StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip_Bottom_StatusLabel.Name = "StatusStrip_Bottom_StatusLabel";
            this.StatusStrip_Bottom_StatusLabel.Size = new System.Drawing.Size(173, 17);
            this.StatusStrip_Bottom_StatusLabel.Text = "StatusStrip_Bottom_StatusLabel";
            // 
            // Timer_FailedPick
            // 
            this.Timer_FailedPick.Interval = 10;
            this.Timer_FailedPick.Tick += new System.EventHandler(this.Timer_FailedPick_Tick);
            // 
            // Panel_GameIndcator
            // 
            this.Panel_GameIndcator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_GameIndcator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_GameIndcator.Controls.Add(this.ProgressBar_Panel_GameIndicator);
            this.Panel_GameIndcator.Location = new System.Drawing.Point(7, 60);
            this.Panel_GameIndcator.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.Panel_GameIndcator.Name = "Panel_GameIndcator";
            this.Panel_GameIndcator.Size = new System.Drawing.Size(313, 24);
            this.Panel_GameIndcator.TabIndex = 3;
            // 
            // ProgressBar_Panel_GameIndicator
            // 
            this.ProgressBar_Panel_GameIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar_Panel_GameIndicator.Location = new System.Drawing.Point(0, 2);
            this.ProgressBar_Panel_GameIndicator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProgressBar_Panel_GameIndicator.Name = "ProgressBar_Panel_GameIndicator";
            this.ProgressBar_Panel_GameIndicator.Size = new System.Drawing.Size(311, 21);
            this.ProgressBar_Panel_GameIndicator.TabIndex = 0;
            // 
            // Label_P1_Score
            // 
            this.Label_P1_Score.AutoSize = true;
            this.Label_P1_Score.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Label_P1_Score.Font = new System.Drawing.Font("ROG Fonts", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_P1_Score.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_P1_Score.Location = new System.Drawing.Point(29, 0);
            this.Label_P1_Score.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.Label_P1_Score.Name = "Label_P1_Score";
            this.Label_P1_Score.Size = new System.Drawing.Size(50, 26);
            this.Label_P1_Score.TabIndex = 1;
            this.Label_P1_Score.Text = "00";
            // 
            // Label_P1_Name
            // 
            this.Label_P1_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_P1_Name.AutoSize = true;
            this.Label_P1_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_P1_Name.Location = new System.Drawing.Point(86, 3);
            this.Label_P1_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label_P1_Name.Name = "Label_P1_Name";
            this.Label_P1_Name.Size = new System.Drawing.Size(21, 24);
            this.Label_P1_Name.TabIndex = 2;
            this.Label_P1_Name.Text = "n";
            // 
            // Label_P2_Name
            // 
            this.Label_P2_Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label_P2_Name.AutoSize = true;
            this.Label_P2_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_P2_Name.Location = new System.Drawing.Point(34, 3);
            this.Label_P2_Name.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.Label_P2_Name.Name = "Label_P2_Name";
            this.Label_P2_Name.Size = new System.Drawing.Size(19, 24);
            this.Label_P2_Name.TabIndex = 0;
            this.Label_P2_Name.Text = "s";
            // 
            // Label_P2_Score
            // 
            this.Label_P2_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_P2_Score.AutoSize = true;
            this.Label_P2_Score.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Label_P2_Score.Font = new System.Drawing.Font("ROG Fonts", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_P2_Score.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_P2_Score.Location = new System.Drawing.Point(60, 0);
            this.Label_P2_Score.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.Label_P2_Score.Name = "Label_P2_Score";
            this.Label_P2_Score.Size = new System.Drawing.Size(50, 26);
            this.Label_P2_Score.TabIndex = 1;
            this.Label_P2_Score.Text = "00";
            // 
            // flowLayoutPanel_leftPlayerPit
            // 
            this.flowLayoutPanel_leftPlayerPit.AutoSize = true;
            this.flowLayoutPanel_leftPlayerPit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_leftPlayerPit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_leftPlayerPit.Controls.Add(this.Label_P1_ColorIndicator);
            this.flowLayoutPanel_leftPlayerPit.Controls.Add(this.Label_P1_Score);
            this.flowLayoutPanel_leftPlayerPit.Controls.Add(this.Label_P1_Name);
            this.flowLayoutPanel_leftPlayerPit.Controls.Add(this.Picturebox_P1_TurnIndicator);
            this.flowLayoutPanel_leftPlayerPit.Location = new System.Drawing.Point(7, 24);
            this.flowLayoutPanel_leftPlayerPit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel_leftPlayerPit.Name = "flowLayoutPanel_leftPlayerPit";
            this.flowLayoutPanel_leftPlayerPit.Size = new System.Drawing.Size(145, 35);
            this.flowLayoutPanel_leftPlayerPit.TabIndex = 1;
            // 
            // Label_P1_ColorIndicator
            // 
            this.Label_P1_ColorIndicator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_P1_ColorIndicator.AutoSize = true;
            this.Label_P1_ColorIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_P1_ColorIndicator.Location = new System.Drawing.Point(2, 3);
            this.Label_P1_ColorIndicator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_P1_ColorIndicator.Name = "Label_P1_ColorIndicator";
            this.Label_P1_ColorIndicator.Size = new System.Drawing.Size(20, 24);
            this.Label_P1_ColorIndicator.TabIndex = 0;
            this.Label_P1_ColorIndicator.Text = "1";
            // 
            // Picturebox_P1_TurnIndicator
            // 
            this.Picturebox_P1_TurnIndicator.Image = global::MemoryGame.Properties.Resources.Internal_Asset_double_arrow_left;
            this.Picturebox_P1_TurnIndicator.Location = new System.Drawing.Point(114, 2);
            this.Picturebox_P1_TurnIndicator.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Picturebox_P1_TurnIndicator.Name = "Picturebox_P1_TurnIndicator";
            this.Picturebox_P1_TurnIndicator.Size = new System.Drawing.Size(27, 27);
            this.Picturebox_P1_TurnIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picturebox_P1_TurnIndicator.TabIndex = 2;
            this.Picturebox_P1_TurnIndicator.TabStop = false;
            // 
            // flowLayoutPanel_rightPlayerPit
            // 
            this.flowLayoutPanel_rightPlayerPit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel_rightPlayerPit.AutoSize = true;
            this.flowLayoutPanel_rightPlayerPit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel_rightPlayerPit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_rightPlayerPit.Controls.Add(this.Label_P2_ColorIndicator);
            this.flowLayoutPanel_rightPlayerPit.Controls.Add(this.Label_P2_Score);
            this.flowLayoutPanel_rightPlayerPit.Controls.Add(this.Label_P2_Name);
            this.flowLayoutPanel_rightPlayerPit.Controls.Add(this.Picturebox_P2_TurnIndicator);
            this.flowLayoutPanel_rightPlayerPit.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_rightPlayerPit.Location = new System.Drawing.Point(177, 24);
            this.flowLayoutPanel_rightPlayerPit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel_rightPlayerPit.Name = "flowLayoutPanel_rightPlayerPit";
            this.flowLayoutPanel_rightPlayerPit.Size = new System.Drawing.Size(140, 35);
            this.flowLayoutPanel_rightPlayerPit.TabIndex = 2;
            // 
            // Label_P2_ColorIndicator
            // 
            this.Label_P2_ColorIndicator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_P2_ColorIndicator.AutoSize = true;
            this.Label_P2_ColorIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_P2_ColorIndicator.Location = new System.Drawing.Point(114, 3);
            this.Label_P2_ColorIndicator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_P2_ColorIndicator.Name = "Label_P2_ColorIndicator";
            this.Label_P2_ColorIndicator.Size = new System.Drawing.Size(20, 24);
            this.Label_P2_ColorIndicator.TabIndex = 2;
            this.Label_P2_ColorIndicator.Text = "1";
            // 
            // Picturebox_P2_TurnIndicator
            // 
            this.Picturebox_P2_TurnIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Picturebox_P2_TurnIndicator.Image = global::MemoryGame.Properties.Resources.Internal_Asset_double_arrow_right;
            this.Picturebox_P2_TurnIndicator.Location = new System.Drawing.Point(0, 2);
            this.Picturebox_P2_TurnIndicator.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.Picturebox_P2_TurnIndicator.Name = "Picturebox_P2_TurnIndicator";
            this.Picturebox_P2_TurnIndicator.Size = new System.Drawing.Size(27, 27);
            this.Picturebox_P2_TurnIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picturebox_P2_TurnIndicator.TabIndex = 7;
            this.Picturebox_P2_TurnIndicator.TabStop = false;
            // 
            // Timer_TurnTimer
            // 
            this.Timer_TurnTimer.Interval = 10;
            this.Timer_TurnTimer.Tick += new System.EventHandler(this.Timer_TurnTimer_Tick);
            // 
            // Timer_TimeRanOutTimer
            // 
            this.Timer_TimeRanOutTimer.Interval = 10;
            this.Timer_TimeRanOutTimer.Tick += new System.EventHandler(this.Timer_TimeRanOutTimer_Tick);
            // 
            // MenuStrip_Top
            // 
            this.MenuStrip_Top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MenuStrip_Top.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Top_File,
            this.MenuStrip_Top_About});
            this.MenuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Top.Name = "MenuStrip_Top";
            this.MenuStrip_Top.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.MenuStrip_Top.Size = new System.Drawing.Size(322, 24);
            this.MenuStrip_Top.TabIndex = 0;
            this.MenuStrip_Top.Text = "menuStrip1";
            // 
            // MenuStrip_Top_File
            // 
            this.MenuStrip_Top_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Top_File_Pause,
            this.MenuStrip_Top_File_Restart,
            this.MenuStrip_Top_File_Main_Menu,
            this.MenuStrip_Top_File_Exit});
            this.MenuStrip_Top_File.Name = "MenuStrip_Top_File";
            this.MenuStrip_Top_File.Size = new System.Drawing.Size(37, 22);
            this.MenuStrip_Top_File.Text = "File";
            // 
            // MenuStrip_Top_File_Pause
            // 
            this.MenuStrip_Top_File_Pause.Name = "MenuStrip_Top_File_Pause";
            this.MenuStrip_Top_File_Pause.ShowShortcutKeys = false;
            this.MenuStrip_Top_File_Pause.Size = new System.Drawing.Size(135, 22);
            this.MenuStrip_Top_File_Pause.Text = "Pause";
            this.MenuStrip_Top_File_Pause.Click += new System.EventHandler(this.MenuStrip_Top_File_Pause_Click);
            // 
            // MenuStrip_Top_File_Restart
            // 
            this.MenuStrip_Top_File_Restart.Name = "MenuStrip_Top_File_Restart";
            this.MenuStrip_Top_File_Restart.ShowShortcutKeys = false;
            this.MenuStrip_Top_File_Restart.Size = new System.Drawing.Size(135, 22);
            this.MenuStrip_Top_File_Restart.Text = "Restart";
            this.MenuStrip_Top_File_Restart.Click += new System.EventHandler(this.MenuStrip_Top_File_Restart_Click);
            // 
            // MenuStrip_Top_File_Main_Menu
            // 
            this.MenuStrip_Top_File_Main_Menu.Name = "MenuStrip_Top_File_Main_Menu";
            this.MenuStrip_Top_File_Main_Menu.ShowShortcutKeys = false;
            this.MenuStrip_Top_File_Main_Menu.Size = new System.Drawing.Size(135, 22);
            this.MenuStrip_Top_File_Main_Menu.Text = "Main Menu";
            this.MenuStrip_Top_File_Main_Menu.Click += new System.EventHandler(this.MenuStrip_Top_File_Main_Menu_Click);
            // 
            // MenuStrip_Top_File_Exit
            // 
            this.MenuStrip_Top_File_Exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MenuStrip_Top_File_Exit.Name = "MenuStrip_Top_File_Exit";
            this.MenuStrip_Top_File_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.MenuStrip_Top_File_Exit.Size = new System.Drawing.Size(135, 22);
            this.MenuStrip_Top_File_Exit.Text = "Exit";
            this.MenuStrip_Top_File_Exit.Click += new System.EventHandler(this.MenuStrip_Top_File_Exit_Click);
            // 
            // MenuStrip_Top_About
            // 
            this.MenuStrip_Top_About.Name = "MenuStrip_Top_About";
            this.MenuStrip_Top_About.Size = new System.Drawing.Size(52, 22);
            this.MenuStrip_Top_About.Text = "About";
            this.MenuStrip_Top_About.Click += new System.EventHandler(this.MenuStrip_Top_About_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(327, 334);
            this.Controls.Add(this.flowLayoutPanel_rightPlayerPit);
            this.Controls.Add(this.flowLayoutPanel_leftPlayerPit);
            this.Controls.Add(this.Panel_GameIndcator);
            this.Controls.Add(this.StatusStrip_Bottom);
            this.Controls.Add(this.MenuStrip_Top);
            this.Controls.Add(this.FlowLayoutPanel_Cards);
            this.MainMenuStrip = this.MenuStrip_Top;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Memory Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TwoPlayerGameB_KeyDown);
            this.StatusStrip_Bottom.ResumeLayout(false);
            this.StatusStrip_Bottom.PerformLayout();
            this.Panel_GameIndcator.ResumeLayout(false);
            this.flowLayoutPanel_leftPlayerPit.ResumeLayout(false);
            this.flowLayoutPanel_leftPlayerPit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_P1_TurnIndicator)).EndInit();
            this.flowLayoutPanel_rightPlayerPit.ResumeLayout(false);
            this.flowLayoutPanel_rightPlayerPit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_P2_TurnIndicator)).EndInit();
            this.MenuStrip_Top.ResumeLayout(false);
            this.MenuStrip_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Cards;
        private System.Windows.Forms.Timer Timer_CorrectPick;
        private System.Windows.Forms.StatusStrip StatusStrip_Bottom;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Bottom_StatusLabel;
        private System.Windows.Forms.Timer Timer_FailedPick;
        private System.Windows.Forms.Panel Panel_GameIndcator;
        private System.Windows.Forms.ProgressBar ProgressBar_Panel_GameIndicator;
        private System.Windows.Forms.Label Label_P1_Name;
        private System.Windows.Forms.Label Label_P1_Score;
        private System.Windows.Forms.Label Label_P2_Name;
        private System.Windows.Forms.Label Label_P2_Score;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_leftPlayerPit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_rightPlayerPit;
        private System.Windows.Forms.Timer Timer_TurnTimer;
        private System.Windows.Forms.Timer Timer_TimeRanOutTimer;
        private System.Windows.Forms.PictureBox Picturebox_P1_TurnIndicator;
        private System.Windows.Forms.PictureBox Picturebox_P2_TurnIndicator;
        private System.Windows.Forms.Label Label_P1_ColorIndicator;
        private System.Windows.Forms.Label Label_P2_ColorIndicator;
        private System.Windows.Forms.MenuStrip MenuStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Top_File;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Top_About;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Top_File_Main_Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Top_File_Restart;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Top_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Top_File_Pause;
    }
}