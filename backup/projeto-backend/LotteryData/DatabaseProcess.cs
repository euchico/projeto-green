using LotteryData.Model;
using MySql.Data.MySqlClient;

namespace LotteryData;

internal class DatabaseProcess
{
    // verificar a loteria para realizar a consulta na tabela correta
    // verificar a último sorteio em banco 
    // realizar insert a partir dessa informação

    internal bool UpdateLotteryDatabase(LotteryResult[] lottery)
    {
        var connection = OpenConnection();

        if (connection != null) {
            OpenTable(connection, lottery);
        }

        return false;
    }

    internal MySqlConnection? OpenConnection()
    {
        try
        {
            Console.WriteLine("Database Connection");

            Console.Write("User:");
            string user = Console.ReadLine();

            Console.Write("Password:");
            string password = Console.ReadLine();

            string strConnection = $"server=localhost;uid={user};pwd={password};database=lottery";
            var connection = new MySqlConnection(strConnection);

            connection.Open();

            Console.WriteLine("Conexão realizada!");
            return connection;
        }
        catch
        {
            Console.WriteLine("Falha na conexão.");
            return null;
        }
    }

    internal void OpenTable(MySqlConnection connection, LotteryResult[] lottery)
    {
        string query = $"SELECT concurso FROM concurso{lottery.Last().Loteria} ORDER BY ID DESC LIMIT 1";

        if (connection != null)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            InsertResult(connection, dataReader, lottery);

            dataReader.Close();
            connection.Close();
        }

        Console.WriteLine("Banco Atualizado!");
    }

    internal void InsertResult(MySqlConnection connection, MySqlDataReader dataReader, LotteryResult[] lottery)
    {
        if (!dataReader.HasRows)
        {
            foreach (LotteryResult result in lottery)
            {
                string query =

                if (connection != null)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
            }
            
            
        }
    }

    internal string MakeInsert(LotteryResult lottery)
    {
        switch (lottery.Loteria)
        {
            case "":
                string insertResult = "INSERT INTO concursodiadesorte (id, concurso, data, local, mesSorte, observacao, acumulou, proximoConcurso, dataProximoConcurso, valorArrecadado, valorAcumuladoProximoConcurso, valorEstimadoProximoConcurso)";
                string valueResult = $" VALUES ({lottery.Concurso}, {lottery.Concurso}, {lottery.Data}, {lottery.Local}, {lottery.MesSorte}, {lottery.Observacao}, {lottery.Acumulou}, {lottery.ProximoConcurso}, {lottery.ProximoConcurso}, valorArrecadado, valorAcumuladoProximoConcurso, valorEstimadoProximoConcurso)";


                break;
            
        }


    }
}
