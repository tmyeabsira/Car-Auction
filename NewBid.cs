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
    public partial class NewBid : Form
    {
        AuctionDBContext context = new AuctionDBContext();
        public NewBid(User u, Car c)
        {
            InitializeComponent();
            lblName.Text = c.carName;
            lblModel.Text = c.carModel.ToString();
            lblSeat.Text = c.noOfSeats.ToString();
            lblOwner.Text = c.carOwner;
            lblBid.Text = c.startBid.ToString();
            lblUser.Text = u.userName;
            User user = context.Users.Single(a=>a.userName==lblUser.Text);
            lblBalance.Text = "Your current Balance is "+user.balance.ToString();
        }

        private void btnAddBid_Click(object sender, EventArgs e)
        {
            if(float.Parse(txtYourBid.Text) > float.Parse(lblBid.Text))
            {
                Bid b = new Bid();
                b.OwnerName = lblUser.Text;
                b.Bidder = lblUser.Text;
                b.OwnerName = lblOwner.Text;
                b.Car = lblName.Text;
                b.BidAmount = float.Parse(txtYourBid.Text);
                b.BidTime = DateTime.Now;

                var bid = new AuctionDBContext();
                bid.Bids.Add(b);
                bid.SaveChanges();
                this.Close();

                MessageBox.Show("Your Bid Has been added");
            }
            else if(float.Parse(txtYourBid.Text) > float.Parse(lblBalance.Text))
            {
                MessageBox.Show("Your Balance is insufficent");
            }
            else
            {
                MessageBox.Show("Your Bid was smaller that the current bid");
            }
            

        }
    }
}
