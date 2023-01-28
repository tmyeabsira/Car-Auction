using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Auction
{
    public partial class Update : Form
    {
        AuctionDBContext context = new AuctionDBContext();
        public Update(Car c)
        {
            InitializeComponent();
            lblId.Text = c.carId.ToString();
            lblName.Text = c.carName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Car c = context.Cars.Single(a => a.carId == int.Parse(lblId.Text));
            var c = context.Cars.Where(a => a.carId == 12).FirstOrDefault();
            c.carModel = int.Parse(txtModel.Text);
            c.noOfSeats = int.Parse(txtNumberOfSeats.Text);
            c.startBid = decimal.Parse(txtStartBid.Text);
            context.SaveChanges();
        }
    }
}
