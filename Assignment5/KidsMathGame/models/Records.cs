using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsMathGame.models
{
    public class Records
    {
        /// <summary>
        /// List of all high score records
        /// </summary>
        List<HighScore> records;

        /// <summary>
        /// Constructor to instantiate the List records
        /// </summary>
        public Records()
        {
            try
            {
                this.records = new List<HighScore>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        /// <summary>
        /// Method adds a new HighSore to records list by by removing lower scores
        /// if there are already 10 high scores and adding itself to the list and then sorting
        /// the list by the score in the HighScore objects
        /// </summary>
        /// <param name="entry"></param>
        public void addHighScoreToRecords(HighScore entry)
        {
            try
            {
                if (this.records.Count < 10)
                {
                    records.Add(entry);
                    sortRecordsByScoreAndTime();
                }
                else
                {
                    records.RemoveAt(records.Count - 1);
                    records.Add(entry);
                    sortRecordsByScoreAndTime();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method sorts the HighScore objects in records List by score
        /// </summary>
        public void sortRecordsByScoreAndTime()
        {
            try
            {
                List<HighScore> mSortedList = records.OrderByDescending(o => o.score).ThenBy(x => x.time).ToList();
                records = mSortedList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for the records list
        /// </summary>
        /// <returns></returns>
        public List<HighScore> getRecords()
        {
            try
            {
                return this.records;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method iterates through each high score and returns true if the high
        /// score injected as parameter has a higher score than one of the HighScores in the list
        /// </summary>
        /// <param name="mHighScore"></param>
        /// <returns></returns>
        public Boolean isNewHighScore(HighScore mHighScore)
        {
            try
            {
                //if top ten is full
                if(this.records.Count < 10)
                {
                    // there is <10 HighScores so add it is a new HighScore by default
                    return true;
                }
                else
                {
                    //check each HighScore
                    foreach (HighScore hs in this.records)
                    {
                        //if injected HighScore is better return true
                        if (mHighScore.CompareTo(hs) > 0)
                        {
                            return true;
                        }
                    }
                    // injected HighScore is worse
                    return false;
                }                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
