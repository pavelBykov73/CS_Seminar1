using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_62
{
    public class ArrayFiller
    {
        Position pos;
        Direction dir = Direction.Rigt;
        const int maxRotates = 4;
        int[,]? matrix = null;
        bool ChekAvailable(Position pos)
        {
            if (matrix == null) { return false; }
            if (pos.r < matrix.GetLength(0)
                && pos.c < matrix.GetLength(1)
                && pos.r >= 0
                && pos.c >= 0
                && matrix[pos.r, pos.c] == 0) return true;
            else return false;
        }

        Position NextPosition()
        {
            Position nextPos = pos;
            switch (dir)
            {
                case Direction.Rigt:
                    nextPos.c++;
                    break;
                case Direction.Down:
                    nextPos.r++;
                    break;
                case Direction.Left:
                    nextPos.c--;
                    break;
                case Direction.Up:
                    nextPos.r--;
                    break;
            }
            return nextPos;
        }
        Direction NextDirection()
        {
            if (dir == Direction.Rigt) return Direction.Down;
            if (dir == Direction.Down) return Direction.Left;
            if (dir == Direction.Left) return Direction.Up;
            if (dir == Direction.Up) return Direction.Rigt;
            return Direction.Rigt;
        }
        bool Move()
        {
            bool success = false;
            for (int i = 0; i < maxRotates; i++)
            {
                if (ChekAvailable(NextPosition()))
                {
                    pos = NextPosition();
                    success = true;
                    break;
                }
                else
                {
                    dir = NextDirection();
                }
            }
            return success;
        }

        public void FillMatrixSnail(int[,] arr)
        {
            int val = 1;
            pos.r = 0;
            pos.c = 0;
            if (arr.Length < 1) return;
            matrix = arr;
            matrix[pos.r, pos.c] = val;
            while (Move())
            {
                val++;
                matrix[pos.r, pos.c] = val;
            }
        }
        enum Direction
        {
            Rigt,
            Down,
            Left,
            Up
        };
        struct Position
        {
            public int r;
            public int c;
        };
    }
}
