using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        //private Label gameAnswerValidationLabel;
        //private Label gameInputErrorLabel;
        //private Label gameQuestionLabel;
        //private Label gameScoreLabel;
        //private Label gameTimerLabel;
        //private Button gameCheckAnswerButton;
        //private TextBox gameAnswerTextBox;

        /// <summary>
        /// MainWindow that is used as an accessor between Windows and GameLogic
        /// </summary>
        private MainWindow mMainWindow;
        /// <summary>
        /// Field to keep track of the current round / question number
        /// </summary>
        private int round;
        /// <summary>
        /// Field to keep track of the current time being counted down in seconds
        /// </summary>
        private int time;
        /// <summary>
        /// Field to validate the player has submitted a valid answer
        /// </summary>
        private Boolean answered;
        /// <summary>
        /// Field to hold the integer answer submitted by the player
        /// </summary>
        private int answer;
        /// <summary>
        /// Field to record how quickly the player completes a game
        /// </summary>
        private int playerTimeCount;
        /// <summary>
        /// Field used as a flag to represent waiting between rounds
        /// </summary>
        private Boolean wait;
        /// <summary>
        /// Timer used for counting down the seconds
        /// </summary>
        private Timer secondTimer;
        /// <summary>
        /// Timer used for waiting after each round / question
        /// </summary>
        private Timer waitTimer;

        /// <summary>
        /// Constructor to instantiate the fields and components
        /// It also calls playGame() to start the game and timers
        /// </summary>
        /// <param name="mw"></param>
        public GameWindow(MainWindow mw)
        {
            try
            {
                InitializeComponent();
                this.mMainWindow = mw;
                this.round = 0;
                this.time = 20;
                this.playerTimeCount = 0;
                this.answered = false;
                this.wait = true;
                this.answer = 0;
                mMainWindow.getGameLogic().getPlayer().resetScore();
                mMainWindow.getGameLogic().getPlayer().resetTime();
                gameScoreLabel.Content = "0";
                gameTimerLabel.Content = "20";
                playGame();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// The event handler for clicking the checkAnswerButton
        /// This method will update error labels and set the flag for valid user answer submission (answered)
        /// This flag is used in the timers to progress through the rounds and update the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameCheckAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Boolean result = int.TryParse(gameAnswerTextBox.Text, out answer);
                if (result)
                {
                    answered = true;
                    gameInputErrorLabel.Content = "";

                }
                else
                {
                    gameInputErrorLabel.Content = "Input must be an number";
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// This is an event handler for when the user hits enter/return when typing int the gameAnswerTextBox
        /// This method will update error labels and set the flag for valid user answer submission (answered)
        /// This flag is used in the timers to progress through the rounds and update the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameAnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Key == Key.Return || e.Key == Key.Enter)
                {
                    Boolean result = int.TryParse(gameAnswerTextBox.Text, out answer);
                    if (result)
                    {
                        answered = true;
                        gameInputErrorLabel.Content = "";

                    }
                    else
                    {
                        gameInputErrorLabel.Content = "Input must be an number";
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.StackTrace);
            }
        }

        /// <summary>
        /// Event handler for the close window event 
        /// Use this method to close timers and threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                secondTimer.Close();
                waitTimer.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This delegate is used to call methods from the separate threads created by the Timers
        /// </summary>
        private delegate void UICallback();

        /// <summary>
        /// This method calls the the startRound() method to start a new round
        /// subsequent rounds will be called with the secondTimer's event method
        /// </summary>
        private void playGame()
        {
            try
            {
                startRound();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method is used at the end of the game to add a HighScore to the Record instance in the MainWindows
        /// instance of Game logic. This GameWindow is closed and the FinalScoresWindow is shown as a Dialog
        /// </summary>
        private void endGame()
        {
            try
            {
                Debug.WriteLine("Correct: \t" + this.mMainWindow.getGameLogic().getPlayer().getScore());
                Debug.WriteLine("Incorrect: \t" + (10 - this.mMainWindow.getGameLogic().getPlayer().getScore()));
                Debug.WriteLine("Time: \t" + (10 - this.mMainWindow.getGameLogic().getPlayer().getTime()));
                mMainWindow.getGameLogic().getPlayer().setTime(playerTimeCount);
                mMainWindow.addHighScoreToRecord();
                mMainWindow.closeGameWindow();
                mMainWindow.showFinalScoresWindow();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method starts a new round by clearing out labels or resetting them and resetting the
        /// fields used for each round like the answered flag and time
        /// the round field is incremented for use in the event handling in the secondTimer for
        /// game completion
        /// </summary>
        private void startRound()
        {
            try
            {
                round++;
                time = 20;
                answered = false;
                gameTimerLabel.Content = "" + time;
                gameQuestionLabel.Content = getQuestion();
                gameAnswerValidationLabel.Content = "";
                gameInputErrorLabel.Content = "";
                startTimer();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method is called at the end of each round either after the user has triggered the 
        /// answered flag or the timer has counted down to zero. This method will evaluate the correctness
        /// of the players answer and update the UI gameAnswerValidationLabel accordingly while also
        /// clearing out the gameAnswerTextBox text
        /// </summary>
        private void endRound()
        {
            try
            {
                int num1 = mMainWindow.getGameLogic().getNumber1();
                int num2 = mMainWindow.getGameLogic().getNumber2();
                Boolean correct = mMainWindow.getGameLogic().checkAnswer(answer, num1, num2);
                gameScoreLabel.Content = "" + mMainWindow.getGameLogic().getPlayer().getScore();
                gameQuestionLabel.Content = getQuestionWithAnswer();
                playerTimeCount += (20 - time);
                if (correct)
                {
                    gameAnswerValidationLabel.Content = "Great Job!";
                    playCorrectSound();
                }
                else
                {
                    gameAnswerValidationLabel.Content = "So Close...";
                    playWrongSound();
                }
                gameAnswerTextBox.Text = "";
                startWaitTimer();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method starts the timer used to count down the seconds. This timer is used to update the
        /// UI through delegates and call startRound methods after each round
        /// </summary>
        private void startTimer()
        {
            try
            {
                secondTimer = new Timer();
                secondTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                secondTimer.Interval = 1000;
                secondTimer.Enabled = true;
            }
            catch (Exception e)
            {
                throw e;
            }          
        }

        /// <summary>
        /// This is an event called after the waitTimer interval where the delegate method UICallback is
        /// used to decrement the time filed and update the gameTimerLabel content by calling the UpdateTimerText. 
        /// The delegate is used to update the UI from the separate thread the timer creates
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                time--;
                gameTimerLabel.Dispatcher.Invoke(new UICallback(this.UpdateTimerText));
            }
            catch (Exception e2)
            {
                throw e2;
            }
        }

        /// <summary>
        /// This method is called to update the UI gameTimerLabel content dynamically as teh time field
        /// is decremented
        /// </summary>
        private void UpdateTimerText()
        {
            try
            {
                gameTimerLabel.Content = "" + time;
                if (time <= 0 || answered)
                {
                    secondTimer.Enabled = false;
                    secondTimer.Close();
                    endRound();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method starts the timer that waits for two seconds after a question is evaluated so the UI
        /// can update before moving to the next question
        /// </summary>
        private void startWaitTimer()
        {
            try
            {
                waitTimer = new Timer();
                waitTimer.Elapsed += new ElapsedEventHandler(OnWaitTimedEvent);
                waitTimer.Interval = 2000;
                waitTimer.Enabled = true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This is an event called after the waitTimer interval where the delegate method UICallback is
        /// used to start a new round if the field round is less than 10 otherwise it calls the endGame
        /// method. The delegate is used to update the UI from the separate thread the timer creates
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnWaitTimedEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                wait = false;
                waitTimer.Enabled = false;
                waitTimer.Close();
                // only start another round if we are under 10 rounds 
                if (round < 10)
                {
                    Dispatcher.Invoke(new UICallback(this.startRound));
                }
                else
                {
                    Dispatcher.Invoke(new UICallback(this.endGame));
                }
            }
            catch (Exception e2)
            {
                throw e2;
            }
        }

        /// <summary>
        /// Method gets a string representation of games current question
        /// from the GameLogic instance in MainWindow
        /// </summary>
        /// <returns></returns>
        private String getQuestion()
        {
            try
            {
                return mMainWindow.getGameLogic().getQuestion();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method gets a string representation of games current question with the answer
        /// from the GameLogic instance in MainWindow
        /// </summary>
        /// <returns></returns>
        private String getQuestionWithAnswer()
        {
            try
            {
                return mMainWindow.getGameLogic().getQuestionWithAnswer();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method plays a sound file from resources/sound for wrong answers
        /// </summary>
        private void playCorrectSound()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer("../../resources/sounds/correct.wav");
                simpleSound.Play();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This method plays a sound file from resources/sound for correct answers
        /// </summary>
        private void playWrongSound()
        {
            try
            {
                SoundPlayer simpleSound = new SoundPlayer("../../resources/sounds/wrong.wav");
                simpleSound.Play();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
