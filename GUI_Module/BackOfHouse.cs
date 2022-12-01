using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Module
{
    internal static class BackOfHouse
    {
        public static void setGrossRevenue(Order order)
        {
            string filePath = "IncomeFile.txt";

            string main = order.getMain();
            string side = order.side;
            string drink = order.drink;
            double mainPrice, sidePrice, drinkPrice, orderPrice = 0;

            if (String.Equals(main, "Hamburger"))
            {
                mainPrice = 6.79;
            }
            else
            {
                mainPrice = 5.59;
            }

            if (String.Equals(side, "Salad"))
            {
                sidePrice = 3.99;
            }
            else
            {
                sidePrice = 1.99;
            }

            if (String.Equals(drink, "Pop"))
            {
                drinkPrice = 1.99;
            }
            else
            {
                drinkPrice = 1.49;
            }

            orderPrice = mainPrice + sidePrice + drinkPrice;
            orderPrice = Math.Round(orderPrice, 2);
            string orderPriceTemp = orderPrice.ToString();


            File.AppendAllText(filePath, orderPriceTemp + Environment.NewLine);
        }

        static IEnumerable<string> ReadLines(this TextReader reader, char delimiter)
        {
            List<char> chars = new List<char>();
            while (reader.Peek() >= 0)
            {
                char c = (char)reader.Read();

                if (c == delimiter)
                {
                    yield return new String(chars.ToArray());
                    chars.Clear();
                    continue;
                }

                chars.Add(c);
            }
        }


        public static double getGrossRevenue()
        {
            string filePath = "IncomeFile.txt";
            double sum = 0;

            using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
            {
                foreach (var line in sr.ReadLines('\n'))
                {
                    sum += Convert.ToDouble(line);
                }
            }

            return Math.Round(sum, 2);
        }


        static void setExpenses(string item, int quantity)
        {
            string filePath = "ExpensesFile.txt"; 
            double expense, totalExpense = 0; 

            if (String.Equals(item, "Hamburger"))
            {
                expense = 2.49;
            } else if (String.Equals(item, "Chicken burger"))
            {
                expense = 1.99;
            } else if (String.Equals(item, "Fries"))
            {
                expense = 0.60;
            } else if (String.Equals(item, "Salad"))
            {
                expense = 1.20;
            } else if (String.Equals(item, "Water"))
            {
                expense = 0.10;
            } else if (String.Equals(item, "Pop"))
            {
                expense = 0.50; 
            } else
            {
                expense = 0; 
            }

            
            totalExpense = expense * quantity; 
            totalExpense = Math.Round(totalExpense, 2); 
            string totalExpenseTemp = totalExpense.ToString(); 


            File.AppendAllText(filePath, totalExpenseTemp + Environment.NewLine); 
        }


        public static double getExpenses()
        {
            string filePath = "ExpensesFile.txt";
            double sum = 0;

            using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
            {
                foreach (var line in sr.ReadLines('\n'))
                {
                    sum += Convert.ToDouble(line);
                }
            }

            return Math.Round(sum, 2);
        }


        public static double getNetRevenue(double grossRevenue, double expenses)
        {
            double netRevenue = grossRevenue - expenses;

            return Math.Round(netRevenue, 2);
        }
    }
}