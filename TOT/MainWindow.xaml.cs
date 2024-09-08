using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TOT.View.UserControls;

namespace TOT
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            menuBar.FileOpened += (sender, filePath) =>
            {
                singleImageUI.imageView.LoadImage(filePath);
                welcomeUI.Visibility = Visibility.Hidden;
                singleImageUI.Visibility = Visibility.Visible;
            };
            welcomeUI.dragDrop.FileOpened += (sender, filePath) =>
            {
                singleImageUI.imageView.LoadImage(filePath);
                welcomeUI.Visibility = Visibility.Hidden;
                singleImageUI.Visibility = Visibility.Visible;
            };
        }
    }
}
