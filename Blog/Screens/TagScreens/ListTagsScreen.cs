using System;
using Blog.Commands;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            TagCommands.List();
            Console.ReadKey();
            TagScreen.Load();
        }
    }
}