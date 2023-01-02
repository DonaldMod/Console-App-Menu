using System;
using System.Collections.Generic;

namespace Menu_At_A_Restaurant
{
    class Program
    {
        static Dictionary<string, double> Orders = new Dictionary<string, double>()
        {
            {"Breakfast Special",40 },
            {"Hasbrown and Egg",20 },
            {"Sunday Special",60 },
            {"Small Chips", 12 },
            {"Medium Chips", 15 },
            {"Large Chips", 22},
            {"Extra Large Chips", 30 },
            {"Cheese Burger", 15 },
            {"Chicken Burger", 20 },
            {"Double Chicken Burger With Cheese", 25 },
            {"Beef Burger", 30 },
            {"Double Beef Burger With Cheese",35 },
            {"Coca-Cola", 20 },
            {"Stoney", 15 },
            {"Spar Letta: Creme Soda", 15 },
            {"Spar Letta: Rasberry", 15 },
            {"Fanta: Orange", 16 },
            {"Chocolate", 25 },
            {"Vanilla", 20 },
            {"Oreo", 26 },
            {"Bubblegum", 25 },
            {"Strawberry", 25 },
            {"Orange",26 },
            {"Tropical",23 },
            {"Craneberry",22 },
            {"Apple",26},
            {"Mango",24 },
           {"Cappachino", 26 },
            {"Hot Chocolate", 24 },
             {"Coffee", 20 },
              {"Tea", 15 },
            {"Beef Burger with Fanta Orange", 45},
            {"Sandwich with Salad", 65},
            {"Chicken Burger with Stoney", 49},
            {"Sunday Special with Cappacino", 65},
            {"Hasbrown and Egg with Coffee", 43},
            { "Death by Chocolate Cake", 60},
            { "Cheesecake", 58},
            { "Banana Bread", 38},
            { "Waffle Cake", 54},
            { "Black Forest Cake", 56},
            {"Oreo Pudding", 63}
        };
        static double total = 0;
        static string results = "", result1 = "", result2 = "", result3 = "", result4 = "", result5 = "", result6 = "", result7 = "", result8 = "", result9 = "", result10 = "", result11 = "", result12 = "", result13 = "", result14 = "", result15 = "", result16 = "", result17 = "", result18 = "", result19 = "", result20 = "", result21 = "", result22 = "", result23 = "", result24 = "", result25 = "", result26 = "", result27 = "", result28 = "", result29 = "", result30 = "", result31 = "", result32 = "", result33 = "", result34 = "", result35 = "", result36 = "", result37 = "", result38 = "", result39 = "", result40 = "", result41 = "";
        enum DessertMenu
        {
            Death = 1,
            Cheese,
            Banana,
            Waffle,
            Black,
            Oreo,
            Back
        }
        static void Dessert()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Dessert Menu");
                Console.WriteLine(@"1. Death by Chocolate Cake R60
2. Cheesecake R58
3. Banana Bread R38
4. Waffle Cake R54
5. Black Forest Cake R56
6. Oreo Pudding R63
7. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                DessertMenu option = (DessertMenu)choice;
                switch (option)
                {
                    case DessertMenu.Death:
                        Console.WriteLine("How many do you want?");
                        int howmanyDeath = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Death by Chocolate Cake")
                            {
                                result36 = item.Key;
                                total = total + (item.Value * howmanyDeath);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Dessert\t\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyDeath, item.Value, item.Value * howmanyDeath, total);
                            }
                        }
                        break;
                    case DessertMenu.Cheese:
                        Console.WriteLine("How many do you want?");
                        int howmanyCheese = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Cheesecake")
                            {
                                result37 = item.Key;
                                total = total + (item.Value * howmanyCheese);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Dessert\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyCheese, item.Value, item.Value * howmanyCheese, total);
                            }
                        }
                        break;
                    case DessertMenu.Banana:
                        Console.WriteLine("How many do you want?");
                        int howmanyBanana = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Banana Bread")
                            {
                                result38 = item.Key;
                                total = total + (item.Value * howmanyBanana);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Dessert\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyBanana, item.Value, item.Value * howmanyBanana, total);
                            }
                        }
                        break;
                    case DessertMenu.Waffle:
                        Console.WriteLine("How many do you want?");
                        int howmanyWaffle = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Waffle Cake")
                            {
                                result39 = item.Key;
                                total = total + (item.Value * howmanyWaffle);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Dessert\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyWaffle, item.Value, item.Value * howmanyWaffle, total);
                            }
                        }
                        break;
                    case DessertMenu.Black:
                        Console.WriteLine("How many do you want?");
                        int howmanyBlack = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Black Forest Cake")
                            {
                                result40 = item.Key;
                                total = total + (item.Value * howmanyBlack);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Dessert\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyBlack, item.Value, item.Value * howmanyBlack, total);
                            }
                        }
                        break;
                    case DessertMenu.Oreo:
                        Console.WriteLine("How many do you want?");
                        int howmanyOreo = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Oreo Pudding")
                            {
                                result41 = item.Key;
                                total = total + (item.Value * howmanyOreo);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Dessert\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyOreo, item.Value, item.Value * howmanyOreo, total);
                            }
                        }
                        break;
                    case DessertMenu.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 7)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Dessert order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum CombosMenu
        {
            Beef = 1,
            Sandwich,
            Chicken,
            Sunday,
            Hasbrown,
            Back
        }
        static void Combos()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Combos Menu");
                Console.WriteLine(@"1. Beef Burger with Fanta Orange R45
2. Sandwich with Salad R65
3. Chicken Burger with Stoney R49
4. Sunday Special with Cappacino R65
5. Hasbrown and Egg with Coffee R43
6. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                CombosMenu option = (CombosMenu)choice;
                switch (option)
                {
                    case CombosMenu.Beef:
                        Console.WriteLine("How many do you want?");
                        int howmanyBeef = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Beef Burger with Fanta Orange")
                            {
                                result31 = item.Key;
                                total = total + (item.Value * howmanyBeef);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyBeef, item.Value, item.Value * howmanyBeef, total);
                            }
                        }
                        break;
                    case CombosMenu.Sandwich:
                        Console.WriteLine("How many do you want?");
                        int howmanySandwich = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Sandwich with Salad")
                            {
                                result32 = item.Key;
                                total = total + (item.Value * howmanySandwich);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanySandwich, item.Value, item.Value * howmanySandwich, total);
                            }
                        }
                        break;
                    case CombosMenu.Chicken:
                        Console.WriteLine("How many do you want?");
                        int howmanyChicken = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Chicken Burger with Stoney")
                            {
                                result33 = item.Key;
                                total = total + (item.Value * howmanyChicken);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyChicken, item.Value, item.Value * howmanyChicken, total);
                            }
                        }
                        break;
                    case CombosMenu.Sunday:
                        Console.WriteLine("How many do you want?");
                        int howmanySunday = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Sunday Special with Cappacino")
                            {
                                result34 = item.Key;
                                total = total + (item.Value * howmanySunday);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanySunday, item.Value, item.Value * howmanySunday, total);
                            }
                        }
                        break;
                    case CombosMenu.Hasbrown:
                        Console.WriteLine("How many do you want?");
                        int howmanyHasbrown = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Hasbrown and Egg with Coffee")
                            {
                                result35 = item.Key;
                                total = total + (item.Value * howmanyHasbrown);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyHasbrown, item.Value, item.Value * howmanyHasbrown, total);
                            }
                        }
                        break;
                    case CombosMenu.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 6)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Combos order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum SoftDrinks
        {
            Coca = 1,
            Stoney,
            CremeSoda,
            Rasberry,
            Orange,
            Back
        }
        static void Soft()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Soft Drinks Menu");
                Console.WriteLine(@"1. Coca-Cola R20
2. Stoney R15
3. Spar Letta: Creme Soda R15
4. Spar Letta: Rasberry R15
5. Fanta: Orange R16
6. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                SoftDrinks option = (SoftDrinks)choice;
                switch (option)
                {
                    case SoftDrinks.Coca:
                        Console.WriteLine("How many do you want?");
                        int howmanyCoca = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Coca-Cola")
                            {
                                result26 = item.Key;
                                total = total + (item.Value * howmanyCoca);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyCoca, item.Value, item.Value * howmanyCoca, total);
                            }
                        }
                        break;
                    case SoftDrinks.Stoney:
                        Console.WriteLine("How many do you want?");
                        int howmanyStoney = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Stoney")
                            {
                                result27 = item.Key;
                                total = total + (item.Value * howmanyStoney);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyStoney, item.Value, item.Value * howmanyStoney, total);
                            }
                        }
                        break;
                    case SoftDrinks.CremeSoda:
                        Console.WriteLine("How many do you want?");
                        int howmanyCremeSoda = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Spar Letta: Creme Soda")
                            {
                                result28 = item.Key;
                                total = total + (item.Value * howmanyCremeSoda);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyCremeSoda, item.Value, item.Value * howmanyCremeSoda, total);
                            }
                        }
                        break;
                    case SoftDrinks.Rasberry:
                        Console.WriteLine("How many do you want?");
                        int howmanyRasberry = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Spar Letta: Rasberry")
                            {
                                result29 = item.Key;
                                total = total + (item.Value * howmanyRasberry);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyRasberry, item.Value, item.Value * howmanyRasberry, total);
                            }
                        }
                        break;
                    case SoftDrinks.Orange:
                        Console.WriteLine("How many do you want?");
                        int howmanyOrange = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Fanta: Orange")
                            {
                                result30 = item.Key;
                                total = total + (item.Value * howmanyOrange);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyOrange, item.Value, item.Value * howmanyOrange, total);
                            }
                        }
                        break;
                    case SoftDrinks.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 6)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Soft Drink order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum MilkshakeDrinks
        {
            Chocolate = 1,
            Vanilla,
            Oreo,
            Bubblegum,
            Strawberry,
            Back
        }
        static void Milkshake()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Milkshake Menu");
                Console.WriteLine(@"1. Chocolate R25
2. Vanilla R20
3. Oreo R26
4. Bubblegum R25
5. Strawberry R25
6. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                MilkshakeDrinks option = (MilkshakeDrinks)choice;
                switch (option)
                {
                    case MilkshakeDrinks.Chocolate:
                        Console.WriteLine("How many do you want?");
                        int howmanyChocolate = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Chocolate")
                            {
                                result21 = item.Key;
                                total = total + (item.Value * howmanyChocolate);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Milkshake\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyChocolate, item.Value, item.Value * howmanyChocolate, total);
                            }
                        }
                        break;
                    case MilkshakeDrinks.Vanilla:
                        Console.WriteLine("How many do you want?");
                        int howmanyVanilla = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Vanilla")
                            {
                                result22 = item.Key;
                                total = total + (item.Value * howmanyVanilla);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Milkshake\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyVanilla, item.Value, item.Value * howmanyVanilla, total);
                            }
                        }
                        break;
                    case MilkshakeDrinks.Oreo:
                        Console.WriteLine("How many do you want?");
                        int howmanyOreo = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Oreo")
                            {
                                result23 = item.Key;
                                total = total + (item.Value * howmanyOreo);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Milkshake\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyOreo, item.Value, item.Value * howmanyOreo, total);
                            }
                        }
                        break;
                    case MilkshakeDrinks.Bubblegum:
                        Console.WriteLine("How many do you want?");
                        int howmanyBubblegum = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Bubblegum")
                            {
                                result24 = item.Key;
                                total = total + (item.Value * howmanyBubblegum);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Milkshake\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyBubblegum, item.Value, item.Value * howmanyBubblegum, total);
                            }
                        }
                        break;
                    case MilkshakeDrinks.Strawberry:
                        Console.WriteLine("How many do you want?");
                        int howmanyStrawberry = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Strawberry")
                            {
                                result25 = item.Key;
                                total = total + (item.Value * howmanyStrawberry);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Milkshake\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyStrawberry, item.Value, item.Value * howmanyStrawberry, total);
                            }
                        }
                        break;
                    case MilkshakeDrinks.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 6)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Milkshake order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum JuiceMenu
        {
            Orange = 1,
            Tropical,
            Craneberry,
            Apple,
            Mango,
            Back
        }
        static void Juice()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Juice Menu");
                Console.WriteLine(@"1. Orange R26
2. Tropical R23
3. Craneberry R22
4. Apple R26
5. Mango R24
6. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                JuiceMenu option = (JuiceMenu)choice;
                switch (option)
                {
                    case JuiceMenu.Orange:
                        Console.WriteLine("How many do you want?");
                        int howmanyOrange = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Orange")
                            {
                                result20 = item.Key;
                                total = total + (item.Value * howmanyOrange);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Juice\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyOrange, item.Value, item.Value * howmanyOrange, total);
                            }
                        }
                        break;
                    case JuiceMenu.Tropical:
                        Console.WriteLine("How many do you want?");
                        int howmanyTropical = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Tropical")
                            {
                                result19 = item.Key;
                                total = total + (item.Value * howmanyTropical);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Juice\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyTropical, item.Value, item.Value * howmanyTropical, total);
                            }
                        }
                        break;
                    case JuiceMenu.Craneberry:
                        Console.WriteLine("How many do you want?");
                        int howmanyCraneberry = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Craneberry")
                            {
                                result18 = item.Key;
                                total = total + (item.Value * howmanyCraneberry);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Juice\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyCraneberry, item.Value, item.Value * howmanyCraneberry, total);
                            }
                        }
                        break;
                    case JuiceMenu.Apple:
                        Console.WriteLine("How many do you want?");
                        int howmanyApple = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Apple")
                            {
                                result17 = item.Key;
                                total = total + (item.Value * howmanyApple);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Juice\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyApple, item.Value, item.Value * howmanyApple, total);
                            }
                        }
                        break;
                    case JuiceMenu.Mango:
                        Console.WriteLine("How many do you want?");
                        int howmanyMango = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Mango")
                            {
                                result16 = item.Key;
                                total = total + (item.Value * howmanyMango);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Juice\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyMango, item.Value, item.Value * howmanyMango, total);
                            }
                        }
                        break;
                    case JuiceMenu.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 6)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Juice order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum HotMenu
        {
            Cappachino = 1,
            HotChoco,
            Coffee,
            Tea,
            Back
        }
        static void Hot()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Soft Drinks Menu");
                Console.WriteLine(@"1. Cappachino R26
2. Hot Chocolate R24
3. Coffee R20
4. Tea 15
5. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                HotMenu option = (HotMenu)choice;
                switch (option)
                {
                    case HotMenu.Cappachino:
                        Console.WriteLine("How many do you want?");
                        int howmanyCappachino = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Cappachino")
                            {
                                result15 = item.Key;
                                total = total + (item.Value * howmanyCappachino);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyCappachino, item.Value, item.Value * howmanyCappachino, total);
                            }
                        }
                        break;
                    case HotMenu.HotChoco:
                        Console.WriteLine("How many do you want?");
                        int howmanyHotChoco = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Hot Chocolate")
                            {
                                result14 = item.Key;
                                total = total + (item.Value * howmanyHotChoco);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyHotChoco, item.Value, item.Value * howmanyHotChoco, total);
                            }
                        }
                        break;
                    case HotMenu.Coffee:
                        Console.WriteLine("How many do you want?");
                        int howmanyCoffee = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Coffee")
                            {
                                result13 = item.Key;
                                total = total + (item.Value * howmanyCoffee);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyCoffee, item.Value, item.Value * howmanyCoffee, total);
                            }
                        }
                        break;
                    case HotMenu.Tea:
                        Console.WriteLine("How many do you want?");
                        int howmanyTea = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Tea")
                            {
                                result12 = item.Key;
                                total = total + (item.Value * howmanyTea);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Soft Drinks\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyTea, item.Value, item.Value * howmanyTea, total);
                            }
                        }
                        break;
                    case HotMenu.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 5)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Hot Drinks order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum TypeDrink
        {
            Soft = 1,
            Milkshake,
            Juice,
            Hot,
            Back
        }
        static void Drinks()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Drinks Menu");
                Console.WriteLine(@"1. Soft Drinks
2. Milkshake
3. Juice
4. Hot Drinks
5. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                TypeDrink option = (TypeDrink)choice;
                switch (option)
                {
                    case TypeDrink.Soft:
                        Soft();
                        break;
                    case TypeDrink.Milkshake:
                        Milkshake();
                        break;
                    case TypeDrink.Juice:
                        Juice();
                        break;
                    case TypeDrink.Hot:
                        Hot();
                        break;
                    case TypeDrink.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 5)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Drinks order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum BurgerMenu
        {
            Cheese = 1,
            Chicken,
            Doublechicken,
            Beef,
            DoubleBeef,
            Back
        }
        static void Burger()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Burger Menu");
                Console.WriteLine(@"1. Cheese Burger R15
2. Chicken Burger R20
3. Double Chicken Burger With Cheese R25
4. Beef Burger R30
5. Double Beef Burger With Cheese R35
6. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                BurgerMenu option = (BurgerMenu)choice;
                switch (option)
                {
                    case BurgerMenu.Cheese:
                        Console.WriteLine("How many do you want?");
                        int howmanyCheese = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Cheese Burger")
                            {
                                result11 = item.Key;
                                total = total + (item.Value * howmanyCheese);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Burger\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyCheese, item.Value, item.Value * howmanyCheese, total);
                            }
                        }
                        break;
                    case BurgerMenu.Chicken:
                        Console.WriteLine("How many do you want?");
                        int howmanyChicken = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Chicken Burger")
                            {
                                result10 = item.Key;
                                total = total + (item.Value * howmanyChicken);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Burger\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyChicken, item.Value, item.Value * howmanyChicken, total);
                            }
                        }
                        break;
                    case BurgerMenu.Doublechicken:
                        Console.WriteLine("How many do you want?");
                        int howmanyDoublechicken = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Double Chicken Burger With Cheese")
                            {
                                result9 = item.Key;
                                total = total + (item.Value * howmanyDoublechicken);
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Burger\t\t\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyDoublechicken, item.Value, item.Value * howmanyDoublechicken, total);
                            }
                        }
                        break;
                    case BurgerMenu.Beef:
                        Console.WriteLine("How many do you want?");
                        int howmanyBeef = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Beef Burger")
                            {
                                result8 = item.Key;
                                total = total + (item.Value * howmanyBeef);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Burger\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyBeef, item.Value, item.Value * howmanyBeef, total);
                            }
                        }
                        break;
                    case BurgerMenu.DoubleBeef:
                        Console.WriteLine("How many do you want?");
                        int howmanyDoubleBeef = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Double Beef Burger With Cheese")
                            {
                                result7 = item.Key;
                                total = total + (item.Value * howmanyDoubleBeef);
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Burger\t\t\t\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyDoubleBeef, item.Value, item.Value * howmanyDoubleBeef, total);
                            }
                        }
                        break;
                    case BurgerMenu.Back:
                        break;
                    default:
                        break;
                }
                if (choice == 6)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Burger order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum ChipMenu
        {
            small = 1,
            medium,
            large,
            extra,
            back
        }
        static void Chips()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Chips Menu");
                Console.WriteLine(@"1. Small Chips R12
2. Medium Chips R15
3. Large Chips R22
4. Extra Large Chips R30
5. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                ChipMenu option = (ChipMenu)choice;
                switch (option)
                {
                    case ChipMenu.small:
                        Console.WriteLine("How many do you want?");
                        int howmanySmall = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Small Chips")
                            {
                                result3 = item.Key;
                                total = total + (item.Value * howmanySmall);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Chip Size\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanySmall, item.Value, item.Value * howmanySmall, total);
                            }
                        }
                        break;
                    case ChipMenu.medium:
                        Console.WriteLine("How many do you want?");
                        int howmanyMedium = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Medium Chips")
                            {
                                result4 = item.Key;
                                total = total + (item.Value * howmanyMedium);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Chip Size\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyMedium, item.Value, item.Value * howmanyMedium, total);
                            }
                        }
                        break;
                    case ChipMenu.large:
                        Console.WriteLine("How many do you want?");
                        int howmanyLarge = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Large Chips")
                            {
                                result5 = item.Key;
                                total = total + (item.Value * howmanyLarge);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Chip Size\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyLarge, item.Value, item.Value * howmanyLarge, total);
                            }
                        }
                        break;
                    case ChipMenu.extra:
                        Console.WriteLine("How many do you want?");
                        int howmanyExtra = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Extra Large Chips")
                            {
                                result6 = item.Key;
                                total = total + (item.Value * howmanyExtra);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Chip Size\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyExtra, item.Value, item.Value * howmanyExtra, total);
                            }
                        }
                        break;
                    case ChipMenu.back:
                        break;
                    default:
                        break;
                }
                if (choice == 5)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your Chips order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum Breakfasts
        {
            special = 1,
            hasbrown,
            sunday,
            back
        }
        static void Breakfast()
        {
            string back = "";
            while (back != "back")
            {
                Console.WriteLine("Breakfast Menu");
                Console.WriteLine(@"1. Breakfast Special R40
2. Hasbrown and Egg R20
3. Sunday Special R60
4. Back");
                Console.WriteLine("Please choose from the above menu");
                int choice = int.Parse(Console.ReadLine());
                Breakfasts option = (Breakfasts)choice;
                switch (option)
                {
                    case Breakfasts.special:
                        Console.WriteLine("How many do you want?");
                        int howmanySpec = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Breakfast Special")
                            {
                                result2 = item.Key;
                                total = total + (item.Value * howmanySpec);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanySpec, item.Value, item.Value * howmanySpec, total);
                            }
                        }
                        break;
                    case Breakfasts.hasbrown:
                        Console.WriteLine("How many do you want?");
                        int howmanyHas = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Hasbrown and Egg")
                            {
                                result1 = item.Key;
                                total = total + (item.Value * howmanyHas);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanyHas, item.Value, item.Value * howmanyHas, total);
                            }
                        }
                        break;
                    case Breakfasts.sunday:
                        Console.WriteLine("How many do you want?");
                        int howmanySun = int.Parse(Console.ReadLine());
                        foreach (var item in Orders)
                        {
                            if (item.Key == "Sunday Special")
                            {
                                results = item.Key;
                                total = total + (item.Value * howmanySun);
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("Breakfast\t\tQuantity\tCost per Item\tTotal Cost For Item\tTotal");
                                Console.WriteLine("----------------------------------------------------------------------------------------------");
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}", item.Key, howmanySun, item.Value, item.Value * howmanySun, total);
                            }
                        }
                        break;
                    case Breakfasts.back:
                        break;
                    default:
                        break;
                }
                if (choice == 4)
                {
                    break;
                }
                Console.WriteLine("Type 'back' to go back or press Enter to continue with your breakfast order");
                back = Console.ReadLine().ToLower();
                Console.Clear();
            }
        }
        enum Menu
        {
            breakfast = 1,
            combos,
            chips,
            burgers,
            drinks,
            desert,
            checkout
        }
        static void Main(string[] args)
        {
            string username = "", password = "", checkout = "";
            while (((username != "abcd") && (password != "1234")) || ((username == "abcd") && (password != "1234")) || ((username != "abcd") && (password == "1234")))
            {
                Console.WriteLine("Give your username:");
                username = Console.ReadLine().ToLower();
                if (username == "abcd")
                {
                    Console.WriteLine("Give your password:");
                    password = Console.ReadLine();
                    if (password == "1234")
                    {
                        Console.WriteLine("You have successfully logged in");
                        Console.WriteLine("Press ENTER to continue");
                        Console.ReadLine();
                        Console.Clear();
                        while (checkout != "yes")
                        {
                            Console.WriteLine("MENU");
                            Console.WriteLine(@"1. Breakfast
2. Combos
3. Chips
4. Burgers
5. Drinks
6. Desserts
7. Checkout");
                            Console.WriteLine("Please choose from the above menu");
                            int choice = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Menu option = (Menu)choice;
                            switch (option)
                            {
                                case Menu.breakfast:
                                    Breakfast();
                                    break;
                                case Menu.combos:
                                    Combos();
                                    break;
                                case Menu.chips:
                                    Chips();
                                    break;
                                case Menu.burgers:
                                    Burger();
                                    break;
                                case Menu.drinks:
                                    Drinks();
                                    break;
                                case Menu.desert:
                                    Dessert();
                                    break;
                                case Menu.checkout:
                                    break;
                                default:
                                    break;
                            }
                            if (choice == 7)
                            {
                                break;
                            }
                            Console.WriteLine("Do you want to checkout. yes/no");
                            checkout = Console.ReadLine().ToLower();
                            Console.Clear();
                        }
                        Console.WriteLine("Your order is below:");
                        foreach (var item in Orders)
                        {
                            if ((results == item.Key) || (result1 == item.Key) || (result2 == item.Key) || (result3 == item.Key) || (result4 == item.Key) || (result5 == item.Key) || (result6 == item.Key) || (result7 == item.Key) || (result8 == item.Key) || (result9 == item.Key) || (result10 == item.Key) || (result11 == item.Key) || (result12 == item.Key) || (result13 == item.Key) || (result14 == item.Key) || (result15 == item.Key) || (result16 == item.Key) || (result17 == item.Key) || (result18 == item.Key) || (result19 == item.Key) || (result20 == item.Key) || (result21 == item.Key) || (result22 == item.Key) || (result23 == item.Key) || (result24 == item.Key) || (result25 == item.Key) || (result26 == item.Key) || (result27 == item.Key) || (result28 == item.Key) || (result29 == item.Key) || (result30 == item.Key) || (result31 == item.Key) || (result32 == item.Key) || (result33 == item.Key) || (result34 == item.Key) || (result35 == item.Key) || (result36 == item.Key) || (result37 == item.Key) || (result38 == item.Key) || (result39 == item.Key) || (result40 == item.Key) || (result41 == item.Key))
                            {
                                Console.WriteLine(item.Key);
                            }
                        }
                        Console.WriteLine("Your total amount is: R{0}", total);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You have entered the incorrect password. TRY AGAIN!");
                        Console.WriteLine("Press ENTER to try again");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect username. TRY AGAIN!");
                    Console.WriteLine("Press ENTER to try again");
                    Console.ReadLine();
                }
                Console.Clear();
            }
        }
    }
}
