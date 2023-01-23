namespace UnnamedRPG.UI {
    // A keyboard controllable menu object
    class Menu {
        private int selectedIndex;
        private string[] menuOptions;
        private string prompt;
        private string NON_SELECTED_OPTION_PREFIX = "  ";
        private string SELECTED_OPTION_PREFIX = "> ";

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
                Console.ForegroundColor = ConsoleColor.Green;
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
        ///Return value should never be less than 0.
        ///</returns>
        public int Run() {
            Console.Clear();
            printMenu();
            
            return selectedIndex;
        }
    }
}