using ChessGame.Game.Enums;

namespace ChessGame.Game
{

    class Piece
    {

        public Position Position { get; set; }

        public Color Color { get; set; }

        public int QtdMovements { get; set; }

        public Board Board { get; set; }

        Piece(Position position, Board board, Color color)
        {

            Position = position;
            Board = board;
            Color = color;
            QtdMovements = 0;
        }
    }
}
