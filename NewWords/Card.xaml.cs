using System.Threading;
using System.Windows;
using System.Windows.Media;
using NewWords.Models;

namespace NewWords
{
    public partial class Card : Window
    {
        private GameContext game;
        public Card(GameContext round)
        {
            game = round;
            InitializeComponent();
        }
        
        private void FirstTranslation_OnClick(object sender, RoutedEventArgs e)
        {
            bool result = game.Guess(game.Vocab[game.Counter].t1);
            if (result)
            {
                firstTranslation.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                firstTranslation.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void FourthTranslation_OnClick(object sender, RoutedEventArgs e)
        {
            bool result = game.Guess(game.Vocab[game.Counter].t2);
            if (result)
            {
                secondTranslation.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                secondTranslation.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void ThirdTranslation_OnClick(object sender, RoutedEventArgs e)
        {
            bool result = game.Guess(game.Vocab[game.Counter].t3);
            if (result)
            {
                thirdTranslation.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                thirdTranslation.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void SecondTranslation_OnClick(object sender, RoutedEventArgs e)
        {
            bool result = game.Guess(game.Vocab[game.Counter].t4);
            if (result)
            {
                fourthTranslation.Background = new SolidColorBrush(Colors.Green);
            }
            else
            {
                fourthTranslation.Background = new SolidColorBrush(Colors.Red);
            }
        }

        private void WordOrigin_OnClick(object sender, RoutedEventArgs e)
        {
            string current = originLabel.Text;
            if (current == game.Vocab[game.Counter].orig)
            {
                originLabel.Text = game.Vocab[game.Counter].definition;}
            else
            {
                originLabel.Text = game.Vocab[game.Counter].orig;
            }
        }

        private void StartRound_OnClick(object sender, RoutedEventArgs e)
        {
            firstTLabel.Text = game.Vocab[game.Counter].t1; 
            secondTLabel.Text = game.Vocab[game.Counter].t2;
            thirdTLabel.Text = game.Vocab[game.Counter].t3;
            fourthTLabel.Text = game.Vocab[game.Counter].t4;
            originLabel.Text = game.Vocab[game.Counter].orig;
        }

        private void clearLabels()
        {
            firstTLabel.Text = ""; 
            secondTLabel.Text = "";
            thirdTLabel.Text = "";
            fourthTLabel.Text = "";
            originLabel.Text = "";
        }
    }
}