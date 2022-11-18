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
    }
}