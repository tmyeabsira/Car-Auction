using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Auction
{
    public partial class Cars : Form
    {
        AuctionDBContext context = new AuctionDBContext();
        public Cars(User u)
        {
            InitializeComponent();
            lblUserName.Text = u.userName;
            User user = context.Users.Single(a => a.userName == lblUserName.Text);
            lblBalance.Text = user.balance.ToString("c");
            refreshData();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCar newCar = new NewCar(lblUserName.Text);
            newCar.Show();
            
        }
        public void refreshData()
        {
            User user = context.Users.Single(a => a.userName == lblUserName.Text);
            lblBalance.Text = user.balance.ToString("c");

            var query = from c in context.Cars
                        select new { c.carId, c.carName, c.carModel, c.noOfSeats, c.startBid, c.carOwner};
            dataGridView1.DataSource= query.ToList();
            dataGridView1.Refresh();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.carName = txtSearch.Text;
            var query = from g in context.Cars
                        where g.carName == txtSearch.Text
                        select new { g.carId, g.carName, g.carModel, g.noOfSeats, g.carOwner };
            dataGridView1.DataSource = query.ToList();
            dataGridView1.Refresh();
            //dataGridView1.DataSource = c.SearchCar();

        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            int a = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string f = (string)dataGridView1.CurrentRow.Cells[5].Value;
            Car c = context.Cars.Single(b => b.carId == a);
            {
                User u = context.Users.Single(d=>d.userName.Equals(lblUserName.Text));
                if (!f.Equals(lblUserName.Text))
                {

                    NewBid bid = new NewBid(u, c);
                    bid.Show();
                }
                else
                {
                    MessageBox.Show("You can't bid on your own car!");
                }
            }
            
        }

        private void btnCurrentBids_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.userName = lblUserName.Text;
            AllBids a = new AllBids(u);
            a.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnYourCars_Click(object sender, EventArgs e)
        {
            User u = context.Users.Single(a => a.userName.Equals(lblUserName.Text));
            YourCars y = new YourCars(u);
            y.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                int c = context.Bids.Count() + 7;
                Console.WriteLine(c);
                List<Bid> bid = context.Bids.ToList();
                foreach (Bid b in bid)
                {
                    if (b != null)
                    {
                        if (Convert.ToInt32(DateTime.Now.Subtract(b.BidTime).TotalMinutes) >= 2)
                        {
                            timer.Stop();
                            MessageBox.Show(context.Cars.Single(a => a.carId == b.carId).carName + "has been sold for " + b.BidderName + " for " + b.BidAmount + "Birr! Congratulations " + b.BidderName);
                            Car car = context.Cars.Single(a => a.carId == b.carId);
                            User owner = context.Users.Single(a => a.userName.Equals(b.BidderName));
                            User bidder = context.Users.Single(a => a.userName.Equals(b.BidderName));
                            owner.balance = owner.balance + b.BidAmount;
                            bidder.balance = bidder.balance - b.BidAmount;
                            context.Bids.Remove(b);
                            context.Cars.Remove(car);
                            context.SaveChanges();
                        }
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
