using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows;
using MahApps.Metro.Controls;
using WPFMusicPlayer.Model;

namespace WPFMusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            // Load the list from json
            string json = File.ReadAllText(Environment.CurrentDirectory + @"\Music.json");
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            ObservableCollection<ArtistViewModel> artists = jsSerializer.Deserialize<ObservableCollection<ArtistViewModel>>(json);

            DataContext = artists;

            InitializeComponent();
        }
    }
}
