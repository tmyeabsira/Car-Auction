using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Auction
{
    public partial class NewCar : Form
    {
        AuctionDBContext context = new AuctionDBContext();
        public NewCar(string u)
        {
            InitializeComponent();
            lblUserName.Text = u;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.carName = txtName.Text;
            c.carModel = int.Parse(txtModel.Text);
            c.noOfSeats = int.Parse(txtNoOfSeats.Text);
            c.startBid = decimal.Parse(txtStartBid.Text);
            c.carOwner = lblUserName.Text;

            MemoryStream ms = new MemoryStream();
            carPic.BackgroundImage.Save(ms, carPic.BackgroundImage.RawFormat);

            c.photo = ms.ToArray();

            context.Cars.Add(c);
            context.SaveChanges();
            MessageBox.Show("Your car has been added!");
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose Photo(*.jpg; *.png; *.jpeg;*.bmp;) | *.jpg; *.png; *.jpeg;*.bmp; ";
            if (op.ShowDialog() == DialogResult.OK)
            {
                carPic.BackgroundImage = Image.FromFile(op.FileName);
            }
        }
    }
}
