using System;
using Blog.Commands;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class UpdateTagScreen
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