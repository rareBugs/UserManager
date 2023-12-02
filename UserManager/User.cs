using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace UserManager
{
    // All user related code and methods here to keep everything clean and easy to keep track of.
    // That includes Json because Json is saving the related user data created with the User class.

    public class User
    {
        private static List<User> usersList = new List<User>();

        public string Username { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        // Static constructor to initialize UsersList
        static User()
        {
            UsersList = new List<User>();
        }

        public User(string username, string department, string role)
        {
            Username = username;
            Department = department;
            Role = role;
        }

        public static List<User> UsersList { get; private set; }

        public static void AddUser(User user)
        {
            UsersList.Add(user);
        }

        // Save user data to a JSON file
        public static void SaveUserData(string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(UsersList);
            File.WriteAllText(filePath, jsonData);
        }

        // Load user data from a JSON file
        public static void LoadUserData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                UsersList = JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
        }
    }
}
