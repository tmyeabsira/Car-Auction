using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Car_Auction
{
    public class Bid
    {
        public int BidId { get; set; }
        public string OwnerName { get; set; }
        public string BidderName { get; set; }
        public int carId { get; set; }
        [Column(TypeName = "money")]
        public decimal BidAmount { get; set; }
        public DateTime BidTime { get; set; }

    }
}
