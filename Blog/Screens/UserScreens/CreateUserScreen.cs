using Blog.Commands;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.TagScreens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Screens.UserScreens
{
    public class CreateUserScreen
    {
        public static void Load()
        {
            var user = new User();

            Console.Clear();
            Console.WriteLine("Nova usuário");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            user.Name = Console.ReadLine();

            Console.Write("E-mail: ");
            user.Email = Console.ReadLine();

            Console.Write("Bio: ");
            user.Bio = Console.ReadLine();

            Console.Write("Image URL: ");
            user.Image = Console.ReadLine();

            Console.Write("Slug: ");
            user.Slug = Console.ReadLine();

            UserCommands.Create(user);
            Console.ReadKey();
            TagScreen.Load();
        }
    }
}
