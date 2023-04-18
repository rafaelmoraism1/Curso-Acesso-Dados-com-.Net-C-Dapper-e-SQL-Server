using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Perfil");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine()!;
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Role { Name = nome, Slug = slug });

            Console.ReadKey();
            MenuRoleScreen.Load();
        }

        public static void Create(Role role)
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                repository.Create(role);
                Console.WriteLine("Perfil Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar p Perfil.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}