using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace UserManager
{
    // All user related code and methods here to keep everything clean and easy to keep track of.
    // That includes Json because Json is saving the related user data created with the User class.

    public class User
    {
        public string Username { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        // Static constructor to initialize UsersList
        static User()
        {
            userList = new List<User>();
        }

        public User(string workername, string department, string role)
        {
            Username = workername;
            Department = department;
            Role = role;
        }

        public static List<User> userList { get; private set; }

        public static void AddUser(User user)
        {
            userList.Add(user);
        }

        // Save user data to a JSON file
        public static void SaveUserData(string filePath)
        {
            string jsonData = JsonConvert.SerializeObject(userList);
            File.WriteAllText(filePath, jsonData);
        }

        // Load user data from a JSON file
        public static void LoadUserData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                userList = JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
        }
    }
}
