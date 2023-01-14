const char EMPTY = '-';

const Tick firstPlayer = Tick.X;
const Tick secondPlayer = Tick.O;
Tick[,] grid = new Tick[3,3];

GameProcess gameState = GameProcess.Playing;
int turn = 0;

void PrintGrid(Tick[,] grid)
{
    for(int i = 0; i < grid.GetLength(0); ++i)
    {
        for(int j = 0; j < grid.GetLength(1); ++j)
        {
            Console.Write("{0} \t", grid[i, j] == Tick.EMPTY ? EMPTY : grid[i, j]);
        }
        Console.WriteLine();
    }
}

void GetMove(Tick[,] grid, ref int turn)
{
    Console.WriteLine("Player {0} turn. Enter the coordinates: ", turn % 2 == 0 ? 1 : 2);
    string input;
    int i = -1; 
    int j = -1;
    input = Console.ReadLine();
    if (input.Length != 3 || input[1] != ',' || !char.IsDigit(input[0]) || !char.IsDigit(input[2])) //Check Format
    {
        Console.WriteLine("Wrong Format");
        GetMove(grid, ref turn);
        return;
    }

    i = int.Parse(input[0].ToString());
    j = int.Parse(input[2].ToString());

    if (i < 0 || i > 2 || j < 0 || j > 2) //Check Coordinates
    {
        Console.WriteLine("Wrong Coordinates");
        GetMove(grid, ref turn);
        return;
    }
    
    if (grid[i,j] != Tick.EMPTY) //Check Availability
    {
        Console.WriteLine("Invalid Move! Try Again");
        GetMove(grid, ref turn);
        return;
    }

    grid[i, j] = turn % 2 == 0 ? firstPlayer : secondPlayer;
    SetCheckGameState(grid, grid[i, j], i, j, turn);
    ++turn;
}

bool isWinner(Tick[,] grid, Tick player, int i, int j)
{
    bool result = CheckHorizontally(grid, player, i, j);
    if (result)
        return true;
    
    result = CheckVertically(grid, player, i, j);
    if (result)
        return true;

    result = CheckDiagonally(grid, player);
    if (result)
        return true;

    return false;
}
bool CheckHorizontally(Tick[,] grid, Tick player, int i, int j)
{
    for (int k = 0; k <= 2; ++k)
    {
        if (k == j)
            continue;
        if (grid[i, k] != player)
            return false;
    }
    return true;
}
bool CheckVertically(Tick[,] grid, Tick player, int i, int j)
{
    for (int k = 0; k <= 2; ++k)
    {
        if (k == i)
            continue;
        if (grid[k, j] != player)
            return false;
    }
    return true;
}
bool CheckDiagonally(Tick[,] grid, Tick player)
{
    if (grid[1, 1] != player)
        return false;
    
    if ((grid[0,0] == grid[2,2] && grid[0,0] == player) || (grid[2,0] == grid[0,2] && grid[2,0] == player))
        return true;
    return false;
}

void SetCheckGameState(Tick[,] grid, Tick player, int i, int j, int turn)
{
    if (isWinner(grid, player, i, j))
    {
        Console.WriteLine("Player {0} has won the game!", player == Tick.X ? 1 : 2);
        gameState = GameProcess.HasWinner;
    }
    else if (turn == 8) //Last move was taken and there is no winner
    {
        Console.WriteLine("It's Draw!");
        gameState = GameProcess.Draw;
    }
    else
        gameState = GameProcess.Playing;
}

while (true)
{
    PrintGrid(grid);
    GetMove(grid, ref turn);
    if (gameState != GameProcess.Playing)
    {
        PrintGrid(grid);
        break;
    }

}

enum GameProcess
{
    Playing,
    HasWinner,
    Draw
}

enum Tick
{
    EMPTY,
    X,
    O
}