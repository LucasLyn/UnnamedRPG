namespace UnnamedRPG.UI {
    // A keyboard controllable menu object
    class Menu {
        private int selectedIndex;
        private string[] menuOptions;
        private string prompt;
        private string NON_SELECTED_OPTION_PREFIX = "  ";
        private string SELECTED_OPTION_PREFIX = "> ";
        private ConsoleColor SELECTED_OPTION_COLOR = ConsoleColor.Green;

        ///<summary>
        ///Menu without a string prompt.
        ///</summary>
        public Menu(string[] menuOptions) {
            this.menuOptions = menuOptions;
            this.prompt = ""; // Empty prompt string
            selectedIndex = 0;
        }

        ///<summary>
        ///Menu with a string prompt to be printed before the menu options.
        ///</summary>
        public Menu(string[] menuOptions, string prompt) {
            this.menuOptions = menuOptions;
            this.prompt = prompt;
            selectedIndex = 0;
        }

        ///<summary>
        ///Prints the whole menu.
        ///</summary>
        private void printMenu() {
            if (prompt.Length > 0) {
                Console.WriteLine($"{prompt}\n");
            }

            for (int i = 0; i < menuOptions.Length; i++) {
                printMenuOption(menuOptions[i], i);
            }
        }

        ///<summary>
        ///Prints a singular menu option.
        ///Prints a prefix and color on the currently selected option.
        ///</summary>
        ///<param name="option">
        ///The menu option to print.
        ///</param>
        ///<param name="index">
        ///The index of the passed menu option.
        ///</param>
        private void printMenuOption(string option, int index) {
            if (selectedIndex == index) {
                Console.ForegroundColor = SELECTED_OPTION_COLOR;
                Console.Write($"{SELECTED_OPTION_PREFIX}");
            } else {
                Console.Write($"{NON_SELECTED_OPTION_PREFIX}");
            }

            Console.WriteLine($"{option}");

            Console.ResetColor();
        }


        ///<summary>
        ///Run the menu object.
        ///</summary>
        ///<returns>
        ///An int corresponding to the currently selected index.
        ///Returns -1 if Backspace has been pressed.
        ///Return value should never be less than -1.
        ///</returns>
        public int Run() {
            ConsoleKey pressedKey = default(ConsoleKey);

            do {
                // If pressedKey haven't been assigned, don't clear any lines
                if (pressedKey != default(ConsoleKey)) {
                    UIHelper.ClearLines(menuOptions.Length);
                }
                
                printMenu();

                // Get the pressed key
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                pressedKey = keyInfo.Key;

                // Update the selected index
                switch (pressedKey) {
                    case ConsoleKey.UpArrow:
                        selectedIndex--;
                        break;
                    
                    case ConsoleKey.DownArrow:
                        selectedIndex++;
                        break;
                    
                    default:
                        break;
                }

                // Check edges to not go out of bounds of the menu
                if (selectedIndex < 0) {
                    selectedIndex = 0;
                } else if (selectedIndex >= menuOptions.Length) {
                    selectedIndex = menuOptions.Length - 1;
                }
            } while (pressedKey != ConsoleKey.Enter &&
                    pressedKey != ConsoleKey.Backspace);
            

            return selectedIndex;
        }
    }
}