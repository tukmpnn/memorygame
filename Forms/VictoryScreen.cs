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
    public partial class VictoryScreen : Form
    {
        public VictoryScreen(string sMainVictoryMessage)
        {
            this.Icon = MemoryGame.Properties.Resources.Internal_Asset_icon;
            InitializeComponent();
            Label_MainMessage.Text = sMainVictoryMessage;
        }

        private void VictoryScreen_Load(object sender, EventArgs e)
        {
        }

        private void Button_Retry_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void Button_MainMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}