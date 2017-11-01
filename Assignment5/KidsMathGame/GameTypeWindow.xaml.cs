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
    /// Interaction logic for GameTypeWindow.xaml
    /// </summary>
    public partial class GameTypeWindow : Window
    {
        /// <summary>
        /// MainWindow that is used as an accessor between Windows and GameLogic
        /// </summary>
        MainWindow mMainWindow;

        /// <summary>
        /// Constructor for the GameTypeWindow to initialize fields and components
        /// </summary>
        /// <param name="mw"></param>
        public GameTypeWindow(MainWindow mw)
        {
            try
            {
                InitializeComponent();
                this.mMainWindow = mw;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Event handler for the additionGameSelectionButton click event
        /// This method sets the gameType  to '+' in GameLogic, closes the GameTypeWindow, 
        /// and displays the GameWindow as a dialogWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void additionGameSelectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mMainWindow.getGameLogic().setGameType("+");
                mMainWindow.closeGameTypeWindow();
                mMainWindow.showGameWindow();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Event handler for the subtractionGameSelectButton click event
        /// This method sets the gameType to '-' in GameLogic, closes the GameTypeWindow, 
        /// and displays the GameWindow as a dialogWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtractionGameSelectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mMainWindow.getGameLogic().setGameType("-");
                mMainWindow.closeGameTypeWindow();
                mMainWindow.showGameWindow();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Event handler for the multiplicationGameSelectButton click event
        /// This method sets the gameType  to '*' in GameLogic, closes the GameTypeWindow, 
        /// and displays the GameWindow as a dialogWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiplicationGameSelectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mMainWindow.getGameLogic().setGameType("*");
                mMainWindow.closeGameTypeWindow();
                mMainWindow.showGameWindow();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// Event handler for the divisionGameSelectButton click event
        /// This method sets the gameType  to '/' in GameLogic, closes the GameTypeWindow, 
        /// and displays the GameWindow as a dialogWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divisionGameSelectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mMainWindow.getGameLogic().setGameType("/");
                mMainWindow.closeGameTypeWindow();
                mMainWindow.showGameWindow();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
        }
    }
}
