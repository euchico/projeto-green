using Lottery.View;

namespace Lottery;

class Lottery
{
    //public const string USER_FILE_PATH = @"C:\Users\eufra\Desenvolvimento\3-github\100diasdecodigo\GameBook\Data\UserRecord.txt";
    //public const string BOOK_FILE_PATH = @"C:\Users\eufra\Desenvolvimento\3-github\100diasdecodigo\GameBook\Data\BookRecord.txt";

    static void Main(string[] args)
    {
        //Screen mainScreen = new ScreenStart("início");
        //mainScreen.ScreenLoop();

        Screen screen = new();
        screen.ShowLogo();
        screen.ShowScreenTitle("Teste Teste");
    }
}