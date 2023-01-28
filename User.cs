using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Auction
{
    public class User
    {
        [Key]
        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string userPassword { get; set; }
        [Column(TypeName = "money")]
        public decimal balance { get; set; }
        

        public void login()
        {
            DBService dbs = new DBService();
            dbs.login(this);
        }
        public void saveUser()
        {
            DBService dbs = new DBService();
            dbs.saveUser(this);
        }
    }
}
