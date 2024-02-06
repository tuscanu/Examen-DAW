namespace Proiect_Backend.DTO
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public int ProfileId { get; set; }
        public string FullName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }

}
