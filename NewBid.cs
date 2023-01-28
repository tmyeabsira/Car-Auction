using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            lblId.Text = c.carId.ToString();
            lblName.Text = c.carName;
            lblModel.Text = c.carModel.ToString();
            lblSeat.Text = c.noOfSeats.ToString();
            lblOwner.Text = c.carOwner;
            lblBid.Text = c.startBid.ToString("c");
            lblUser.Text = u.userName;
            carPic.BackgroundImage = Image.FromStream(new MemoryStream(c.photo));
            User user = context.Users.Single(a=>a.userName==lblUser.Text);
            lblBalance.Text = user.balance.ToString("c");
        }

        private void btnAddBid_Click(object sender, EventArgs e)
        {
            User u = context.Users.Single(a => a.userName.Equals(lblUser.Text));
            if (decimal.Parse(txtYourBid.Text) > u.balance)
            {
                MessageBox.Show("Your Balance is insufficent");
            }
            else if (decimal.Parse(txtYourBid.Text) > decimal.Parse(lblBid.Text,NumberStyles.AllowCurrencySymbol | NumberStyles.Currency))
            {
                int i = int.Parse(lblId.Text);
                if(context.Bids.Any(a=>a.carId == i))
                {
                    MessageBox.Show("in here");
                    Bid d = context.Bids.First(a => a.carId == i);
                    d.BidderName = lblUser.Text;
                    d.BidAmount = decimal.Parse(txtYourBid.Text);
                    d.BidTime = DateTime.Now;
                    Car g = context.Cars.Find(i);
                    g.startBid = decimal.Parse(txtYourBid.Text);

                    context.SaveChanges();
                    MessageBox.Show("Your Bid Has been added");
                    this.Close();
                }
                else
                {
                    Bid b = new Bid();
                    b.OwnerName = lblUser.Text;
                    b.BidderName = lblUser.Text;
                    b.OwnerName = lblOwner.Text;
                    b.carId = int.Parse(lblId.Text);
                    b.BidAmount = decimal.Parse(txtYourBid.Text);
                    b.BidTime = DateTime.Now;

                    var bid = new AuctionDBContext();
                    Car g = context.Cars.Find(i);
                    g.startBid = decimal.Parse(txtYourBid.Text);

                    context.Bids.Add(b);
                    context.SaveChanges();
                    this.Close();

                    MessageBox.Show("Your Bid Has been added");
                }
            }
            
            else
            {
                MessageBox.Show("Your Bid was smaller that the current bid");
            }
        }
    }
}
