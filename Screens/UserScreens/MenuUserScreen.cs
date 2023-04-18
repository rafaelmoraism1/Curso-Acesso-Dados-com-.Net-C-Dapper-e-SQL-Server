namespace Blog.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Usuários");
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("(1) Listar Usuários");
            Console.WriteLine("(2) Cadastrar Usuário");
            Console.WriteLine("(3) Atualizar Usuário");
            Console.WriteLine("(4) Excluir Usuário");
            Console.WriteLine("(5) Retornar para Página Inicial");
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1: ListUserScreen.Load(); break;
                case 2: CreateUserScreen.Load(); break;
                case 3: UpdateUserScreen.Load(); break;
                case 4: DeleteUserScreen.Load(); break;
                case 5: Program.Load(); break;
                default: Load(); break;
            }
        }
    }
}