using Microsoft.Win32;
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

namespace Videoplayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            MediaState ms = MediaState.Play;
            me.LoadedBehavior = ms;
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            MediaState ms = MediaState.Pause;
            me.LoadedBehavior = ms;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            MediaState ms = MediaState.Stop;
        
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fd.ShowDialog();
            string fileName = fd.FileName;

            if (fileName != "")
            {
                
                Uri u = new Uri(fileName);
                me.Source = u;
                MediaState opt = MediaState.Play;
                me.LoadedBehavior = opt;
            }
            else{
                MessageBox.Show("No selection!");
            }
        }
        string url = @"C:\\Users\\Student\\source\\repos\\Videoplayer\\Resourses\\ideo1.mp4";
        private void window_loaded(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(url);
            me.Source = uri;

            MediaState opt = MediaState.Play;

            me.LoadedBehavior = opt;
        }
    }
}