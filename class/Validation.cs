namespace PazzleGame {
    class Validation {
        public static bool isOverRange(Position pos) {
            if((Consts.BD_WIDTH - 1) > pos.X && 0 < pos.X) {
                if((Consts.BD_HEIGHT - 1) > pos.Y && 0 <= pos.Y) {
                    return false;
                }
            }
            
            return true;
        }
    }
}