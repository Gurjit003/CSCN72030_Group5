namespace inventoryTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void createItem_verifyContents()
        {
            // Arrange
            int itemID = 1;
            string itemName = "testItem";
            double itemPrice = 1.99;
            double orderPrice = 0.49;
            int quantity = 1;

            // Act
            item testItem = new item(itemID, itemName, itemPrice, orderPrice, quantity);

            // Assert
            Assert.AreEqual(testItem.getItemID(), itemID);
            Assert.AreEqual(testItem.getItemName(), itemName);
            Assert.AreEqual(testItem.getItemPrice(), itemPrice);
            Assert.AreEqual(testItem.getOrderPrice(), orderPrice);
            Assert.AreEqual(testItem.getQuantity(), quantity);
        }

        [TestMethod]
        public void createDefaultItems_verifyItemAttributes()
        {
            // Arrange
            int hamburgerID = 1;
            string chickenBurderName = "Chicken Burger";
            double saladPrice = 3.99;
            double friesOrderPrice = 0.60;
            int popQuantity = 10;
            int waterID = 6;

            // Act
            inventory testInventory = new inventory();
            item[] arrayOfDefaultItems = testInventory.createDefaultItems();

            // Assert
            Assert.AreEqual(arrayOfDefaultItems[0].getItemID(), hamburgerID);
            Assert.AreEqual(arrayOfDefaultItems[1].getItemName(), chickenBurderName);
            Assert.AreEqual(arrayOfDefaultItems[2].getItemPrice(), saladPrice);
            Assert.AreEqual(arrayOfDefaultItems[3].getOrderPrice(), friesOrderPrice);
            Assert.AreEqual(arrayOfDefaultItems[4].getQuantity(), popQuantity);
            Assert.AreEqual(arrayOfDefaultItems[5].getItemID(), waterID);
        }
        
        [TestMethod]
        public void getAllItemStock_verifyStock()
        {
            // Arrange
            int itemQuantity = 10;

            // Act
            inventory testInventory = new inventory();
            item[] arrayOfDefaultItems = testInventory.createDefaultItems();
            int[] itemQuantityArray = testInventory.getAllItemStock(arrayOfDefaultItems);

            // Assert
            Assert.AreEqual(itemQuantityArray[0], itemQuantity);
            Assert.AreEqual(itemQuantityArray[1], itemQuantity);
            Assert.AreEqual(itemQuantityArray[2], itemQuantity);
            Assert.AreEqual(itemQuantityArray[3], itemQuantity);
            Assert.AreEqual(itemQuantityArray[4], itemQuantity);
            Assert.AreEqual(itemQuantityArray[5], itemQuantity);
        }

        [TestMethod]
        public void removeItemFromStock_verifyStockRecudedByOne()
        {
            // Arrange
            int itemQuantityAfterReduced = 9;

            // Act
            inventory testInventory = new inventory();
            item[] arrayOfDefaultItems = testInventory.createDefaultItems();
            testInventory.removeItemFromStock(arrayOfDefaultItems);


            // Assert
            Assert.AreEqual(arrayOfDefaultItems[0].getQuantity(), itemQuantityAfterReduced);
            Assert.AreEqual(arrayOfDefaultItems[1].getQuantity(), itemQuantityAfterReduced);
            Assert.AreEqual(arrayOfDefaultItems[2].getQuantity(), itemQuantityAfterReduced);
            Assert.AreEqual(arrayOfDefaultItems[3].getQuantity(), itemQuantityAfterReduced);
            Assert.AreEqual(arrayOfDefaultItems[4].getQuantity(), itemQuantityAfterReduced);
            Assert.AreEqual(arrayOfDefaultItems[5].getQuantity(), itemQuantityAfterReduced);
        }


        [TestMethod]
        public void createDefaultItemsAndModify_verifyTextFileAccuracy()
        {
            // Arrange
            string newBurgerName = "Burger2.0";
            int newChickenBurgerQuantity = 25;
            double newPopPrice = 0.99;
            string fileBurgerName;
            int fileChickenBurgerQuantity;
            double filePopPrice;

            // Act
            inventory testInventory = new inventory();
            item[] arrayOfDefaultItems = testInventory.createDefaultItems();
            arrayOfDefaultItems[testInventory.burgerIndex].setItemName(newBurgerName);
            arrayOfDefaultItems[testInventory.chickenBurgerIndex].setQuantity(newChickenBurgerQuantity);
            arrayOfDefaultItems[testInventory.popIndex].setItemPrice(newPopPrice);

            while (true)
            {
                if (File.Exists(arrayOfDefaultItems[0].dataFileName))
                {
                    // Get values from file
                    string[] fileLines = File.ReadAllLines(arrayOfDefaultItems[0].dataFileName);
                    string fileBurger = String.Join(",", fileLines[testInventory.burgerIndex]);
                    fileBurgerName = fileBurger.Split(',')[arrayOfDefaultItems[0].nameIndex];
                    string fileChickenBurger = String.Join(",", fileLines[testInventory.chickenBurgerIndex]);
                    fileChickenBurgerQuantity = int.Parse(fileChickenBurger.Split(',')[arrayOfDefaultItems[0].quantityIndex]);
                    string filePop = String.Join(",", fileLines[testInventory.popIndex]);
                    filePopPrice = double.Parse(filePop.Split(',')[arrayOfDefaultItems[0].priceIndex]);

                    break;
                }
                else
                {
                    // Create empty data file
                    string[] emptyDataFile = { "0", "0", "0", "0", "0", "0" };
                    File.WriteAllLines(arrayOfDefaultItems[0].dataFileName, emptyDataFile);
                }
            }

            // Assert
                // Compare file values to custom values
            Assert.AreEqual(fileBurgerName, newBurgerName);
            Assert.AreEqual(fileChickenBurgerQuantity, newChickenBurgerQuantity);
            Assert.AreEqual(filePopPrice, newPopPrice); 
        }

        [TestMethod]
        public void createItemsInFile_readAndVerifyItem()
        {
            // Arrange
            string newBurgerName = "Burger2.0";
            int newChickenBurgerQuantity = 25;
            double newPopPrice = 0.99;
            string fileBurgerName;
            int fileChickenBurgerQuantity;
            double filePopPrice;

            // Act
            inventory testInventory = new inventory();
            item[] arrayOfDefaultItems = testInventory.createDefaultItems();
            arrayOfDefaultItems[testInventory.burgerIndex].setItemName(newBurgerName);
            arrayOfDefaultItems[testInventory.chickenBurgerIndex].setQuantity(newChickenBurgerQuantity);
            arrayOfDefaultItems[testInventory.popIndex].setItemPrice(newPopPrice);

                // Create custom data file
            string[] emptyDataFile = { "1,Burger2.0,6.79,2.49,10", "2,Chicken Burger,5.59,1.99,25",
                        "3,Salad,3.99,1.2,10", "4,Fries,1.99,0.6,10", "5,Pop,0.99,0.5,10", "6,Water,1.49,0.1,10" };
            File.WriteAllLines(arrayOfDefaultItems[0].dataFileName, emptyDataFile);

                // Get values from file 
            string[] fileLines = File.ReadAllLines(arrayOfDefaultItems[0].dataFileName);
            string fileBurger = String.Join(",", fileLines[testInventory.burgerIndex]);
            fileBurgerName = fileBurger.Split(',')[arrayOfDefaultItems[0].nameIndex];
            string fileChickenBurger = String.Join(",", fileLines[testInventory.chickenBurgerIndex]);
            fileChickenBurgerQuantity = int.Parse(fileChickenBurger.Split(',')[arrayOfDefaultItems[0].quantityIndex]);
            string filePop = String.Join(",", fileLines[testInventory.popIndex]);
            filePopPrice = double.Parse(filePop.Split(',')[arrayOfDefaultItems[0].priceIndex]);

            // Assert
                // Compare file values to actual item values
            Assert.AreEqual(arrayOfDefaultItems[testInventory.burgerIndex].getItemName(), newBurgerName);
            Assert.AreEqual(arrayOfDefaultItems[testInventory.chickenBurgerIndex].getQuantity(), newChickenBurgerQuantity);
            Assert.AreEqual(arrayOfDefaultItems[testInventory.popIndex].getItemPrice(), newPopPrice);
        }
    }
}