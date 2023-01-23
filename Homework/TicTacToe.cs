namespace TicTacToe
{
    public enum Tick
    {
        Empty,
        X,
        O
    }

    public struct Game
    {
        private const int MATRIX_SIZE = 4;
        private Tick[,] grid;
        private Tick currentPlayer;
        private static int turnCount = 0;

        public Game()
        {
            grid = new Tick[MATRIX_SIZE, MATRIX_SIZE];
            currentPlayer = Tick.X;
            FillGrid(Tick.Empty);
        }
        public void Play()
        {
            bool isGameOver = false;
            PrintGrid();

            currentPlayer = Tick.X;
            while (!isGameOver)
            {
                int selectedPoint = GetSelectedPoint();
                SetTick(currentPlayer, selectedPoint);
                PrintGrid();

                (int i, int j) = GetCoords(selectedPoint);
                if (CheckWin(currentPlayer, i, j))
                {
                    Console.WriteLine($"Winner is: {(currentPlayer == Tick.X ? "Player 1" : "Player 2")}");
                    isGameOver = true;
                }
                else if (IsDraw())
                {
                    Console.WriteLine("It's Draw");
                    isGameOver = true;
                }
                else
                {
                    currentPlayer = (currentPlayer == Tick.X) ? Tick.O : Tick.X;
                    ++turnCount;
                }
            }
        }
        private static bool IsDraw()
        {
            if (turnCount == MATRIX_SIZE * MATRIX_SIZE - 1)
                return true;
            return false;
        }

        private void FillGrid(Tick tick)
        {
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    grid[i, j] = tick;
                }
            }
        }

        private void PrintGrid()
        {
            for (int i = 0; i < MATRIX_SIZE; i++)
            {
                for (int j = 0; j < MATRIX_SIZE; j++)
                {
                    if (grid[i, j] == Tick.X)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X\t");
                        Console.ResetColor();
                    }
                    else if (grid[i, j] == Tick.O)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("O\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0}\t",i * MATRIX_SIZE + j + 1);
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }

        private int GetSelectedPoint()
        {
            bool isValid = false;
            int selectedPoint;
            do
            {
                Console.Write("Input point (1 - {0}): ", MATRIX_SIZE * MATRIX_SIZE);
                string input = Console.ReadLine();

                if (int.TryParse(input, out selectedPoint))
                {
                    if (CheckInputValue(selectedPoint) && IsEmpty(selectedPoint))
                        isValid = true;

                    else
                        Console.WriteLine("Invalid point. Please select a point between 1 and {0} that is empty.", MATRIX_SIZE * MATRIX_SIZE);

                }
                else
                    Console.WriteLine("Invalid input. Please enter a number between 1 and {0}.", MATRIX_SIZE * MATRIX_SIZE);

            } while (!isValid);

            return selectedPoint;
        }

        private static bool CheckInputValue(int value)
        {
            return value > 0 && value <= MATRIX_SIZE*MATRIX_SIZE;
        }

        private static (int i, int j) GetCoords(int point)
        {
            int i = (point - 1) / MATRIX_SIZE;
            int j = (point - 1) % MATRIX_SIZE;
            return (i, j);
        }

        private bool IsEmpty(int point)
        {
            (int i, int j) = GetCoords(point);
            return grid[i, j] == Tick.Empty;
        }

        private void SetTick(Tick tick, int point)
        {
            (int i, int j) = GetCoords(point);
            grid[i, j] = tick;
        }

        private bool CheckWin(Tick tick, int i, int j)
        {
            // check row
            if (IsWin(tick, i, 0, 0, 1))
                return true;

            // check column
            if (IsWin(tick, 0, j, 1, 0))
                return true;

            // check diagonal
            if (i == j && IsWin(tick, 0, 0, 1, 1))
                return true;

            // check anti-diagonal
            if (i + j == MATRIX_SIZE - 1 && IsWin(tick, 0, MATRIX_SIZE - 1, 1, -1))
                return true;

            return false;
        }

        private bool IsWin(Tick tick, int i, int j, int rowIncrement, int colIncrement)
        {
            for (int k = 0; k < MATRIX_SIZE; k++)
            {
                if (grid[i + k * rowIncrement, j + k * colIncrement] != tick)
                    return false;
            }
            return true;
        }
    }
    class Program
    {
        public static void Main()
        {
            Game game = new();
            game.Play();
        }
    }
}