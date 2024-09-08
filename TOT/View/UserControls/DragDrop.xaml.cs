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
    public partial class DragDrop : UserControl
    {
        public DragDrop()
        {
            InitializeComponent();
        }

        public event EventHandler<string> FileOpened;

        private void dragDropArea_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void dragDropArea_DragOver(object sender, DragEventArgs e)
        {
            e.Handled = true;
        }

        private void dragDropArea_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if(filePaths.Length == 1)
                {
                    string filePath = filePaths[0];
                    if (IsImageFile(filePath))
                    {
                        FileOpened?.Invoke(this, filePath);
                    }
                } 
                else if (filePaths.Length > 1)
                {
                    foreach (var filePath in filePaths)
                    {
                        if (IsImageFile(filePath))
                        {
                            
                        }
                    }
                }
            }
        }

        private bool IsImageFile(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp" };
            string extension = System.IO.Path.GetExtension(filePath).ToLower();
            return Array.Exists(imageExtensions, ext => ext == extension);
        }
    }
}
