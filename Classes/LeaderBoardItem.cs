using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MemoryGame
{
    public class LeaderBoardItem : IComparable<LeaderBoardItem>
    {
        private string _sName;
        private int _iVictoryCounter;
        public LeaderBoardItem()
        {
        }
        public LeaderBoardItem(int iVictoryCounter, string sName)
        {
            this.iVictoryCounter = iVictoryCounter;
            this.sName = sName;
        }
        public int iVictoryCounter
        {
            get { return _iVictoryCounter; }
            set { _iVictoryCounter = value; }
        }
        public string sName
        {
            get { return _sName; }
            set { _sName = value; }
        }
        public static void SaveWinnerData(GameUtils.Player winner)
        {
            bool PlayerNameFound = false;
            string sFilename = "Leaderboard.JSON";
            List<LeaderBoardItem> leaderList = new List<LeaderBoardItem>();


            //Read data if file exits and is not empty
            if (File.Exists(sFilename))
            {
                leaderList = JsonConvert.DeserializeObject<List<LeaderBoardItem>>(System.IO.File.ReadAllText(sFilename));
                //Search and add to found playername matches
                foreach (LeaderBoardItem lbi in leaderList)
                {
                    if (lbi.sName == winner.sName)
                    {
                        lbi._iVictoryCounter += 1;
                        PlayerNameFound = true;
                    }
                }
                //If not found make new entry
                if (!PlayerNameFound)
                {
                    leaderList.Add(new LeaderBoardItem(1, winner.sName));
                }
                //Save back to file
                System.IO.File.WriteAllText(sFilename, JsonConvert.SerializeObject(leaderList));
            }

            else
            {
                //If file not found make new one
                FileStream fs = File.Create(sFilename);
                fs.Close();
                //Add new entry and save to file
                leaderList.Add(new LeaderBoardItem(1, winner.sName));
                System.IO.File.WriteAllText(sFilename, JsonConvert.SerializeObject(leaderList));
            }
        }
        public static List<LeaderBoardItem> GetLeaderboardList()
        {
            string sFilename = "Leaderboard.JSON";

            List<LeaderBoardItem> leaderList = new List<LeaderBoardItem>();
            if (File.Exists(sFilename) && File.ReadAllText(sFilename).Length > 0)
            {
                leaderList = JsonConvert.DeserializeObject<List<LeaderBoardItem>>(System.IO.File.ReadAllText(sFilename));
                leaderList.Sort();
                leaderList.Reverse();
                return leaderList;
            }
            else
            {
                return leaderList;
            }
        }
        public static bool DeleteLeaderboardList()
        {
            string sFilename = "Leaderboard.JSON";
            if (File.Exists(sFilename))
            {
                File.Delete(sFilename);
                return true;
            }
            else
            {
                return false;
            }
        }


        public int CompareTo(LeaderBoardItem other)
        {
            // A null value means that this object is greater.
            if (other == null)
                return 1;
            else
                return this.iVictoryCounter.CompareTo(other.iVictoryCounter);
        }
    }
}
