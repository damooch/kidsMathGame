using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsMathGame.utils
{
    /// <summary>
    /// This class is a simple calculator for arithmatic and remainders
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// This method returns the addition result of number1 + number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Addition(int number1, int number2)
        {
            try
            {
                return number1 + number2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method returns the subtraction result of number1 - number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Subtraction(int number1, int number2)
        {
            try
            {
                return number1 - number2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method returns the multiplication result of number1 * number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Multiplication(int number1, int number2)
        {
            try
            {
                return number1 * number2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method returns the division result of number1 / number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Division(int number1, int number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method returns the remainder of number1/number2
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public static int Modulus(int number1, int number2)
        {
            try
            {
                return number1 % number2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
