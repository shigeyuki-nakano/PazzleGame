using System;

namespace PazzleGame {
    class User {
        public static Actions Action() {
            ConsoleKeyInfo action = Console.ReadKey();
            
            switch(action.Key) {
                case ConsoleKey.RightArrow:
                case ConsoleKey.L:
                    return Actions.right;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.H:
                    return Actions.left;
                case ConsoleKey.DownArrow:
                case ConsoleKey.K:
                    return Actions.down;
                case ConsoleKey.Spacebar:
                    return Actions.rollRight;
                case ConsoleKey.P:
                    return Actions.pause;
                default:
                    return Actions.unknown;
            }
        }
    }
}