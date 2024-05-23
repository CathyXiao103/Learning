public class GameMap
{
    public int TilesCount { get; set; }
    public int[] Snakes { get; set; }
    public int[] Ladders { get; set; }

    public GameMap()
    {
        TilesCount = 72;
        Snakes = new int[] { 16, 47, 49, 56, 62, 64, 87, 93, 95, 98 };
        Ladders = new int[] { 1, 4, 9, 21, 28, 36, 51, 71, 80 };
    }
}
