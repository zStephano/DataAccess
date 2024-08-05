using Azure;
using Blog.Models;
using Blog.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Commands
{
    public class UserCommands
    {
        public static void Create(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Create(user);
                Console.WriteLine("Tag cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível salvar a tag");
                Console.WriteLine(ex.Message);
            }

        }

        public void Update(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar o usuário");
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(User user)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Update(user);
                Console.WriteLine("Usuário deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível deletar o usuário");
                Console.WriteLine(ex.Message);
            }
        }

        //public void ReadUser(Repository<User> repository)
        //{
        //    var user = repository.Read(2);
        //    Console.WriteLine(user?.Email);
        //}

        //public void ReadUsers(Repository<User> repository)
        //{
        //    var users = repository.Read();
        //    foreach (var item in users)
        //        Console.WriteLine(item.Email);
        //}

        public void ReadWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var users = repository.ReadWithRole();

            foreach (var user in users)
            {
                Console.WriteLine(user.Email);
                foreach (var role in user.Roles) Console.WriteLine($" - {role.Slug}");
            }
        }
    }
}
