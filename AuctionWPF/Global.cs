using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionWPF
{
    public static class Global
    {
        public static string usernameProp;
        public static string idprop;
        public static string highestBid;

        public static void Globals()
        {
            userProp = usernameProp;
            idProp = idprop;
            highestValue = highestBid;
        }

        public static string userProp
        {
            get
            {
                return (usernameProp);
            }
            set
            {
                usernameProp = value;
            }
        }

        public static string highestValue
        {
            get
            {
                return (highestBid);
            }
            set
            {
                highestBid = value;
            }
        }

        public static string idProp
        {
            get
            {
                return (idprop);
            }
            set
            {
                idprop = value;
            }
        }
    }
}
