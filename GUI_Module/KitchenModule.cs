using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI_Module;

namespace GUI_Module
{
    public class Kitchen
    {
        

        Grill grill;
        Fryer fryer;
        public Kitchen()
        {
            grill = new Grill();
            fryer = new Fryer();
        }
        public bool reciveOrder(Order[] order)
        {
            //array {Hamburger, Chicken, Fries, Salad, Pop, Water}
            int[] brokenDownOrder = { 0, 0, 0, 0, 0, 0 };
            int numberOfMeals = order.Length;
            for (int i = 0; i < numberOfMeals; i++)
            {
                //Disect the order to tally up chicken burgers and beef burgerss
                if (order[i].getMain() == "Hamburger")
                {
                    brokenDownOrder[0] += brokenDownOrder[0];
                }
                else
                {
                    brokenDownOrder[1] += brokenDownOrder[1];
                }
                if (order[i].side == "Salad")
                {
                    brokenDownOrder[2] += brokenDownOrder[2];
                }
                else
                {
                    brokenDownOrder[3] += brokenDownOrder[3];
                }
                if (order[i].drink == "Pop")
                {
                    brokenDownOrder[4] += brokenDownOrder[4];
                }
                else
                {
                    brokenDownOrder[5] += brokenDownOrder[5];
                }
            }



            //if enough inventory
            //int[] currentStock = getAllItemStock(inventory.itemArrray);
            //for(int i = 0; i < currentStock.Length; i++)
            //{
                    //if(currentStock[i] < parsedArray[i]
                        //Flag GUI for not enough stock
            //{
            fryer.CookFood(brokenDownOrder[1]);
            grill.CookFood(brokenDownOrder[0]);
            //}

            //Deduct inventory
            //inventory.removeItemFromStock(brokenDownOrder);

            fryer.setCookingSpace(4);
            grill.setCookingSpace(4);
            return true;
        }

    }



}
