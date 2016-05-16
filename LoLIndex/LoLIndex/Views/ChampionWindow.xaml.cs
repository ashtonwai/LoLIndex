using LoLIndex.Models;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace LoLIndex.Views
{
    /// <summary>
    /// Interaction logic for ChampionWindow.xaml
    /// </summary>
    public partial class ChampionWindow : Window
    {
        public string imageURI = "http://ddragon.leagueoflegends.com/cdn/6.9.1/img";
        public string splashURI = "http://ddragon.leagueoflegends.com/cdn/img";

        public ChampionWindow()
        {
            InitializeComponent();
        }

        public ChampionWindow(ChampionDetails champion)
        {
            InitializeComponent();
            Title = champion.Name;

            ChampBG.Source = new BitmapImage(new Uri($"{splashURI}/champion/splash/{champion.Key}_{champion.Skins[0].Num}.jpg"));

            ChampProfile.Source = new BitmapImage(new Uri($"{imageURI}/champion/{champion.Image.Full}"));
            ChampName.Content = champion.Name;
            ChampTitle.Content = champion.Title;

            ChampInfo_AttackBar.Margin = new Thickness(0, 0, 200 - champion.Info.Attack * 20, 0);
            ChampInfo_DefenseBar.Margin = new Thickness(0, 0, 200 - champion.Info.Defense * 20, 0);
            ChampInfo_MagicBar.Margin = new Thickness(0, 0, 200 - champion.Info.Magic * 20, 0);
            ChampInfo_DifficultyBar.Margin = new Thickness(0, 0, 200 - champion.Info.Difficulty * 20, 0);

            Passive_Image.Source = new BitmapImage(new Uri($"{imageURI}/passive/{champion.Passive.Image.Full}"));
            Passive_Name.Content = champion.Passive.Name;
            Passive_Desc.Text = champion.Passive.Description;

            SpellQ_Image.Source = new BitmapImage(new Uri($"{imageURI}/spell/{champion.Spells[0].Image.Full}"));
            SpellQ_Name.Content = champion.Spells[0].Name;
            SpellQ_Desc.Text = champion.Spells[0].Description;

            SpellW_Image.Source = new BitmapImage(new Uri($"{imageURI}/spell/{champion.Spells[1].Image.Full}"));
            SpellW_Name.Content = champion.Spells[1].Name;
            SpellW_Desc.Text = champion.Spells[1].Description;

            SpellE_Image.Source = new BitmapImage(new Uri($"{imageURI}/spell/{champion.Spells[2].Image.Full}"));
            SpellE_Name.Content = champion.Spells[2].Name;
            SpellE_Desc.Text = champion.Spells[2].Description;

            SpellR_Image.Source = new BitmapImage(new Uri($"{imageURI}/spell/{champion.Spells[3].Image.Full}"));
            SpellR_Name.Content = champion.Spells[3].Name;
            SpellR_Desc.Text = champion.Spells[3].Description;

            LoreText.Text = champion.Lore;
        }
    }
}
