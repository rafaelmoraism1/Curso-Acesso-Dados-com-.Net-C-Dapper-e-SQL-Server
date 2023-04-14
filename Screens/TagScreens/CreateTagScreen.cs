using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Tag");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag { Name = nome, Slug = slug });

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag Cadastrada com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar a Tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}