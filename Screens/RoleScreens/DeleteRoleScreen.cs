using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class DeleteRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar Perfil");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite o Id do Perfil que deseja Excluir: ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Perfil Excluído com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o Perfil.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
