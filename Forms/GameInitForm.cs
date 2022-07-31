using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameInitForm : Form
    {
        GameSettings gs;
        Thread thr;
        private Image imagCardBack;
        GameUtils.Player p1;
        GameUtils.Player p2;
        private List<Image> imagCardImagesList = new List<Image>();
        private List<string> cardBackKeys = new List<string>();

        public GameInitForm(bool isSoloGame)
        {
            this.Icon = MemoryGame.Properties.Resources.Internal_Asset_icon;
            InitializeComponent();
            GameSettings gs1 = new GameSettings(isSoloGame);
            gs = gs1;
        }

        private void CheckAndFixCardBackColor()
        {
            if (PictureBox_CardBackColorSelection.BackColor.Equals(Btn_P1_Color.BackColor) || PictureBox_CardBackColorSelection.BackColor.Equals(Btn_P2_Color.BackColor))
            {

                //If chosen color is same as player color adjust cardback color alpha to remove issues in game logic
                if (PictureBox_CardBackColorSelection.BackColor.A == 255 && PictureBox_CardBackColorSelection.BackColor.A > 1)
                {

                    PictureBox_CardBackColorSelection.BackColor = (Color.FromArgb(
                        PictureBox_CardBackColorSelection.BackColor.A - 1,
                        PictureBox_CardBackColorSelection.BackColor.R,
                        PictureBox_CardBackColorSelection.BackColor.G,
                        PictureBox_CardBackColorSelection.BackColor.B));
                }
                else
                {
                    PictureBox_CardBackColorSelection.BackColor = (Color.FromArgb(
                        PictureBox_CardBackColorSelection.BackColor.A + 1,
                        PictureBox_CardBackColorSelection.BackColor.R,
                        PictureBox_CardBackColorSelection.BackColor.G,
                        PictureBox_CardBackColorSelection.BackColor.B));
                }
            }
        }
        private void CheckAndFixCardBackColor(bool IssueKnown, string sInfo)
        {
            if (PictureBox_CardBackColorSelection.BackColor.Equals(Btn_P1_Color.BackColor) || PictureBox_CardBackColorSelection.BackColor.Equals(Btn_P2_Color.BackColor))
            {
                //If problem color is known, inform user based on knowledge
                if (IssueKnown)
                {
                    StatusStrip_Bottom_StatusLabel.Text = sInfo;
                }
                CheckAndFixCardBackColor();
            }
        }

        private void LoadDefaultValues()
        {
            //Select default/recommended values
            ComboBox_Pairs_amount.SelectedIndex = 1;
            ComboBox_TurnTime.SelectedIndex = 8;
            ComboBox_WaitTimeAfterCorrectAnswer.SelectedIndex = 0;
            ComboBox_WaitTimeAfterFailedAnswer.SelectedIndex = 2;

            Btn_P1_Color.BackColor = Color.CadetBlue;
            Btn_P2_Color.BackColor = Color.LightSalmon;
            PictureBox_CardBackColorSelection.BackColor = Color.Chocolate;
            StatusStrip_Bottom_StatusLabel.Text = "Default settings loaded";
        }


        private void TwoPlayerInitForm_Load(object sender, EventArgs e)
        {
            //Populate Items to comboboxes
            //PAIRS
            for (int i = 2; i <= 50; i += 1)
            {
                //add values for squarelike experience
                if (Math.Sqrt(i * 2) % 1 == 0)
                {
                    ComboBox_Pairs_amount.Items.Add(i);
                }
            }
            for (int i = 2; i <= 50; i += 1)
            {
                //add other values for more variety
                if (i % 2 == 0 && !ComboBox_Pairs_amount.Items.Contains(i))
                {
                    ComboBox_Pairs_amount.Items.Add(i);
                }
            }
            //TURNTIME
            for (int i = 1; i <= 60; i += 1)
            {
                ComboBox_TurnTime.Items.Add(i);
            }
            ComboBox_TurnTime.Items.Add(999);
            //CORRECT WAIT
            for (int i = 1; i <= 20; i += 1)
            {
                ComboBox_WaitTimeAfterCorrectAnswer.Items.Add(i);
            }
            //FAILED WAIT
            for (int i = 1; i <= 20; i += 1)
            {
                ComboBox_WaitTimeAfterFailedAnswer.Items.Add(i);
            }


            //Solo mode setup if true
            if (gs.isSoloGame)
            {
                //Hide unneeded elements
                TextBox_P2.Hide();
                Btn_P2_Color.Hide();
                Label_players2.Hide();
                ComboBox_TurnTime.Text = "";
                CheckBox_NoTurnTimer.Hide();
                CheckBox_NoTurnTimer.Checked = true;

                //Get previous sologame settings from files if possible
                try
                {
                    if (gs.ReadGsFromJSON(true))
                    {
                        TextBox_P1.Text = gs.p1.sName;
                        Btn_P1_Color.BackColor = gs.p1.color;

                        PictureBox_CardBackColorSelection.BackColor = gs.cardBackColor;
                        CheckBox_NoCardHiding.Checked = gs.noCardHiding;
                        CheckBox_NoTurnTimer.Checked = gs.noTurnTimer;

                        //Select item indexes based on previous game settings
                        ComboBox_Pairs_amount.SelectedIndex = ComboBox_Pairs_amount.Items.IndexOf(gs.iPairs);
                        ComboBox_TurnTime.SelectedIndex = ComboBox_TurnTime.Items.IndexOf(gs.iTurnTime / 1000);
                        ComboBox_WaitTimeAfterCorrectAnswer.SelectedIndex = ComboBox_WaitTimeAfterCorrectAnswer.Items.IndexOf(gs.iWaitTimeAfterCorrectAnswer / 1000);
                        ComboBox_WaitTimeAfterFailedAnswer.SelectedIndex = ComboBox_WaitTimeAfterFailedAnswer.Items.IndexOf(gs.iWaitTimeAfterFailedAnswer / 1000);
                        StatusStrip_Bottom_StatusLabel.Text = "Defaulted to previous game's setting";
                    }
                    else
                    {
                        LoadDefaultValues();
                        StatusStrip_Bottom_StatusLabel.Text = "No previous settings found";
                        TextBox_P1.BackColor = Color.Tomato;
                        TextBox_P2.BackColor = Color.Tomato;
                        Btn_StartGame.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading previous game's settings:\nError message:" + ex.Message.ToString(), "Reading Cached Settings Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDefaultValues();

                    TextBox_P1.BackColor = Color.Tomato;
                    TextBox_P2.BackColor = Color.Tomato;
                    Btn_StartGame.Enabled = false;
                }
            }
            //Get previous multiplayergame settings from files if possible
            else
            {
                try
                {
                    if (gs.ReadGsFromJSON(false))
                    {
                        TextBox_P1.Text = gs.p1.sName;
                        Btn_P1_Color.BackColor = gs.p1.color;
                        TextBox_P2.Text = gs.p2.sName;
                        Btn_P2_Color.BackColor = gs.p2.color;


                        PictureBox_CardBackColorSelection.BackColor = gs.cardBackColor;
                        CheckBox_NoCardHiding.Checked = gs.noCardHiding;
                        CheckBox_NoTurnTimer.Checked = gs.noTurnTimer;

                        //Select item indexes based on previous game settings
                        ComboBox_Pairs_amount.SelectedIndex = ComboBox_Pairs_amount.Items.IndexOf(gs.iPairs);
                        ComboBox_TurnTime.SelectedIndex = ComboBox_TurnTime.Items.IndexOf(gs.iTurnTime / 1000);
                        ComboBox_WaitTimeAfterCorrectAnswer.SelectedIndex = ComboBox_WaitTimeAfterCorrectAnswer.Items.IndexOf(gs.iWaitTimeAfterCorrectAnswer / 1000);
                        ComboBox_WaitTimeAfterFailedAnswer.SelectedIndex = ComboBox_WaitTimeAfterFailedAnswer.Items.IndexOf(gs.iWaitTimeAfterFailedAnswer / 1000);
                        StatusStrip_Bottom_StatusLabel.Text = "Defaulted to previous game's setting";
                    }
                    else
                    {
                        LoadDefaultValues();
                        StatusStrip_Bottom_StatusLabel.Text = "No previous settings found";
                        TextBox_P1.BackColor = Color.Tomato;
                        TextBox_P2.BackColor = Color.Tomato;
                        Btn_StartGame.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading previous game's settings:\nError message:" + ex.Message.ToString(), "Reading Previous Settings Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDefaultValues();
                    TextBox_P1.BackColor = Color.Tomato;
                    TextBox_P2.BackColor = Color.Tomato;
                    Btn_StartGame.Enabled = false;
                }
            }

            //Setup for multiple card backs
            //Get key & image pairs from Resources
            //https://docs.microsoft.com/en-us/dotnet/core/extensions/resources
            ResourceSet rs = Properties.Resources.ResourceManager
                       .GetResourceSet(CultureInfo.CurrentCulture, true, true);
            // Define resources to be include whose key contains this string
            string matchString = "Internal_CardBack";

            var cardBacks = rs.Cast<DictionaryEntry>()
                       .Where(x => x.Key.ToString().Contains(matchString) && x.Value.GetType() == typeof(System.Drawing.Bitmap))
                       .Select(x => new { key = x.Key.ToString(), val = x.Value })
                       .ToList();

            //CardImages to imagCardImagesList
            for (int i = 0; i < cardBacks.Count(); i++)
            {
                imagCardImagesList.Add((Image)cardBacks.ElementAt(i).val);
            }

            // Keys to array to handle switching of cardbacks
            foreach (var back in cardBacks)
            {
                cardBackKeys.Add(back.key.ToString());
            }

            //if key was not found in previous game settings, default to first
            if (gs.sCardBackKey == null)
            {
                gs.sCardBackKey = cardBacks[0].key;
            }

            //find and set
            imagCardBack = (Image)cardBacks.FirstOrDefault(x => x.key == gs.sCardBackKey).val;
            if (imagCardBack == null)
            {

            }
            PictureBox_CardBackColorSelection.Image = imagCardBack;
            PictureBox_CardBackColorSelection.Tag = gs.sCardBackKey;

            //Center form to screen
            this.CenterToScreen();
        }

        //Launch game with set parameters
        private void Btn_StartGame_Click(object sender, EventArgs e)
        {
            //Parse settings to GameSettings object
            //Int variables
            gs.iPairs = int.Parse(ComboBox_Pairs_amount.SelectedItem.ToString());
            gs.iTurnTime = int.Parse(ComboBox_TurnTime.SelectedItem.ToString()) * 1000;
            gs.iWaitTimeAfterFailedAnswer = int.Parse(ComboBox_WaitTimeAfterFailedAnswer.SelectedItem.ToString()) * 1000;
            gs.iWaitTimeAfterCorrectAnswer = int.Parse(ComboBox_WaitTimeAfterCorrectAnswer.SelectedItem.ToString()) * 1000;

            //Player details
            p1.sName = TextBox_P1.Text;
            p1.color = Btn_P1_Color.BackColor;
            p1.iHits = 0;
            gs.p1 = p1;
            p2.sName = TextBox_P2.Text;
            p2.color = Btn_P2_Color.BackColor;
            p2.iHits = 0;
            gs.p2 = p2;

            //cardback variables
            gs.imagCardBack = PictureBox_CardBackColorSelection.Image;
            gs.sCardBackKey = PictureBox_CardBackColorSelection.Tag.ToString();
            CheckAndFixCardBackColor();

            //booleans from checkboxes
            if (CheckBox_NoCardHiding.Checked == true)
            {
                gs.noCardHiding = true;
                //Color setup based on if cards are hidden
                gs.cardBackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                gs.noCardHiding = false;
                gs.cardBackColor = PictureBox_CardBackColorSelection.BackColor;
            }
            if (CheckBox_NoTurnTimer.Checked == true)
            {
                gs.noTurnTimer = true;
            }
            else
            {
                gs.noTurnTimer = false;
            }

            try
            {
                //after parsing gamesettings save settings to relevant JSON-file
                if (gs.isSoloGame)
                {
                    gs.WriteGsToJSON(true);
                }
                else
                {
                    gs.WriteGsToJSON(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving game's settings:\nError message:" + ex.Message.ToString(), "Saving Settings Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //after parsing gamesettings launch new form/game
            this.Close();
            thr = new Thread(StartNewGame);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
        private void StartNewGame(object obj)
        {
            //Go with parsed gamesettings
            Application.Run(new GameForm(gs));
        }

        /// <summary>
        /// Return to menu
        /// </summary>
        private void Btn_StartNewMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            thr = new Thread(StartNewMenu);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
        private void StartNewMenu(object obj)
        {
            Application.Run(new MainMenu());
        }

        /// <summary>
        /// Select color for control from colorpicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_P1_Color_Click(object sender, EventArgs e)
        {

            if (ColorDialog_InitForm.ShowDialog() == DialogResult.OK)
            {
                Btn_P1_Color.BackColor = ColorDialog_InitForm.Color;
                CheckAndFixCardBackColor(true, "P1 wanted the same color as card back => card back color altered");
            }
        }

        /// <summary>
        /// Select color for control from colorpicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_P2_Color_Click(object sender, EventArgs e)
        {
            if (ColorDialog_InitForm.ShowDialog() == DialogResult.OK)
            {
                Btn_P2_Color.BackColor = ColorDialog_InitForm.Color;
                CheckAndFixCardBackColor(true, "P2 wanted the same color as card back => card back color altered");
            }
        }

        /// <summary>
        /// Select color for control from colorpicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_CardBackColorSelection_Click(object sender, EventArgs e)
        {
            if (ColorDialog_InitForm.ShowDialog() == DialogResult.OK)
            {
                PictureBox_CardBackColorSelection.BackColor = ColorDialog_InitForm.Color;
                CheckAndFixCardBackColor(true, "A Player already had this color => card back color altered");
            }
        }

        private void Btn_LoadDefaults_Click(object sender, EventArgs e)
        {
            LoadDefaultValues();
        }

        /// <summary>
        /// Set controls and variables based on state of checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_NoTurnTimer_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBox_NoTurnTimer.Checked == true)
            {
                ComboBox_TurnTime.Enabled = false;
                ComboBox_TurnTime.Text = "";
            }
            else
            {
                ComboBox_TurnTime.Enabled = true;
                ComboBox_TurnTime.SelectedText = gs.iTurnTime.ToString();
            }
        }

        /// <summary>
        /// Set controls and variables based on state of checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox_NoCardHiding_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_NoCardHiding.Checked == true)
            {
                PictureBox_CardBackColorSelection.Enabled = false;
                PictureBox_CardBackColorSelection.Visible = false;
                label_CardBackColor.Visible = false;
                label_CardBackChange.Visible = false;
                Btn_cardbackimage_decrement.Visible = false;
                Btn_cardbackimage_increment.Visible = false;
            }
            else
            {
                PictureBox_CardBackColorSelection.Enabled = true;
                PictureBox_CardBackColorSelection.Visible = true;
                PictureBox_CardBackColorSelection.BackColor = Color.Chocolate;
                CheckAndFixCardBackColor();
                label_CardBackColor.Visible = true;
                label_CardBackChange.Visible = true;
                Btn_cardbackimage_decrement.Visible = true;
                Btn_cardbackimage_increment.Visible = true;
            }
        }


        /// <summary>
        /// Hide statusstrip text after certain amount of time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatusStrip_Bottom_StatusLabel_TextChanged(object sender, EventArgs e)
        {
            Timer_HideMessage.Start();
        }

        private void Timer_HideMessage_Tick(object sender, EventArgs e)
        {
            StatusStrip_Bottom_StatusLabel.Text = "";
            Timer_HideMessage.Stop();
        }

        private void TextBox_P1_TextChanged(object sender, EventArgs e)
        {
            //Check if this textbox is OK
            if (TextBox_P1.Text.Length == 0)
            {
                TextBox_P1.BackColor = Color.Tomato;
                Btn_StartGame.Enabled = false;
                StatusStrip_Bottom_StatusLabel.Text = "P1 Name must exeed 0 characters!";
            }
            else
            {
                TextBox_P1.BackColor = System.Drawing.SystemColors.Window;
                //enable in solo
                if (gs.isSoloGame)
                {
                    Btn_StartGame.Enabled = true;
                }
                //Check if other player textbox is also OK
                else if (TextBox_P2.Text.Length > 0)
                {
                    Btn_StartGame.Enabled = true;
                }
            }
        }

        private void TextBox_P2_TextChanged(object sender, EventArgs e)
        {
            //Check if this textbox is OK
            if (TextBox_P2.Text.Length == 0)
            {
                TextBox_P2.BackColor = Color.Tomato;
                Btn_StartGame.Enabled = false;
                StatusStrip_Bottom_StatusLabel.Text = "P2 Name must exeed 0 characters!";
            }
            else
            {
                TextBox_P2.BackColor = System.Drawing.SystemColors.Window;
                //enable in solo
                if (gs.isSoloGame)
                {
                    Btn_StartGame.Enabled = true;
                }
                //Check if other player textbox is also OK
                else if (TextBox_P1.Text.Length > 0)
                {
                    Btn_StartGame.Enabled = true;
                }
            }
        }


        /// <summary>
        /// Limit the type and lenght of charters in name string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_P1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == '.') && !(e.KeyChar == '-') && !(e.KeyChar == '_') && !(e.KeyChar == ' ') || (TextBox_P1.Text.Length >= 15))
            {
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    if (TextBox_P1.Text.Length >= 15)
                    {
                        StatusStrip_Bottom_StatusLabel.Text = "P1 Name must be less than 15 characters!";
                    }
                }

            }
        }

        private void TextBox_P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar == '\b') && !(e.KeyChar == '.') && !(e.KeyChar == '-') && !(e.KeyChar == '_') && !(e.KeyChar == ' ') || (TextBox_P2.Text.Length >= 15))
            {
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    if (TextBox_P1.Text.Length >= 15)
                    {
                        StatusStrip_Bottom_StatusLabel.Text = "P2 Name must be less than 15 characters!";
                    }
                }
            }
        }

        private void Btn_cardbackimage_decrement_Click(object sender, EventArgs e)
        {
            ChangeCardBack(-1);
        }

        private void Btn_cardbackimage_increment_Click(object sender, EventArgs e)
        {
            ChangeCardBack(1);
        }

        private void ChangeCardBack(int operation)
        {
            int iCurrentIndex = cardBackKeys.IndexOf(gs.sCardBackKey);
            if (operation == 1)
            {
                if (iCurrentIndex >= cardBackKeys.Count - 1)
                {
                    gs.sCardBackKey = cardBackKeys[0];
                    PictureBox_CardBackColorSelection.Image = imagCardImagesList[0];
                    PictureBox_CardBackColorSelection.Tag = gs.sCardBackKey;
                }
                else
                {
                    gs.sCardBackKey = cardBackKeys[iCurrentIndex + 1];
                    PictureBox_CardBackColorSelection.Image = imagCardImagesList[iCurrentIndex + 1];
                    PictureBox_CardBackColorSelection.Tag = gs.sCardBackKey;
                }
            }
            else if (operation == -1)
            {
                if (iCurrentIndex == 0)
                {
                    int iLastIndex = cardBackKeys.Count - 1;
                    gs.sCardBackKey = cardBackKeys[iLastIndex];
                    PictureBox_CardBackColorSelection.Image = imagCardImagesList[iLastIndex];
                    PictureBox_CardBackColorSelection.Tag = gs.sCardBackKey;
                }
                else
                {
                    gs.sCardBackKey = cardBackKeys[iCurrentIndex - 1];
                    PictureBox_CardBackColorSelection.Image = imagCardImagesList[iCurrentIndex - 1];
                    PictureBox_CardBackColorSelection.Tag = gs.sCardBackKey;
                }
            }
        }
    }
}