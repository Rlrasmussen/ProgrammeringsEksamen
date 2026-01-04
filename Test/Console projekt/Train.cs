using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_projekt
{
    public class Train
    {
        private List<int> prices = new List<int>();

        public List<int> Prices { get => prices; set => prices = value; }

        public int Ticketprice(int age)
        {
            if (age < 2)
            {
                Prices.Add(0);
                return 0;
            }
            else if (age < 15)
            {
                Prices.Add(10);
                return 10;
            }
            else if (age < 65)
            {
                Prices.Add(20);
                return 20;
            }
            else
            {
                Prices.Add(5);
                return 5;
            }
        }
    }
}
