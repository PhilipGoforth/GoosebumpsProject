using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace GoosebumpsReader
{
    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;

        }

        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string selector;

                if (i == SelectedIndex)
                {
                    selector = "                                      =>";
                    ForegroundColor = ConsoleColor.Magenta;

                }
                else
                {
                    selector = "                                         ";
                    ForegroundColor = ConsoleColor.White;
                }
                WriteLine($"{selector}<<{currentOption}>>");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow && SelectedIndex > 0)
                {
                    SelectedIndex--;
                }
                else if (keyPressed == ConsoleKey.DownArrow && SelectedIndex < 2)
                {
                    SelectedIndex++;
                }


            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
