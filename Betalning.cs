public class PayoutSystem
{
    public int CalculatePayout(Spelobject[,] grid, int bet)
    {
        int width = grid.GetLength(0);
        int height = grid.GetLength(1);

        int totalWin = 0;

        
        for (int y = 0; y < height; y++)
        {
            int streak = 1;

            for (int x = 1; x < width; x++)
            {
                if (grid[x, y].Type == grid[x - 1, y].Type)
                {
                    streak++;
                }
                else
                {
                    if (streak >= 3)
                    {
                        totalWin += bet * streak * grid[x - 1, y].Multiplier;
                    }

                    streak = 1;
                }
            }

           
            if (streak >= 3)
            {
                totalWin += bet * streak * grid[width - 1, y].Multiplier;
            }
        }

        return totalWin;
    }
}