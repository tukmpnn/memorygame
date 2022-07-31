using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MemoryGame
{
    /// <summary>
    /// Handles storing of game settings values
    /// </summary>
    public class GameSettings
    {
        private int _iPairs;
        private int _iTurnTime;
        private int _iWaitTimeAfterCorrectAnswer;
        private int _iWaitTimeAfterFailedAnswer;

        private GameUtils.Player _p1, _p2;
        private Image _imagCardBack;
        private Color _cardBackColor;
        private string _sCardBackKey;

        private bool _NoCardHiding;
        private bool _NoTurnTimer;
        private bool _IsSoloGame;

        public GameSettings()
        {
        }

        public GameSettings(bool isSoloGame)
        {
            this.isSoloGame = isSoloGame;
        }

        public GameSettings(int iPairs, int iTurnTime, int iWaitTimeAfterCorrectAnswer, int iWaitTimeAfterFailedAnswer, GameUtils.Player p1, GameUtils.Player p2, bool noCardHiding, bool noTurnTimer, bool isSoloGame)
        {
            this._iPairs = iPairs;
            this._iTurnTime = iTurnTime;
            this._iWaitTimeAfterCorrectAnswer = iWaitTimeAfterCorrectAnswer;
            this._iWaitTimeAfterFailedAnswer = iWaitTimeAfterFailedAnswer;
            this._p1 = p1;
            this._p2 = p2;
            this._NoCardHiding = noCardHiding;
            this._NoTurnTimer = noTurnTimer;
            this._IsSoloGame = isSoloGame;
        }

        public GameSettings(Color cardBackColor, Image imagCardBack, int iPairs, int iTurnTime, int iWaitTimeAfterCorrectAnswer, int iWaitTimeAfterFailedAnswer, GameUtils.Player p1, GameUtils.Player p2, bool noCardHiding, bool noTurnTimer, bool isSoloGame)
        {
            this._cardBackColor = cardBackColor;
            this._imagCardBack = imagCardBack;
            this._iPairs = iPairs;
            this._iTurnTime = iTurnTime;
            this._iWaitTimeAfterCorrectAnswer = iWaitTimeAfterCorrectAnswer;
            this._iWaitTimeAfterFailedAnswer = iWaitTimeAfterFailedAnswer;
            this._p1 = p1;
            this._p2 = p2;
            this._NoCardHiding = noCardHiding;
            this._NoTurnTimer = noTurnTimer;
            this._IsSoloGame = isSoloGame;
        }

        public GameSettings(string sCardBackKey, Color cardBackColor, Image imagCardBack, int iPairs, int iTurnTime, int iWaitTimeAfterCorrectAnswer, int iWaitTimeAfterFailedAnswer, GameUtils.Player p1, GameUtils.Player p2, bool noCardHiding, bool noTurnTimer, bool isSoloGame)
        {
            this._sCardBackKey = sCardBackKey;
            this._cardBackColor = cardBackColor;
            this._imagCardBack = imagCardBack;
            this._iPairs = iPairs;
            this._iTurnTime = iTurnTime;
            this._iWaitTimeAfterCorrectAnswer = iWaitTimeAfterCorrectAnswer;
            this._iWaitTimeAfterFailedAnswer = iWaitTimeAfterFailedAnswer;
            this._p1 = p1;
            this._p2 = p2;
            this._NoCardHiding = noCardHiding;
            this._NoTurnTimer = noTurnTimer;
            this._IsSoloGame = isSoloGame;
        }

        public string sCardBackKey { get { return _sCardBackKey; } set { _sCardBackKey = value; } }
        public Color cardBackColor { get { return _cardBackColor; } set { _cardBackColor = value; } }
        public Image imagCardBack { get { return _imagCardBack; } set { _imagCardBack = value; } }
        public int iPairs { get => _iPairs; set => _iPairs = value; }
        public int iTurnTime { get => _iTurnTime; set => _iTurnTime = value; }
        public int iWaitTimeAfterCorrectAnswer { get => _iWaitTimeAfterCorrectAnswer; set => _iWaitTimeAfterCorrectAnswer = value; }
        public int iWaitTimeAfterFailedAnswer { get => _iWaitTimeAfterFailedAnswer; set => _iWaitTimeAfterFailedAnswer = value; }
        public GameUtils.Player p1 { get => _p1; set => _p1 = value; }
        public GameUtils.Player p2 { get => _p2; set => _p2 = value; }
        public bool noCardHiding { get => _NoCardHiding; set => _NoCardHiding = value; }
        public bool noTurnTimer { get => _NoTurnTimer; set => _NoTurnTimer = value; }
        public bool isSoloGame { get => _IsSoloGame; set => _IsSoloGame = value; }


        /// <summary>
        /// Writes GameSettings to JSON based on gamemode
        /// </summary>
        /// <param name="IsSingePlayer">Set to true if SinglePlayer</param>
        public void WriteGsToJSON(bool IsSingePlayer)
        {
            string sFileNameSoloGame = "SinglePlayerSettings.JSON";
            string sFileNameMultiplayerGame = "MultiplayerSettings.JSON";

            if (IsSingePlayer)
            {
                if (File.Exists(sFileNameSoloGame) == false)
                {
                    FileStream fs = File.Create(sFileNameSoloGame);
                    fs.Close();
                }
                //Save to JSON file after file exists
                Image imagJSONhelper = this.imagCardBack;
                //image null to prevent JSON parsing errors
                this.imagCardBack = null;
                System.IO.File.WriteAllText(sFileNameSoloGame, JsonConvert.SerializeObject(this));
                this.imagCardBack = imagJSONhelper;
            }
            else
            {
                if (File.Exists(sFileNameMultiplayerGame) == false)
                {
                    FileStream fs = File.Create(sFileNameMultiplayerGame);
                    fs.Close();
                }
                //Save to JSON file after file exists
                Image imagJSONhelper = this.imagCardBack;
                //image null to prevent JSON parsing errors
                this.imagCardBack = null;
                System.IO.File.WriteAllText(sFileNameMultiplayerGame, JsonConvert.SerializeObject(this));
                this.imagCardBack = imagJSONhelper;
            }
        }
        /// <summary>
        /// Reads GameSettings from JSON based on gamemode
        /// </summary>
        /// <param name="IsSingePlayer"></param>
        /// <returns>true if file existed</returns>
        public bool ReadGsFromJSON(bool IsSingePlayer)
        {
            string sFileNameSoloGame = "SinglePlayerSettings.JSON";
            string sFileNameMultiplayerGame = "MultiplayerSettings.JSON";

            if (IsSingePlayer)
            {
                if (File.Exists(sFileNameSoloGame) == false)
                {
                    return false;
                }
                else
                {
                    GameSettings gs = JsonConvert.DeserializeObject<GameSettings>(System.IO.File.ReadAllText(sFileNameSoloGame));
                    this._sCardBackKey = gs.sCardBackKey;
                    this._cardBackColor = gs.cardBackColor;
                    this._imagCardBack = gs.imagCardBack;
                    this._iPairs = gs.iPairs;
                    this._iTurnTime = gs.iTurnTime;
                    this._iWaitTimeAfterCorrectAnswer = gs.iWaitTimeAfterCorrectAnswer;
                    this._iWaitTimeAfterFailedAnswer = gs.iWaitTimeAfterFailedAnswer;
                    this._p1 = gs.p1;
                    this._NoCardHiding = gs.noCardHiding;
                    this._NoTurnTimer = gs.noTurnTimer;
                    this._IsSoloGame = gs.isSoloGame;
                    return true;
                }
            }
            else
            {
                if (File.Exists(sFileNameMultiplayerGame) == false)
                {
                    return false;
                }
                else
                {
                    GameSettings gs = JsonConvert.DeserializeObject<GameSettings>(System.IO.File.ReadAllText(sFileNameMultiplayerGame));
                    this._sCardBackKey = gs.sCardBackKey;
                    this._cardBackColor = gs.cardBackColor;
                    this._imagCardBack = gs.imagCardBack;
                    this._iPairs = gs.iPairs;
                    this._iTurnTime = gs.iTurnTime;
                    this._iWaitTimeAfterCorrectAnswer = gs.iWaitTimeAfterCorrectAnswer;
                    this._iWaitTimeAfterFailedAnswer = gs.iWaitTimeAfterFailedAnswer;
                    this._p1 = gs.p1;
                    this._p2 = gs.p2;
                    this._NoCardHiding = gs.noCardHiding;
                    this._NoTurnTimer = gs.noTurnTimer;
                    this._IsSoloGame = gs.isSoloGame;
                    return true;
                }
            }
        }
    }
}