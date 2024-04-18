namespace Green.Controller.Draw;

internal class DrawLotofacil : Draw
{
    private const int MinLotofacilNumber = 1;
    private const int MaxLotofacilNumber = 25;

    public override List<List<int>> SimpleDraw(int numberOfDraws)
    {
        List<List<int>> drawList = new List<List<int>>();
        List<int> drawSingle = new List<int>();
        Random random = new Random();
        int countDraws = 0, countNumbers = 0;

        while (countDraws < numberOfDraws)
        {
            while (countNumbers < 15) 
            {
                int pick = random.Next(MinLotofacilNumber, MaxLotofacilNumber + 1);

                if (!drawSingle.Contains(pick))
                {
                    drawSingle.Add(pick);
                    countNumbers++;
                }
            }

            drawList.Add(new List<int>(drawSingle));
            drawSingle.Clear();

            countNumbers = 0;
            countDraws++;
        }

        return drawList;
    }
}
