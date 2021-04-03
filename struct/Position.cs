namespace PazzleGame {
    struct Position {
        private int _x;
        private int _y;
        
        public int X{
            get{ return this._x; }
            set{ this._x = value; }
        }
        public int Y{
            get{ return this._y; }
            set{ this._y = value; }
        }
        
        public Position(int x, int y) {
            this._x = x;
            this._y = y;
        }
        
        public void Merge(Position pos) {
            this.X = this._x + pos.X;
            this.Y = this._y + pos.Y;
        }
    }
}