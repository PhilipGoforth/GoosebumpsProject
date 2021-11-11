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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
                    Choices.Gallop119();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch15()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
                    Choices.Right12();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch6()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Leave by the red door...", "Try the Yellow door..." };
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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
                    Choices.NotFollowDwarf33();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Wait For Help...", "Hop out of car..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.WaitForHelp();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.LeaveCar();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Join Patty and Brad on Space Mountain", "Go to House of Horrors alone..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.SpaceCoaster();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.HouseofHorrors64();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch17()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "If it comes up heads take the Yellow door..", "If it comes up tails take the red door.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.BlueDoor();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.RedDoor();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch18()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Make a grab for the side of the bridge..", "Flap your arms and try to fly.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.BridgeGrab46();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Flap30();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch19()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Want to try the Boat Trip to nowhere..", "Ready for the house of horrors.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.BoatTrip88();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.HouseOfHorrors66();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch20()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Wait to be rescued..", "Swim for it.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.WaitRescue100();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Swim56();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch21()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Turn right..", "Turn left.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Right29();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Left118();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch22()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "You think its a robot and try to knock its head off..", "If you think its real.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.HeadOff81();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.RealMonster110();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch23()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Pick the red card..", "Pick the Yellow card.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.RedCard14();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.BlueCard59();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch24()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Guess your weight on mars..", "Play wheel of chance.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.WeightOnMars72();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.WheelOfChance8();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch25()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "If you think your mars weight is 37 to 39..", "If you think your Mars weight is less than 37.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.MarsWeightHigh53();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.MarsWeightLow22();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch26()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "If you havent tried the wheel of chance..", "If you have played the wheel of chance.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.WheelOfChance8();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.PlayedChance17();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch27()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Help the freaks..", "Dont help the freaks.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.HelpFreaks11();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.DontHelp113();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch28()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Escape through the door down the hall..", "Stay and talk to Al.." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Escape48();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Stay62();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch29()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Run to the left...", "Run to the right..." };
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
                    Choices.Right12();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch30()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Go with Al...", "Trust the snake lady..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.GoWithAl84();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.TrustSnake102();
                    ReadKey();
                    Clear();
                    break;
            }
        }
        public static void PlotSwitch31()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            string[] options = { "Its sunny outside...", "Its night outside..." };
            Menu PlotChoose = new Menu(prompt, options);
            int selectedIndex = PlotChoose.Run();
            switch (selectedIndex)
            {
                case 0:
                    Choices.Sunny45();
                    ReadKey();
                    Clear();
                    break;
                case 1:
                    Choices.Night85();
                    ReadKey();
                    Clear();
                    break;
            }
        }
    }
}
