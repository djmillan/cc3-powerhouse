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
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();

            DataContext = _gameSession;
        }
        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
        }
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
        private void AttackButton_Click(object sender, RoutedEventArgs e)
        {
            // attack
        }

        private void InteractButton_Click(object sender, RoutedEventArgs e)
        {
            // interact
        }

        private void InventoryButton_Click(object sender, RoutedEventArgs e)
        {
            // inventory
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            // run
        }

//Some additional xD
private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.ExperiencePoints = _gameSession.CurrentPlayer.ExperiencePoints + 10;
        }
        SoundPlayer _soundPlayer = new SoundPlayer(@"C:\cc3-1b-millandj\SOSCSRPG\WPFUI\Music\AMV - Berserk - Forces.wav");
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _soundPlayer.Play();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            _soundPlayer.Stop();
        }
    }
}