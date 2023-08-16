
namespace ChessGame.Classes
{

    class Position
    {

        public int Line { get; set; }
        public int Column { get; set; }
        public int BundinhaGrande { get; set; }

        public Position(int line, int column)
        {

            Line = line;
            Column = column;
        }
    }
}
