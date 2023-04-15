using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public static class UpdateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Usuário");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine()!;
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

            Update(new User { Id = int.Parse(id), Name = nome, Email = email, PasswordHash = password, Bio = bio, Image = image, Slug = slug });

            Console.ReadKey();
            MenuUserScreen.Load();
        }

        public static void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Tag atualizada com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a Tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
