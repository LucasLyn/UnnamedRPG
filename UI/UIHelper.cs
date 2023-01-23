namespace UnnamedRPG.UI {
    class UIHelper {
        //fields here

        ///<summary>
        ///Empty constructor for the UIHelper class.
        ///</summary>
        public UIHelper() {}

        ///<summary>
        ///Clears the given amount of lines in the console.
        ///This moves the cursor back the given amount of lines
        ///while clearing each one.
        ///Cursor is placed on the beginning of the last cleared line.
        ///<summary>
        ///<param name = "amount">
        ///Amount of lines to clear.
        ///</param>
        public static void ClearLines(int amount) {
            for (int i = 0; i < amount; i++) {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new String(' ', Console.BufferWidth));
            }
            // Set cursor postition to be on the last cleared line.
            Console.SetCursorPosition(0, Console.CursorTop);
        }
    }
}