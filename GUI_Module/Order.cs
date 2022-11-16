using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Module
{
    internal class Order
    {
        string main = "Nothing";
        string side = "Nothing";
        string drink = "Nothing";

        public Order(string main, string side, string drink)
        {
            this.main = main;
            this.side = side;
            this.drink = drink;
        }

        static public bool getNumOfOrder(int numOrders)
        {
            bool ready = true;
            Order[] order = new Order[numOrders];

            for (int i = 0; i < numOrders; i++)
            {
                Order newOrder = new Order("Nothing", "Nothing", "Nothing");
                order[i] = newOrder;
            }

            getMain(order, numOrders);
            getSide(order, numOrders);
            getDrink(order, numOrders);

            return ready;
        }
        //-----------------------------------------------------------------------------------------------------------------
        //getting and setting the main
        static private void getMain(Order[] order, int numOforder)
        {
            int counter = 0;
            string[] gottenMain = new string[numOforder];

            for (int i = 0; i < numOforder; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 2);

                foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\daveo_xxpkcgs\\OneDrive\\Desktop\\College\\year 2 (fall semseter)\\Software develpment\\Group project\\Group Code\\GUI_Module\\main.txt"))
                {
                    if ((counter + 1) == random)
                    {
                        gottenMain[i] = line;
                    }
                    counter++;
                }

                counter = 0;
            }


            setMain(gottenMain, order, numOforder);
        }

        static private void setMain(string[] Main, Order[] order, int numOfOrder)
        {
            for (int i = 0; i < numOfOrder; i++)
            {
                order[i].main = Main[i];
            }
        }
        //-----------------------------------------------------------------------------------------------------------------

        //getting and setting the side
        static private void getSide(Order[] order, int numOfOrder)
        {
            int counter = 0;
            string[] gottenSide = new string[numOfOrder];

            for (int i = 0; i < numOfOrder; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 2);

                foreach (string line in System.IO.File.ReadLines(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\Group Code\GUI_Module\side.txt"))
                {
                    if ((counter + 1) == random)
                    {
                        gottenSide[i] = line;
                    }
                    counter++;
                }

                counter = 0;
            }


            setSide(gottenSide, order, numOfOrder);
        }

        static private void setSide(string[] Side, Order[] order, int numOfOrder)
        {
            for (int i = 0; i < numOfOrder; i++)
            {
                order[i].side = Side[i];
            }
        }
        //-----------------------------------------------------------------------------------------------------------------

        //getting and setting the drink
        static private void getDrink(Order[] order, int numOfOrder)
        {
            int counter = 0;
            string[] gottenDrink = new string[numOfOrder];

            for (int i = 0; i < numOfOrder; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 2);

                foreach (string line in System.IO.File.ReadLines(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\Group Code\GUI_Module\drink.txt"))
                {
                    if ((counter + 1) == random)
                    {
                        gottenDrink[i] = line;
                    }
                    counter++;
                }

                counter = 0;
            }


            setDrink(gottenDrink, order, numOfOrder);
        }

        static private void setDrink(string[] Drink, Order[] order, int numOfOrder)
        {
            for (int i = 0; i < numOfOrder; i++)
            {
                order[i].drink = Drink[i];
            }
        }
        //-----------------------------------------------------------------------------------------------------------------
    }
}
