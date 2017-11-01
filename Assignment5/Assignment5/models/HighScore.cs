using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsMathGame.models
{
    public class HighScore
    {
        /// <summary>
        /// players score
        /// </summary>
        public int score;
        /// <summary>
        /// players name
        /// </summary>
        public String name;
        /// <summary>
        /// players game time
        /// </summary>
        public int time;

        /// <summary>
        /// Constructor to create new HighScore with name and score passed in
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_score"></param>
        public HighScore(String _name, int _score, int _time)
        {
            try
            {
                this.score = _score;
                this.name = _name;
                this.time = _time;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method compares this Highscore against the HighScore injected as param
        /// If this HighScore's score is greater returns positive
        /// If scores are equal the times are compared
        /// If this HighScores time is lower returns positive
        /// If equal on both returns zero
        /// If lower score or equal score and higher time returns negative
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(HighScore other)
        {
            try
            {
                if(this.score > other.score)
                {
                    // get highest score
                    return 1;
                }
                else if(this.score == other.score)
                {
                    if (this.time < other.time)
                    {
                        return 1;
                    }
                    else if(this.time == other.time)
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
