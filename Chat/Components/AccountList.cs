using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorApp2.Components
{
    public static class AccountList
    {
        public static List<User> Users { get; set; } = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("Components//Users.txt"));

        public static void Get()
        {
            Users = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("Components//Users.txt"));
        }

        public static void Update(User user)
        {
            Users.Add(user);
            File.WriteAllText("Components//Users.txt", JsonConvert.SerializeObject(Users));
        }
    }
}
