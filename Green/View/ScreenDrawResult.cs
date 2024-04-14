namespace Green.View
{
    internal class ScreenDrawResult : Screen
    {
        private bool statusScreenDraw;

        internal ScreenDrawResult(string title) : base(title) { }

        internal override bool ScreenLoop(List<List<int>> draw)
        {
            int count = 0;

            while (StatusLoop)
            {
                ShowHeader(ScreenTitle);

                Console.WriteLine(draw);
                Console.ReadKey();
            }

            return statusScreenDraw;
        }
    }
}
