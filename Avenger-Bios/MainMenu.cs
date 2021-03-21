using System;
using System.Collections.Generic;
using System.Globalization;

namespace AvengersBioLister
{
    public class MainMenu
    {
        public List<MenuOption> BuildMainMenu()
        {
            return new List<MenuOption>
            {
                new MenuOption ("Ant-Man"),
                new MenuOption ("Black Panther"),
                new MenuOption("Black Widow"),
                new MenuOption("Captain America"),
                new MenuOption("Falcon"),
                new MenuOption("Hawkeye"),
                new MenuOption("Hulk"),
                new MenuOption("Iron Man"),
                new MenuOption("Scarlet Witch"),
                new MenuOption("Spider-Man (Peter Parker)"),
                new MenuOption("Thor"),
                new MenuOption("Vision")

            };
        }

        public void DisplayMainMenu(List<MenuOption> options)
        {
            Console.Clear();
            Console.WriteLine("**************** Welcome to the Avengers Biography Database  ****************");
            Console.WriteLine("Please choose a number from the menu below to read the bios of the Avenger team members");
            Console.WriteLine("To exit the database please type 'Exit' and hit enter");
            Console.WriteLine("***************************************************************************************\n\n");

            int menuOptionCount = 1;
            foreach (var option in options)
            {
                Console.WriteLine($"{menuOptionCount++}.{option.ItemText}");

            }
        }



        public int GetMenuSelection(List<MenuOption> options)
        {

            do
            {
                string userChoice = Console.ReadLine();
                userChoice = userChoice.ToLower();
                if (userChoice == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    if (int.TryParse(userChoice, out int selection) && selection > 0 && selection <= options.Count)
                    {
                        //options[selection - 1];
                        return selection;
                    }
                    Console.WriteLine("Invalid Option");
                }

            }
            while (true);
        }


    }
}
