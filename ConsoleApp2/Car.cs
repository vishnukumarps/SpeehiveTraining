using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        public int a; 
       
        private int price;

        public void setPrice(int x)
        {
            price = x;
        }

        public int getPrice()
        {
            return price;
        }


        public int TopSpeed { get; set; }

        public string RegNo { get; set; }






    }
}
