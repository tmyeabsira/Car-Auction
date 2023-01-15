using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Auction
{
    public partial class AllBids : Form
    {
        AuctionDBContext context = new AuctionDBContext();
        public AllBids(User u)
        {
            InitializeComponent();
            lblUser.Text = u.userName;
            referesh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.userName = lblUser.Text;

            int a = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Car c = context.Cars.Single(b => b.carId == 1); 

            NewBid bid = new NewBid(u, c);
            bid.Show();
        }
        private void referesh()
        {
            dataGridView1.DataSource = context.Bids.ToList();
            dataGridView1.Refresh();
        }

        private void btnReferesh_Click(object sender, EventArgs e)
        {
            referesh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int c = context.Bids.Count()+7;
            Console.WriteLine(c);
            //for(int i = 7; i < c; i++)
            //{
                Bid b = context.Bids.Single(a => a.BidId == 17);
                if (Convert.ToInt32(DateTime.Now.Subtract(b.BidTime).TotalMinutes) >= 3)
                {
                    timer.Stop();
                    MessageBox.Show(b.Car + "has been sold for " + b.Bidder + " for " + b.BidAmount + "Birr! Congratulations " + b.Bidder);
                    Car car = context.Cars.Single(a => a.carOwner == b.OwnerName && a.carName == b.Car);
                    User owner = context.Users.Single(a => a.userName == b.OwnerName);
                    User bidder = context.Users.Single(a => a.userName == b.Bidder);
                    owner.balance += b.BidAmount;
                    bidder.balance -= b.BidAmount;
                    context.Bids.Remove(b);
                    context.Cars.Remove(car);
                    context.SaveChanges();
                    
                //}
            }
        }
    }
}
