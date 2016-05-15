using LoLIndex.Models;
using LoLIndex.ViewControllers;
using System;
using System.Collections.Generic;
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
            ShowChampions(Controller.AllChampions());
        }

        private void ShowChampions(List<Champion> champions)
        {
            foreach (var champion in champions)
            {
                Image ChampImage = new Image();
                ChampImage.Width = champion.Image.W * 2;
                ChampImage.Height = champion.Image.H * 2;
                ChampImage.ToolTip = champion.Name;
                ChampImage.Source = new BitmapImage(new Uri($"{imageURI}{champion.Image.Full}"));
                ChampionsIndex.Children.Add(ChampImage);
            }
        }

        private void ShowChampionDetail(int champId)
        {
            ChampionDetails champDetail = Controller.ChampionDetail(champId);
            Console.WriteLine(champDetail);
        }
    }
}
