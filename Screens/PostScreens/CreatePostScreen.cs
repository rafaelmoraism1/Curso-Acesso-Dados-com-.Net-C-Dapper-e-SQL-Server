using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Postagem ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Id: ");
            var id = Console.ReadLine()!;
            Console.WriteLine("CategoriaId: ");
            var categoryId = Console.ReadLine()!;
            Console.WriteLine("AutorId: ");
            var authorId = Console.ReadLine()!;
            Console.WriteLine("Título: ");
            var title = Console.ReadLine();
            Console.WriteLine("Sumário: ");
            var summary = Console.ReadLine();
            Console.WriteLine("Texto: ");
            var body = Console.ReadLine();
            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Post { Id = int.Parse(id), CategoryId = int.Parse(categoryId), AuthorId = int.Parse(authorId), Title = title, Summary = summary, Body = body, Slug = slug });

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Postagem Cadastrada com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível cadastrar a Postagem.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}