using ProjetoGreenXGH.Screens;

namespace ProjetoGreenXGH.Utility
{
    public class Authentication
    {
        public bool Login(string usuario, string senha)
        {
            return UserValidation(usuario, senha);
        }

        static bool UserValidation(string usuario, string senha)
        {
            string[] linhas = File.ReadAllLines(@"C:\Users\eufra\Desenvolvimento\3-github\projeto-green\projeto-backend\ProjetoGreenXGH\Arquivos\credenciais.txt");

            foreach (string linha in linhas)
            {
                string[] credencial = linha.Split(',');
                string credencialUsuario = credencial[1];
                string credencialSenha = credencial[2];

                if (credencialUsuario == usuario && credencialSenha == senha)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
