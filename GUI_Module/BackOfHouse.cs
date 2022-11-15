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


        static double getGrossRevenue()
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


        static double getExpenses()
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


        static double getNetRevenue(double grossRevenue, double expenses)
        {
            double netRevenue = grossRevenue - expenses;

            return Math.Round(netRevenue, 2);
        }

        public static void Main() 
        {
            double grossRevenue = getGrossRevenue();
            double expenses = getExpenses();
            double netRevenue = getNetRevenue(grossRevenue, expenses);

            Console.WriteLine("Gross Revenue: $" + grossRevenue);
            Console.WriteLine("Total expenses: $" + expenses);
            Console.WriteLine("Net Revenue: $" + netRevenue);
        }
    }
}