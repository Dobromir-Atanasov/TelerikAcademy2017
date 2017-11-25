using System;

namespace BishopPathFinder
{
    public struct Point
    {
        private int v1;
        private int v2;

        public Point(int v1, int v2) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }

    class BishopPathFinder
    {
        public static bool[,] matrix;
        public static Point currentPosition = new Point(0,0);
        static void Main()
        {
            int totalSum = 0;
            string[] inputToken = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int matrixDimRow = int.Parse(inputToken[0]);
            int matrixDimCol = int.Parse(inputToken[1]);
            matrix = new bool[matrixDimRow, matrixDimCol];
            inputToken = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int numberOfInputs = int.Parse(inputToken[0]);
            for (int i = 0; i < numberOfInputs; i++)
            {
                inputToken = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                int moves = int.Parse(inputToken[1]);
                switch (inputToken[0])
                {
                    case "UR":
                        totalSum += moveUR(moves);
                        break;
                    case "RU":
                        totalSum += moveUR(moves);
                        break;
                    case "LU":
                        totalSum += moveUL(moves);
                        break;
                    case "UL":
                        totalSum += moveUL(moves);
                        break;
                    case "DL":
                        totalSum += moveDL(moves);
                        break;
                    case "LD":
                        totalSum += moveDL(moves);
                        break;
                    case "RD":
                        totalSum += moveDR(moves);
                        break;
                    case "DR":
                        totalSum += moveDR(moves);
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(totalSum);
        }
        static int moveDR(int moves)
        {
            int result = 0;
            for (int i = 1; i < moves; i++)
            {
                if (!matrix[currentPosition.X, currentPosition.Y])
                {
                    result += (currentPosition.X * 3 + currentPosition.Y * 3);
                    matrix[currentPosition.X, currentPosition.Y] = true;
                }
                if (currentPosition.X == matrix.GetLength(0) - 1 || currentPosition.Y == matrix.GetLength(1) - 1
                    ||currentPosition.X==0||currentPosition.Y==0)
                {
                    break;
                }
                currentPosition.X++;
                currentPosition.Y--;
            }
            return result;
        }

        static int moveDL(int moves)
        {
            int result = 0;
            for (int i = 1; i < moves; i++)
            {
                if (!matrix[currentPosition.X, currentPosition.Y])
                {
                    result += (currentPosition.X * 3 + currentPosition.Y * 3);
                    matrix[currentPosition.X, currentPosition.Y] = true;
                }
                if (currentPosition.X == matrix.GetLength(0) - 1 || currentPosition.Y == matrix.GetLength(1) - 1)
                {
                    break;
                }
                currentPosition.X--;
                currentPosition.Y--;
            }
            return result;
        }
        static int moveUL(int moves)
        {
            int result = 0;
            for (int i = 1; i < moves; i++)
            {
                if (!matrix[currentPosition.X, currentPosition.Y])
                {
                    result += (currentPosition.X * 3 + currentPosition.Y * 3);
                    matrix[currentPosition.X, currentPosition.Y] = true;
                }
                if (currentPosition.X == matrix.GetLength(0) - 1 || currentPosition.Y == matrix.GetLength(1) - 1)
                {
                    break;
                }
                currentPosition.X--;
                currentPosition.Y++;
            }
            return result;
        }

        static int moveUR(int moves)
        {
            int result = 0;
            for (int i = 1; i < moves; i++)
            {
                if (!matrix[currentPosition.X, currentPosition.Y])
                {
                    result += (i * 3 + i * 3);
                    matrix[currentPosition.X, currentPosition.Y] = true;
                }
                if (currentPosition.X==matrix.GetLength(0)-1||currentPosition.Y==matrix.GetLength(1)-1)
                {
                    break;
                }
                currentPosition.X++;
                currentPosition.Y++;
            }
            return result;
        }
    }
}
