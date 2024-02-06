public class UserDto
{
    public string Username { get; set; }
}

public class UserProfileDto
{
    public string FullName { get; set; }
}

public class CreateUserDto
{
    public string Username { get; set; }
    public string Password { get; set; }
    public UserProfileDto Profile { get; set; }
}

public class UpdateUserDto
{
    public string Username { get; set; }
    public UserProfileDto Profile { get; set; }
}
