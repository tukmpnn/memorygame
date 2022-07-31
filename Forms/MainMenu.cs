using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MemoryGame
{
    public partial class MainMenu : Form
    {
        Thread thr;
        public MainMenu()
        {
            this.Icon = MemoryGame.Properties.Resources.Internal_Asset_icon;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Center form to screen
            this.CenterToScreen();
        }
        private void Btn_startTwoPlayerGameB_Click(object sender, EventArgs e)
        {
            this.Close();
            thr = new Thread(StartNewTwoPlayerGame);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
        private void StartNewTwoPlayerGame(object obj)
        {
            Application.Run(new GameInitForm(false));
        }
        private void Button_StartSinglePlayer_Click(object sender, EventArgs e)
        {
            this.Close();
            thr = new Thread(StartNewSinglePlayerGame);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
        private void StartNewSinglePlayerGame(object obj)
        {
            Application.Run(new GameInitForm(true));
        }

        private void Button_Leaderboard_Click(object sender, EventArgs e)
        {
            List<LeaderBoardItem> leaderList = new List<LeaderBoardItem>();
            try
            {
                leaderList = LeaderBoardItem.GetLeaderboardList();
            }
            catch (Exception ex1)
            {
                if (MessageBox.Show("Leaderboard found to be corrupted\nRemove leaderboard?\nError Message: " + ex1.Message.ToString(), "Leaderboard corrupted", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    try
                    {
                        if (LeaderBoardItem.DeleteLeaderboardList())
                        {
                            MessageBox.Show("Leaderboard removed per user request", "Leaderboard removed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Leaderboard not found", "Leaderboard deletion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Leaderboard deletion failed\nError message: " + ex2.Message.ToString(), "Deletion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    leaderList = new List<LeaderBoardItem>();
                }
            }

            if (leaderList != null)
            {
                Form scrbrd = new Leaderboard(leaderList);
                this.Hide();
                scrbrd.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Empty leaderboard", "Nothing to show", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                if (MessageBox.Show("Do you want to exit the program?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}