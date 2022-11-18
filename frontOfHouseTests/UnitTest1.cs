namespace frontOfHouseTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void createTable_verifyContents()
        {
            // Arrage
            int tableID = 1;
            int seatsOccupied = 3;

            // Act
            table newTable = new table(tableID, seatsOccupied); // Create table

            // Assert
            Assert.AreEqual(newTable.getTableID(), tableID);
            Assert.AreEqual(newTable.getOccupants(), seatsOccupied);
        }

        [TestMethod]
        public void createArrayOfEmptyTables_verifyNumberOfTables()
        {
            // Arrage
            int numberOFTables = 6;

            // Act
            // Create array of empty tables 
            frontOfHouse frontOfHouse = new frontOfHouse();
            table[] arrayOfTables = frontOfHouse.createArrayOfEmptyTables();

            // Assert
            Assert.AreEqual(arrayOfTables.Length, numberOFTables);
        }

        [TestMethod]
        public void findEmptyTableNumber_verifyTableIsEmpty()
        {
            // Arrage
            int tableNumberThatShouldBeEmpty = 1;

            // Act
            frontOfHouse frontOfHouse = new frontOfHouse();
            table[] arrayOfEmptyTables = frontOfHouse.createArrayOfEmptyTables();
            arrayOfEmptyTables[0].setOccupants(1); // Occupy first table
            int emptyTableFoundByFunction = 
                frontOfHouse.findEmptyTableNumber(arrayOfEmptyTables); // Find empty table

            // Assert
            Assert.AreEqual(emptyTableFoundByFunction, tableNumberThatShouldBeEmpty);
        }

        [TestMethod]
        public void generateNumberOfCustomers_verifyWithinBounds()
        {
            // Arrage
            int numberOfCustomers;
            int maxCustomers = 4;
            int minCustomers = 1;

            // Act
            frontOfHouse frontOfHouse = new frontOfHouse();
            numberOfCustomers = frontOfHouse.generateNumberOfCustomers();

            // Assert
            Assert.IsTrue(numberOfCustomers <= maxCustomers);
            Assert.IsTrue(numberOfCustomers >= minCustomers);
        }

        [TestMethod]
        public void assignGeneratedNumberOfCustomersToTable_verifyAssignedCustomers()
        {
            // Arrage
            int numberOfCustomers = 2;
            int tableToOccupy = 1;

            // Act
            frontOfHouse frontOfHouse = new frontOfHouse();
            table[] arrayOfEmptyTables = frontOfHouse.createArrayOfEmptyTables();
            frontOfHouse.assignCustomersToTable(arrayOfEmptyTables, 
                tableToOccupy, numberOfCustomers);

            // Assert
            Assert.AreEqual(arrayOfEmptyTables[tableToOccupy].getOccupants(), numberOfCustomers);
        }

    }
}