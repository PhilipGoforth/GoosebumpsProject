using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GoosebumpsReader
{
    class PlotSwitches
    {
        public static void PlotSwitch14()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Cannon..", "Choo-choo.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Cannon130();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Choo128();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch13()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Run down a different path", "Halloween Express.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.DiffPath5();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.HalloweenExpress108();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch12()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "It is Monday, Wednesday, Friday or Saturday..", "It is Tuesday, Thursday or Sunday.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Mon114();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Sun71();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch11()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Jump out..", "Urge the horse to gallop.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.JumpOut103();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Gallop.119();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch15()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "You can do it..", "You can't do it.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Can73();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Cant127();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch10()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Go to Halloween Express..", "Go to Mountain King.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.HalloweenExpress108();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.MountainKing107();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch9()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "If you think the words are karru marri odonna loma molonu karrano...", "If you think the words are oooopah lupah dummie dupah" };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Karru69();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Dupah82();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch8()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "You previously won Monster Blood...", "You dont have the Monster Blood..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.MonsterBlood97();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.NoBlood27();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch7()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Guess 44..", "Guess 74...", "Guess 124..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Page44();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Page74();
                    ReadKey();
                    Clear();
                    break;
                case 3:
                    Choices.Page124();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch16()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Follow Patty...", "Dont take the way out..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Left125();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Right.12();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch6()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Follow Patty...", "Dont take the way out..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.FollowPatty48();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.DontLeave86();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch5()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Pick slide 1, 4 or 5", "Pick slide 2, 7 or 9", "Pick slide 3, 6, 8 or 10" };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Slide121();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Slide95();
                    ReadKey();
                    Clear();
                    break;
                case 3:
                    Choices.Slide68();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch4()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Leave by the red door...", "Try the blue door..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.RedDoor();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.BlueDoor();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch3()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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
            string[] options = { "Follow dwarf...", "Not follow dwarf..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.FollowDwarf();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.NotFollowDwarf();
                    ReadKey();
                    Clear();
                    break;
            }
        }
    }
}
