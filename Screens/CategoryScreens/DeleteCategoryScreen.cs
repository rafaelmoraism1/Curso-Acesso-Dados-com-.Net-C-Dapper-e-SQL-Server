using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public static class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar Categoria");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite o Id da Categoria que deseja Excluir: ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria Excluída com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a Categoria.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
