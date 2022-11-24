using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    public class Order
    {
        public string main;
        public string side;
        public string drink;

        public Order()
        {
            main = "Hamburger";
            side = "Frys";
            drink = "Water";
        }
        public string getMain() { return this.main; }
    }


    public class Kitchen
    {
        int[] parsedArray = {0,0};

        Grill grill = new Grill();
        Fryer fryer = new Fryer();
        bool reciveOrder(Order[] order)
        {
            int numberOfMeals = order.Length;
            for(int i = 0; i < numberOfMeals; i++)
            {
                if (order[i].main == "Hamburger" )
                {
                    parsedArray[0] += parsedArray[0]; 
                }
                else
                {
                    parsedArray[1] += parsedArray[1];
                }
            }
            fryer.cookFood(parsedArray[1]);
            grill.cookFood(parsedArray[0]);
            return true;
        }

    }



}
