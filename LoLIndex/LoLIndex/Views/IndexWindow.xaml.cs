using LoLIndex.ViewControllers;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace LoLIndex.Views
{
    /// <summary>
    /// Interaction logic for IndexWindow.xaml
    /// </summary>
    public partial class IndexWindow : Window
    {
        public string imageURI = "http://ddragon.leagueoflegends.com/cdn/6.9.1/img/champion/";

        public ViewController Controller { get; set; }

        public IndexWindow()
        {
            InitializeComponent();
            Controller = new ViewController();
            Controller.AllChampions();
            ShowChampions();
        }

        private void ShowChampions()
        {
            foreach (var champion in Controller.AllChampions())
            {
                Image ChampImage = new Image();
                ChampImage.Width = champion.Image.W;
                ChampImage.Height = champion.Image.H;
                ChampImage.Source = new BitmapImage(new Uri($"{imageURI}{champion.Image.Full}"));
                ChampionsIndex.Children.Add(ChampImage);
            }
        }
    }
}
