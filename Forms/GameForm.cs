using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameForm : Form
    {
        Thread thr;
        string sMainVictoryMessage;

        private Random rnd = new Random();
        GameSettings gs;

        //Variables for pausing
        bool GameIsPaused = false;
        bool Timer_CorrectPickIsPaused = false;
        bool Timer_FailedPickIsPaused = false;
        bool Timer_TurnTimerIsPaused = false;

        //Lists
        private List<Image> imagCardImagesList = new List<Image>();
        private List<int> rndImagesIndexes = new List<int>();
        private List<PictureBox> pictureboxes = new List<PictureBox>();

        //Selection helper variables
        int iLayoutindex = 0;
        private bool FirstIsSelected = false;
        private bool PlayerActivityAfterTimeout = false;
        private int iFirstSelectedIndex;
        private int iSecondSelectedIndex;

        //Wait timers and helper variables
        private int iTimerCounterForTicks = 0;
        private int iFlashInterval = 125;
        private int iFlashBlockCounter = 0;

        //Image references
        public Image imagP1Indicator = global::MemoryGame.Properties.Resources.Internal_Asset_double_arrow_left;
        public Image imagP2Indicator = global::MemoryGame.Properties.Resources.Internal_Asset_double_arrow_right;
        public Image imagTransparentIndicator = global::MemoryGame.Properties.Resources.Internal_Asset_Arrow_Dummy_Transparent;
        //helper to set images to imageboxes
        private Image imagHelper;

        //Color references
        private Color colorDefaultCardControlBackColor = System.Drawing.SystemColors.Control;
        private Color colorDefaultCardBackColor;

        //CardSize & padding
        public int iImageSize = 90;
        public int iImagePaddings = 8;

        //Player values
        private List<GameUtils.Player> Players = new List<GameUtils.Player>();
        public Boolean isP1Turn = true;
        public int iCurrentPlayerIndex = 0;


        /// <summary>
        /// Switches turns between players
        /// </summary>
        private void SwitchTurns()
        {
            if (isP1Turn)
            {
                //Handover to P2
                isP1Turn = false;
                iCurrentPlayerIndex = 1;
                StatusStrip_Bottom_StatusLabel.Text = "Player " + Players[iCurrentPlayerIndex].sName + " turn!";
                Picturebox_P1_TurnIndicator.Image = imagTransparentIndicator;
                Picturebox_P2_TurnIndicator.Image = imagP2Indicator;
            }
            else
            {
                //Handover to P1
                isP1Turn = true;
                iCurrentPlayerIndex = 0;
                StatusStrip_Bottom_StatusLabel.Text = "Player " + Players[iCurrentPlayerIndex].sName + " turn!";

                Picturebox_P1_TurnIndicator.Image = imagP1Indicator;
                Picturebox_P2_TurnIndicator.Image = imagTransparentIndicator;

            }
        }
        /// <summary>
        /// Flashes chosen cards
        /// </summary>
        /// <param name="clr">Color of flash</param>
        /// <param name="flashOnlyFirst">Set to true if only one card is selected</param>
        private void FlashPickedChoices(Color clr, Boolean flashOnlyFirst)
        {
            //Flash based on interval         
            if (flashOnlyFirst)
            {
                //Only flash first selected index
                if (iTimerCounterForTicks - iFlashBlockCounter > iFlashInterval)
                {
                    pictureboxes[iFirstSelectedIndex].BackColor = pictureboxes[iFirstSelectedIndex].BackColor == colorDefaultCardControlBackColor ? clr : colorDefaultCardControlBackColor;
                    iFlashBlockCounter += iFlashInterval;
                }
            }
            else
            {
                //Only both currently selected cards
                if (iTimerCounterForTicks - iFlashBlockCounter > iFlashInterval)
                {
                    pictureboxes[iFirstSelectedIndex].BackColor = pictureboxes[iFirstSelectedIndex].BackColor == colorDefaultCardControlBackColor ? clr : colorDefaultCardControlBackColor;
                    pictureboxes[iSecondSelectedIndex].BackColor = pictureboxes[iSecondSelectedIndex].BackColor == colorDefaultCardControlBackColor ? clr : colorDefaultCardControlBackColor;
                    iFlashBlockCounter += iFlashInterval;
                }
            }

        }

        /// <summary>
        /// Hides current player in-play-indicator
        /// </summary>
        private void HideCurrentPlayerIndicator()
        {
            if (iCurrentPlayerIndex == 0)
            {
                Picturebox_P1_TurnIndicator.Image = imagTransparentIndicator;
            }
            else
            {
                Picturebox_P2_TurnIndicator.Image = imagTransparentIndicator;
            }
        }

        /// <summary>
        /// Flashes the next player's indicator
        /// Must execute before other flashers
        /// </summary>
        /// <param name="isWithOtherFlasher">set true if in block with other flasher</param>
        private void FlashNextPlayerIndicator(Boolean isWithOtherFlasher)
        {

            if (iCurrentPlayerIndex == 0)
            {
                //Flash P2
                if (iTimerCounterForTicks - iFlashBlockCounter > iFlashInterval)
                {
                    if (Picturebox_P2_TurnIndicator.Image.Equals(imagP2Indicator))
                    {
                        Picturebox_P2_TurnIndicator.Image = imagTransparentIndicator;
                    }
                    else
                    {
                        Picturebox_P2_TurnIndicator.Image = imagP2Indicator;
                    }
                    if (!isWithOtherFlasher)
                    {
                        iFlashBlockCounter += iFlashInterval;
                    }
                }
            }
            else
            {
                //Flash P1
                if (iTimerCounterForTicks - iFlashBlockCounter > iFlashInterval)
                {
                    if (Picturebox_P1_TurnIndicator.Image.Equals(imagP1Indicator))
                    {
                        Picturebox_P1_TurnIndicator.Image = imagTransparentIndicator;
                    }
                    else
                    {
                        Picturebox_P1_TurnIndicator.Image = imagP1Indicator;
                    }
                    if (!isWithOtherFlasher)
                    {
                        iFlashBlockCounter += iFlashInterval;
                    }
                }
            }
        }
        /// <summary>
        /// Sets progressbar value withing timer block
        /// Counter default slow behaviour of progressbar by first incrementing and then decrementing to proper value
        /// </summary>
        /// <param name="waitTime"></param>
        private void SetIncrementingProgressbarFast(int waitTime)
        {
            if (iTimerCounterForTicks == waitTime)
            {
                ProgressBar_Panel_GameIndicator.Maximum = waitTime + 1;
                ProgressBar_Panel_GameIndicator.Value = iTimerCounterForTicks + 1;

                ProgressBar_Panel_GameIndicator.Maximum = waitTime;
                ProgressBar_Panel_GameIndicator.Value = iTimerCounterForTicks;
            }
            else
            {
                ProgressBar_Panel_GameIndicator.Maximum = waitTime;
                ProgressBar_Panel_GameIndicator.Value = iTimerCounterForTicks + 1;
                ProgressBar_Panel_GameIndicator.Value = iTimerCounterForTicks;
            }
        }

        /// <summary>
        /// Sets progressbar value withing timer block
        /// </summary>
        /// <param name="waitTime"></param>
        private void SetDecrementingProgressbar(int waitTime)
        {
            // Counter default slow behaviour of progressbar
            if (waitTime - iTimerCounterForTicks >= 0)
            {
                ProgressBar_Panel_GameIndicator.Maximum = waitTime;
                ProgressBar_Panel_GameIndicator.Value = waitTime - iTimerCounterForTicks;
            }
            else
            {
                ProgressBar_Panel_GameIndicator.Maximum = waitTime;
                ProgressBar_Panel_GameIndicator.Value = 0;
            }
        }
        private bool AttemptLeaderBoardSave(int playerNumber)
        {
            try
            {
                LeaderBoardItem.SaveWinnerData(Players[playerNumber]);
                return true;
            }
            catch (Exception ex1)
            {
                if (MessageBox.Show("Leaderboard found to be corrupted\nRemove corrupted file and start a new leaderboard?\nError message: " + ex1.Message.ToString(), "Leaderboard corrupted", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    try
                    {
                        if (LeaderBoardItem.DeleteLeaderboardList())
                        {
                            LeaderBoardItem.SaveWinnerData(Players[playerNumber]);
                            MessageBox.Show("Leaderboard removed and new results saved", "Leaderboard removed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Leaderboard deletion failed!", "Deletion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Leaderboard deletion failed\nError message: " + ex2.Message.ToString(), "Deletion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Event for game victory
        /// </summary>
        private void EndGameVictory()
        {
            DialogResult dr;
            if (gs.isSoloGame)
            {
                sMainVictoryMessage = "Congratulations!\nPlayer:\n" + Players[0].sName + "\nhas won the game!" +
                    "\nGame result was not saved to leaderboard";
                Form win = new VictoryScreen(sMainVictoryMessage);
                dr = win.ShowDialog();
            }
            else
            {
                if (Players[0].iHits > Players[1].iHits)
                {
                    if (AttemptLeaderBoardSave(0))
                    {
                        sMainVictoryMessage = "Congratulations!\nPlayer:\n" + Players[0].sName + "\nhas won the game!" +
                                                "\nGame result saved to leaderboard";
                    }
                    else
                    {
                        sMainVictoryMessage = "Congratulations!\nPlayer:\n" + Players[0].sName + "\nhas won the game!" +
                                                "\nError prevented saving to leaderboard";
                    }

                    Form win = new VictoryScreen(sMainVictoryMessage);
                    dr = win.ShowDialog();
                }
                else if (Players[0].iHits == Players[1].iHits)
                {
                    sMainVictoryMessage = "It's a tie!\nWell played both of you:\n"
                        + Players[0].sName + "\nand\n" + Players[1].sName +
                        "\nGame results not saved to leaderboard";

                    Form win = new VictoryScreen(sMainVictoryMessage);
                    dr = win.ShowDialog();
                }
                else
                {
                    if (AttemptLeaderBoardSave(1))
                    {
                        sMainVictoryMessage = "Congratulations!\nPlayer:\n" + Players[1].sName + "\nhas won the game!" +
                                                "\nGame result saved to leaderboard";
                    }
                    else
                    {
                        sMainVictoryMessage = "Congratulations!\nPlayer:\n" + Players[1].sName + "\nhas won the game!" +
                                                "\nError prevented saving to leaderboard";
                    }
                    Form win = new VictoryScreen(sMainVictoryMessage);
                    dr = win.ShowDialog();
                }
            }

            if (dr == DialogResult.Yes)
            {
                EndGameReturnToMenu();
            }
            else if (dr == DialogResult.Retry)
            {
                RestartGame();
            }
            else
            {
                Application.Exit();
            }
        }


        /// <summary>
        /// Exits game form to menu
        /// </summary>
        private void EndGameReturnToMenu()
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
        /// Restarts gameform with same settings
        /// </summary>
        private void RestartGame()
        {
            this.Close();
            thr = new Thread(ReStartGame);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        private void ReStartGame(object obj)
        {
            //Workarounds to set player scores back to 0
            GameUtils.Player plrA = Players[0].GetNewWithZeroHits();
            GameUtils.Player plrB = Players[1].GetNewWithZeroHits();
            gs.p1 = plrA;
            gs.p2 = plrB;
            //go with same settings and players with 0 score
            Application.Run(new GameForm(gs));
        }

        /// <summary>
        /// Pauses game in multiplayer
        /// </summary>
        private void PauseGame()
        {
            if (!gs.isSoloGame)
            {
                if (Timer_CorrectPick.Enabled == true)
                {
                    Timer_CorrectPick.Enabled = false;
                    Timer_CorrectPickIsPaused = true;
                }
                else if (Timer_FailedPick.Enabled == true)
                {
                    Timer_FailedPick.Enabled = false;
                    Timer_FailedPickIsPaused = true;
                }
                else if (Timer_TurnTimer.Enabled == true)
                {
                    Timer_TurnTimer.Enabled = false;
                    Timer_TurnTimerIsPaused = true;
                }
                else
                {
                    Timer_TimeRanOutTimer.Enabled = false;

                }
                GameIsPaused = true;
                StatusStrip_Bottom_StatusLabel.Text = "Game Paused";
            }
        }

        /// <summary>
        /// Unpauses game in multiplayer
        /// </summary>
        private void UnPauseGame()
        {
            if (!gs.isSoloGame)
            {
                if (Timer_CorrectPickIsPaused == true)
                {
                    Timer_CorrectPick.Enabled = true;
                    Timer_CorrectPickIsPaused = false;
                }
                else if (Timer_FailedPickIsPaused == true)
                {
                    Timer_FailedPick.Enabled = true;

                    Timer_FailedPickIsPaused = false;
                }
                else if (Timer_TurnTimerIsPaused == true)
                {
                    Timer_TurnTimer.Enabled = true;
                    Timer_TurnTimerIsPaused = false;
                }
                else
                {
                    Timer_TimeRanOutTimer.Enabled = true;
                }
                GameIsPaused = false;
                StatusStrip_Bottom_StatusLabel.Text = "Game Unpaused";
            }
        }

        /// <summary>
        /// Disable pictureboxes(prevent clicking)
        /// </summary>
        private void DisablePictureBoxes()
        {
            foreach (PictureBox pbxs in pictureboxes)
            {
                pbxs.Enabled = false;
            }
        }

        /// <summary>
        /// Enable pictureboxes that are still in play
        /// </summary>
        private void ReEnablePictureBoxes()
        {
            foreach (PictureBox pbxs in pictureboxes)
            {
                //Skip already revealed and correct ones
                if (pbxs.BackColor == colorDefaultCardControlBackColor || pbxs.BackColor == colorDefaultCardBackColor)
                {
                    pbxs.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Turns card back to top if necessary
        /// </summary>
        private void TurnCardsIfNeeded()
        {
            //turn cards if necessary
            if (!gs.noCardHiding)
            {
                if (FirstIsSelected)
                {
                    pictureboxes[iFirstSelectedIndex].Image = gs.imagCardBack;
                }
                else if (PlayerActivityAfterTimeout)
                {
                    pictureboxes[iFirstSelectedIndex].Image = gs.imagCardBack;
                    pictureboxes[iSecondSelectedIndex].Image = gs.imagCardBack;
                }
            }
        }

        /// <summary>
        /// Starts turn timer if game settings allow
        /// </summary>
        private void StartTurnTimerIfValidOption()
        {
            if (gs.noTurnTimer)
            {
                ProgressBar_Panel_GameIndicator.Maximum = 100;
                ProgressBar_Panel_GameIndicator.Value = 100;
            }
            else
            {
                Timer_TurnTimer.Start();
            }
        }


        /// <summary>
        /// Sets/insures a gap between the playerpits that indicate status, score etc.
        /// </summary>
        private void MakeGapInScoreboard()
        {
            int iLeftPanelRightEdgeLocation = flowLayoutPanel_leftPlayerPit.Location.X + flowLayoutPanel_leftPlayerPit.Size.Width;

            if (iLeftPanelRightEdgeLocation >= flowLayoutPanel_rightPlayerPit.Location.X)
            {
                //Set variables so that new location can be set
                this.AutoSize = false;
                flowLayoutPanel_rightPlayerPit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top));
                this.Width = flowLayoutPanel_leftPlayerPit.Width + flowLayoutPanel_rightPlayerPit.Width + 40;

                //Set new location with gap
                System.Drawing.Point adjustedLocation = new System.Drawing.Point(iLeftPanelRightEdgeLocation + 10, flowLayoutPanel_rightPlayerPit.Location.Y);
                flowLayoutPanel_rightPlayerPit.Location = adjustedLocation;

                //Prevent form resize
                this.AutoSize = true;
            }
        }

        /// <summary>
        /// Setup Control locations and widths for solo play
        /// </summary>
        private void SetupUIForSoloMode()
        {
            if (flowLayoutPanel_leftPlayerPit.Width < FlowLayoutPanel_Cards.Width)
            {
                this.AutoSize = false;
                this.Width = FlowLayoutPanel_Cards.Width + 25;
                ProgressBar_Panel_GameIndicator.Width = this.Width - 35;
                flowLayoutPanel_leftPlayerPit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top));
                flowLayoutPanel_leftPlayerPit.Location = new System.Drawing.Point(this.Width / 2 - flowLayoutPanel_leftPlayerPit.Width / 2, flowLayoutPanel_rightPlayerPit.Location.Y);
                this.AutoSize = true;
            }
            else
            {
                this.AutoSize = false;
                this.Width = flowLayoutPanel_leftPlayerPit.Width + 25;
                ProgressBar_Panel_GameIndicator.Width = this.Width - 15;
                flowLayoutPanel_leftPlayerPit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top));
                flowLayoutPanel_leftPlayerPit.Location = new System.Drawing.Point(ProgressBar_Panel_GameIndicator.Width / 2 - flowLayoutPanel_leftPlayerPit.Width / 2, flowLayoutPanel_rightPlayerPit.Location.Y);
                this.AutoSize = true;
            }
        }

        /// <summary>
        /// Centers flowlayoutpanel that holds the cards
        /// </summary>
        private void CenterCards()
        {
            FlowLayoutPanel_Cards.Location = new System.Drawing.Point((this.Width - FlowLayoutPanel_Cards.Width) / 2, FlowLayoutPanel_Cards.Location.Y);
        }


        public GameForm(GameSettings gsIN)
        {
            this.Icon = MemoryGame.Properties.Resources.Internal_Asset_icon;
            InitializeComponent();
            this.gs = gsIN;
            this.Players.Add(gs.p1);
            this.Players.Add(gs.p2);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

            //Set player details to UI elements
            Label_P1_Name.Text = Players[0].sName;
            Label_P1_ColorIndicator.BackColor = Players[0].color;
            Label_P1_ColorIndicator.ForeColor = Players[0].color;
            StatusStrip_Bottom_StatusLabel.Text = "Player " + Players[iCurrentPlayerIndex].sName + " turn!";

            //Set layoutpanel max size to get squarelike layout for cards
            FlowLayoutPanel_Cards.MaximumSize = new Size(
                (int)Math.Ceiling(Math.Sqrt(gs.iPairs * 2)) * (iImageSize + iImagePaddings * 2) + FlowLayoutPanel_Cards.Margin.Horizontal,
                (int)Math.Ceiling(Math.Sqrt(gs.iPairs * 2)) * (iImageSize + iImagePaddings * 2) + FlowLayoutPanel_Cards.Margin.Vertical);


            //Get key & image pairs from Resources
            ResourceSet rs = Properties.Resources.ResourceManager
                       .GetResourceSet(CultureInfo.CurrentCulture, true, true);

            // Define resources to be rejected whose key contains this string
            string rejectString = "Internal";

            var cardImages = rs.Cast<DictionaryEntry>()
           .Where(x => !x.Key.ToString().Contains(rejectString) && x.Value.GetType() == typeof(System.Drawing.Bitmap))
           .Select(x => new { key = x.Key.ToString(), val = x.Value })
           .ToList();

            //CardImages to imagCardImagesList
            for (int i = 0; i < cardImages.Count(); i++)
            {
                imagCardImagesList.Add((Image)cardImages.ElementAt(i).val);
            }

            //generate random image index list
            for (int i = 0; i < gs.iPairs;)
            {
                int iRnd = rnd.Next(cardImages.Count);
                if (!rndImagesIndexes.Contains(iRnd))
                {
                    rndImagesIndexes.Add(iRnd);
                    rndImagesIndexes.Add(iRnd);
                    i++;
                }
            }
            //Shuffle list
            GameUtils.ShuffleList(rndImagesIndexes);

            if (gs.noCardHiding)
            {
                colorDefaultCardBackColor = colorDefaultCardControlBackColor;
            }


            colorDefaultCardBackColor = gs.cardBackColor;

            //Create pictureboxes           
            foreach (int i in rndImagesIndexes)
            {
                //determine if to display card back or face
                if (gs.noCardHiding)
                {
                    imagHelper = imagCardImagesList[i];
                }
                else
                {
                    imagHelper = gs.imagCardBack;
                }
                //Init pictureboxes
                PictureBox picbox = new PictureBox
                {

                    Image = imagHelper,
                    BackColor = colorDefaultCardBackColor,
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Location = new System.Drawing.Point(2, 2),
                    Margin = new System.Windows.Forms.Padding(iImagePaddings),
                    Name = "pictureBox",
                    Size = new System.Drawing.Size(iImageSize, iImageSize),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
                    TabIndex = 7,
                    TabStop = false,
                    Tag = iLayoutindex++
                };
                picbox.Click += new System.EventHandler(PictureBox_Click);
                //To list and panel
                pictureboxes.Add(picbox);
                this.FlowLayoutPanel_Cards.Controls.Add(picbox);
            }


            //Make Ui elements match game mode solo/multiplayer
            if (gs.isSoloGame)
            {
                flowLayoutPanel_rightPlayerPit.Dispose();
                SetupUIForSoloMode();
            }
            else
            {
                Label_P2_Name.Text = Players[1].sName;
                Label_P2_ColorIndicator.BackColor = Players[1].color;
                Label_P2_ColorIndicator.ForeColor = Players[1].color;
                Picturebox_P2_TurnIndicator.Image = imagTransparentIndicator;
                //Insure a gap between top flowlayoutpanels
                MakeGapInScoreboard();
            }

            //Center flowlayoutpanel that holds the cards
            CenterCards();
            //Starts the clock/game for p1 after load
            StartTurnTimerIfValidOption();
            //Center form to screen
            this.CenterToScreen();
        }

        /// <summary>
        /// Main game logic, Handles clicking and comparing of cards
        /// </summary>
        private void PictureBox_Click(object sender, EventArgs e)
        {

            PlayerActivityAfterTimeout = true;
            PictureBox pb = sender as PictureBox;
            pb.Image = imagCardImagesList[rndImagesIndexes[int.Parse(((PictureBox)sender).Tag.ToString())]];

            //Colors based of if cards hidden or not
            if (gs.noCardHiding)
            {
                pb.BackColor = Color.Gray;
            }
            else
            {
                pb.BackColor = colorDefaultCardControlBackColor;
            }


            // First picked image index to memory
            if (FirstIsSelected == false)
            {
                FirstIsSelected = true;
                //Prevent repicking of same index
                pb.Enabled = false;
                iFirstSelectedIndex = int.Parse(((PictureBox)sender).Tag.ToString());
            }

            //If first card is selected run logic for second card         
            else
            {
                // Second picked image index to memory
                iSecondSelectedIndex = int.Parse(((PictureBox)sender).Tag.ToString());

                //Prevent clicking during waiting events
                DisablePictureBoxes();

                //Correct pairing event based on images in the list
                if (pictureboxes[iSecondSelectedIndex].Image.Equals(pictureboxes[iFirstSelectedIndex].Image))
                {
                    StatusStrip_Bottom_StatusLabel.Text = "Pair!";
                    Players[iCurrentPlayerIndex] = Players[iCurrentPlayerIndex].GetNewWithIncrementedIHits();

                    //Refresh scores
                    if (isP1Turn)
                    {
                        Label_P1_Score.Text = GameUtils.ZeroPadScore(Players[0].iHits);
                    }
                    else
                    {
                        Label_P2_Score.Text = GameUtils.ZeroPadScore(Players[1].iHits);
                    }
                    //Kill turntimer
                    Timer_TurnTimer.Stop();
                    iTimerCounterForTicks = 0;

                    //Check if game complete
                    if (Players[0].iHits + Players[1].iHits >= gs.iPairs)
                    {
                        EndGameVictory();
                    }
                    else
                    {
                        Timer_CorrectPick.Start();
                    }
                }
                //Incorrect pairing event
                else
                {
                    Timer_TurnTimer.Stop();
                    iTimerCounterForTicks = 0;
                    StatusStrip_Bottom_StatusLabel.Text = "Not a pair!";

                    //next timer event handles flashing
                    HideCurrentPlayerIndicator();
                    if (gs.isSoloGame)
                    {
                        iCurrentPlayerIndex = 1;
                    }
                    Timer_FailedPick.Start();
                }
                FirstIsSelected = false;
            }
        }

        /// <summary>
        /// Timer and flashing handler for correct pics
        /// </summary>
        private void Timer_CorrectPick_Tick(object sender, EventArgs e)
        {
            //Incement tick counter
            iTimerCounterForTicks += Timer_CorrectPick.Interval;

            //Flash for correct pick
            FlashPickedChoices(Color.LightGreen, false);

            //Call func to set progressbar
            SetIncrementingProgressbarFast(gs.iWaitTimeAfterCorrectAnswer);

            //End
            if (iTimerCounterForTicks >= gs.iWaitTimeAfterCorrectAnswer)
            {
                Timer_CorrectPick.Stop();
                iTimerCounterForTicks = 0;
                iFlashBlockCounter = 0;

                //Set correct picks to player color
                pictureboxes[iFirstSelectedIndex].BackColor = Players[iCurrentPlayerIndex].color;
                pictureboxes[iSecondSelectedIndex].BackColor = Players[iCurrentPlayerIndex].color;

                //Re-enable clicking after wait
                ReEnablePictureBoxes();

                StartTurnTimerIfValidOption();
            }
        }

        /// <summary>
        /// Timer and flashing handler for failed/incorrect pairing pics
        /// </summary>
        private void Timer_FailedPick_Tick(object sender, EventArgs e)
        {
            //Incement tick counter
            iTimerCounterForTicks += Timer_FailedPick.Interval;

            //Flashing for player indicators
            FlashNextPlayerIndicator(true);

            //Flashing for incorrect pics
            FlashPickedChoices(Color.Red, false);

            //Call func to set progressbar
            SetIncrementingProgressbarFast(gs.iWaitTimeAfterFailedAnswer);

            //End
            if (iTimerCounterForTicks >= gs.iWaitTimeAfterFailedAnswer)
            {
                Timer_FailedPick.Stop();
                iTimerCounterForTicks = 0;
                iFlashBlockCounter = 0;

                //reset color to cardback
                pictureboxes[iFirstSelectedIndex].BackColor = colorDefaultCardBackColor;
                pictureboxes[iSecondSelectedIndex].BackColor = colorDefaultCardBackColor;

                TurnCardsIfNeeded();
                //Re-enable clicking after wait
                ReEnablePictureBoxes();

                if (!gs.isSoloGame)
                {
                    //switch turns
                    SwitchTurns();
                }
                else
                {
                    iCurrentPlayerIndex = 0;
                    Picturebox_P1_TurnIndicator.Image = imagP1Indicator;
                    StatusStrip_Bottom_StatusLabel.Text = "Try again!";
                }

                StartTurnTimerIfValidOption();
            }
        }

        /// <summary>
        /// Timer for turns
        /// </summary>
        private void Timer_TurnTimer_Tick(object sender, EventArgs e)
        {
            //Incement tick counter
            iTimerCounterForTicks += Timer_TurnTimer.Interval;

            SetDecrementingProgressbar(gs.iTurnTime);

            //Ran out of time
            if (iTimerCounterForTicks >= gs.iTurnTime)
            {
                //Prevent clicking during waiting event
                DisablePictureBoxes();

                Timer_TurnTimer.Stop();
                PlayerActivityAfterTimeout = false;
                iTimerCounterForTicks = 0;
                iFlashBlockCounter = 0;
                StatusStrip_Bottom_StatusLabel.Text = "Turn time over!";

                //next timer event handles flashing
                HideCurrentPlayerIndicator();
                Timer_TimeRanOutTimer.Start();
            }
        }

        /// <summary>
        /// Timer and flashing handler if player ran out of time
        /// </summary>
        private void Timer_TimeRanOutTimer_Tick(object sender, EventArgs e)
        {
            //Incement tick counter
            iTimerCounterForTicks += Timer_TimeRanOutTimer.Interval;

            //Flashing for incorrect pics
            if (FirstIsSelected)
            {
                //Flash next player indicator
                FlashNextPlayerIndicator(true);
                FlashPickedChoices(Color.Red, true);
            }
            else
            {
                FlashNextPlayerIndicator(false);
            }

            //Call func to set progressbar
            SetIncrementingProgressbarFast(gs.iWaitTimeAfterFailedAnswer);

            //End
            if (iTimerCounterForTicks >= gs.iWaitTimeAfterFailedAnswer)
            {
                Timer_TimeRanOutTimer.Stop();
                iTimerCounterForTicks = 0;
                iFlashBlockCounter = 0;
                if (FirstIsSelected)
                {
                    pictureboxes[iFirstSelectedIndex].BackColor = colorDefaultCardBackColor;
                }
                TurnCardsIfNeeded();
                FirstIsSelected = false;

                //Re-enable clicking after wait
                ReEnablePictureBoxes();

                if (!gs.isSoloGame)
                {
                    //switch turns
                    SwitchTurns();
                }
                else
                {
                    StatusStrip_Bottom_StatusLabel.Text = "Try again!";
                }
                StartTurnTimerIfValidOption();
            }
        }

        /// <summary>
        /// Game pausing handler. Pauses based on keypress
        /// Esc queries for exit and pauses on MultiPlayer Games
        /// </summary>
        private void TwoPlayerGameB_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            if (e.KeyCode.Equals(Keys.Space) || e.KeyCode.Equals(Keys.Pause) || e.KeyCode.Equals(Keys.Enter))
            {
                if (GameIsPaused)
                {
                    UnPauseGame();
                }
                else
                {
                    PauseGame();
                }
            }
            else if (e.KeyCode.Equals(Keys.Escape))
            {
                if (!GameIsPaused)
                {
                    PauseGame();
                    if (MessageBox.Show("Are you sure that you want to Exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        UnPauseGame();
                    }
                }
            }
        }

        private void MenuStrip_Top_File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStrip_Top_File_Restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void MenuStrip_Top_File_Pause_Click(object sender, EventArgs e)
        {
            if (GameIsPaused)
            {
                UnPauseGame();
            }
            else
            {
                PauseGame();
            }
        }

        private void MenuStrip_Top_File_Main_Menu_Click(object sender, EventArgs e)
        {
            EndGameReturnToMenu();
        }

        /// <summary>
        /// Shows About form with some useful information
        /// </summary>
        private void MenuStrip_Top_About_Click(object sender, EventArgs e)
        {
            PauseGame();
            Form about = new About();
            about.ShowDialog();
            UnPauseGame();
        }
    }
}