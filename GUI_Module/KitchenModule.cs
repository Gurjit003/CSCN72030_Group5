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

        string kitchenOrderFIle = "kitchenOrderedItems.txt";
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

            inventoryCode mainInventory = new inventoryCode();

            //if enough inventory
            bool needToOrder = false;
            int[] itemsToOrder = { 0, 0, 0, 0, 0, 0 };
            int[] currentStock = mainInventory.getAllItemStock(mainInventory.arrayOfItems);
            for (int i = 0; i < currentStock.Length; i++)
            {
                if (currentStock[i] < brokenDownOrder[i])
                {
                    itemsToOrder[i] = brokenDownOrder[i] - currentStock[i];
                    needToOrder = true;
                }                           

            }
            if (needToOrder == true)
            {
                this.UpdateOrderedItemsFile(itemsToOrder);
                mainInventory.addItemToStock(itemsToOrder);
                this.orderPopUp();
            }
            

            this.fryer.CookFood(brokenDownOrder[1]);
            this.grill.CookFood(brokenDownOrder[0]);


            //Deduct inventory
            mainInventory.removeItemFromStock(brokenDownOrder);

            this.fryer.setCookingSpace(4);
            this.grill.setCookingSpace(4);
            return true;
        }

        public string[] LoadFile()
        {
            string[] orderedItems = { "0", "0", "0", "0", "0", "0" };

            if(File.Exists(kitchenOrderFIle))
            {
                orderedItems = File.ReadAllLines(kitchenOrderFIle);
            }

            return orderedItems;
        }
        public void UpdateOrderedItemsFile(int[] items)
        {
            if (File.Exists(kitchenOrderFIle))
            {
                string[] fileLines = File.ReadAllLines(kitchenOrderFIle);

                for(int i = 0; i < items.Length; i++)
                {
                    fileLines[i] = items[i].ToString();
                }
                File.WriteAllLines(kitchenOrderFIle, fileLines);
            }
            else
            {
                string[] emptyFile = { "0", "0", "0", "0", "0", "0" };

                File.WriteAllLines(kitchenOrderFIle, emptyFile);

               // this.orderedItemsFile(items);
            }
        }
        public void orderPopUp()
        {
            Form formBackground = new Form();
            try
            {
                using (KitchenOrderLevelPopUp uu = new KitchenOrderLevelPopUp())
                {
                    formBackground.StartPosition = FormStartPosition.CenterParent;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0;
                    formBackground.TopMost = true;
                    //formBackground.Location = KitchenControl
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
    }




}
