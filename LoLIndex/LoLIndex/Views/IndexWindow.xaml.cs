using LoLIndex.ViewControllers;
using System;
using System.Windows;

namespace LoLIndex.Views
{
    /// <summary>
    /// Interaction logic for IndexWindow.xaml
    /// </summary>
    public partial class IndexWindow : Window
    {
        public ViewController Controller { get; set; }

        public IndexWindow()
        {
            InitializeComponent();
            Controller = new ViewController();
        }

        public void ShowChampions()
        {
            object champs = Controller.GetAllChampions();
            Console.WriteLine(champs);
        }
    }
}
