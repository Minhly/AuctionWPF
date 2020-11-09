using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace AuctionWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowAuctionList();
        }


        public void ShowAuctionList()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=MININT-3GF1PEB; Initial Catalog=SDE; Integrated Security= True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                //String Query = "SELECT * FROM Auction_items INNER JOIN Auction_bids ON Auction_items.id = Auction_bids.item_id ORDER BY Auction_bids.bid_price ASC";
                String Query = "SELECT * FROM Auction_items";
                SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable("auction");
                da.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
                TitleTxt.Content = "Welcome " + Global.userProp;
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

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                highBidderName.Content = row_selected["winner_name"].ToString();
                Global.highestValue = row_selected["highest_bid"].ToString();
                Global.idProp = row_selected["id"].ToString();
                itmName.Content = row_selected["item_name"].ToString();
                description.Text = row_selected["description"].ToString();
                price.Content = row_selected["price"].ToString();
                highBid.Content = row_selected["highest_bid"].ToString();
            }
        }

        private void Bid_Button(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=MININT-3GF1PEB; Initial Catalog=SDE; Integrated Security= True;");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                int bidText = Convert.ToInt32(bidTxt.Text);
                int highVal = Convert.ToInt32(Global.highestValue);
                if (bidText >= highVal)
                {
                String Query = "INSERT INTO Auction_bids (user_id, item_id, bid_price) Values (@bidID, @itemID, @bidtxt);";
                SqlCommand sqlCmd = new SqlCommand(Query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@bidID", Global.userProp);
                sqlCmd.Parameters.AddWithValue("@itemID", Global.idProp);
                sqlCmd.Parameters.AddWithValue("@bidtxt", bidTxt.Text);
                int count2 = Convert.ToInt32(sqlCmd.ExecuteScalar());

                String Query2 = "UPDATE Auction_items SET highest_bid = @highBid, winner_name = @winnerName WHERE id = @itemIDs;";
                SqlCommand sqlCmd2 = new SqlCommand(Query2, sqlCon);
                sqlCmd2.CommandType = CommandType.Text;
                sqlCmd2.Parameters.AddWithValue("@highBid", bidText);
                sqlCmd2.Parameters.AddWithValue("@winnerName", Global.userProp);
                sqlCmd2.Parameters.AddWithValue("@itemIDs", Global.idProp);
                int count1 = Convert.ToInt32(sqlCmd2.ExecuteScalar());
                }
                else
                {
                    MessageBox.Show("Your bid was lower please try again.");
                }
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
