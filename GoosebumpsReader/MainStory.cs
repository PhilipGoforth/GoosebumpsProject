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

                                           BY: R.L. STEIN

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
            WriteLine(@"
                            Late one night you and your friends Patty and Brad visit the old fairgrounds. 
                        They're putting up rides and booths for the annual carnival. 
                        But this year things look really different. Really odd. Really scary");
            ReadKey();
            Clear();
            WriteLine(@"
                            The place is lit up by a hundred fiery torches and spooky music is coming from the main tent.
                        Then you meet Big Al, the creepy carnival manager.Hes invited you in to test some of the rides.");
            ReadKey();
            Clear();
            WriteLine(@"
                            “I’m Big Al, the manager. And what I say around here goes.”
                       Big Al digs around in his checkered jacket and pulls out three maps. He hands one to each of you.
                       “Study them carefully,” he says. “If you have any questions, ask them now.”
                       Your eyes fall upon the map. You have a question. But when you gaze up, Big Al is gone.
                       He’s vanished!
                       “A whole carnival to ourselves!” Patty exclaims. “Where should we start?”
                       You stare down at your map once again. You notice that the carnival is split in half.
                       On one side are the rides. Tons of them. 
                       On the other side is the midway, packed with games of chance and the Freak Show.
                       What will you try first?");
            ReadKey();
            Clear();
            static void PlotAorB()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                string prompt = @"
                        88888888ba,    88888888888  ,ad8888ba,   88  88888888ba,    88888888888  
                        88        8b   88          d8        8b  88  88        8b   88           
                        88         8b  88         d8             88  88         8b  88           
                        88         88  88aaaaa    88             88  88         88  88aaaaa
                        88         88  88         88             88  88         88  88 
                        88         8P  88         Y8,            88  88         8P  88
                        88        88   Y8          .a8       de  88  88       a8P   88
                        88888888Y      88888888888    Y8888Ya    88  88888888Y      88888888888  

                                           What would you like to do?
                                    (Use arrow keys and Enter to select.)";
                string[] options = { "Test out creepy carnival rides..", "Play scary carnival games.." };
                Menu PlotChoose = new Menu(prompt, options);
                int selectedIndex = PlotChoose.Run();
                switch (selectedIndex)
                {
                    case 0:
                        PlotA.SideStory();
                        ReadKey();
                        Clear();
                        break;
                    case 1:
                        PlotB.SideStory();
                        ReadKey();
                        Clear();
                        break;
                }
            }
            PlotAorB();
            ReadKey();
            Clear();
        }
    }
}
