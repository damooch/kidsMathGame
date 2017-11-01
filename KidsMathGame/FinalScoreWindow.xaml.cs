using KidsMathGame.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
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
    //ListBox topTenScoresListBox;
    //Button mainMenuNavButton;

    /// <summary>
    /// Interaction logic for FinalScoreWindow.xaml
    /// </summary>
    public partial class FinalScoreWindow : Window
    {
        /// <summary>
        /// MainWindow that is used as an accessor between Windows and GameLogic
        /// </summary>
        private MainWindow mMainWindow;
        /// <summary>
        /// Sound player to play dora sound at end
        /// </summary>
        private SoundPlayer simpleSound;

        /// <summary>
        /// Constructor to initialize fields and components
        /// </summary>
        /// <param name="mw"></param>
        public FinalScoreWindow(MainWindow mw)
        {
            try
            {
                InitializeComponent();
                this.mMainWindow = mw;
                showHighScores();
                playEndGameSound();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Event handler for the mainMenuNavButton click event
        /// This button closes the current FinalScoreWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuNavButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                stopPlayingEndGameSound();
                this.Close();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// This method loops throw all the HighScores in the Records instance within the GameLogic instance
        /// and adds them to the topTenScoresListBox to show on the UI
        /// sets the labels for players score with name, correct, incorrect, and time
        /// </summary>
        private void showHighScores()
        {
            try
            {
                Records mRecords = mMainWindow.getGameLogic().getRecords();
                String highScores = "";
                finalNameLabel.Content = " Name: \t\t" + this.mMainWindow.getPlayerName();
                finalCorrectLabel.Content = " Correct: \t\t" + this.mMainWindow.getGameLogic().getPlayer().getScore();
                int incorrect = 10 - this.mMainWindow.getGameLogic().getPlayer().getScore();
                finalIncorrectLabel.Content = " Incorrect: \t" + incorrect;
                finalTimeLabel.Content = " Time: \t\t" + this.mMainWindow.getGameLogic().getPlayer().getTime();
                topScoreHeaderLabel.Content = " Name  \t\t Score \t\tTime ";
                if (mRecords.getRecords().Count() > 0)
                {
                    Debug.WriteLine("mRecords.getRecords().Count() = " + mRecords.getRecords().Count());
                    foreach (HighScore hs in mRecords.getRecords())
                    {
                        highScores += hs.name + "\t\t" + hs.score + "/10\t\t" + hs.time +"\n";
                        topTenScoresListBox.Items.Add(hs.name + "\t\t" + hs.score + "/10\t\t" + hs.time);
                    }
                    Debug.WriteLine("HighScores:\n" + highScores);
                }
                else
                {
                    Debug.WriteLine(".... IDK why ....");
                }
            }
            catch (Exception e)
            {
                throw e;
            }           
        }

        /// <summary>
        /// This method plays a sound file from resources/sound for correct answers
        /// </summary>
        private void playEndGameSound()
        {
            try
            {
                simpleSound = new SoundPlayer("../../resources/sounds/doraFinal.wav");
                simpleSound.Play();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method stops playing game sound
        /// </summary>
        private void stopPlayingEndGameSound()
        {
            try
            {
                simpleSound.Stop();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
