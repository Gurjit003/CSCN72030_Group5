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
        

        Grill grill;
        Fryer fryer;
        public Kitchen()
        {
            grill = new Grill();
            fryer = new Fryer();
        }
        bool reciveOrder(Order[] order)
        {
            //array {Hamburger, Chicken, Fries, Salad, Pop, Water}
            int[] parsedArray = { 0, 0, 0, 0, 0, 0 };
            int numberOfMeals = order.Length;
            for (int i = 0; i < numberOfMeals; i++)
            {
                //Disect the order to tally up chicken burgers and beef burgerss
                if (order[i].main == "Hamburger")
                {
                    parsedArray[0] += parsedArray[0];
                }
                else
                {
                    parsedArray[1] += parsedArray[1];
                }
                if (order[i].side == "Salad")
                {
                    parsedArray[2] += parsedArray[2];
                }
                else
                {
                    parsedArray[3] += parsedArray[3];
                }
                if (order[i].drink == "Pop")
                {
                    parsedArray[4] += parsedArray[4];
                }
                else
                {
                    parsedArray[5] += parsedArray[5];
                }
            }



            //if enough inventory
            //int[] currentStock = getAllItemStock(inventory.itemArrray);


            //{
            fryer.CookFood(parsedArray[1]);
            grill.CookFood(parsedArray[0]);
            //}

            //Deduct inventory

            fryer.setCookingSpace(0);
            grill.setCookingSpace(0);
            return true;
        }

    }



}
