using Microsoft.Win32;
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

namespace TOT.View.UserControls
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        public event EventHandler<string> FileOpened;

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            bool? succes = fileDialog.ShowDialog();

            if(succes == true)
            {
                string filePath = fileDialog.FileName;

                FileOpened?.Invoke(this, filePath);
            }
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemSaveAs_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemUndo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemRedo_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}