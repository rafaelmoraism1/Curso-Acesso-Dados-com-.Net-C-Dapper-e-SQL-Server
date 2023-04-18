using Blog.Screens.CategoryScreens;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using Blog.Screens.PostScreens;
using Blog.Screens.RoleScreens;
using Microsoft.Data.SqlClient;

namespace Blog
{
    internal class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=Meiokilo1#331813;Trusted_Connection=False;TrustServerCertificate=True;";
        private static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Database.Connection.Close();

            Console.ReadKey();
        }

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("(1) Gestão de Usuário"); // User - ok
            Console.WriteLine("(2) Gestão de Perfil"); // Role - ok
            Console.WriteLine("(3) Gestão de Postagens"); // Post - ok
            Console.WriteLine("(4) Gestão de Categoria"); // Category - ok
            Console.WriteLine("(5) Gestão de Tag"); // Tag - ok
            Console.WriteLine("(6) Vincular Perfil/Usuário");
            Console.WriteLine("(7) Vincular Tag/Postagem");
            Console.WriteLine("(8) Relatórios");
            Console.WriteLine("(9) Encerrar Programa");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1: MenuUserScreen.Load(); break;
                case 2: MenuRoleScreen.Load(); break; //falta
                case 3: MenuPostScreen.Load(); break;
                case 4: MenuCategoryScreen.Load(); break;
                case 5: MenuTagScreen.Load(); break;
                case 6: DeleteTagScreen.Load(); break;
                case 7: DeleteTagScreen.Load(); break;
                case 8: DeleteTagScreen.Load(); break;
                case 9: System.Environment.Exit(0); break;
                default: Load(); break;
            }
        }

        //ReadUsers(connection); // AQUI O MÉTODO BUSCA TODOS OS DADOS (NESTE CASO OS NOMES) DA TABELA USER
        //ReadRoles(connection); // AQUI O MÉTODO BUSCA TODOS OS DADOS (NESTE CASO OS NOMES) DA TABELA ROLE
        //ReadTags(connection); // AQUI O MÉTODO BUSCA TODOS OS DADOS (NESTE CASO OS NOMES) DA TABELA TAGS
        //ReadUser(); // AQUI O MÉTODO BUSCA UM NOME ATRAVÉS DO SEU ID NA TABELA USER
        //CreateUser(); // AQUI É CRIADO UM USUÁRIO NO BANCO DE DADOS. CRIADO UMA VARIÁVEL COM OS DADOS A SEREM INSERIDOS
        //UpdateUser(); // AQUI É REALIZADO A ATUALIZAÇÃO DE ALGUM USUÁRIO. 
        //DeleteUser(); // AQUI É FEITA A EXCLUSÃO DE UM USUÁRIO

    }
}
