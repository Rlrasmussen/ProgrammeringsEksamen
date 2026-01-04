using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_projekt
{
    public class Calculater
    {
        public List<int> Results { get; set; } = new List<int>();

        public int Adding(int first, int second)
        {
            Results.Add(first + second);
            return first + second;
        }
    }
}
