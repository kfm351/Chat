namespace BlazorApp2.Components
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid UserId { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            UserId = Guid.NewGuid();
        }
    }
}
