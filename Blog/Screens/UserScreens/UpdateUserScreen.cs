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
    public class UpdateUserScreen
    {
        public static void Load()
        {
            var tag = new Tag();

            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            tag.Id = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            tag.Name = Console.ReadLine();

            Console.Write("Slug: ");
            tag.Slug = Console.ReadLine();

            TagCommands.Update(tag);
            Console.ReadKey();
            TagScreen.Load();
        }
    }
}
