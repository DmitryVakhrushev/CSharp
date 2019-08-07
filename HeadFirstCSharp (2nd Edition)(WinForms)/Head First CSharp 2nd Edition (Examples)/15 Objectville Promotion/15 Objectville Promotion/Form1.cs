using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5_Objectville_Promotion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<StarbuzzData> starbuzzList = GetStarbuzzData();
            ContactDBDataContext context = new ContactDBDataContext();
            
            var results =
                   from starbuzzCustomer in starbuzzList
                   where starbuzzCustomer.MoneySpent > 90
                   join person in context.Peoples
                   on starbuzzCustomer.Name equals person.Name
                   select new
                   {
                       person.Name,
                       person.Company,
                       starbuzzCustomer.FavoriteDrink
                   };

            foreach (var row in results)
            {
                Console.WriteLine("{0} at {1} likes {2}",
                           row.Name, row.Company, row.FavoriteDrink);
            }

            MessageBox.Show("Check the output for the results");

        }

        public List<StarbuzzData> GetStarbuzzData() {
            List<StarbuzzData> list = new List<StarbuzzData>() {
                new StarbuzzData() {
                    Name = "Janet Venutian", FavoriteDrink = Drink.ChocoMacchiato,
                    MoneySpent = 255, Visits = 50 },
                new StarbuzzData() {
                    Name = "Liz Nelson", FavoriteDrink = Drink.DoubleCappuccino,
                    MoneySpent = 150, Visits = 35 },
                new StarbuzzData() {
                    Name = "Matt Franks", FavoriteDrink = Drink.ZestyLemonChai,
                    MoneySpent = 75, Visits = 15 },
                new StarbuzzData() {
                    Name = "Joe Ng", FavoriteDrink = Drink.BananaSplitInACup,
                    MoneySpent = 60, Visits = 10 },
                new StarbuzzData() {
                    Name = "Sarah Kalter", FavoriteDrink = Drink.BoringCoffee,
                    MoneySpent = 110, Visits = 15 }
            };
            return list;
        }
    }
}