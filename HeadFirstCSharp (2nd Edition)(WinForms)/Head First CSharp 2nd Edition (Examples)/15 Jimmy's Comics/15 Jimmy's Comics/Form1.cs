using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_Jimmy_s_Comics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private static List<Comic> BuildCatalog()
        {
            List<Comic> comics = new List<Comic>() {
                new Comic() { Name = "Johnny America vs. the Pinko", Issue = 6 },
                new Comic() { Name = "Rock and Roll (limited edition)", Issue = 19 },
                new Comic() { Name = "Woman’s Work", Issue = 36 },
                new Comic() { Name = "Hippie Madness (misprinted)", Issue = 57 },
                new Comic() { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68 },
                new Comic() { Name = "Black Monday", Issue = 74 },
                new Comic() { Name = "Tribal Tattoo Madness", Issue = 83 },
                new Comic() { Name = "The Death of an Object", Issue = 97 }
            };
            return comics;
        }

        private static Dictionary<int, int> GetPrices()
        {
            Dictionary<int, int> values = new Dictionary<int, int>();
            values.Add(6, 3600);
            values.Add(19, 500);
            values.Add(36, 650);
            values.Add(57, 13525);
            values.Add(68, 250);
            values.Add(74, 75);
            values.Add(83, 25);
            values.Add(97, 35);
            return values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Comic> comics = BuildCatalog();
            Dictionary<int, int> values = GetPrices();

            var mostExpensive =
                from comic in comics
                where values[comic.Issue] > 500
                orderby values[comic.Issue] descending
                select comic;

            foreach (Comic comic in mostExpensive)
                Console.WriteLine("{0} is worth {1:c}",
                                  comic.Name, values[comic.Issue]);

        }





        public List<Purchase> FindPurchases()
        {
            List<Purchase> purchases = new List<Purchase>() {
                new Purchase() { Issue = 68, Price = 225 },
                new Purchase() { Issue = 19, Price = 375 },
                new Purchase() { Issue = 6, Price = 3600 },
                new Purchase() { Issue = 57, Price = 13215 },
                new Purchase() { Issue = 36, Price = 660 },
            };
            return purchases;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Comic> comics = BuildCatalog();
            Dictionary<int, int> values = GetPrices();
            List<Purchase> purchases = FindPurchases();

            var results =
                from comic in comics
                join purchase in purchases
                on comic.Issue equals purchase.Issue
                orderby comic.Issue ascending
                select new { comic.Name, comic.Issue, purchase.Price };

            int gregsListValue = 0;
            int totalSpent = 0;
            foreach (var result in results)
            {
                gregsListValue += values[result.Issue];
                totalSpent += result.Price;
                Console.WriteLine("Issue #{0} ({1}) bought for {2:c}",
                         result.Issue, result.Name, result.Price);
            }
            Console.WriteLine("I spent {0:c} on comics worth {1:c}",
                         totalSpent, gregsListValue);
        }
    }
}