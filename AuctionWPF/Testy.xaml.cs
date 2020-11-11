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
using System.Windows.Shapes;

namespace AuctionWPF
{
    /// <summary>
    /// Interaction logic for Testy.xaml
    /// </summary>
    public partial class Testy : Window
    {
        public Testy()
        {
            InitializeComponent();
        }

        private void showDatez_Click(object sender, RoutedEventArgs e)
        {
            showDate.Text = pickedDate.Text;
        }
    }
}
