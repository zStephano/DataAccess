using System;
using Blog.Commands;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            var tag = new Tag();

            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            tag.Name = Console.ReadLine();

            Console.Write("Slug: ");
            tag.Slug = Console.ReadLine();

            TagCommands.Create(tag);
            Console.ReadKey();
            TagScreen.Load();
        }


    }
}