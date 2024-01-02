namespace Green.Controller.Draw;

internal class DrawLotofacil : Draw
{
    private const int MinLotofacilNumber = 1;
    private const int MaxLotofacilNumber = 25;

    public override List<int> SimpleDraw()
    {
        List<int> drawnNumbers = new List<int>();

        drawnNumbers.Add(1);
        drawnNumbers.Add(2);
        drawnNumbers.Add(3);
        drawnNumbers.Add(4);
        drawnNumbers.Add(5);
        drawnNumbers.Add(6);

        return drawnNumbers;
    }

}
