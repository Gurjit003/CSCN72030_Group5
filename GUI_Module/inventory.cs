using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    public class item
    {
        int itemID;
        string itemName;
        double itemPrice;
        double orderPrice;
        int itemQuantity;

        public item(int itemID, string itemName, double itemPrice, double orderPrice, int quantity) // Base constructor
        {
            setItemID(itemID);
            setItemName(itemName);
            setItemPrice(itemPrice);
            setOrderPrice(orderPrice);
            setQuantity(quantity);
        }

        public void setItemID(int itemID) { this.itemID = itemID; } // Set itemID
        public void setItemName(string itemName) { this.itemName = itemName; } // Set itemName
        public void setItemPrice(double price) { this.itemPrice = price; } // Set itemPrice
        public void setOrderPrice(double orderPrice) { this.orderPrice = orderPrice; } // Set orderPrice
        public void setQuantity(int quantity) { this.itemQuantity = quantity; } // Set quantity

        public int getItemID() { return this.itemID; } // Get itemID
        public string getItemName() { return this.itemName; } // Get itemName
        public double getItemPrice() { return this.itemPrice; } // Get itemPrice
        public double getOrderPrice() { return this.orderPrice; } // Get orderPrice
        public int getQuantity() { return this.itemQuantity; } // Get quantity
    }

    public class inventory
    {
        string textFileName = "inventoryCount.txt";
        int numberOfItems = 6;

        public item[] createDefaultItems() // Create an instance of all menu items
        {
            item[] arrayOfItems= new item[numberOfItems]; // Array to store all items

            // Create items and add to array
            item hamburger = new item(1, "Hamburger", 6.79, 2.49, 10); arrayOfItems[0] = hamburger;
            item chickenBurger = new item(2, "Chicken Burger", 5.59, 1.99, 10); arrayOfItems[1] = chickenBurger;
            item salad = new item(3, "Salad", 3.99, 1.20, 10); arrayOfItems[2] = salad;
            item fries = new item(4, "Fries", 1.99, 0.60, 10); arrayOfItems[3] = fries;
            item pop = new item(5, "Pop", 1.99, 0.50, 10); arrayOfItems[4] = pop;
            item water = new item(6, "Water", 1.49, 0.10, 10); arrayOfItems[5] = water;

            return arrayOfItems;
        }

        public int[] getAllItemStock(item[] itemArray)
        {
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