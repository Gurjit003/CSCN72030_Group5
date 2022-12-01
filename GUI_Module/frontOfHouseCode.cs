using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace GUI_Module
{
    public class table
    {
        int tableID;
        int seatsOccupied;
        int idIndex = 0;
        int occupantIndex = 1;

        public string tableFileName = "tableData.txt";
        
        public table() // Base contructor
        {
            setTableID(0);
            setOccupants(0);
            updateTableFile();
        }

        public table(int tableID) // Constructor with tableID
        {
            setTableID(tableID);
            setOccupants(0);
            updateTableFile();
        }

        public table(int tableID, int seatsOccupied) // Constructor with tableID and seatsOccupied
        {
            setTableID(tableID);
            setOccupants(seatsOccupied);
            updateTableFile();
        }

        public void setTableID(int tableID) // Set tableID
        { 
            this.tableID = tableID;
            updateTableFile();
        }

        public void setOccupants(int seatsOccupied) // Set seatsOccupied
        { 
            this.seatsOccupied = seatsOccupied;
            updateTableFile();
        }

        public int getTableID() // Return tableID
        { return tableID; }

        public int getOccupants() // Return seatsOccupied
        { return seatsOccupied; }

        public void clearTable() // Set seatsOccupied to 0
        { 
            this.seatsOccupied = 0;
            updateTableFile();
        }

        public void updateTableFile() // Method to update tableData.txt
        {
            // Read data file into string 1 line per index
            if (File.Exists(tableFileName))
            {
                // Store each line in array of strings
                string[] fileLines = File.ReadAllLines(tableFileName);

                // Replace line that corresponds with this table ID with any new info
                fileLines[this.getTableID() - 1] = this.getTableID().ToString() + ',' + this.getOccupants();

                // Write updated info
                File.WriteAllLines(tableFileName, fileLines);
            }
            else
            {
                // Create empty data file
                string[] emptyDataFile = { "Empty", "Empty", "Empty", "Empty",
                    "Empty", "Empty", "Empty", "Empty" };

                File.WriteAllLines(tableFileName, emptyDataFile);

                this.updateTableFile();
            }
        }

        public void readDataFile() // Method to read existing item data from file
        {
            if (File.Exists(this.tableFileName))
            {
                // Store each line in array of strings
                string[] fileLines = File.ReadAllLines(this.tableFileName);

                string fileItem = String.Join(",", fileLines[this.getTableID() - 1]);
                int tableID = int.Parse(fileItem.Split(',')[this.idIndex]); this.setTableID(tableID);
                int occupants = int.Parse(fileItem.Split(',')[this.occupantIndex]); this.setOccupants(occupants);
            }
        }

    }

    public class frontOfHouseCode
    {
        // These values are not modifiable 
        int minimumTableOccupants = 1;
        int maximumTableOccupants = 4;
        int minimumTableIndex = 0;
        public int numberOfTables = 8;
        int emptyTable = 0;

        public table[] arrayOfTables; // Front of house table array

        public table[] createArrayOfEmptyTables() // Method to create 8 empty tables
        {
            // New list for all the tables (easier access)
            table[] arrayOfTables = new table[numberOfTables];

            // Create 8 empty tables, add tables to list
            table table1 = new table(1); arrayOfTables[0] = table1;
            table table2 = new table(2); arrayOfTables[1] = table2;
            table table3 = new table(3); arrayOfTables[2] = table3;
            table table4 = new table(4); arrayOfTables[3] = table4;
            table table5 = new table(5); arrayOfTables[4] = table5;
            table table6 = new table(6); arrayOfTables[5] = table6;
            table table7 = new table(7); arrayOfTables[6] = table7;
            table table8 = new table(8); arrayOfTables[7] = table8;

            // Tables are visible at the start of the program
            this.arrayOfTables = arrayOfTables;

            return arrayOfTables;
        }

        public int findEmptyTableNumber(table[] arrayOfTables) // Method to find next empty table (returns table number)
        {
            // Update all tables before searching
            for (int tableNumber = 0; tableNumber < this.numberOfTables; tableNumber++)
            {
                this.arrayOfTables[tableNumber].readDataFile();
            }

            // Starting table to check if empty
            int tableNum = minimumTableIndex;

            // Loop until an unoccupied table is found
            while (true)
            {
                if (arrayOfTables[tableNum].getOccupants() != emptyTable) // If table is not empty
                {
                    tableNum++; // Increment table number
                }
                else if (tableNum > maximumTableOccupants)
                {
                    
                    break;
                }
                else
                    break; // Exit loop when empty table is found
            }

            return tableNum;
        }

        public int generateNumberOfCustomers() // Method to generate random number of customer (1-4)
        {
            // Choose random (1-4) occupants
            Random random = new Random();
            
            int numberOfOccupants = random.Next(minimumTableOccupants, maximumTableOccupants);
            return numberOfOccupants;
        }

        public bool setTable() // Method to assign randomly generated number of customers to an empty table
        {
            // Get empty table
            int tableToOccupy = findEmptyTableNumber(this.arrayOfTables);

            // Set random number of customers to a table
            int numberOfCustomers = generateNumberOfCustomers();
            this.arrayOfTables[tableToOccupy].setOccupants(numberOfCustomers);

            // GUI: Show numberOfCustomers occupant icons on table ID

            // Send to Order Module
            return sendOrder(this.arrayOfTables[tableToOccupy]);
        }

        public bool sendOrder(table tableOrdering) // Method to send the number of occupants to the Order module 
        {
            bool orderConfirmation = false; // Order starts as incomplete

            // Send to order module
            //while (orderConfirmation != true)
           // {
                orderConfirmation = Order.getNumOfOrder(tableOrdering.getOccupants()); // Continue ordering until complete
           // }

            // After ordering is complete, empty the table 
            //Thread.Sleep(1000);
            //tableOrdering.setOccupants(emptyTable);

            return orderConfirmation; // Temp return statement 
        }

        public void updateTables(table[] arrayOfTablesToUpdate) // Method to update the attributes of this object's item array
        {
            for (int itemIndex = 0; itemIndex < numberOfTables; itemIndex++)
            {
                arrayOfTablesToUpdate[itemIndex].readDataFile();
            }
        }

        public string getOrderStatus(table tableToGetStatus)
        {
            if (tableToGetStatus.getOccupants() != 0)
            {
                return "In Progress";
            }
            else
                return "Empty";
        }


        // if getNumOfCustomers(numberOfOccupants) == 1
        // Order is complete
        // delay
        // arrayOfTables[tableNum].setOccupants(emptyTable);

        // else
        // order failed
        // delay
        // re-order

        // Get reply when complete 


        // Set table occupancy to 0
    }
}
