namespace Green.Controller.General;

internal class UserController
{
    public void CreateUser(string user, string password)
    {

        string[] lines = File.ReadAllLines(Green.UserRecordFilePath);
        int lastId = int.Parse(lines.Last().Split(",")[0]);

        string userRecord = $"{lastId + 1},{user},{password}";

        //Tratar exceção
        File.AppendAllText(Green.UserRecordFilePath, Environment.NewLine + userRecord);
    }
}
