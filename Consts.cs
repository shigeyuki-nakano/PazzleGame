namespace PazzleGame {
    class Consts {
        public const int FL_WIDTH      = 10;             // フィールドの横幅
        public const int FL_HEIGHT     = 20;             // フィールドの高さ
        public const int BD_WIDTH      = FL_WIDTH + 2;   // 壁も含めた横幅
        public const int BD_HEIGHT     = FL_HEIGHT + 2;  // 壁も含めた高さ
        public const int PZ_WIDTH      = 4;              // パズルの最大横幅
        public const int PZ_HEIGHT     = 4;              // パズルの最大高さ
        public const int PZ_TYPES      = 7;              // パズルの種類数
        public const int FALL_INTERVAL = 30;             // 落下間隔
        public const int MOVE_INTERVAL = 15;             // 左右移動間隔
        public const int ROT_INTERVAL  = 15;             // 回転間隔
    }
}