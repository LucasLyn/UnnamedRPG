using System;
using UnnamedRPG.UI;

namespace UnnamedRPG {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Program running");
            Console.WriteLine("Printing menu...\n");

            string[] menuOptions = {"Play", "Credits", "Exit"};
            Menu menu = new Menu(menuOptions);

            menu.printMenu();
        }
    }
}