using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsMathGame.models
{
    /// <summary>
    /// Player class to store player information
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Players name
        /// </summary>
        private String name;
        /// <summary>
        /// Players age
        /// </summary>
        private int age;
        /// <summary>
        /// Players score
        /// </summary>
        private int score;
        /// <summary>
        /// Players completion time
        /// </summary>
        private int time;

        /// <summary>
        /// Constructor to instantiate Players fields
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_age"></param>
        public Player(String _name, int _age)
        {
            try
            {
                this.name = _name;
                this.age = _age;
                this.score = 0;
                this.time = 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Increments the players score by one
        /// </summary>
        public void incrementScore()
        {
            try
            {
                score++;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for players name
        /// </summary>
        /// <returns>players name</returns>
        public String getName()
        {
            try
            {
                return this.name;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for players score
        /// </summary>
        /// <returns></returns>
        public int getScore()
        {
            try
            {
                return this.score;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method resets the players score to zero
        /// </summary>
        public void resetScore()
        {
            try
            {
                this.score = 0;
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        /// <summary>
        /// Method resets the players completion time to zero
        /// </summary>
        public void resetTime()
        {
            try
            {
                this.time = 0;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for the players age
        /// </summary>
        /// <returns></returns>
        public int getAge()
        {
            try
            {
                return this.age;
            }
            catch (Exception e)
            {
                throw e;
            }
        }  

        /// <summary>
        /// Getter for the players completion time
        /// </summary>
        /// <returns></returns>
        public int getTime()
        {
            return this.time;
        }
        
        /// <summary>
        /// Setter for players completion time
        /// </summary>
        /// <param name="_time"></param>
        public void setTime(int _time)
        {
            this.time = _time;
        }  
    }    
}
