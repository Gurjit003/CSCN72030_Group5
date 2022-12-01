using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    public class Order
    {
        //initilized the atrributes of an order
        public string main = "Nothing";
        public string side = "Nothing";
        public string drink = "Nothing";
        //-----------------------------------------------------------------------------------------------------------------

        //this is a function that other module can call to get the main of an order object
        public string getMain()
        {
            return this.main;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will set the main
        public void setMain(string main)
        {
            this.main = main;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //paramiatized constructor 
        public Order(string main, string side, string drink)
        {
            this.main = main;
            this.side = side;
            this.drink = drink;
        }
        //-----------------------------------------------------------------------------------------------------------------

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

            bool isReady = sendKitchenOrder(order);
            sendBOHOrder(order, numOrders);
            tellDishesOfOrder(numOrders);

            deduceNumOfMaking(order, numOrders);
        

            return ready;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //getting and setting the main
        static private void getMain(Order[] order, int numOforder)
        {
            string[] gottenMain = new string[numOforder];

            for (int i = 0; i < numOforder; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 3);

                if (random == 1)
                {
                    gottenMain[i] = "Hamburger";
                }

                if (random == 2)
                {
                    gottenMain[i] = "chicken burger";
                }
            }


            setMain(gottenMain, order, numOforder);
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will set the main of the order object 
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
            string[] gottenSide = new string[numOfOrder];

            for (int i = 0; i < numOfOrder; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 3);

                if(random == 1)
                {
                    gottenSide[i] = "Fries";
                }
                if (random == 2)
                {
                    gottenSide[i] = "Salad";
                }
            }


            setSide(gottenSide, order, numOfOrder);
        }

        //this will set the side of the order object
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
            string[] gottenDrink = new string[numOfOrder];

            for (int i = 0; i < numOfOrder; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 3);

                if(random == 1)
                {
                    gottenDrink[i] = "Pop";
                }
                if (random == 2)
                {
                    gottenDrink[i] = "Water";
                }
            }


            setDrink(gottenDrink, order, numOfOrder);
        }

        //this will set the drink of the order object
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
            Kitchen k = new Kitchen();

            orderRecievedAndMade = k.reciveOrder(order);  //this will send the orders to the kitchen class and will return a boolean when the order is ready 

            return orderRecievedAndMade;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will send the back or house the order
        static private void sendBOHOrder(Order[] order, int numOfOrder)
        {
            for (int i = 0; i < numOfOrder; i++)
            {
                BackOfHouse.setGrossRevenue(order[i]); //this will call the gross revenue function  
            }
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
            int[] product = getProductNum();

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
                    product[0]++;
                }

                if (order[i].main == chic)
                {
                    product[1]++;
                }

                if (order[i].side == fri)
                {
                    product[2]++;
                }

                if (order[i].side == sal)
                {
                    product[3]++;
                }

                if (order[i].drink == POP)
                {
                    product[4]++;
                }

                if (order[i].drink == wat)
                {
                    product[5]++;
                }
            }

            setProductNum(product);
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this function will send the global varibale (reducing)
        private static void deduceNumOfMaking(Order[] order, int numOrders)
        {
            int[] product = getProductNum();

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
                    product[0]--;
                }

                if (order[i].main == chic)
                {
                    product[1]--;
                }

                if (order[i].side == fri)
                {
                    product[2]--;
                }

                if (order[i].side == sal)
                {
                    product[3]--;
                }

                if (order[i].drink == POP)
                {
                    product[4]--;
                }

                if (order[i].drink == wat)
                {
                    product[5]--;
                }
            }

            setProductNum(product);
        }

        //this will get the number of the products been made from the text file
        public static int[] getProductNum()
        {
            string[] productString = {"0", "0", "0", "0", "0", "0"};
            int[] product = { 0, 0, 0, 0, 0, 0 };
            int current = 0;

            string productFileName = "ProductNumber.txt";

            if (File.Exists(productFileName))
            {
                foreach (string line in System.IO.File.ReadLines(productFileName))
                {
                    if (current == 0)
                    {
                        productString[0] = line;
                    }

                    if (current == 1)
                    {
                        productString[1] = line;
                    }

                    if (current == 2)
                    {
                        productString[2] = line;
                    }

                    if (current == 3)
                    {
                        productString[3] = line;
                    }

                    if (current == 4)
                    {
                        productString[4] = line;
                    }

                    if (current == 5)
                    {
                        productString[5] = line;
                    }

                    current++;
                }
            }
            else
            {
                // Create empty data file
                string[] emptyDataFile = { "0", "0", "0", "0", "0", "0" };

                File.WriteAllLines(productFileName, emptyDataFile);
            }

            Int32.TryParse(productString[0], out product[0]);
            Int32.TryParse(productString[1], out product[1]);
            Int32.TryParse(productString[2], out product[2]);
            Int32.TryParse(productString[3], out product[3]);
            Int32.TryParse(productString[4], out product[4]);
            Int32.TryParse(productString[5], out product[5]);

            return product;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will set the number of products been made in the text file
        public static void setProductNum(int[] product)
        {
            string ham = product[0].ToString();
            string chic = product[1].ToString();
            string fri = product[2].ToString();
            string sal = product[3].ToString();
            string POP = product[4].ToString();
            string wat = product[5].ToString();

            string productFilePath = "ProductNumber.txt";

            if (File.Exists(productFilePath))
            {
                string[] fileLines = File.ReadAllLines(productFilePath);

                fileLines[0] = ham;
                fileLines[1] = chic;
                fileLines[2] = fri;
                fileLines[3] = sal;
                fileLines[4] = POP;
                fileLines[5] = wat;

                File.WriteAllLines(productFilePath, fileLines);

            }
            else
            {
                string[] emptyFile = { "0", "0", "0", "0", "0", "0" };

                File.WriteAllLines(productFilePath, emptyFile);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will return the number of hamburgers been made 
        public static int sendHam()
        {
            int[] product = getProductNum();
            int hamburger = product[0];

            return hamburger;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will return the number of chichken burger been made
        public static int sendChic()
        {
            int[] product = getProductNum();
            int ChickenBurger = product[1];

            return ChickenBurger;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will return the number of fries been made
        public static int sendFri()
        {
            int[] product = getProductNum();
            int Fries = product[2];

            return Fries;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will return the number of salads been made
        public static int sendSal()
        {
            int[] product = getProductNum();
            int Salad = product[3];

            return Salad;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will return the number of Pop been made
        public static int sendPop()
        {
            int[] product = getProductNum();
            int Pop = product[4];

            return Pop;
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this will return the number of water been made
        public static int sendWat()
        {
            int[] product = getProductNum();
            int Water = product[5];

            return Water;
        }
        //-----------------------------------------------------------------------------------------------------------------
    }
}
