using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public static class UpdatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Postagem");
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

            Update(new Post { Id = int.Parse(id), CategoryId = int.Parse(categoryId), AuthorId = int.Parse(authorId), Title = title, Summary = summary, Body = body, Slug = slug });

            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Update(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Update(post);
                Console.WriteLine("Postagem atualizada com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a Postagem.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
