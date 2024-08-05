using Blog.Models;
using Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Commands
{
    public class TagCommands
    {
        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
        public static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag exluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível exluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
