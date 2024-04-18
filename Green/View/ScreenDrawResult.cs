namespace Green.View
{
    internal class ScreenDrawResult : Screen
    {
        private bool statusScreenDraw;

        internal ScreenDrawResult(string title) : base(title) { }

        protected internal override bool ScreenLoop(List<List<int>> draw)
        {
            while (StatusLoop)
            {
                ShowHeader(ScreenTitle);

                PrintResult(draw);
                Console.ReadKey();

                StatusLoop = false;
            }

            return statusScreenDraw;
        }

        private void PrintResult(List<List<int>> draw)
        {
            int countDraws = 0;

            foreach (var drawList in draw)
            {
                countDraws++;
                Console.Write($"#{(countDraws).ToString("00")}: ");

                foreach (var drawItem in drawList)
                {
                    
                    Console.Write($"{(drawItem).ToString("00")} ");
                }
                Console.WriteLine();
            }
        }
    }
}
