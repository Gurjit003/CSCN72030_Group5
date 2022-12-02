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
       
        int clean;
        int dirty;
        int beenUsed;
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
            this.beenUsed = beenused;
        }

        public static void resetDishes()
        {
            int clean = 32;
            int dirty = 0;
            int beenused = 0;

            reWriteDishes(clean, dirty, beenused);
        }

        private static dishes getDishes()
        {
            int current = 0;
            string[] gottenNumber = new string[3];

            string dishesFileName = "Dishes.txt";

            if (File.Exists(dishesFileName))
            {
                foreach (string line in System.IO.File.ReadLines(dishesFileName))
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
            }
            else
            {
                // Create empty data file
                string[] emptyDishesFile = { "32", "0", "0" };

                File.WriteAllLines(dishesFileName, emptyDishesFile);
            }
            int newClean;
            int newDirty;
            int newBeenUsed;

            Int32.TryParse(gottenNumber[0], out newClean);
            Int32.TryParse(gottenNumber[1], out newDirty);
            Int32.TryParse(gottenNumber[2], out newBeenUsed);

            dishes d = new dishes(newClean, newDirty, newBeenUsed);

            return d;
        }

        public static int getDishesClean()
        {
            int current = 0;
            string[] gottenNumber = new string[3];

            string dishesFileName = "Dishes.txt";

            if (File.Exists(dishesFileName))
            {
                foreach (string line in System.IO.File.ReadLines(dishesFileName))
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
            }
            else
            {
                // Create empty data file
                string[] emptyDishesFile = { "0", "0", "0"};

                File.WriteAllLines(dishesFileName, emptyDishesFile);
            }

            int newClean;
            int newDirty;
            int newBeenUsed;

            Int32.TryParse(gottenNumber[0], out newClean);
            Int32.TryParse(gottenNumber[1], out newDirty);
            Int32.TryParse(gottenNumber[2], out newBeenUsed);

            return newClean;
        }

        public static int getDishesDirty()
        {
            int current = 0;
            string[] gottenNumber = new string[3];
            string dishesFileName = "Dishes.txt";
            if (File.Exists(dishesFileName))
            {
                foreach (string line in System.IO.File.ReadLines("Dishes.txt"))
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
            }
            else
            {
                // Create empty data file
                string[] emptyDishesFile = { "32", "0", "0" };

                File.WriteAllLines(dishesFileName, emptyDishesFile);
            }

            int newClean;
            int newDirty;
            int newBeenUsed;

            Int32.TryParse(gottenNumber[0], out newClean);
            Int32.TryParse(gottenNumber[1], out newDirty);
            Int32.TryParse(gottenNumber[2], out newBeenUsed);;

            return newDirty;
        }
        //-------------------------------------------------------------------------------------

        public static int getDishesBeenUsed()
        {
            string[] gottenNumber = new string[3];

            string dishesFileName = "Dishes.txt";
            int current = 0;

            if (File.Exists(dishesFileName))
            {
                foreach (string line in System.IO.File.ReadLines("Dishes.txt"))
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
            }
            else
            {
                // Create empty data file
                string[] emptyDishesFile = { "32", "0", "0" };

                File.WriteAllLines(dishesFileName, emptyDishesFile);
            }
            int newClean;
            int newDirty;
            int newBeenUsed;

            Int32.TryParse(gottenNumber[0], out newClean);
            Int32.TryParse(gottenNumber[1], out newDirty);
            Int32.TryParse(gottenNumber[2], out newBeenUsed);

            return newBeenUsed;
        }

        //this function will write the number of dishes to the file 
        private static void reWriteDishes(int clean, int dirty, int beenUsed)
        {
            string cleanString = clean.ToString();
            string dirtyString = dirty.ToString();
            string beenUsedString = beenUsed.ToString();

            string filePath = "Dishes.txt";

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
                string[] emptyFile = { "32", "0", "0" };

                File.WriteAllLines(filePath, emptyFile);
            }
        }

        //this will recieve the numer of dishes needed for an order
        public static void recieveNumOfDishes(int numOfDishes)
        {
            dishes d = new dishes();
            //d = getDishes();
            d.clean = getDishesClean();
            d.dirty = getDishesDirty();
            d.beenUsed = getDishesBeenUsed();

            bool isOkToContinue = checkNumOfDishes(d);
            bool ifNotEnough = true;

            if (isOkToContinue == true)
            {
                d.clean = d.clean - numOfDishes;
                d.beenUsed = d.beenUsed + numOfDishes;
            }

            if (isOkToContinue == false)
            {
                ifNotEnough = tellToClean(0);

                if (ifNotEnough == true)
                {
                    d.clean = d.clean - numOfDishes;
                    d.beenUsed = d.beenUsed + numOfDishes;
                }
            }

            reWriteDishes(d.clean, d.dirty, d.beenUsed);
        }
        //-------------------------------------------------------------------------------------

        //this will check the number of clean dishes we have
        private static bool checkNumOfDishes(dishes d)
        {
            bool isEnough = true;

            if (d.clean < 5)
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
                DishesPopUp2 d = new DishesPopUp2();
                d.Show();
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
        }
        public static void recieveNumOfLeavingCus(int leavingCus)
        {
            dishes d = new dishes();
            d = getDishes();
            d.beenUsed = d.beenUsed - leavingCus;
            d.dirty = d.dirty + leavingCus;

            reWriteDishes(d.clean, d.dirty, d.beenUsed);
        }
    }
}
