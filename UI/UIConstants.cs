namespace UnnamedRPG.UI {
    class UIConstants {
        // fields

        ///<summary>
        ///Empty constructor for the Constants class.
        ///</summary>
        public UIConstants() {}

        ///<summary>
        ///Print the title (home) screen of the game.
        ///</summary>
        public static void PrintHomeStartScreen() {
            Console.WriteLine(@"    ██╗   ██╗███╗   ██╗███╗   ██╗ █████╗ ███╗   ███╗███████╗██████╗     ██████╗ ██████╗  ██████╗ 
    ██║   ██║████╗  ██║████╗  ██║██╔══██╗████╗ ████║██╔════╝██╔══██╗    ██╔══██╗██╔══██╗██╔════╝ 
    ██║   ██║██╔██╗ ██║██╔██╗ ██║███████║██╔████╔██║█████╗  ██║  ██║    ██████╔╝██████╔╝██║  ███╗
    ██║   ██║██║╚██╗██║██║╚██╗██║██╔══██║██║╚██╔╝██║██╔══╝  ██║  ██║    ██╔══██╗██╔═══╝ ██║   ██║
    ╚██████╔╝██║ ╚████║██║ ╚████║██║  ██║██║ ╚═╝ ██║███████╗██████╔╝    ██║  ██║██║     ╚██████╔╝
     ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝╚═════╝     ╚═╝  ╚═╝╚═╝      ╚═════╝ ");
        }

        ///<summary>
        ///Print the "About" page of the game.
        ///</summary>
        public static void PrintAboutPage() {
            Console.WriteLine(@"This project started as an attempt at a text
based RPG game. Development first began on the
23rd of January, 2023. I am not good with names,
and thus it's named as so. After developing
for a bit, I got an idea to release not only
the game, but also 2 libraries; the first
would be a general purpose but simple console
library, with the sole purpose of making
console programs easier to program. 
I wanted to name it something not inherntly
stupid, but also something that could be
remembered. I came up with 'Solaris'.
The 2nd library, which I wanted to name 'Lunar',
was to essentially do the same, but with
features helping with console based games
instead of general console applications.
Enjoy.");
        }
    }
}