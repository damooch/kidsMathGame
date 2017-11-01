using KidsMathGame.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsMathGame.utils
{
    /// <summary>
    /// This class is the main business logic for the entire math game
    /// </summary>
    public class GameLogic
    {
        /// <summary>
        /// The player object playing the game
        /// </summary>
        private Player mPlayer;
        /// <summary>
        /// The records of HighScores for the game
        /// </summary>
        private Records mRecords;
        /// <summary>
        /// Random number generator object
        /// </summary>
        private Random mRandom;
        /// <summary>
        /// The first number in the arithmetic equation
        /// </summary>
        private int number1;
        /// <summary>
        /// The second number in the arithmetic equation
        /// </summary>
        private int number2;
        /// <summary>
        /// The correct answer for solving the arithmetic equation
        /// </summary>
        private int correctAnswer;
        /// <summary>
        /// The game type selected either +, -, *, or /
        /// </summary>
        private String gameType;

        /// <summary>
        /// Constructor to instantiate fields
        /// </summary>
        public GameLogic()
        {
            try
            {
                this.mRandom = new Random();
                this.mRecords = new Records();
                this.number1 = 0;
                this.number2 = 0;
                this.correctAnswer = 0;
                this.gameType = "";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method gets a string representation of a random arithmetic question based on the 
        /// current gameType
        /// </summary>
        /// <returns></returns>
        public String getQuestion()
        {
            try
            {
                switch (gameType)
                {
                    case "+":
                        return createAdditionQuestion();
                    case "-":
                        return createSubtractionQuestion();
                    case "*":
                        return createMultiplicationQuestion();
                    case "/":
                        return createDivisionQuestion();
                    default:
                        return "";
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method returns a string representation of the current question with the answer included
        /// </summary>
        /// <returns></returns>
        public String getQuestionWithAnswer()
        {
            try
            {
                return number1 + " " + gameType + " " + number2 + " = " + correctAnswer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method uses the Calculator class to calculate and instantiate the correctAnswer for the current
        /// arithmetic type of question and increments the players score while returning true if the players answer
        /// is correct
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public Boolean checkAnswer(int answer, int num1, int num2)
        {
            try
            {
                correctAnswer = 0;
                switch (gameType)
                {
                    case "+":
                        correctAnswer = Calculator.Addition(num1, num2);
                        if (answer == correctAnswer)
                        {
                            mPlayer.incrementScore();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "-":
                        correctAnswer = Calculator.Subtraction(num1, num2);
                        if (answer == correctAnswer)
                        {
                            mPlayer.incrementScore();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "*":
                        correctAnswer = Calculator.Multiplication(num1, num2);
                        if (answer == correctAnswer)
                        {
                            mPlayer.incrementScore();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case "/":
                        correctAnswer = Calculator.Division(num1, num2);
                        if (answer == correctAnswer)
                        {
                            mPlayer.incrementScore();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    default:
                        return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method creates and returns a string representation of a whole addition question
        /// it also instantiates the number1 and number2 fields with random numbers
        /// </summary>
        /// <returns></returns>
        public String createAdditionQuestion()
        {
            try
            {
                number1 = getRandomNumber();
                number2 = getRandomNumber();
                return number1 + " + " + number2 + " = ?";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method creates and returns a string representation of a whole subtraction question
        /// it also instantiates the number1 and number2 fields with random numbers
        /// </summary>
        /// <returns></returns>
        public String createSubtractionQuestion()
        {
            try
            {
                number1 = getRandomNumber();
                number2 = getRandomNumber();
                return number1 + " - " + number2 + " = ?";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method creates and returns a string representation of a whole multiplication question
        /// it also instantiates the number1 and number2 fields with random numbers
        /// </summary>
        /// <returns></returns>
        public String createMultiplicationQuestion()
        {
            try
            {
                number1 = getRandomNumber();
                number2 = getRandomNumber();
                return number1 + " + " + number2 + " = ?";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method creates and returns a string representation of a whole division question
        /// it also instantiates the number1 and number2 fields with random numbers
        /// </summary>
        /// <returns></returns>
        public String createDivisionQuestion()
        {
            try
            {
                number2 = getRandomDenominator();
                number1 = getRandomNumerator(number2);
                return number1 + " / " + number2 + " = ?";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method creates a new player instance with the injected name and age params
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public void createNewPlayer(String name, int age)
        {
            try
            {
                this.mPlayer = new Player(name, age);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method creates a new HighScore with the current player instances name and score
        /// </summary>
        /// <returns></returns>
        public HighScore createHighScore()
        {
            try
            {
                return new HighScore(this.mPlayer.getName(), this.mPlayer.getScore(), this.mPlayer.getTime());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="highScore"></param>
        public void addHighScoreToRecords(HighScore highScore)
        {
            try
            {
                if (this.mRecords.isNewHighScore(highScore))
                {
                    this.mRecords.addHighScoreToRecords(highScore);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for a random denominator between 1 and 10
        /// </summary>
        /// <returns></returns>
        public int getRandomDenominator()
        {
            try
            {
                return mRandom.Next(1, 11);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for a random numerator that is a multiple of the injected integer param
        /// the injected integer is the denominator
        /// the number returned is a multiple between 1-10 of the denominator param
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int getRandomNumerator(int num)
        {
            try
            {
                return num * mRandom.Next(1, 11);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for a random number between 1 and 10
        /// </summary>
        /// <returns></returns>
        public int getRandomNumber()
        {
            try
            {
                return mRandom.Next(10) + 1;
            }
            catch (Exception e)
            {
                throw e;
            }            
        }

        /// <summary>
        /// Getter for the current instance of mPlayer
        /// </summary>
        /// <returns></returns>
        public Player getPlayer()
        {
            try
            {
                return this.mPlayer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for the current instance of mRecords
        /// </summary>
        /// <returns></returns>
        public Records getRecords()
        {
            try
            {
                return this.mRecords;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for the current instance of correctAnser
        /// </summary>
        /// <returns></returns>
        public int getCorrectAnswer()
        {
            try
            {
                return this.correctAnswer;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for the current instance of number1
        /// </summary>
        /// <returns></returns>
        public int getNumber1()
        {
            try
            {
                return this.number1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for the current instance of number2
        /// </summary>
        /// <returns></returns>
        public int getNumber2()
        {
            try
            {
                return this.number2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Setter for the current instance of gameType
        /// </summary>
        /// <param name="type"></param>
        public void setGameType(String type)
        {
            try
            {
                this.gameType = type;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
