using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_mini_class_project
{
    class Program
    {
        bool cancel_Order, cancel_Activity = false;

        /*
            ===  FUNCTIONS NEEDED  ===
         *  1. options
         *  2. order-breakast 
         *  2. order-lunch 
         *  3. order-dinner 
         *  4. Display whats ordered with prices 
         *  5. Thnak User for eating at this cafe 
         */



        void chooseOption()
        {
            Console.WriteLine("Welcome to ISBAT COMBO CAFFETERIA");
            Console.WriteLine("What would you want today?");
            Console.WriteLine("1. BREAKFAST");
            Console.WriteLine("2. LUNCH");
            Console.WriteLine("3. DINNER");

            string meal_choice = Console.ReadLine();
            int choice = Convert.ToInt32(meal_choice);

            switch (choice)
            {
                case 1:
                    orderBreakFast();
                    break;

                case 2:
                    orderLunch();
                    break;

                case 3:
                    orderDinner();
                    break;

                default:
                    Console.WriteLine("Please choose from the above options");
                    break;
            }

        }
        
        void orderBreakFast()
        {
            string[] breakFast_menu = {
                "tea + rolex -> UGX 2,500", 
                "milk + toasted bread - > UGX 3,000",
                "coffee + krabby party -> UGX 7,000"};

            Console.WriteLine("Make an order");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + "\t" + breakFast_menu[i] + " ");
            }
            int breakFast_choice = Convert.ToInt32(Console.ReadLine());
            switch (breakFast_choice)
            {
                case 0:
                    Console.WriteLine($"Ordered: {breakFast_menu[0]}");
                    break;
                
               case 1:
                    Console.WriteLine($"Ordered: {breakFast_menu[1]}");
                    break;
                
                case 2:
                    Console.WriteLine($"Ordered: {breakFast_menu[2]}");
                    break;
            }

        }
        
        void orderLunch()
        {
            string[] lunch_menu = {
                "fries -> UGX 5,500",
                "burger -> UGX 8,000",
                "plain chips -> UGX 3,500",
            };

            Console.WriteLine("Make an order");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + "\t" + lunch_menu[i] + " ");
            }
            int lunch_choice = Convert.ToInt32(Console.ReadLine());
            switch (lunch_choice)
            {
                case 0:
                    Console.WriteLine($"Ordered: {lunch_menu[0]}");
                    break;

                case 1:
                    Console.WriteLine($"Ordered: {lunch_menu[1]}");
                    break;

                case 2:
                    Console.WriteLine($"Ordered: {lunch_menu[2]}");
                    break;
            }

        }
        
        void orderDinner()
        {
            string[] dinner_menu = {
                "fries + liver -> UGX 12,000",
                "hot dog -> UGX 6,000",
                "local dish combo -> UGX 18,000",
            };
            Console.WriteLine("Make an order");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + "\t" + dinner_menu[i] + " ");
            }
            int dinner_choice = Convert.ToInt32(Console.ReadLine());
            switch (dinner_choice)
            {
                case 0:
                    Console.WriteLine($"Ordered: {dinner_menu[0]}");
                    break;

                case 1:
                    Console.WriteLine($"Ordered: {dinner_menu[1]}");
                    break;

                case 2:
                    Console.WriteLine($"Ordered: {dinner_menu[2]}");
                    break;
            }
        }


        void thankClient()
        {
            Console.WriteLine("Thank You for eating at ISBAT COMBO CAFFETERIA");
        }


        static void Main(string[] args)
        {
            Program client = new Program();
            client.chooseOption();
            client.thankClient();
        }
    }
}
