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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.firstName = txtFirstName.Text;
            u.lastName = txtLastName.Text;
            u.Email = txtEmail.Text;
            u.userName = txtUserName.Text;
            u.userPassword = txtPassword.Text;
            u.balance = decimal.Parse(txtBalance.Text);
            var user = new AuctionDBContext();
            user.Users.Add(u);
            user.SaveChanges();
            MessageBox.Show("Successfully added");
            this.Close();
            //u.saveUser();
        }
    }
}
