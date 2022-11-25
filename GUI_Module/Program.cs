using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUI_Module
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int idIndex = 0;
            int quantityIndex = 1;

            int tableOneID = 1;
            int tableFourID = 4;
            int tableFourQuantity = 3;
            int tableSixID = 6;
            int tableEightID = 8;
            int tableEightQuantity = 2;

            frontOfHouse frontOfHouse = new frontOfHouse();
            table[] arrayOfTables = frontOfHouse.createArrayOfEmptyTables();


            arrayOfTables[tableOneID - 1].setTableID(tableOneID);
            arrayOfTables[tableFourID - 1].setOccupants(tableFourQuantity);
            arrayOfTables[tableSixID - 1].setTableID(tableSixID);
            arrayOfTables[tableEightID - 1].setOccupants(tableEightQuantity);

            // Act
            string[] fileLines = File.ReadAllLines(arrayOfTables[0].tableFileName);

            string tableOneLine = String.Join(",", fileLines[tableOneID - 1]);
            string tableOneFileID = tableOneLine.Split(',')[idIndex];
            int tableOneFileIDInt = int.Parse(tableOneFileID);

            string tableFourLine = String.Join(",", fileLines[tableFourID - 1]);
            string tableFourFileID = tableOneLine.Split(',')[quantityIndex];
            int tableFourQuantityInt = int.Parse(tableFourFileID);

            string tableSixLine = String.Join(",", fileLines[tableSixID - 1]);
            string tableSixFileID = tableOneLine.Split(',')[idIndex];
            int tableSixFileIDInt = int.Parse(tableSixFileID);

            string tableEightLine = String.Join(",", fileLines[tableEightID - 1]);
            string tableEightFileID = tableOneLine.Split(',')[quantityIndex];
            int tableEightQuantityInt = int.Parse(tableEightFileID);


        }
    }
}
