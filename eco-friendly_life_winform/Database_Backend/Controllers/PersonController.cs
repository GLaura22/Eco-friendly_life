using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eco_friendly_life_winform.Database_Backend.Connection;
using eco_friendly_life_winform.Database_Backend.Tables;
using System.Security.Cryptography;

namespace eco_friendly_life_winform.Database_Backend.Controllers
{
    internal class PersonController
    {

        public int AddPerson(Person user)
        {
            try
            {
                /* SQL Connection. */
                var context = new AppDbContext();

                /* Insert data into Database. */
                context.Persons.Add(user);
                context.SaveChanges();

                /* Get last inserted ID. */
                var id = context.Persons.OrderBy(row => row.UserID).Last();

                /* Return the previously saved ID. */
                return id.UserID;
            }
            catch (Exception)
            {
                /* On error. */
                return 0; // Return 0 to easily check if there is a problem or not.
            }

        }

        
        public Person Login(string username, string password)
        {
            try
            {
                /* SQL Connection. */
                var context = new AppDbContext();

                /* Get user ID by the given username & password. */
                var data = context.Persons
                    .Single(row => row.UserName == username && row.Password == password);

                /* Get user by previously fetched ID. */
                var user = context.Persons
                    .Single(row => row.UserID == data.UserID);

                return user;
            }
            catch (Exception)
            {
                return new Person { UserID = 0, UserName = "", Password = ""};
            }
        }


        public string GetUsername(int userId)
        {
            string username = "";
            try
            {
                var context = new AppDbContext();

                // get username by the given id
                var data = context.Persons.Single(row => row.UserID == userId);

                username = data.UserName;

                return username;
            }
            catch
            {
                return username;
            }
        }

        public string Hash(string value)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(value);

            byte[] hashBytes;

            using (SHA256 sha256 = SHA256.Create())
            {
                hashBytes = sha256.ComputeHash(passwordBytes);
            }

            return Convert.ToBase64String(hashBytes);
        }

        public Person LoginHashVersion(string username, string password)
        {
            try
            {
                AppDbContext context = new();

                string passwordHash = Hash(password);

                Person felhasznalo = context.Persons
                    .Single(row => row.UserName == username && row.Password == passwordHash);

                return felhasznalo;
            }
            catch (Exception)
            {
                return new Person
                {
                    UserName = "",
                    Password = ""
                };
            }
        }

    }
}
