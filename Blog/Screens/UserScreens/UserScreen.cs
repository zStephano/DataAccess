using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreens
{
    public class UserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de usuários");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar tags");
            Console.WriteLine("3 - Atualizar tag");
            Console.WriteLine("4 - Excluir tag");
            Console.WriteLine();
            Console.Write("Opção: ");

            var option = short.Parse(Console.ReadLine());

            HandleUserOption(option);
        }

        public static void HandleUserOption(short option)
        {
            switch (option)
            {
                case 1: 
                    ListUsersScreen.Load(); 
                    break;
                case 2: 
                    CreateUserScreen.Load(); 
                    break;
                case 3: 
                    UpdateUserScreen.Load(); 
                    break;
                case 4: 
                    DeleteUserScreen.Load(); 
                    break;
                case 0:
                    {
                        Console.Clear();
                        Menu.Show();
                        break;
                    }
                default: Load(); break;
            }
        }
    }
}
