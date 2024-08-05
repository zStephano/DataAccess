using Blog.Models;
using Blog.Screens.TagScreens;
using Blog.Screens.UserScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            WriteMenuOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }


        public static void WriteMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("Meu Blog");
            Console.WriteLine("-----------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil"); // Role
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            //Console.WriteLine("5 - Vincular perfil/usuário"); // User x Role
            //Console.WriteLine("6 - Vincular post/tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine();
            Console.Write("Opção: ");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: UserScreen.Load(); break;
                //case 2: RoleScreen.Load(); break;
                //case 3: CategoryScreen.Load(); break;
                case 4: TagScreen.Load(); break;
                //case 5: UserScreen.LinkLoad(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}
