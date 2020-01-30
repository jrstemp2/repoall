using System;
using System.Collections.Generic;

namespace lab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string goAgain = "yes";
            double price = 0;
            double sum = 0.0;
            double averagePrice = 0.0;

            Console.WriteLine("Welcome to the sotre! Please Browse our Goods!");
            Console.WriteLine();
            
            List<string> shoppingCartItems = new List<string>();
            List<double> shoppingCartPrices = new List<double>();

            Dictionary<string, double> inventory = new Dictionary<string, double>();
            inventory["apple"] = 0.88;
            inventory["frozen pizza"] = 4.99;
            inventory["dvd movie"] = 19.99;
            inventory["potatoe"] = 1.99;
            inventory["ramen soup"] = 0.89;
            inventory["gummy bear"] = 2.99;
            inventory["napkin"] = 2.95;
            inventory["banana"] = 1.15;

            foreach (KeyValuePair<string, double> kvPair in inventory)
            {
                Console.WriteLine($"{kvPair.Key, -20} ${ kvPair.Value}");//20 is 20 characters away from left side. This is printing the whole table. 
            }

            do
            {
                Console.WriteLine();
                Console.Write("Please enter an item you would like to purchase: ");
                string item = Console.ReadLine().ToLower();

                if (inventory.ContainsKey(item))
                {  
                    Console.WriteLine("your have added a(n) " + item);
                    shoppingCartItems.Add(item);

                    
                    
                }
                else
                {
                    Console.WriteLine("We do not stcok that item.");
                    Console.Write("Would you like to add another item? ");
                    continue;
                }
                
                Console.Write("Would you like to add another item? ");
                
                goAgain = Console.ReadLine();
                
                
            } while (goAgain == "yes");
            
            for (int i = 0; i < shoppingCartPrices.Count; i++)
            {
                sum += price;
                averagePrice = sum / shoppingCartPrices.Count;

            }


            Console.WriteLine();
            Console.WriteLine("The items in your cart are:");
            
            foreach (string item in shoppingCartItems)
            {
                sum += inventory[item];
                averagePrice = sum / shoppingCartItems.Count;
                Console.WriteLine($"{item,-20}{"$"+ inventory[item], 15}");        
            }
            Console.WriteLine("The total price of your items is $" + sum);
            Console.WriteLine(String.Format("The Average price of your items is $" + "{0:N2}",averagePrice));   
        }

    }
}
