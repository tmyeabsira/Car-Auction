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
            lblBalance.Text = "Your current Balance is " + user.balance.ToString();
            refreshData();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCar newCar = new NewCar(lblUserName.Text);
            newCar.Show();
            
        }
        public void refreshData()
        {
            BindingSource bi = new BindingSource();
            User user = context.Users.Single(a => a.userName == lblUserName.Text);
            lblBalance.Text = "Your current Balance is " + user.balance.ToString();

            var query = from c in context.Cars
                        select new { c.carId, c.carName, c.carModel, c.noOfSeats, c.startBid, c.carOwner };
            bi.DataSource = query.ToList();
            dataGridView1.DataSource=bi;
            dataGridView1.Refresh();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.carModel = int.Parse(txtSearch.Text);
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
            Car c = context.Cars.Single(b => b.carId == a);
            if(c.carOwner != lblUserName.Text)
            {
                User u = new User();
                u.userName = lblUserName.Text;

                NewBid bid = new NewBid(u, c);
                bid.Show();
            }
            else
            {
                MessageBox.Show("You can't bid on your own car!");
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
    }
}
