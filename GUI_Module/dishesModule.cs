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
    internal class dishes
    {
        //public static int cleanDishesCount = 10;
        //public static int dirtyDishesCount = 10;
        //public static int beenUsedDishesCount = 0;

        int clean = 20;
        int dirty = 0;
        int beenUsed = 0;

        public static dishes allDishes = new dishes();
        //-----------------------------------------------------------------------------------------------------------------

        //this function will get the number of dishes from the file 

        dishes()
        {
            clean = 20;
            dirty = 0;
            beenUsed = 0;
        }

        dishes(int clean, int dirty, int beenused)
        {
            this.clean = clean;
            this.dirty = dirty;
            this.beenUsed = beenUsed;
        }
        private static void getDishes()
        {
            int current = 0;
            string[] gottenNumber = new string[3];

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\group project\GUI_Module\Dishes.txt"))
            {
                if (current == 0)
                {
                    gottenNumber[0] = line;
                }

                if (current == 1)
                {
                    gottenNumber[1] = line;
                }

                if (current == 2)
                {
                    gottenNumber[2] = line;
                }

                current = 0;
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

        public static int getDishesClean()
        {
            int current = 0;
            string[] gottenNumber = new string[3];

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\group project\GUI_Module\Dishes.txt"))
            {
                if (current == 0)
                {
                    gottenNumber[0] = line;
                }

                if (current == 1)
                {
                    gottenNumber[1] = line;
                }

                if (current == 2)
                {
                    gottenNumber[2] = line;
                }

                current++;
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

            return newClean;
        }

        public static int getDishesDirty()
        {
            int current = 0;
            string[] gottenNumber = new string[3];

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\group project\GUI_Module\Dishes.txt"))
            {
                if (current == 0)
                {
                    gottenNumber[0] = line;
                }

                if (current == 1)
                {
                    gottenNumber[1] = line;
                }

                if (current == 2)
                {
                    gottenNumber[2] = line;
                }

                current++;
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

            return newDirty;
        }
        //-------------------------------------------------------------------------------------

        public static int getDishesBeenUsed()
        {
            int counter = 0;
            string[] gottenNumber = new string[3];

            string filePath = "Dishes.txt";

            int current = 0;

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\group project\GUI_Module\Dishes.txt"))
            {
                if (current == 0)
                {
                    gottenNumber[0] = line;
                }

                if (current == 1)
                {
                    gottenNumber[1] = line;
                }

                if (current == 2)
                {
                    gottenNumber[2] = line;
                }

                current++;
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

            return newBeenUsed;
        }

        //this function will write the number of dishes to the file 
        private static void reWriteDishes(int clean, int dirty, int beenUsed)
        {
            string cleanString = clean.ToString();
            string dirtyString = dirty.ToString();
            string beenUsedString = beenUsed.ToString();

            string filePath = @"C:\Users\daveo_xxpkcgs\OneDrive\Desktop\College\year 2 (fall semseter)\Software develpment\Group project\group project\GUI_Module\Dishes.txt";

            if (File.Exists(filePath))
            {
                string[] fileLines = File.ReadAllLines(filePath);

                fileLines[0] = cleanString;
                fileLines[1] = dirtyString;
                fileLines[2] = beenUsedString;

                File.WriteAllLines(filePath, fileLines);

            }
            else
            {
                string[] emptyFile = { "0", "0", "0" };

                File.WriteAllLines(filePath, emptyFile);
            }
        }

        //this will recieve the numer of dishes needed for an order
        public static void recieveNumOfDishes(int numOfDishes)
        {
            getDishes();
            //setNumOfDishes(allDishes);
            sendCurrentDishesNum();

            bool isOkToContinue = checkNumOfDishes();
            bool ifNotEnough = true;

            if (isOkToContinue == true)
            {
                allDishes.clean = allDishes.clean - numOfDishes;
                allDishes.beenUsed = allDishes.beenUsed + numOfDishes;
            }

            if (isOkToContinue == false)
            {
                ifNotEnough = tellToClean(0);

                if (ifNotEnough == true)
                {
                    allDishes.clean = allDishes.clean - numOfDishes;
                    allDishes.beenUsed = allDishes.beenUsed + numOfDishes;
                }
            }

            reWriteDishes(allDishes.clean, allDishes.dirty, allDishes.beenUsed);
            //setNumOfDishes(allDishes);
            sendCurrentDishesNum();
        }
        //-------------------------------------------------------------------------------------

        //this will check the number of clean dishes we have
        private static bool checkNumOfDishes()
        {
            bool isEnough = true;

            if (allDishes.clean < 5)
            {
                isEnough = false;
            }

            return isEnough;
        }
        //-------------------------------------------------------------------------------------

        // this will tell the GUI to display that the clean dishes is running low
        private static bool tellToClean(int sender)
        {
            bool isOkToContinue = true;

            if (sender == 0)
            {
                //DishesPopUp2 d = new DishesPopUp2;
            }

            if (sender == 1)
            {
                return isOkToContinue;
            }
            else
            {
                return isOkToContinue;
            }
        }
        //-------------------------------------------------------------------------------------

        //this will clean all the dirty dishes
        public static void cleanDishes()
        {
            int currentClean = getDishesClean();
            int currentDirty = getDishesDirty();
            int currentBeenUsed = getDishesBeenUsed();

            int temp = 0;
            temp = currentDirty;

            currentDirty = 0;
            currentClean = currentClean + temp;
            temp = 0;

            dishes d = new dishes(currentClean, currentDirty, currentBeenUsed);

            reWriteDishes(currentClean, currentDirty, currentBeenUsed);
            //setNumOfDishes(d);
            //sendCurrentDishesNum();
        }
        //-------------------------------------------------------------------------------------

        //this will send to the GUI the current amount of Dishes
        public static void sendCurrentDishesNum()
        {
            dishesControl1 d = new dishesControl1();
        }
        //-------------------------------------------------------------------------------------

        //this function will adjust the number of beenUsed and clean dishes according to the amount of customers that leave
        public static void recieveNumOfLeavingCus(int leavingCus)
        {
            allDishes.beenUsed = allDishes.beenUsed - leavingCus;
            allDishes.dirty = allDishes.dirty + leavingCus;

            reWriteDishes(allDishes.clean, allDishes.dirty, allDishes.beenUsed);
            //setNumOfDishes(allDishes);
            sendCurrentDishesNum();
        }
        //-----------------------------------------------------------------------------------------------------------------

        //this function will set the global varibales 
        /*private static void setNumOfDishes(dishes dishes)
        {
            cleanDishesCount = dishes.clean;
            dirtyDishesCount = dishes.dirty;
            beenUsedDishesCount = dishes.beenUsed;
        }*/
        //-----------------------------------------------------------------------------------------------------------------
    }
}
