using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Bus
{
    class Bus
    {
      
        public static int count=0;

        public static string[,] buses = new string[100,100];

        public Bus(string name, string secondName, string brand, string year, string numberOfBus, int numberOfRoute, int millage)
        {
            buses[count, 0] = name;
            buses[count, 1] = secondName;
            buses[count, 2] = brand;
            buses[count, 3] = year;
            buses[count, 4] = numberOfBus;
            buses[count, 5] = numberOfRoute.ToString();
            buses[count, 6] = millage.ToString();
            count++;
        }
    }
}
