using LoLIndex.Models;
using LoLIndex.ViewControllers;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
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
            ShowChampions(Controller.AllChampions());
        }

        private void ShowChampions(List<Champion> champions)
        {
            foreach (var champion in champions)
            {
                Button ChampImage = new Button();
                ChampImage.Width = champion.Image.W * 2;
                ChampImage.Height = champion.Image.H * 2;
                ChampImage.ToolTip = champion.Name;
                ChampImage.Background = new ImageBrush(new BitmapImage(new Uri($"{imageURI}{champion.Image.Full}")));
                ChampImage.Click += (s, e) => { ShowChampionDetail(champion.Id); };
                ChampionsIndex.Children.Add(ChampImage);
            }
        }

        private void ShowChampionDetail(int champId)
        {
            ChampionDetails champDetail = Controller.ChampionDetail(champId);
            ChampionWindow champWindow = new ChampionWindow(champDetail);
            champWindow.Show();
        }
    }
}
