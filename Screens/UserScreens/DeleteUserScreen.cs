using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar Usuário");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite o Id do Usuário que deseja Excluir: ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário Excluído com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o Usuário.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
