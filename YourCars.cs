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
    public partial class YourCars : Form
    {
        AuctionDBContext context = new AuctionDBContext();
        public YourCars(User u)
        {
            InitializeComponent();
            var query = from g in context.Cars
                        where g.carOwner.Equals(u.userName)
                        select g;
            dgvYourCars.DataSource = query.ToList();
        }

        private void dgvYourCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int a = (int)dgvYourCars.CurrentRow.Cells[0].Value;
            Car c = context.Cars.Single(b => b.carId == a);

            Update u = new Update(c);
            u.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int a = (int)dgvYourCars.CurrentRow.Cells[0].Value;
            Car c = context.Cars.Single(b => b.carId == a);
            context.Cars.Remove(c);
            context.SaveChanges();
        }
    }
}
