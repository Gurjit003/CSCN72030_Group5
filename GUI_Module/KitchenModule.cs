using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.Design;

namespace GUI_Module
{
    public class Kitchen
    {
        string fullOrder = "fullKitchenOrder";
        string kitchenOrderFIle = "kitchenOrderedItems.txt";

        Appliance.Grill grill;
        Appliance.Fryer fryer;
        
        public Kitchen()
        {
            grill = new Appliance.Grill();
            fryer = new Appliance.Fryer();
        }
        public string getFullOrder() { return this.fullOrder; }
        public string getKitchenOrderFIle() { return this.kitchenOrderFIle; }
        public bool reciveOrder(Order[] order)
        {
            //array {Hamburger, Chicken, Salad, Fries,  Pop, Water}
            int[] brokenDownOrder = { 0, 0, 0, 0, 0, 0 };
            int numberOfMeals = order.Length;
            for (int i = 0; i < numberOfMeals; i++)
            {
                //Disect the order to tally up chicken burgers and beef burgerss
                if (order[i].getMain() == "Hamburger")
                {
                    brokenDownOrder[0] = brokenDownOrder[0] + 1;
                }
                else
                {
                    brokenDownOrder[1] = brokenDownOrder[1] + 1;
                }
                if (order[i].side == "Salad")
                {
                    brokenDownOrder[2] = brokenDownOrder[2] + 1;
                }
                else
                {
                    brokenDownOrder[3] = brokenDownOrder[3] + 1;
                }
                if (order[i].drink == "Pop")
                {
                    brokenDownOrder[4] = brokenDownOrder[4] + 1;
                }
                else
                {
                    brokenDownOrder[5] = brokenDownOrder[5] + 1;
                }
            }

            inventoryCode mainInventory = new inventoryCode();

            //if enough inventory
            bool needToOrder = false;
            int[] itemsToOrder = { 0, 0, 0, 0, 0, 0 };
            int[] currentStock = mainInventory.getAllItemStock(mainInventory.arrayOfItems); // Get array of current inventory stock
            for (int i = 0; i < currentStock.Length; i++)
            {
                if (currentStock[i] < brokenDownOrder[i]) // compare curent inventory stock with the needed items
                {
                    itemsToOrder[i] = brokenDownOrder[i] - currentStock[i];
                    needToOrder = true;
                }                           

            }
            if (needToOrder == true) //if there are less items in stock then needed
            {
                this.UpdateFile(itemsToOrder, kitchenOrderFIle); //write to file the extra items that were ordered
                mainInventory.addItemToStock(itemsToOrder); 
                this.orderPopUp(); //Calls a popup to show items ordered to make the meal
            }

            this.UpdateFile(brokenDownOrder, fullOrder); //update a file with the whole broken down order

            
            this.fryer.CookFood(brokenDownOrder[1]);
            this.grill.CookFood(brokenDownOrder[0]);
            ProgressPopUp();//call the cooking progress popup


            //Deduct used inventory
            mainInventory.removeItemFromStock(brokenDownOrder);
            
            //reset the used cooking space back to 0 and update the appliance file
            this.fryer.setCookingSpace(4);
            this.grill.setCookingSpace(4);
            this.grill.updateFile(grill.getGrillFile());
            this.fryer.updateFile(fryer.getFryerFile());
            return true;
        }

        public string[] LoadFile(string fileName)
        {
            string[] items = { "0", "0", "0", "0", "0", "0" }; //blank array to write to

            if(File.Exists(fileName))
            {
                items = File.ReadAllLines(fileName); //read all lines into the array
            }

            return items;
        }
        public void UpdateFile(int[] items, string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] fileLines = File.ReadAllLines(fileName); //write all items into an array

                for(int i = 0; i < items.Length; i++)
                {
                    fileLines[i] = items[i].ToString(); //copy one line at a time into item array
                }
                File.WriteAllLines(fileName, fileLines);
            }
            else
            {
                //Create File if it does not exist
                string[] emptyFile = { "0", "0", "0", "0", "0", "0" };

                File.WriteAllLines(fileName, emptyFile);

               this.UpdateFile(items, fileName);
            }
        }
        //Call OrderedItems Popup
        public void orderPopUp()
        {
            Form formBackground = new Form();
            try
            {
                using (KitchenOrderLevelPopUp uu = new KitchenOrderLevelPopUp())
                {
                    uu.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Call cooking progress pop up
        public void ProgressPopUp()
        {
            Form formBackground = new Form();
            try
            {
                using (CookingProgression uu = new CookingProgression())
                {
                    uu.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
