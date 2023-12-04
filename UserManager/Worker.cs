using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace UserManager
{
    // All user related code and methods here to keep everything clean and easy to keep track of.
    // That includes Json because Json is saving the related user data created with the User class.

    public class Worker
    {
        private static List<Worker> usersList = new List<Worker>();

        public string Username { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }

        // Static constructor to initialize UsersList
        static Worker()
        {
            UsersList = new List<Worker>();
        }

        public Worker(string workername, string department, string role)
        {
            Username = workername;
            Department = department;
            Role = role;
        }

        public static List<Worker> UsersList { get; private set; }

        public static void AddUser(Worker user)
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
                UsersList = JsonConvert.DeserializeObject<List<Worker>>(jsonData);
            }
        }
    }
}
