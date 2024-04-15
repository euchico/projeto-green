using Green.Utility;
using Green.View;

namespace Green;

class Green
{
    internal struct Game
    {
        internal Game(int id, string tag, string name)
        {
            Id = id;
            Tag = tag;
            Name = name;
        }

        internal int Id {  get; set; }
        internal string Tag {  get; set; }
        internal string Name {  get; set; }
    }

    protected static TextManager? TextContent { get; set; }
    internal static string UserRecordFilePath = DataFile.GetDataFilePath("UserRecord.txt");


    static void Main(string[] args)
    {
        new ScreenStart(TextContent?.GetTitle("ScreenTitleStart") ?? "Início").ScreenLoop();
    }

    internal static List<Game> GameList()
    {
        List<Game> gameList = new List<Game>();

        Dictionary<string, string> games = new Dictionary<string, string>()
        {
            {"diadesorte","Dia de Sorte"},
            {"duplasena", "Dupla Sena"},
            {"federal", "Federal"},
            {"loteca", "Loteca"},
            {"lotofacil", "Lotofácil"},
            {"lotogol", "Lotogol"},
            {"lotomania", "Lotomania"},
            {"maismilionaria", "+Milionária"},
            {"megasena", "Mega-Sena"},
            {"quina", "Quina"},
            {"supersete", "Super Sete"},
            {"timemania", "Timemania"}
        };

        int count = 0; 
        foreach (var game in games)
        {
            int id = count;
            string tag = game.Key;
            string name = game.Value;

            gameList.Add(new Game(id, tag, name));

            count++;
        }

        return gameList;
    }
}