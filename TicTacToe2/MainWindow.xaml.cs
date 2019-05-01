using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string xwins = ("X = " + Properties.Settings.Default.XScore + " wins");
        string owins = ("O = " + Properties.Settings.Default.OScore + " wins");
        string currentPlayer = "X";

        public MainWindow()
        {
            InitializeComponent();
            //if (Properties.Settings.Default.XScore < 1)
            //{
            //    Properties.Settings.Default.XScore = 0;
            //}
            //if (Properties.Settings.Default.OScore < 1)
            //{
            //    Properties.Settings.Default.OScore = 0;
            //}
            //Properties.Settings.Default.Save();

            XScores.Text = xwins;
            OScores.Text = owins;
            CurrentPlayer.Text = (currentPlayer + " to play...");
        }

        private void WinCheck()
        {
            if ((Box1.Content.ToString() == "X" && Box2.Content.ToString() == "X" && Box3.Content.ToString() == "X")
                || (Box4.Content.ToString() == "X" && Box5.Content.ToString() == "X" && Box6.Content.ToString() == "X")
                || (Box7.Content.ToString() == "X" && Box8.Content.ToString() == "X" && Box9.Content.ToString() == "X")
                || (Box1.Content.ToString() == "X" && Box4.Content.ToString() == "X" && Box7.Content.ToString() == "X")
                || (Box2.Content.ToString() == "X" && Box5.Content.ToString() == "X" && Box8.Content.ToString() == "X")
                || (Box3.Content.ToString() == "X" && Box6.Content.ToString() == "X" && Box9.Content.ToString() == "X")
                || (Box1.Content.ToString() == "X" && Box5.Content.ToString() == "X" && Box9.Content.ToString() == "X")
                || (Box3.Content.ToString() == "X" && Box5.Content.ToString() == "X" && Box7.Content.ToString() == "X")
                || (Box1.Content.ToString() == "O" && Box2.Content.ToString() == "O" && Box3.Content.ToString() == "O")
                || (Box4.Content.ToString() == "O" && Box5.Content.ToString() == "O" && Box6.Content.ToString() == "O")
                || (Box7.Content.ToString() == "O" && Box8.Content.ToString() == "O" && Box9.Content.ToString() == "O")
                || (Box1.Content.ToString() == "O" && Box4.Content.ToString() == "O" && Box7.Content.ToString() == "O")
                || (Box2.Content.ToString() == "O" && Box5.Content.ToString() == "O" && Box8.Content.ToString() == "O")
                || (Box3.Content.ToString() == "O" && Box6.Content.ToString() == "O" && Box9.Content.ToString() == "O")
                || (Box1.Content.ToString() == "O" && Box5.Content.ToString() == "O" && Box9.Content.ToString() == "O")
                || (Box3.Content.ToString() == "O" && Box5.Content.ToString() == "O" && Box7.Content.ToString() == "O")
                )
            {
                MessageBox.Show("Game won by player " + currentPlayer + "!");

                if (currentPlayer == "X")
                {
                    Properties.Settings.Default.XScore++;
                }
                else if (currentPlayer == "O")
                {
                    Properties.Settings.Default.OScore++;
                }
                Properties.Settings.Default.Save();
                ResetGame();
            }
            else if (Box1.Content.ToString() != " "
                && Box2.Content.ToString() != " "
                && Box3.Content.ToString() != " "
                && Box4.Content.ToString() != " "
                && Box5.Content.ToString() != " "
                && Box6.Content.ToString() != " "
                && Box7.Content.ToString() != " "
                && Box8.Content.ToString() != " "
                && Box9.Content.ToString() != " ")
            {
                MessageBox.Show("The game resulted in a tie!");
                ResetGame();
            }

            else
            {
                PlayerSwitch();
            }
        }

        void PlayerSwitch()
        {
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
                OScores.FontWeight = FontWeights.Bold;
                XScores.FontWeight = FontWeights.Light;
            }

            else
            {
                currentPlayer = "X";
                XScores.FontWeight = FontWeights.Bold;
                OScores.FontWeight = FontWeights.Light;
            }

            CurrentPlayer.Text = (currentPlayer + " to play...");
        }

        void ResetGame()
        {
            Box1.IsEnabled = true;
            Box2.IsEnabled = true;
            Box3.IsEnabled = true;
            Box4.IsEnabled = true;
            Box5.IsEnabled = true;
            Box6.IsEnabled = true;
            Box7.IsEnabled = true;
            Box8.IsEnabled = true;
            Box9.IsEnabled = true;
            Box1.Content = " ";
            Box2.Content = " ";
            Box3.Content = " ";
            Box4.Content = " ";
            Box5.Content = " ";
            Box6.Content = " ";
            Box7.Content = " ";
            Box8.Content = " ";
            Box9.Content = " ";
            string xwins = ("X = " + Properties.Settings.Default.XScore + " wins");
            string owins = ("O = " + Properties.Settings.Default.OScore + " wins");
            XScores.Text = xwins;
            OScores.Text = owins;
        }

        private void Box1_Click(object sender, RoutedEventArgs e)
        {
            Box1.IsEnabled = false;
            Box1.Content = currentPlayer;
            WinCheck();
        }

        private void Box2_Click(object sender, RoutedEventArgs e)
        {
            Box2.IsEnabled = false;
            Box2.Content = currentPlayer;
            WinCheck();
        }

        private void Box3_Click(object sender, RoutedEventArgs e)
        {
            Box3.IsEnabled = false;
            Box3.Content = currentPlayer;
            WinCheck();
        }

        private void Box4_Click(object sender, RoutedEventArgs e)
        {
            Box4.IsEnabled = false;
            Box4.Content = currentPlayer;
            WinCheck();
        }

        private void Box5_Click(object sender, RoutedEventArgs e)
        {
            Box5.IsEnabled = false;
            Box5.Content = currentPlayer;
            WinCheck();
        }

        private void Box6_Click(object sender, RoutedEventArgs e)
        {
            Box6.IsEnabled = false;
            Box6.Content = currentPlayer;
            WinCheck();
        }

        private void Box7_Click(object sender, RoutedEventArgs e)
        {
            Box7.IsEnabled = false;
            Box7.Content = currentPlayer;
            WinCheck();
        }

        private void Box8_Click(object sender, RoutedEventArgs e)
        {
            Box8.IsEnabled = false;
            Box8.Content = currentPlayer;
            WinCheck();
        }

        private void Box9_Click(object sender, RoutedEventArgs e)
        {
            Box9.IsEnabled = false;
            Box9.Content = currentPlayer;
            WinCheck();
        }

        private void ResetScores_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you really want to clear the scores?",
                                          "Confirmation",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Properties.Settings.Default.XScore = 0;
                Properties.Settings.Default.OScore = 0;
                Properties.Settings.Default.Save();
                string xwins = ("X = " + Properties.Settings.Default.XScore + " wins");
                string owins = ("O = " + Properties.Settings.Default.OScore + " wins");
                XScores.Text = xwins;
                OScores.Text = owins;
            }
        }

        private void ResetGame_Click(object sender, RoutedEventArgs e)
        {
            ResetGame();
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void QuitGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpponentToggle_Click(object sender, RoutedEventArgs e)
        {
            if (OpponentToggle.Content.ToString() == "2 Player Game")
            {
                OpponentToggle.Content = "CPU Game";
            }
            else
            {
                OpponentToggle.Content = "2 Player Game";
            }
        }
    }
}
