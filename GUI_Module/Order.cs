using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GUI_Module;

namespace GUI_Module
{
    internal class Order
    {
        public static int hambuger = 0;
        public static int chickenBurger = 0;
        public static int fries = 0;
        public static int salad = 0;
        public static int water = 0;
        public static int pop = 0;

        string main = "Nothing";
        string side = "Nothing";
        string drink = "Nothing";
        //-----------------------------------------------------------------------------------------------------------------

        //paramiatized constructor 
        public Order(string main, string side, string drink)
        {
            this.main = main;
            this.side = side;
            this.drink = drink;
        }

        //this will get the number of orders from the frontOfHouseModule
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

            setNumOfMaking(order, numOrders);
            sendWhatHasbeenMade();

            bool isReady = sendKitchenOrder(order);
            sendBOHOrder(order, numOrders);
            tellDishesOfOrder(numOrders);

            deduceNumOfMaking(order, numOrders);
            sendWhatHasbeenMade();

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

        //this will send the kitchen module the order
        static private bool sendKitchenOrder(Order[] order)
        {
            bool orderRecievedAndMade = true;

           //orderRecievedAndMade = Kitchen.recieveOrder(order);  //this will send the orders to the kitchen class and will return a boolean when the order is ready 

           return orderRecievedAndMade; 
        }
        //-----------------------------------------------------------------------------------------------------------------

       //this will send the back or house the order
       static private void sendBOHOrder(Order[] order, int numOfOrder)
        {
            for(int i = 0; i < numOfOrder; i++)
            {
                //BackOfHouse.getGrossRevenue(order[i]); //this will call the gross revenue function  
            }
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will send to the GUI ehat has been made
        public static void sendWhatHasbeenMade()
        {
            //KitchenControl k = new KitchenControl;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will let the dishes module the amount of orders made
        private static void tellDishesOfOrder(int numOfOrder)
        {
            dishes.recieveNumOfDishes(numOfOrder);
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this funtction set the global varibale (increasing)
        private static void setNumOfMaking(Order[] order, int numOrders)
        {
            string ham = "Hamburger";
            string chic = "chicken burger";
            string fri = "Fries";
            string sal = "Salad";
            string wat = "Water";
            string POP = "Pop";

            for (int i = 0; i < numOrders; i++)
            {
                if (order[i].main == ham)
                {
                    hambuger++;
                }

                if(order[i].main == chic)
                {
                    chickenBurger++;
                }

                if (order[i].side == fri)
                {
                    fries++;
                }

                if (order[i].side == sal)
                {
                    salad++;
                }

                if (order[i].drink == wat)
                {
                    water++;
                }

                if (order[i].drink == POP)
                {
                    pop++;
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this function will send the global varibale (reducing)
        private static void deduceNumOfMaking(Order[] order, int numOrders)
        {
            string ham = "Hamburger";
            string chic = "chicken burger";
            string fri = "Fries";
            string sal = "Salad";
            string wat = "Water";
            string POP = "Pop";

            for (int i = 0; i < numOrders; i++)
            {
                if (order[i].main == ham)
                {
                    hambuger--;
                }

                if (order[i].main == chic)
                {
                    chickenBurger--;
                }

                if (order[i].side == fri)
                {
                    fries++;
                }

                if (order[i].side == sal)
                {
                    salad--;
                }

                if (order[i].drink == wat)
                {
                    water--;
                }

                if (order[i].drink == POP)
                {
                    pop--;
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------------
    }
}
