namespace PazzleGame {
    class Move {
        public static Position To(Direction direction) {
            Position pos = new Position(0, 0);
            
            switch(direction) {
                case Direction.left:
                    pos.X -= 1;
                    break;
                case Direction.right:
                    pos.X += 1;
                    break;
                case Direction.down:
                    pos.Y += 1;
                    break;
                default:
                    break;
            }
            
            return pos;
        }
    }
}