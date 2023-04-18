namespace Blog.Screens.PostScreens
{
    public static class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Postagens");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("(1) Listar Postagens");
            Console.WriteLine("(2) Cadastrar uma Postagem");
            Console.WriteLine("(3) Atualizar uma Postagem");
            Console.WriteLine("(4) Excluir uma Postagem");
            Console.WriteLine("(5) Retornar para Página Inicial");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1: ListPostScreen.Load(); break;
                case 2: CreatePostScreen.Load(); break;
                case 3: UpdatePostScreen.Load(); break;
                case 4: DeletePostScreen.Load(); break;
                case 5: Program.Load(); break;
                default: Load(); break;
            }
        }
    }
}