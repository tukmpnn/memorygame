using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MemoryGame
{
    public static class GameUtils
    {
        public struct Player
        {
            public string sName;
            public int iHits;
            public Color color;

            /// <summary>
            /// Returs player with +=1 hits on record
            /// Needed for score incrementation
            /// </summary>
            /// <returns>Returs player with +=1 hits on record</returns>
            public Player GetNewWithIncrementedIHits()
            {
                Player p2;
                iHits += 1;
                p2 = this;
                return p2;
            }

            /// <summary>
            /// Returs player with zero hits on record
            /// Needed for game restart
            /// </summary>
            /// <returns></returns>
            public Player GetNewWithZeroHits()
            {
                Player p2;
                iHits = 0;
                p2 = this;
                return p2;
            }
        }

        /// <summary>
        /// Get Zero padded score as string
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Zero padded score as string ie. "01"</returns>
        public static string ZeroPadScore(int i)
        {
            if (i < 10)
            {
                return "0" + i.ToString();
            }
            else
            {
                return i.ToString();
            }
        }
        /// <summary>
        /// Fisher–Yates shuffle the list
        /// </summary>
        public static void ShuffleList(List<int> list)
        {
            Random rng = new Random();
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }
    }
}
