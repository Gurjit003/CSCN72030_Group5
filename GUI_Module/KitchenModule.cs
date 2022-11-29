using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            inventoryCode mainInventory = new inventoryCode();

            //if enough inventory
            int[] itemsToOrder = { 0, 0, 0, 0, 0, 0 };
            int[] currentStock = mainInventory.getAllItemStock(mainInventory.arrayOfItems);
            for (int i = 0; i < currentStock.Length; i++)
            {
                if (currentStock[i] < brokenDownOrder[i])
                {
                    itemsToOrder[i] = brokenDownOrder[i] - currentStock[i];
                }

                mainInventory.addItemToStock(itemsToOrder);
                //GUI popup syas items ordered
                


            }
            fryer.CookFood(brokenDownOrder[1]);
            grill.CookFood(brokenDownOrder[0]);


            //Deduct inventory
            mainInventory.removeItemFromStock(brokenDownOrder);

            fryer.setCookingSpace(4);
            grill.setCookingSpace(4);
            return true;
        }

        public void orderPopUp(int[] addedItems)
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
