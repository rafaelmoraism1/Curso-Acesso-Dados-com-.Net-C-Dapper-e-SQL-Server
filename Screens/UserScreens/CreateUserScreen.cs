using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Novo Usuário");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Password: ");
            var password = Console.ReadLine();
            Console.WriteLine("Bio: ");
            var bio = Console.ReadLine();
            Console.WriteLine("Image: ");
            var image = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new User { Name = nome, Email = email, PasswordHash = password, Bio = bio, Image = image, Slug = slug });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Usuário Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar a Tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}