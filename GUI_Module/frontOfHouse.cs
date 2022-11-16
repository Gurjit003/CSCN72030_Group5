using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Module
{
    internal class table
    {
        int tableID;
        int seatsOccupied;
        
        public table(int tableID) // Base constructor
        {
            setTableID(tableID);
            seatsOccupied = 0;
        }

        public void setTableID(int tableID) // Set tableID
        { this.tableID = tableID; }

        public void setOccupants(int seatsOccupied) // Set seatsOccupied
        { this.seatsOccupied = seatsOccupied; }

        public int getTableID() // Return tableID
        { return tableID; }

        public int getOccupants() // Return seatsOccupied
        { return seatsOccupied; }

        public void clearTable() // Set seatsOccupied to 0
        { this.seatsOccupied = 0; }

    }

    internal class frontOfHouse
    {
        int minimumTableOccupants = 1;
        int maximumTableOccupants = 4;
        int numberOfTables = 6;
        int emptyTable = 0;

        table[] createArrayOfEmptyTables() // Method to create 6 empty tables
        {
            // New list for all the tables (easier access)
            table[] arrayOfTables = new table[6];

            // Starting table to check if empty
            int tableNum = minimumTableOccupants;

            // Create 4 empty tables, add tables to list
            table table1 = new table(1); arrayOfTables[1] = table1;
            table table2 = new table(2); arrayOfTables[2] = table2;
            table table3 = new table(3); arrayOfTables[3] = table3;
            table table4 = new table(4); arrayOfTables[4] = table4;
            table table5 = new table(5); arrayOfTables[5] = table5;
            table table6 = new table(6); arrayOfTables[6] = table6;

            return arrayOfTables;
        }

        table findEmptyTable(table[] arrayOfTables) // Method to find next empty table
        {
            // Loop until an unoccupied table is found
            while (true)
            {
                if (arrayOfTables[tableNum].getOccupants() != emptyTable) // If table is not empty
                {
                    tableNum++; // Increment table number
                }
                else if (tableNum > 6)
                {
                    // Error - all tables occupied
                }
                else
                    break; // Exit loop when empty table is found
            }
        }

        int generateNumberOfCustomers()
        {
            // Choose random (1-4) occupants
            Random random = new Random();
            int numberOfOccupants = random.Next(minimumTableOccupants, maximumTableOccupants);
        }

        void assignCustomersToTable(table[] arrayOfTables)
        {
            // Assign generated number of occupants to the empty table
            arrayOfTables[tableNum].setOccupants(numberOfOccupants);
        }

        void createOrder()
        {
            // Send to order
            // boolean getNumOfCustomers(int numberOfOccupants); -- Function in order module

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


            // Delay 10 seconds

        }
    }
}
