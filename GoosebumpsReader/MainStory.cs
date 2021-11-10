using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GoosebumpsReader
{
    class MainStory
    {
        public void Start()
        {
            Title = "Goosebumps: Carnival of Horror!";
            RunMainMenu();
        }
        public static void RunMainMenu()
        {
            string prompt = @"
  ▄████  ▒█████   ▒█████    ██████ ▓█████  ▄▄▄▄    █    ██  ███▄ ▄███▓ ██▓███    ██████ 
 ██▒ ▀█▒▒██▒  ██▒▒██▒  ██▒▒██    ▒ ▓█   ▀ ▓█████▄  ██  ▓██▒▓██▒▀█▀ ██▒▓██░  ██▒▒██    ▒ 
▒██░▄▄▄░▒██░  ██▒▒██░  ██▒░ ▓██▄   ▒███   ▒██▒ ▄██▓██  ▒██░▓██    ▓██░▓██░ ██▓▒░ ▓██▄   
░▓█  ██▓▒██   ██░▒██   ██░  ▒   ██▒▒▓█  ▄ ▒██░█▀  ▓▓█  ░██░▒██    ▒██ ▒██▄█▓▒ ▒  ▒   ██▒
░▒▓███▀▒░ ████▓▒░░ ████▓▒░▒██████▒▒░▒████▒░▓█  ▀█▓▒▒█████▓ ▒██▒   ░██▒▒██▒ ░  ░▒██████▒▒
 ░▒   ▒ ░ ▒░▒░▒░ ░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░░░ ▒░ ░░▒▓███▀▒░▒▓▒ ▒ ▒ ░ ▒░   ░  ░▒▓▒░ ░  ░▒ ▒▓▒ ▒ ░
  ░   ░   ░ ▒ ▒░   ░ ▒ ▒░ ░ ░▒  ░ ░ ░ ░  ░▒░▒   ░ ░░▒░ ░ ░ ░  ░      ░░▒ ░     ░ ░▒  ░ ░
░ ░   ░ ░ ░ ░ ▒  ░ ░ ░ ▒  ░  ░  ░     ░    ░    ░  ░░░ ░ ░ ░      ░   ░░       ░  ░  ░  
      ░     ░ ░      ░ ░        ░     ░  ░ ░         ░            ░                  ░  
   ___                 _            _          __                                   
  / __\__ _ _ __ _ __ (_)_   ____ _| |   ___  / _|   /\  /\___  _ __ _ __ ___  _ __ 
 / /  / _` | '__| '_ \| \ \ / / _` | |  / _ \| |_   / /_/ / _ \| '__| '__/ _ \| '__|
/ /__| (_| | |  | | | | |\ V / (_| | | | (_) |  _| / __  / (_) | |  | | | (_) | |   
\____/\__,_|_|  |_| |_|_| \_/ \__,_|_|  \___/|_|   \/ /_/ \___/|_|  |_|  \___/|_|   
                                                                                                                                    ░                                       

                               (Use arrow keys and Enter to select.)";
            string[] options = { "Read Story", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    RunChoice();
                    break;
                case 1:
                    DisplayAbout();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }
        public static void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
        public static void DisplayAbout()
        {
            Clear();
            WriteLine("Help was provided by Googling and YouTube tutorials...");
            WriteLine("Assets from http://patorjk.com/software/taag");
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
            RunMainMenu();
        }
        public static void RunChoice()
        {
            ReadKey();
            Clear();
            WriteLine("Late one night you and your friends visit the old fairgrounds. They're putting up rides and booths for the annual carnival. \nBut this year things look really different. \nReally odd. \nReally scary");
            ReadKey();
            Clear();
            WriteLine("The place is lit up by a hundred fiery torches and spooky music is coming from the main tent.\nThen you meet Big Al, the creepy carnival manager.Hes invited you in to test some of the rides.");
            ReadKey();
            Clear();
            WriteLine("Will you brave the terrifying Supersonic Space Coaster? \nRisk the horrors of the Reptile Petting Zoo? \nSlice through the oily waters of Booger Bog?\n Or confront the evil Snake Lady? \n\nThe choice is yours!!");
 
        }
    }
}
