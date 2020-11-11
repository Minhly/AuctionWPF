using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using Path = System.IO.Path;

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
                //var fileNameToSave = DateTime.Now.ToFileNameFormat() + Path.GetExtension(fd.FileName);
                //var imagePath = Path.Combine("images/" + fileNameToSave);
                //File.Copy(fd.FileName, imagePath);
            }

        }

        private void listItem_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=MININT-3GF1PEB; Initial Catalog=SDE; Integrated Security= True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                string phoTo = "mona.jpg";
                String Query = "INSERT INTO Auction_items (item_name, price, description, picture, date_created, owner, date_Deadline) Values (@itemName, @itemPrice, @itemDesc, @itemPicture, GETDATE(), @itemOwner, @itemDeadline);";
                SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@itemOwner", Global.userProp);
                sqlCmd.Parameters.AddWithValue("@itemName", itemNamez.Text);
                sqlCmd.Parameters.AddWithValue("@itemPrice", startPrice.Text);
                sqlCmd.Parameters.AddWithValue("@itemDesc", itemDESC.Text);
                sqlCmd.Parameters.AddWithValue("@itemPicture", phoTo);
                sqlCmd.Parameters.AddWithValue("@itemDeadline", datePicked.Text + timePicked.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                MainWindow dashboard = new MainWindow();
                dashboard.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
