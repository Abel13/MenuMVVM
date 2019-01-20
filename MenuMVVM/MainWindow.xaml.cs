using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MenuMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<MenuItem> menu = new List<MenuItem>();

            menu.Add(new MenuItem("Images", PackIconKind.Image, new ItemCount(Brushes.Black, 2)));
            menu.Add(new MenuItem("Sounds", PackIconKind.Music, new ItemCount(Brushes.DarkBlue, 4)));
            menu.Add(new MenuItem("Video", PackIconKind.Video, new ItemCount(Brushes.DarkGreen, 7)));
            menu.Add(new MenuItem("Documents", PackIconKind.Folder, new ItemCount(Brushes.DarkOrange, 9)));

            ListViewMenu.ItemsSource = menu;
        }
    }
}
