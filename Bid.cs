using System;
using System.Collections.Generic;
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
        public string Bidder { get; set; }
        public string Car { get; set;}
        public float BidAmount { get; set; }
        public DateTime BidTime { get; set; }

    }
}
