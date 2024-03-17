using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModels;
using System.Media;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly GameSession _gameSession;
        private readonly SoundPlayer _soundPlayer;

        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();
            DataContext = _gameSession;

            // Set up the sound player
            if (!File.Exists(@"C:\cc3-1b-millandj\SOSCSRPG\WPFUI\Music\AMV - Berserk - Forces.wav"))
            {
                throw new FileNotFoundException("The specified sound file does not exist.");
            }

            _soundPlayer = new SoundPlayer(@"C:\cc3-1b-millandj\SOSCSRPG\WPFUI\Music\AMV - Berserk - Forces.wav");
        }

        private void OnMove(object sender, RoutedEventArgs e, Action moveAction)
        {
            try
            {
                moveAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            OnMove(sender, e, _gameSession.MoveNorth);
        }

        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            OnMove(sender, e, _gameSession.MoveWest);
        }

        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            OnMove(sender, e, _gameSession.MoveEast);
        }

        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            OnMove(sender, e, _gameSession.MoveSouth);
        }

        private void OnClick_AddExperience(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.ExperiencePoints += 10;
        }

        private void OnClick_PlaySound(object sender, RoutedEventArgs e)
        {
            _soundPlayer.Play();
        }

        private void OnClick_StopSound(object sender, RoutedEventArgs e)
        {
            _soundPlayer.Stop();
        }
    }
}
