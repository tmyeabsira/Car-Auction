using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Auction
{
    internal class DBService
    {
        string constr = "server=.;database=CarAuction2;integrated security = true";
        SqlConnection con;
        public void login(User u)
        {
            try
            {
                using (con = new SqlConnection(constr))
                {
                    con.Open(); 
                    SqlDataAdapter da = new SqlDataAdapter("select * from [Users] where userName='"+u.userName+"' and userPassword = '"+u.userPassword+"'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count == 1)
                    {

                        Cars cars = new Cars(u);
                        cars.Show();
                    }
                    else
                    {

                        MessageBox.Show("Invalid user name or password");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void saveUser(User u)
        {
            try
            {
                using (con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("spInsertUser", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@fname",u.firstName);
                    com.Parameters.AddWithValue("@lname",u.lastName);
                    com.Parameters.AddWithValue("@email",u.Email);
                    com.Parameters.AddWithValue("@uname", u.userName);
                    com.Parameters.AddWithValue("@password", u.userPassword);
                    com.Parameters.AddWithValue("@balance", u.balance);

                    int rows = com.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Creation Successful");
                    }
                    else
                    {
                        MessageBox.Show("User not created");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable getAllCars()
        {
            
            using (con = new SqlConnection(constr))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("spGetAllCars", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0];
            }
        }


        public void saveCar(Car c)
        {
            try
            {
                using (con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("spInsertCar", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@name", c.carName);
                    com.Parameters.AddWithValue("@model", c.carModel);
                    com.Parameters.AddWithValue("@noOfSeats", c.noOfSeats);
                    com.Parameters.AddWithValue("@startBid", c.startBid);
                    com.Parameters.AddWithValue("@carOwner", c.startBid);

                    int rows = com.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Car registered for bid");
                    }
                    else
                    {
                        MessageBox.Show("something went wrong");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable SearchCar(Car c)
        {
                using (con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("select * from [Car] where carName='" + c.carName + "' or carModel = '" + c.carModel + "'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
        }
    }
}
