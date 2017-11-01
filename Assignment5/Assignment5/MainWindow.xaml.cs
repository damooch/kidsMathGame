using KidsMathGame.utils;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KidsMathGame
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// GameLogic object instance field
        /// </summary>
        private GameLogic mGameLogic;
        /// <summary>
        /// PlayerInfoWindow object instance field
        /// </summary>
        private PlayerInfoWindow mPlayerInfoWinow;
        /// <summary>
        /// FinalScoreWindow object instance field
        /// </summary>
        private FinalScoreWindow mFinalScoreWindow;
        /// <summary>
        /// GameWindow object instance field
        /// </summary>
        private GameWindow mGameWindow;
        /// <summary>
        /// GameTypeWindow object instance field
        /// </summary>
        private GameTypeWindow mGameTypeWindow;
        /// <summary>
        /// Sound player to play dora sound at start
        /// </summary>
        SoundPlayer simpleSound;

        /// <summary>
        /// Constructor for the MainWindow that Initializes components and class objects
        /// </summary>
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                InitializeGameLogicClasses();
                InitializeGameWindows();
                hideMainErrorLabel();
                playStartGameSound();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// Mthod initializes the mGameLogic object instance
        /// </summary>
        private void InitializeGameLogicClasses()
        {
            try
            {
                mGameLogic = new GameLogic();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Instantiates the PlayerInfoWindow and GameTypeWindow
        /// </summary>
        private void InitializeGameWindows()
        {
            try
            {
                mPlayerInfoWinow = new PlayerInfoWindow(this);
                mGameTypeWindow = new GameTypeWindow(this);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Override OnClosed method to close the application from running when the MainWindow is closed
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(EventArgs e)
        {
            try
            {

                base.OnClosed(e);
                Application.Current.Shutdown();
            }
            catch(Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }


        /// <summary>
        /// Button that will navigate the main window to the PlayerInfoWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userInfoNavButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                hideMainErrorLabel();
                showPlayerWindow();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// Button that will navigate the main window to the FinalScoresWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highScoresNavButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                hideMainErrorLabel();
                showFinalScoresWindow();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// Button that will navigate the main window to the GameWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playGameNavButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mGameLogic.getPlayer() != null)
                {
                    hideMainErrorLabel();
                    showGameTypeWindow();
                }
                else
                {
                    showMainErrorLabel();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
            
        }

        /// <summary>
        /// Method adds a new HighScore object to the Record object instance in the GameLogic instance
        /// </summary>
        public void addHighScoreToRecord()
        {
            try
            {
                this.mGameLogic.addHighScoreToRecords(this.mGameLogic.createHighScore());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method shows the GameWindow by creating a new instance and shows it as a Dialog
        /// </summary>
        public void showGameWindow()
        {
            try
            {
                stopPlayingStartGameSound();
                mGameWindow = new GameWindow(this);
                mGameWindow.ShowDialog();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method closes the GameWindow
        /// </summary>
        public void closeGameWindow()
        {
            try
            {
                mGameWindow.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method shows the PlayerWindow by creating a new instance and shows it as a Dialog
        /// </summary>
        public void showPlayerWindow()
        {
            try
            {
                mPlayerInfoWinow = new PlayerInfoWindow(this);
                mPlayerInfoWinow.ShowDialog();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method closes the PlayerWindow
        /// </summary>
        public void closePlayerWindow()
        {
            try
            {
                mPlayerInfoWinow.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method shows the FinalScoreWindow by creating a new instance and shows it as a Dialog
        /// </summary>
        public void showFinalScoresWindow()
        {
            try
            {
                if(this.mGameLogic != null && this.mGameLogic.getPlayer() != null)
                {
                    hideMainErrorLabel();
                    mFinalScoreWindow = new FinalScoreWindow(this);
                    mFinalScoreWindow.ShowDialog();
                }else
                {
                    showMainErrorLabel();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method closes the FinalScoreWindow
        /// </summary>
        public void closeFinalScoreWindow()
        {
            try
            {
                mFinalScoreWindow.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method shows the GameTypeWindow by creating a new instance and shows it as a Dialog
        /// </summary>
        public void showGameTypeWindow()
        {
            try
            {
                mGameTypeWindow = new GameTypeWindow(this);
                mGameTypeWindow.ShowDialog();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method closes the GameTypeWindow
        /// </summary>
        public void closeGameTypeWindow()
        {
            try
            {
                mGameTypeWindow.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method makes mainErrorLabels text an error string
        /// </summary>
        public void showMainErrorLabel()
        {
            try
            {
                mainErrorLabel.Content = "Please Enter Player Info First";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method makes mainErrorLabels text an empty string
        /// </summary>
        public void hideMainErrorLabel()
        {
            try
            {
                mainErrorLabel.Content = "";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Getter for the current instance of GameLogic
        /// </summary>
        /// <returns></returns>
        public GameLogic getGameLogic()
        {
            try
            {
                return this.mGameLogic;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method gets the current players name from the player instance in GameLogic
        /// </summary>
        /// <returns></returns>
        public String getPlayerName()
        {
            try
            {
                if (this.mGameLogic != null)
                {
                    if (this.mGameLogic.getPlayer() != null)
                    {
                        return this.mGameLogic.getPlayer().getName();
                    }
                }
                return "";
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method gets the current players age from the player instance in GameLogic
        /// </summary>
        /// <returns></returns>
        public int getPlayerAge()
        {
            try
            {
                if (this.mGameLogic != null)
                {
                    if (this.mGameLogic.getPlayer() != null)
                    {
                        return this.mGameLogic.getPlayer().getAge();
                    }
                }
                return -1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method plays a sound file from resources/sound for correct answers
        /// </summary>
        private void playStartGameSound()
        {
            try
            {

                simpleSound = new SoundPlayer("../../resources/sounds/doraStart.wav");
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
        private void stopPlayingStartGameSound()
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
