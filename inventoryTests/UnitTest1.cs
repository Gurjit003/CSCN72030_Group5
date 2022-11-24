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
                    // Store each line in array of strings
                    string[] fileLines = File.ReadAllLines(arrayOfDefaultItems[0].dataFileName);

                    string fileBurger = String.Join(",", fileLines[testInventory.burgerIndex]);
                    fileBurgerName = fileBurger.Split(',')[testInventory.nameIndex];

                    string fileChickenBurger = String.Join(",", fileLines[testInventory.chickenBurgerIndex]);
                    fileChickenBurgerQuantity = int.Parse(fileChickenBurger.Split(',')[testInventory.quantityIndex]);
                    

                    string filePop = String.Join(",", fileLines[testInventory.popIndex]);
                    filePopPrice = double.Parse(filePop.Split(',')[testInventory.priceIndex]);

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
            Assert.AreEqual(fileBurgerName, newBurgerName);
            Assert.AreEqual(fileChickenBurgerQuantity, newChickenBurgerQuantity);
            Assert.AreEqual(filePopPrice, newPopPrice);
        }
    }
}