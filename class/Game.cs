using System;

namespace PazzleGame {
    class Game {
        private Field[,] _field = new Field[Consts.BD_HEIGHT, Consts.BD_WIDTH];
        private string _msg = "";
        private Position _pos;
        private Status _status;
        
        public Game() {
            for(int y = 0; y < Consts.BD_HEIGHT; y++) {
                for(int x = 0; x < Consts.BD_WIDTH; x++) {
                    this._field[y,x] = Field.empty;
                }
            }
            
            for(int y = 0; y < Consts.BD_HEIGHT; y++) {
                this._field[y,0] = Field.wall;
                this._field[y,(Consts.BD_WIDTH - 1)] = Field.wall;
            }
            
            for(int x = 0; x < Consts.BD_WIDTH; x++) {
                this._field[(Consts.BD_HEIGHT - 1),x] = Field.wall;
            }
            
            this._pos = new Position(1,0);
            this._status = Status.playing;
        }
        
        public void Start() {
            while(this._status != Status.end) {
                this.Display();
                Actions action = User.Action();
                this.Action(action);
            }
        }
        
        private void Display() {
            Console.Clear();
            
            if(this._status == Status.playing) {
                this.DisplayField();
            }
            
            this.DisplayMessage();
        }
        
        private void DisplayMessage() {
            if(this._status == Status.pause) {
                Console.WriteLine("\r\n\r\nIf you play game again, Please push P key!!");
            } else {
                Console.WriteLine();
                Console.WriteLine(this._msg);
            }
        }
        
        private void DisplayField() {
            for(int y = 0; y < Consts.BD_HEIGHT; y++) {
                string disp = "";
                
                for(int x = 0; x < Consts.BD_WIDTH; x++) {
                    if(this._pos.X == x && this._pos.Y == y) {
                        disp += "ｐ";
                    } else {
                        switch(this._field[y,x]) {
                            case Field.empty:
                                disp += "・";
                                break;
                            case Field.wall:
                                disp += "■";
                                break;
                        }
                    }
                }
                
                Console.WriteLine(disp);
            }
        }
        
        private void Action(Actions action) {
            switch(action) {
                case Actions.down:
                    this.Mover(Move.To(Direction.down));
                    break;
                case Actions.left:
                    this.Mover(Move.To(Direction.left));
                    break;
                case Actions.right:
                    this.Mover(Move.To(Direction.right));
                    break;
                case Actions.pause:
                    if(this._status == Status.pause) {
                        this._status = Status.playing;
                    } else {
                        this._status = Status.pause;
                    }
                    break;
            }
        }
        
        private void Mover(Position moveTo) {
            Position newPos = this._pos;
            
            newPos.Merge(moveTo);
            if( ! Validation.isOverRange(newPos)) {
                this._pos = newPos;
            }
        }
    }
}