
namespace MemoryGame
{
    partial class GameInitForm
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
            this.Btn_StartGame = new System.Windows.Forms.Button();
            this.label_Pairs_amount = new System.Windows.Forms.Label();
            this.ComboBox_Pairs_amount = new System.Windows.Forms.ComboBox();
            this.label_WaitTimeAfterCorrectAnswer = new System.Windows.Forms.Label();
            this.ComboBox_WaitTimeAfterCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.label_WaitTimeAfterFailedAnswer = new System.Windows.Forms.Label();
            this.ComboBox_WaitTimeAfterFailedAnswer = new System.Windows.Forms.ComboBox();
            this.Label_players = new System.Windows.Forms.Label();
            this.Label_players1 = new System.Windows.Forms.Label();
            this.Label_players2 = new System.Windows.Forms.Label();
            this.label_Pairs_amount_unit = new System.Windows.Forms.Label();
            this.label_WaitTimeAfterCorrectAnswer_unit = new System.Windows.Forms.Label();
            this.label_WaitTimeAfterFailedAnswer_unit = new System.Windows.Forms.Label();
            this.Btn_StartNewMenu = new System.Windows.Forms.Button();
            this.ColorDialog_InitForm = new System.Windows.Forms.ColorDialog();
            this.Btn_P1_Color = new System.Windows.Forms.Button();
            this.Btn_P2_Color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TurnTime = new System.Windows.Forms.Label();
            this.ComboBox_TurnTime = new System.Windows.Forms.ComboBox();
            this.CheckBox_NoCardHiding = new System.Windows.Forms.CheckBox();
            this.CheckBox_NoTurnTimer = new System.Windows.Forms.CheckBox();
            this.label_CardBackColor = new System.Windows.Forms.Label();
            this.StatusStrip_Bottom = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_Bottom_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_LoadDefaults = new System.Windows.Forms.Button();
            this.TextBox_P1 = new System.Windows.Forms.TextBox();
            this.TextBox_P2 = new System.Windows.Forms.TextBox();
            this.PictureBox_CardBackColorSelection = new System.Windows.Forms.PictureBox();
            this.Timer_HideMessage = new System.Windows.Forms.Timer(this.components);
            this.label_CardBackChange = new System.Windows.Forms.Label();
            this.Btn_cardbackimage_decrement = new System.Windows.Forms.Button();
            this.Btn_cardbackimage_increment = new System.Windows.Forms.Button();
            this.StatusStrip_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CardBackColorSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_StartGame
            // 
            this.Btn_StartGame.Location = new System.Drawing.Point(337, 363);
            this.Btn_StartGame.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_StartGame.Name = "Btn_StartGame";
            this.Btn_StartGame.Size = new System.Drawing.Size(117, 36);
            this.Btn_StartGame.TabIndex = 10;
            this.Btn_StartGame.Text = "Start";
            this.Btn_StartGame.UseVisualStyleBackColor = true;
            this.Btn_StartGame.Click += new System.EventHandler(this.Btn_StartGame_Click);
            // 
            // label_Pairs_amount
            // 
            this.label_Pairs_amount.AutoSize = true;
            this.label_Pairs_amount.Location = new System.Drawing.Point(215, 224);
            this.label_Pairs_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Pairs_amount.Name = "label_Pairs_amount";
            this.label_Pairs_amount.Size = new System.Drawing.Size(84, 13);
            this.label_Pairs_amount.TabIndex = 17;
            this.label_Pairs_amount.Text = "Number of pairs:";
            this.label_Pairs_amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox_Pairs_amount
            // 
            this.ComboBox_Pairs_amount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Pairs_amount.FormattingEnabled = true;
            this.ComboBox_Pairs_amount.Location = new System.Drawing.Point(299, 224);
            this.ComboBox_Pairs_amount.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_Pairs_amount.Name = "ComboBox_Pairs_amount";
            this.ComboBox_Pairs_amount.Size = new System.Drawing.Size(110, 21);
            this.ComboBox_Pairs_amount.TabIndex = 6;
            // 
            // label_WaitTimeAfterCorrectAnswer
            // 
            this.label_WaitTimeAfterCorrectAnswer.AutoSize = true;
            this.label_WaitTimeAfterCorrectAnswer.Location = new System.Drawing.Point(146, 286);
            this.label_WaitTimeAfterCorrectAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WaitTimeAfterCorrectAnswer.Name = "label_WaitTimeAfterCorrectAnswer";
            this.label_WaitTimeAfterCorrectAnswer.Size = new System.Drawing.Size(149, 13);
            this.label_WaitTimeAfterCorrectAnswer.TabIndex = 19;
            this.label_WaitTimeAfterCorrectAnswer.Text = "Pause time after finding a pair:";
            this.label_WaitTimeAfterCorrectAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox_WaitTimeAfterCorrectAnswer
            // 
            this.ComboBox_WaitTimeAfterCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_WaitTimeAfterCorrectAnswer.FormattingEnabled = true;
            this.ComboBox_WaitTimeAfterCorrectAnswer.Location = new System.Drawing.Point(299, 286);
            this.ComboBox_WaitTimeAfterCorrectAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_WaitTimeAfterCorrectAnswer.Name = "ComboBox_WaitTimeAfterCorrectAnswer";
            this.ComboBox_WaitTimeAfterCorrectAnswer.Size = new System.Drawing.Size(110, 21);
            this.ComboBox_WaitTimeAfterCorrectAnswer.TabIndex = 8;
            // 
            // label_WaitTimeAfterFailedAnswer
            // 
            this.label_WaitTimeAfterFailedAnswer.AutoSize = true;
            this.label_WaitTimeAfterFailedAnswer.Location = new System.Drawing.Point(146, 307);
            this.label_WaitTimeAfterFailedAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WaitTimeAfterFailedAnswer.Name = "label_WaitTimeAfterFailedAnswer";
            this.label_WaitTimeAfterFailedAnswer.Size = new System.Drawing.Size(148, 13);
            this.label_WaitTimeAfterFailedAnswer.TabIndex = 20;
            this.label_WaitTimeAfterFailedAnswer.Text = "Pause time if incorrect pairing:";
            this.label_WaitTimeAfterFailedAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox_WaitTimeAfterFailedAnswer
            // 
            this.ComboBox_WaitTimeAfterFailedAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_WaitTimeAfterFailedAnswer.FormattingEnabled = true;
            this.ComboBox_WaitTimeAfterFailedAnswer.Location = new System.Drawing.Point(299, 307);
            this.ComboBox_WaitTimeAfterFailedAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_WaitTimeAfterFailedAnswer.Name = "ComboBox_WaitTimeAfterFailedAnswer";
            this.ComboBox_WaitTimeAfterFailedAnswer.Size = new System.Drawing.Size(110, 21);
            this.ComboBox_WaitTimeAfterFailedAnswer.TabIndex = 9;
            // 
            // Label_players
            // 
            this.Label_players.AutoSize = true;
            this.Label_players.Location = new System.Drawing.Point(296, 12);
            this.Label_players.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_players.Name = "Label_players";
            this.Label_players.Size = new System.Drawing.Size(41, 13);
            this.Label_players.TabIndex = 13;
            this.Label_players.Text = "Players";
            // 
            // Label_players1
            // 
            this.Label_players1.AutoSize = true;
            this.Label_players1.Location = new System.Drawing.Point(280, 38);
            this.Label_players1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_players1.Name = "Label_players1";
            this.Label_players1.Size = new System.Drawing.Size(16, 13);
            this.Label_players1.TabIndex = 15;
            this.Label_players1.Text = "1:";
            // 
            // Label_players2
            // 
            this.Label_players2.AutoSize = true;
            this.Label_players2.Location = new System.Drawing.Point(280, 96);
            this.Label_players2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_players2.Name = "Label_players2";
            this.Label_players2.Size = new System.Drawing.Size(16, 13);
            this.Label_players2.TabIndex = 16;
            this.Label_players2.Text = "2:";
            // 
            // label_Pairs_amount_unit
            // 
            this.label_Pairs_amount_unit.AutoSize = true;
            this.label_Pairs_amount_unit.Location = new System.Drawing.Point(410, 228);
            this.label_Pairs_amount_unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Pairs_amount_unit.Name = "label_Pairs_amount_unit";
            this.label_Pairs_amount_unit.Size = new System.Drawing.Size(27, 13);
            this.label_Pairs_amount_unit.TabIndex = 22;
            this.label_Pairs_amount_unit.Text = "pcs.";
            // 
            // label_WaitTimeAfterCorrectAnswer_unit
            // 
            this.label_WaitTimeAfterCorrectAnswer_unit.AutoSize = true;
            this.label_WaitTimeAfterCorrectAnswer_unit.Location = new System.Drawing.Point(410, 290);
            this.label_WaitTimeAfterCorrectAnswer_unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WaitTimeAfterCorrectAnswer_unit.Name = "label_WaitTimeAfterCorrectAnswer_unit";
            this.label_WaitTimeAfterCorrectAnswer_unit.Size = new System.Drawing.Size(12, 13);
            this.label_WaitTimeAfterCorrectAnswer_unit.TabIndex = 24;
            this.label_WaitTimeAfterCorrectAnswer_unit.Text = "s";
            // 
            // label_WaitTimeAfterFailedAnswer_unit
            // 
            this.label_WaitTimeAfterFailedAnswer_unit.AutoSize = true;
            this.label_WaitTimeAfterFailedAnswer_unit.Location = new System.Drawing.Point(410, 310);
            this.label_WaitTimeAfterFailedAnswer_unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_WaitTimeAfterFailedAnswer_unit.Name = "label_WaitTimeAfterFailedAnswer_unit";
            this.label_WaitTimeAfterFailedAnswer_unit.Size = new System.Drawing.Size(12, 13);
            this.label_WaitTimeAfterFailedAnswer_unit.TabIndex = 25;
            this.label_WaitTimeAfterFailedAnswer_unit.Text = "s";
            // 
            // Btn_StartNewMenu
            // 
            this.Btn_StartNewMenu.Location = new System.Drawing.Point(14, 363);
            this.Btn_StartNewMenu.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_StartNewMenu.Name = "Btn_StartNewMenu";
            this.Btn_StartNewMenu.Size = new System.Drawing.Size(117, 36);
            this.Btn_StartNewMenu.TabIndex = 11;
            this.Btn_StartNewMenu.Text = "Main Menu";
            this.Btn_StartNewMenu.UseVisualStyleBackColor = true;
            this.Btn_StartNewMenu.Click += new System.EventHandler(this.Btn_StartNewMenu_Click);
            // 
            // Btn_P1_Color
            // 
            this.Btn_P1_Color.AutoSize = true;
            this.Btn_P1_Color.BackColor = System.Drawing.Color.LightSalmon;
            this.Btn_P1_Color.Location = new System.Drawing.Point(299, 57);
            this.Btn_P1_Color.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_P1_Color.Name = "Btn_P1_Color";
            this.Btn_P1_Color.Size = new System.Drawing.Size(92, 23);
            this.Btn_P1_Color.TabIndex = 1;
            this.Btn_P1_Color.Text = "Player 1 Color";
            this.Btn_P1_Color.UseVisualStyleBackColor = false;
            this.Btn_P1_Color.Click += new System.EventHandler(this.Btn_P1_Color_Click);
            // 
            // Btn_P2_Color
            // 
            this.Btn_P2_Color.AutoSize = true;
            this.Btn_P2_Color.BackColor = System.Drawing.Color.DarkOrange;
            this.Btn_P2_Color.Location = new System.Drawing.Point(299, 115);
            this.Btn_P2_Color.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_P2_Color.Name = "Btn_P2_Color";
            this.Btn_P2_Color.Size = new System.Drawing.Size(92, 23);
            this.Btn_P2_Color.TabIndex = 3;
            this.Btn_P2_Color.Text = "Player 2 Color";
            this.Btn_P2_Color.UseVisualStyleBackColor = false;
            this.Btn_P2_Color.Click += new System.EventHandler(this.Btn_P2_Color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "s";
            // 
            // label_TurnTime
            // 
            this.label_TurnTime.AutoSize = true;
            this.label_TurnTime.Location = new System.Drawing.Point(221, 250);
            this.label_TurnTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TurnTime.Name = "label_TurnTime";
            this.label_TurnTime.Size = new System.Drawing.Size(74, 13);
            this.label_TurnTime.TabIndex = 18;
            this.label_TurnTime.Text = "Turn time limit:";
            this.label_TurnTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBox_TurnTime
            // 
            this.ComboBox_TurnTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_TurnTime.FormattingEnabled = true;
            this.ComboBox_TurnTime.Location = new System.Drawing.Point(299, 246);
            this.ComboBox_TurnTime.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox_TurnTime.Name = "ComboBox_TurnTime";
            this.ComboBox_TurnTime.Size = new System.Drawing.Size(110, 21);
            this.ComboBox_TurnTime.TabIndex = 7;
            // 
            // CheckBox_NoCardHiding
            // 
            this.CheckBox_NoCardHiding.AutoSize = true;
            this.CheckBox_NoCardHiding.Location = new System.Drawing.Point(299, 155);
            this.CheckBox_NoCardHiding.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_NoCardHiding.Name = "CheckBox_NoCardHiding";
            this.CheckBox_NoCardHiding.Size = new System.Drawing.Size(146, 17);
            this.CheckBox_NoCardHiding.TabIndex = 4;
            this.CheckBox_NoCardHiding.Text = "Card faces always shown";
            this.CheckBox_NoCardHiding.UseVisualStyleBackColor = true;
            this.CheckBox_NoCardHiding.CheckedChanged += new System.EventHandler(this.CheckBox_NoCardHiding_CheckedChanged);
            // 
            // CheckBox_NoTurnTimer
            // 
            this.CheckBox_NoTurnTimer.AutoSize = true;
            this.CheckBox_NoTurnTimer.Location = new System.Drawing.Point(299, 177);
            this.CheckBox_NoTurnTimer.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBox_NoTurnTimer.Name = "CheckBox_NoTurnTimer";
            this.CheckBox_NoTurnTimer.Size = new System.Drawing.Size(112, 17);
            this.CheckBox_NoTurnTimer.TabIndex = 5;
            this.CheckBox_NoTurnTimer.Text = "Unlimited turn time";
            this.CheckBox_NoTurnTimer.UseVisualStyleBackColor = true;
            this.CheckBox_NoTurnTimer.CheckStateChanged += new System.EventHandler(this.CheckBox_NoTurnTimer_CheckStateChanged);
            // 
            // label_CardBackColor
            // 
            this.label_CardBackColor.AutoSize = true;
            this.label_CardBackColor.Location = new System.Drawing.Point(21, 33);
            this.label_CardBackColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CardBackColor.Name = "label_CardBackColor";
            this.label_CardBackColor.Size = new System.Drawing.Size(117, 13);
            this.label_CardBackColor.TabIndex = 14;
            this.label_CardBackColor.Text = "Select card back color:";
            this.label_CardBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusStrip_Bottom
            // 
            this.StatusStrip_Bottom.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.StatusStrip_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_Bottom_StatusLabel});
            this.StatusStrip_Bottom.Location = new System.Drawing.Point(0, 408);
            this.StatusStrip_Bottom.Name = "StatusStrip_Bottom";
            this.StatusStrip_Bottom.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.StatusStrip_Bottom.Size = new System.Drawing.Size(483, 22);
            this.StatusStrip_Bottom.TabIndex = 21;
            this.StatusStrip_Bottom.Text = "statusStrip1";
            // 
            // StatusStrip_Bottom_StatusLabel
            // 
            this.StatusStrip_Bottom_StatusLabel.Name = "StatusStrip_Bottom_StatusLabel";
            this.StatusStrip_Bottom_StatusLabel.Size = new System.Drawing.Size(118, 17);
            this.StatusStrip_Bottom_StatusLabel.Text = "toolStripStatusLabel1";
            this.StatusStrip_Bottom_StatusLabel.TextChanged += new System.EventHandler(this.StatusStrip_Bottom_StatusLabel_TextChanged);
            // 
            // Btn_LoadDefaults
            // 
            this.Btn_LoadDefaults.Location = new System.Drawing.Point(179, 363);
            this.Btn_LoadDefaults.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_LoadDefaults.Name = "Btn_LoadDefaults";
            this.Btn_LoadDefaults.Size = new System.Drawing.Size(117, 36);
            this.Btn_LoadDefaults.TabIndex = 12;
            this.Btn_LoadDefaults.Text = "Default Settings";
            this.Btn_LoadDefaults.UseVisualStyleBackColor = true;
            this.Btn_LoadDefaults.Click += new System.EventHandler(this.Btn_LoadDefaults_Click);
            // 
            // TextBox_P1
            // 
            this.TextBox_P1.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_P1.Location = new System.Drawing.Point(299, 36);
            this.TextBox_P1.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_P1.Name = "TextBox_P1";
            this.TextBox_P1.Size = new System.Drawing.Size(155, 20);
            this.TextBox_P1.TabIndex = 0;
            this.TextBox_P1.TextChanged += new System.EventHandler(this.TextBox_P1_TextChanged);
            this.TextBox_P1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_P1_KeyPress);
            // 
            // TextBox_P2
            // 
            this.TextBox_P2.Location = new System.Drawing.Point(299, 94);
            this.TextBox_P2.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox_P2.Name = "TextBox_P2";
            this.TextBox_P2.Size = new System.Drawing.Size(155, 20);
            this.TextBox_P2.TabIndex = 2;
            this.TextBox_P2.TextChanged += new System.EventHandler(this.TextBox_P2_TextChanged);
            this.TextBox_P2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_P2_KeyPress);
            // 
            // PictureBox_CardBackColorSelection
            // 
            this.PictureBox_CardBackColorSelection.Location = new System.Drawing.Point(154, 17);
            this.PictureBox_CardBackColorSelection.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox_CardBackColorSelection.Name = "PictureBox_CardBackColorSelection";
            this.PictureBox_CardBackColorSelection.Size = new System.Drawing.Size(49, 49);
            this.PictureBox_CardBackColorSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_CardBackColorSelection.TabIndex = 26;
            this.PictureBox_CardBackColorSelection.TabStop = false;
            this.PictureBox_CardBackColorSelection.Click += new System.EventHandler(this.PictureBox_CardBackColorSelection_Click);
            // 
            // Timer_HideMessage
            // 
            this.Timer_HideMessage.Interval = 7000;
            this.Timer_HideMessage.Tick += new System.EventHandler(this.Timer_HideMessage_Tick);
            // 
            // label_CardBackChange
            // 
            this.label_CardBackChange.AutoSize = true;
            this.label_CardBackChange.Location = new System.Drawing.Point(21, 81);
            this.label_CardBackChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CardBackChange.Name = "label_CardBackChange";
            this.label_CardBackChange.Size = new System.Drawing.Size(124, 13);
            this.label_CardBackChange.TabIndex = 27;
            this.label_CardBackChange.Text = "Switch card back image:";
            this.label_CardBackChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_cardbackimage_decrement
            // 
            this.Btn_cardbackimage_decrement.Location = new System.Drawing.Point(150, 76);
            this.Btn_cardbackimage_decrement.Name = "Btn_cardbackimage_decrement";
            this.Btn_cardbackimage_decrement.Size = new System.Drawing.Size(49, 23);
            this.Btn_cardbackimage_decrement.TabIndex = 28;
            this.Btn_cardbackimage_decrement.Text = "<";
            this.Btn_cardbackimage_decrement.UseVisualStyleBackColor = true;
            this.Btn_cardbackimage_decrement.Click += new System.EventHandler(this.Btn_cardbackimage_decrement_Click);
            // 
            // Btn_cardbackimage_increment
            // 
            this.Btn_cardbackimage_increment.Location = new System.Drawing.Point(205, 76);
            this.Btn_cardbackimage_increment.Name = "Btn_cardbackimage_increment";
            this.Btn_cardbackimage_increment.Size = new System.Drawing.Size(49, 23);
            this.Btn_cardbackimage_increment.TabIndex = 29;
            this.Btn_cardbackimage_increment.Text = ">";
            this.Btn_cardbackimage_increment.UseVisualStyleBackColor = true;
            this.Btn_cardbackimage_increment.Click += new System.EventHandler(this.Btn_cardbackimage_increment_Click);
            // 
            // GameInitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 430);
            this.Controls.Add(this.Btn_cardbackimage_increment);
            this.Controls.Add(this.Btn_cardbackimage_decrement);
            this.Controls.Add(this.label_CardBackChange);
            this.Controls.Add(this.TextBox_P2);
            this.Controls.Add(this.TextBox_P1);
            this.Controls.Add(this.Btn_LoadDefaults);
            this.Controls.Add(this.StatusStrip_Bottom);
            this.Controls.Add(this.label_CardBackColor);
            this.Controls.Add(this.PictureBox_CardBackColorSelection);
            this.Controls.Add(this.CheckBox_NoTurnTimer);
            this.Controls.Add(this.CheckBox_NoCardHiding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_TurnTime);
            this.Controls.Add(this.ComboBox_TurnTime);
            this.Controls.Add(this.Btn_P2_Color);
            this.Controls.Add(this.Btn_P1_Color);
            this.Controls.Add(this.Btn_StartNewMenu);
            this.Controls.Add(this.label_WaitTimeAfterFailedAnswer_unit);
            this.Controls.Add(this.label_WaitTimeAfterCorrectAnswer_unit);
            this.Controls.Add(this.label_Pairs_amount_unit);
            this.Controls.Add(this.Label_players2);
            this.Controls.Add(this.Label_players1);
            this.Controls.Add(this.Label_players);
            this.Controls.Add(this.label_WaitTimeAfterFailedAnswer);
            this.Controls.Add(this.ComboBox_WaitTimeAfterFailedAnswer);
            this.Controls.Add(this.label_WaitTimeAfterCorrectAnswer);
            this.Controls.Add(this.ComboBox_WaitTimeAfterCorrectAnswer);
            this.Controls.Add(this.label_Pairs_amount);
            this.Controls.Add(this.ComboBox_Pairs_amount);
            this.Controls.Add(this.Btn_StartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameInitForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Game Setup";
            this.Load += new System.EventHandler(this.TwoPlayerInitForm_Load);
            this.StatusStrip_Bottom.ResumeLayout(false);
            this.StatusStrip_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_CardBackColorSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_StartGame;
        private System.Windows.Forms.Label label_Pairs_amount;
        private System.Windows.Forms.ComboBox ComboBox_Pairs_amount;
        private System.Windows.Forms.Label label_WaitTimeAfterCorrectAnswer;
        private System.Windows.Forms.ComboBox ComboBox_WaitTimeAfterCorrectAnswer;
        private System.Windows.Forms.Label label_WaitTimeAfterFailedAnswer;
        private System.Windows.Forms.ComboBox ComboBox_WaitTimeAfterFailedAnswer;
        private System.Windows.Forms.Label Label_players;
        private System.Windows.Forms.Label Label_players1;
        private System.Windows.Forms.Label Label_players2;
        private System.Windows.Forms.Label label_Pairs_amount_unit;
        private System.Windows.Forms.Label label_WaitTimeAfterCorrectAnswer_unit;
        private System.Windows.Forms.Label label_WaitTimeAfterFailedAnswer_unit;
        private System.Windows.Forms.Button Btn_StartNewMenu;
        private System.Windows.Forms.ColorDialog ColorDialog_InitForm;
        private System.Windows.Forms.Button Btn_P1_Color;
        private System.Windows.Forms.Button Btn_P2_Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TurnTime;
        private System.Windows.Forms.ComboBox ComboBox_TurnTime;
        private System.Windows.Forms.CheckBox CheckBox_NoCardHiding;
        private System.Windows.Forms.CheckBox CheckBox_NoTurnTimer;
        private System.Windows.Forms.PictureBox PictureBox_CardBackColorSelection;
        private System.Windows.Forms.Label label_CardBackColor;
        private System.Windows.Forms.StatusStrip StatusStrip_Bottom;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Bottom_StatusLabel;
        private System.Windows.Forms.Button Btn_LoadDefaults;
        private System.Windows.Forms.TextBox TextBox_P1;
        private System.Windows.Forms.TextBox TextBox_P2;
        private System.Windows.Forms.Timer Timer_HideMessage;
        private System.Windows.Forms.Label label_CardBackChange;
        private System.Windows.Forms.Button Btn_cardbackimage_decrement;
        private System.Windows.Forms.Button Btn_cardbackimage_increment;
    }
}