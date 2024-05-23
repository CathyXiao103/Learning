public class GameBoard
{
    public int Size { get; set; }
    public Dictionary<int, int> SnakeMap { get; set; }
    public Dictionary<int, int> LadderMap { get; set; }

    public GameBoard()
    {
        Size = 3;
        SnakeMap = new Dictionary<int, int>
        {
            { 5, 3 }
        };
        LadderMap = new Dictionary<int, int>
        {
            { 3, 8 }
        };
    }
}