using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace AuctionWPF
{
    /// <summary>
    /// Interaction logic for CreateAuction.xaml
    /// </summary>
    public partial class CreateAuction : Window
    {
        public CreateAuction()
        {
            InitializeComponent();
        }

        private void Upload_Picture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(fd.FileName));
                var fileNameToSave = DateTime.Now.ToString() + System.IO.Path.GetExtension(fd.FileName);
                var imagePath = System.IO.Path.Combine("/images/"+fileNameToSave);                
            
                File.Copy(fd.FileName, imagePath);
            }

        }
    }
}
