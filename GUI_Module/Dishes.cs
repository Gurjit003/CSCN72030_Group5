using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    //this will be the new number of dishers from the file
    internal class Dishes
    {
        int clean = 20;
        int dirty = 0;
        int beenUsed = 0;

        public static Dishes allDishes = new Dishes();

        private static void getDishes()
        {
            int counter = 0;
            string[] gottenNumber = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 2);

                foreach (string line in System.IO.File.ReadLines(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\Group Code\GUI_Module\Dishes.txt"))
                {
                    if ((counter + 1) == random)
                    {
                        gottenNumber[i] = line;
                    }
                    counter++;
                }

                counter = 0;
            }

            int newClean;
            int newDirty;
            int newBeenUsed;

            Int32.TryParse(gottenNumber[0], out newClean);
            Int32.TryParse(gottenNumber[1], out newDirty);
            Int32.TryParse(gottenNumber[2], out newBeenUsed);

            allDishes.clean = newClean;
            allDishes.dirty = newDirty;
            allDishes.beenUsed = newBeenUsed;
        }

        private static void reWriteDishes()
        {
            string cleanString = allDishes.clean.ToString();
            string dirtyString = allDishes.dirty.ToString();
            string beenUsedString = allDishes.beenUsed.ToString();
            using (StreamWriter writer = new StreamWriter(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\Group Code\GUI_Module\Dishes.txt"))
            {
                writer.WriteLine(cleanString);
                writer.WriteLine(dirtyString);
                writer.WriteLine(beenUsedString);
            }
        }

        //this will recieve the numer of dishes needed for an order
        public static void recieveNumOfDishes(int numOfDishes)
        {
            getDishes();
            sendCurrentDishesNum();

            bool isOkToContinue = checkNumOfDishes();
            bool ifNotEnough = true;

            if(isOkToContinue = true)
            {
                allDishes.clean = allDishes.clean - numOfDishes;
                allDishes.beenUsed = allDishes.beenUsed + numOfDishes;
            }

            if (isOkToContinue = false)
            {
                ifNotEnough = tellToClean();

                if(ifNotEnough = true)
                {
                    allDishes.clean = allDishes.clean - numOfDishes;
                    allDishes.beenUsed = allDishes.beenUsed + numOfDishes;
                }
            }

            reWriteDishes();
            sendCurrentDishesNum();
        }

        //this will check the number of clean dishes we have
        private static bool checkNumOfDishes()
        {
            bool isEnough = true;

            if(allDishes.clean < 5)
            {
                isEnough = false;
            }

            return isEnough;
        }

        // this will tell the GUI to display that the clean dishes is running low
        private static bool tellToClean()
        {
            bool isOkToContinue = true;

            //tell to clean
           
            return isOkToContinue;
        }

        //this will clean all the dirty dishes
        private static void cleanDishes()
        {
            int temp = 0;
            temp = allDishes.dirty;

            allDishes.dirty = 0;
            allDishes.clean = allDishes.clean + temp;
            temp = 0;

            reWriteDishes();
            sendCurrentDishesNum();
        }

        //this will send to the GUI the current amount of Dishes
        public static void sendCurrentDishesNum()
        {

        }

        public static void recieveNumOfLeavingCus(int leavingCus)
        {
            allDishes.beenUsed = allDishes.beenUsed - leavingCus;
            allDishes.beenUsed = allDishes.beenUsed + leavingCus;

            reWriteDishes();
            sendCurrentDishesNum();
        }
    }
}
