using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GoosebumpsReader
{
    class Reader
    {
        public static void ReaderDies()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string prompt = @"
                        
                        ▓██   ██▓ ▒█████   █    ██    ▓█████▄  ██▓▓█████ ▓█████▄ 
                         ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▒██▀ ██▌▓██▒▓█   ▀ ▒██▀ ██▌
                          ▒██ ██░▒██░  ██▒▓██  ▒██░   ░██   █▌▒██▒▒███   ░██   █▌
                          ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░▓█▄   ▌░██░▒▓█  ▄ ░▓█▄   ▌
                          ░ ██▒▓░░ ████▓▒░▒▒█████▓    ░▒████▓ ░██░░▒████▒░▒████▓ 
                           ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒▒▓  ▒ ░▓  ░░ ▒░ ░ ▒▒▓  ▒ 
                         ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░     ░ ▒  ▒  ▒ ░ ░ ░  ░ ░ ▒  ▒ 
                         ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░     ░ ░  ░  ▒ ░   ░    ░ ░  ░ 
                         ░ ░         ░ ░     ░           ░     ░     ░  ░   ░    
                         ░ ░                           ░                  ░      

                                     What would you like to do?
                               (Use arrow keys and Enter to select.)";
            string[] options = { "Play Again", "Exit" };
            Menu DeadMenu = new Menu(prompt, options);
            int selectedIndex = DeadMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    MainStory.RunChoice();
                    break;
                case 1:
                    MainStory.ExitGame();
                    break;
            }
        }
        public static void TheEnd()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string prompt = @"
                           ▄▄▄▄▀ ▄  █ ▄███▄       ▄███▄      ▄   ██▄   
                        ▀▀▀ █   █   █ █▀   ▀      █▀   ▀      █  █  █  
                            █   ██▀▀█ ██▄▄        ██▄▄    ██   █ █   █ 
                           █    █   █ █▄   ▄▀     █▄   ▄▀ █ █  █ █  █  
                          ▀        █  ▀███▀       ▀███▀   █  █ █ ███▀  
                                       ▀                       █         
                                               
                                     What would you like to do?
                               (Use arrow keys and Enter to select.)";
            string[] options = { "Play Again", "Exit" };
            Menu EndMenu = new Menu(prompt, options);
            int selectedIndex = EndMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    MainStory.RunChoice();
                    break;
                case 1:
                    MainStory.ExitGame();
                    break;
            }
        }
    }
}
