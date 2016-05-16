using LoLIndex.Models;
using System.Windows;

namespace LoLIndex.Views
{
    /// <summary>
    /// Interaction logic for ChampionWindow.xaml
    /// </summary>
    public partial class ChampionWindow : Window
    {
        public ChampionWindow()
        {
            InitializeComponent();
        }

        public ChampionWindow(ChampionDetails champion)
        {
            InitializeComponent();
            Title = champion.Name;
        }
    }
}
