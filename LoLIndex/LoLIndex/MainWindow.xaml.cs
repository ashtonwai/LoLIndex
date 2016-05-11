using LoLIndex.Views;
using System.Windows;

namespace LoLIndex
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

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var indexWindow = new IndexWindow();
            indexWindow.Show();
            this.Close();
        }
    }
}
