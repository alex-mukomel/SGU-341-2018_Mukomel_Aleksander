using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_3_1
{
    public class Train : Ground
    {
        public Train(double speed, double carrying, string mark, 
            int numberOfStaff, int numberOfPassengers) 
            : base(speed, carrying, mark, numberOfStaff, numberOfPassengers) { }

        public override string Delivery()
        {
            return base.Delivery() + " - на поезде";
        }
    }
}
