using System;

namespace FallingRocks
{
    class Player
    {
        public int _locationX;
        public int _locationY;
        public char _player;
        public ConsoleColor _playerColor;

        public Player(int locationX, int locationY, char player, ConsoleColor playerColor)
        {
            this._locationX = locationX;
            this._locationY = locationY;
            this._player = player;
            this._playerColor = playerColor;
        }
    }
}