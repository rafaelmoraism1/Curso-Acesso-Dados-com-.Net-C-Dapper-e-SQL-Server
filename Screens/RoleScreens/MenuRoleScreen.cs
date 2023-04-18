namespace Blog.Screens.RoleScreens
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Perfis");
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
                case 1: ListRoleScreen.Load(); break;
                case 2: CreateRoleScreen.Load(); break;
                case 3: UpdateRoleScreen.Load(); break;
                case 4: DeleteRoleScreen.Load(); break;
                case 5: Program.Load(); break;
                default: Load(); break;
            }
        }
    }
}