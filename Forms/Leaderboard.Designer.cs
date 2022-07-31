
namespace MemoryGame
{
    partial class Leaderboard
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Label_Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.CausesValidation = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView.Location = new System.Drawing.Point(52, 51);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 72;
            this.DataGridView.RowTemplate.Height = 31;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridView.Size = new System.Drawing.Size(335, 230);
            this.DataGridView.TabIndex = 1;
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(172, 315);
            this.Button_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(86, 22);
            this.Button_Back.TabIndex = 0;
            this.Button_Back.Text = "Exit";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Label_Header
            // 
            this.Label_Header.AutoSize = true;
            this.Label_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label_Header.Location = new System.Drawing.Point(157, 21);
            this.Label_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Header.Name = "Label_Header";
            this.Label_Header.Size = new System.Drawing.Size(124, 24);
            this.Label_Header.TabIndex = 2;
            this.Label_Header.Text = "1v1 Ranking";
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 351);
            this.Controls.Add(this.Label_Header);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Leaderboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "1v1 Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Label Label_Header;
    }
}