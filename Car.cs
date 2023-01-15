using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Auction
{
    public class Car
    {
        public int carId { get; set; }
        public string carName { get; set; }
        public int carModel { get; set; }
        public int noOfSeats { get; set; }
        public float startBid { get; set; }
        public string carOwner { get; set; }

        public void saveCar()
        {
            DBService dbs = new DBService();
            dbs.saveCar(this);
        }
        public DataTable getAllCars()
        {
            DBService dbs = new DBService();
            return dbs.getAllCars();
        }
        public DataTable SearchCar()
        {
            DBService dbs = new DBService();
            return dbs.SearchCar(this);
        }
    }
}
