namespace Green.Controller.General;

internal class LoginController
{
    internal bool UserValidation(string user, string password)
    {
        string[] lines = File.ReadAllLines(Green.UserRecordFilePath);

        foreach (string line in lines)
        {
            string[] credential = line.Split(',');
            string userCredential = credential[1];
            string passwordCredential = credential[2];

            if (userCredential == user && passwordCredential == password)
            {
                return true;
            }
        }

        return false;
    }
}
