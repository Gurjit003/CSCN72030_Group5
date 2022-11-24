using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GUI_Module
{
    public class item
    {
        int numberOfItems = 6;
        public string dataFileName = "itemQuantities.txt";

        int itemID;
        string itemName;
        double itemPrice;
        double orderPrice;
        int itemQuantity;

        // Item attribute index (file and default array)
        public int idIndex = 0;
        public int nameIndex = 1;
        public int priceIndex = 2;
        public int orderPriceIndex = 3;
        public int quantityIndex = 4;

        public item(int itemID, string itemName, double itemPrice, double orderPrice, int quantity) // Base constructor
        {
            setItemID(itemID);
            setItemName(itemName);
            setItemPrice(itemPrice);
            setOrderPrice(orderPrice);
            setQuantity(quantity);

            this.updateDataFile();
        }

        public void setItemID(int itemID) 
        { 
            this.itemID = itemID; // Set itemID
            this.updateDataFile();
        } 
        public void setItemName(string itemName)
        {
            this.itemName = itemName; // Set itemName
            this.updateDataFile();
        } 
        public void setItemPrice(double price) { 
            this.itemPrice = price; // Set itemPrice
            this.updateDataFile();
        } 
        public void setOrderPrice(double orderPrice)
        {
            this.orderPrice = orderPrice; // Set orderPrice
            this.updateDataFile();
        }
        public void setQuantity(int quantity) 
        { 
            this.itemQuantity = quantity; // Set quantity
            this.updateDataFile();
        } 

        public int getItemID() { return this.itemID; } // Get itemID
        public string getItemName() { return this.itemName; } // Get itemName
        public double getItemPrice() { return this.itemPrice; } // Get itemPrice
        public double getOrderPrice() { return this.orderPrice; } // Get orderPrice
        public int getQuantity() { return this.itemQuantity; } // Get quantity

        public void updateDataFile() // Method to update item info in text file
        {
            // Read data file into string 1 line per index
            if (File.Exists(dataFileName))
            {
                // Store each line in array of strings
                string[] fileLines = File.ReadAllLines(dataFileName);

                // Replace line that corresponds with this item ID with any new info
                fileLines[this.getItemID() - 1] = this.getItemID().ToString() + ',' + this.getItemName() + ',' +
                    this.getItemPrice().ToString() + ',' + this.getOrderPrice().ToString() + ',' + this.getQuantity().ToString();

                // Write updated info
                File.WriteAllLines(dataFileName, fileLines);
            }
            else
            {
                // Create empty data file
                string[] emptyDataFile = { "0", "0", "0", "0", "0", "0" };

                File.WriteAllLines(dataFileName, emptyDataFile);    

                this.updateDataFile();
            }
        }

        public void readDataFile() // Method to read existing item data from file
        {
            if (File.Exists(this.dataFileName))
            {
                // Store each line in array of strings
                string[] fileLines = File.ReadAllLines(this.dataFileName);

                string fileItem = String.Join(",", fileLines[this.idIndex]);
                int fileItemID = int.Parse(fileItem.Split(',')[this.idIndex]); this.setItemID(fileItemID);
                string fileItemName = fileItem.Split(',')[this.nameIndex]; this.setItemName(fileItemName);
                double fileItemPrice = double.Parse(fileItem.Split(',')[this.priceIndex]); this.setItemPrice(fileItemPrice);
                double fileItemOrder = double.Parse(fileItem.Split(',')[this.orderPriceIndex]); this.setOrderPrice(fileItemOrder);
                int fileItemQuantity = int.Parse(fileItem.Split(',')[this.quantityIndex]); this.setQuantity(fileItemQuantity);
            }
        }
    }

    public class inventory
    {
        // Number of menu items
        public int numberOfItems = 6;

        // Menu item indexes (file and default array)
        public int burgerIndex = 0;
        public int chickenBurgerIndex = 1;
        public int saladIndex = 2;
        public int friesIndex = 3;
        public int popIndex = 4;
        public int waterIndex = 5;

        public item[] createDefaultItems() // Create an instance of all menu items
        {
            item[] arrayOfItems= new item[numberOfItems]; // Array to store all items

            // Create items and add to array
            item hamburger = new item(1, "Hamburger", 6.79, 2.49, 10); arrayOfItems[burgerIndex] = hamburger;
            item chickenBurger = new item(2, "Chicken Burger", 5.59, 1.99, 10); arrayOfItems[chickenBurgerIndex] = chickenBurger;
            item salad = new item(3, "Salad", 3.99, 1.20, 10); arrayOfItems[saladIndex] = salad;
            item fries = new item(4, "Fries", 1.99, 0.60, 10); arrayOfItems[friesIndex] = fries;
            item pop = new item(5, "Pop", 1.99, 0.50, 10); arrayOfItems[popIndex] = pop;
            item water = new item(6, "Water", 1.49, 0.10, 10); arrayOfItems[waterIndex] = water;

            return arrayOfItems;
        }

        public int[] getAllItemStock(item[] itemArray) // Returns an array of quantity of items 
        {
            int[] itemStockArray = new int[numberOfItems]; // Create array to hold item stock values

            for (int x = 0; x < itemArray.Length; x++) // For all items
            {
                int itemQuantityToAdd = itemArray[x].getQuantity(); // Get quantity for item
                itemStockArray[x] = itemQuantityToAdd; // Add item quantity to itemStockArray
            }

            return itemStockArray; // Return array of stock values
        }

        public void removeItemFromStock(item[] itemsOrdered) // Method to decrement an item's stock by 1
        {
            for (int x = 0; x < itemsOrdered.Length; x++) // For all items ordered
            {
                int currentItemStock = itemsOrdered[x].getQuantity(); // Get current quantity
                itemsOrdered[x].setQuantity(--currentItemStock); // Set quantity to current - 1
            }
        }
    }
}

/* 
Customer prices: 
Hamburger: $6.79
Chicken burger: $5.59
Salad: $3.99
Fries: $1.99
Pop: $1.99
Water: $1.49

Inventory/order prices: 
Hamburger: $2.49
Chicken burger: $1.99
Salad: $1.20
Fries: $0.60
Pop: $0.50
Water: $0.10
*/ 