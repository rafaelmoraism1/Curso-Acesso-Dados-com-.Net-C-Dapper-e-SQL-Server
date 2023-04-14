using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar Tag");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite o Id da Tag que deseja Excluir: ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag Excluída com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a Tag.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
