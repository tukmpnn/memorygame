using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Leaderboard : Form
    {
        List<LeaderBoardItem> lbrdlst;
        public Leaderboard(List<LeaderBoardItem> leaderList)
        {
            this.Icon = MemoryGame.Properties.Resources.Internal_Asset_icon;
            InitializeComponent();
            lbrdlst = leaderList;
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            //Data source(already sorted)
            DataGridView.DataSource = lbrdlst;
            var dg = DataGridView;
            //Formatting
            dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridView.Columns[0].HeaderText = "Wins";
            DataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridView.Columns[1].HeaderText = "Player";

            this.CenterToScreen();
        }
    }
}