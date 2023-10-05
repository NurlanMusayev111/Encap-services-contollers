using Methods_Constructor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Constructor
{
    internal class UserService
    {
        public void ShowUsers()
        {
            var result = GetAllUsers();

            foreach (var user in result)
            {
                Console.WriteLine(user.fullName);
            }
        }


        public User GetUserByİd(int id)
        {
            User[] users = GetAllUsers();

            User user = users.FirstOrDefault(m => m.id == id);

            return user;
        }


        public User[] GetAllUsers()
        {
            User user1 = new User
            {
                id = 1,
                fullName = "Nurlan Musayev",
                age = 21
            };

            User user2 = new User
            {
                id = 2,
                fullName = "Nermin Musayeva",
                age = 29
            };

            User user3 = new User
            {
                id = 3,
                fullName = "Gunel Veliyeva",
                age = 31
            };

            User user4 = new User
            {
                id = 4,
                fullName = "Nermin Nerimanli",
                age = 18
            };

            User[] people = { user1, user2, user3, user4 };

            return people;
        }
    }
}
