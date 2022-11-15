using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    internal class item
    {
        int itemID;
        string itemName;
        double itemPrice;
        int itemQuantity;

        public item(int itemID, string itemName, double price, int quantity) // Base constructor
        {
            setItemID(itemID);
            setItemName(itemName);
            setItemPrice(price);
            setQuantity(quantity);
        }

        void setItemID(int itemID) { this.itemID = itemID; } // Set itemID
        void setItemName(string itemName) { this.itemName = itemName; } // Set itemName
        void setItemPrice(double price) { this.itemPrice = price; } // Set itemPrice
        void setQuantity(int quantity) { this.itemQuantity = quantity; } // Set quantity

        public int getItemID() { return this.itemID; } // Get itemID
        public string getItemName() { return this.itemName; } // Get itemName
        public double getItemPrice() { return this.itemPrice; } // Get itemPrice
        public int getQuantity() { return this.itemQuantity; } // Get quantity
    }

    internal class inventory
    {
        string textFileName = "inventoryCount.txt";
        int numberOfItems = 8;

        void createItems() // Create an instance of all menu items
        {
            item[] arrayOfItems= new item[numberOfItems]; // Array to store all items

            // Example - Create item and add to array
            item hamburger = new item(1, "hamburger", 2.99, 5); arrayOfItems[1] = hamburger;
            item pop = new item(2, "pop", 0.99, 5); arrayOfItems[2] = pop;
        }

        int[] getAllItemStock()
        {
            item[] itemArray = new item[numberOfItems]; // Create array to hold items in stock
            int[] itemStockArray = new int[numberOfItems]; // Create array to hold item stock values

            for (int x = 0; x < itemArray.Length; x++) // For all items
            {
                int itemQuantityToAdd = itemArray[x].getQuantity(); // Get quantity for item
                itemStockArray[x] = itemQuantityToAdd; // Add item quantity to itemStockArray
            }

            return itemStockArray; // Return array of stock values
        }
    }
}
