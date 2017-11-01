using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KidsMathGame
{
    /// <summary>
    /// Interaction logic for PlayerInfoWindow.xaml
    /// </summary>
    public partial class PlayerInfoWindow : Window
    {
        /// <summary>
        /// MainWindow that is used as an accessor between Windows and GameLogic
        /// </summary>
        MainWindow mMainWindow;

        /// <summary>
        /// Constructor to initialize the playerNameTextBox and playerAgeTextBox content and to use a local instance
        /// of the MainWindow that is used as an accessor between windows and GameLogic
        /// </summary>
        /// <param name="mw"></param>
        public PlayerInfoWindow(MainWindow mw)
        {
            try
            {
                InitializeComponent();
                this.mMainWindow = mw;
                playerNameTextBox.Text = mMainWindow.getPlayerName();
                int age = mMainWindow.getPlayerAge();
                if (age < 0)
                {
                    playerAgeTextBox.Text = "";
                }
                else
                {
                    playerAgeTextBox.Text = "" + age;
                }
            }
            catch (Exception e)
            {
                throw e;
            }          
        }

        /// <summary>
        /// Event handler for clicking the savePlayerInfo button
        /// This method validates the name and age input before allowing a new player to be saved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savePlayerInfoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool resName = validateNameInput();
                bool resAge = validateAgeInput();
                if (resName && resAge)
                {
                    String name = playerNameTextBox.Text;
                    int age = -1;
                    bool res = int.TryParse(playerAgeTextBox.Text, out age);
                    if (res)
                    {
                        mMainWindow.getGameLogic().createNewPlayer(name, age);
                        mMainWindow.closePlayerWindow();
                        mMainWindow.showGameTypeWindow();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }          
        }

        /// <summary>
        /// Event handler for player hitting enter/return in the player name text box
        /// calls validateNameInput()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return || e.Key == Key.Enter)
                {
                    bool res = validateNameInput();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// Event handler for player hitting enter/return in the player age text box
        /// calls validateAgeInput()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playerAgeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return || e.Key == Key.Enter)
                {
                    bool res = validateAgeInput();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// This method validates age name by calling IsAllLetters(String name)
        /// And updates the playerNameErrorLabel if they enter characters other than letters
        /// or if they try to save with the input empty
        /// </summary>
        /// <returns></returns>
        private bool validateNameInput()
        {
            try
            {
                if (playerNameTextBox.Text.Equals(""))
                {
                    playerNameErrorLabel.Content = "Name can't be empty";
                    return false;
                }
                else if (IsAllLetters(playerNameTextBox.Text))
                {
                    playerNameErrorLabel.Content = "";
                    return true;
                }
                playerNameErrorLabel.Content = "Name can only be letters (A-Z)";
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method validates age input by calling IsAllDigits(String name)
        /// And updates the playerAgeErrorLabel if they enter characters other than digits
        /// or if they try to save with the input empty
        /// </summary>
        /// <returns></returns>
        private bool validateAgeInput()
        {
            try
            {
                if (playerAgeTextBox.Text.Equals(""))
                {
                    playerAgeErrorLabel.Content = "Age can't be empty";
                    return false;
                }
                else if (IsAllDigits(playerAgeTextBox.Text))
                {
                    playerAgeErrorLabel.Content = "";
                    return true;
                }
                playerAgeErrorLabel.Content = "Age can only be numbers";
                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method checks that all the characters in a string are letters
        /// </summary>
        /// <param name="s"></param>
        /// <returns>true if all chars are letters</returns>
        public bool IsAllLetters(string s)
        {
            try
            {
                foreach (char c in s)
                {
                    if (!Char.IsLetter(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method checks that all the characters in a string are digits
        /// </summary>
        /// <param name="s"></param>
        /// <returns>true if all chars are digits</returns>
        public bool IsAllDigits(string s)
        {
            try
            {
                foreach (char c in s)
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
