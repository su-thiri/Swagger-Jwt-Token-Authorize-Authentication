namespace MyTokenTest
{
    public class User
    {
        public string UserName { get; set; } = string.Empty;    
        public byte[] passwordHash { get; set; }    
        public byte[] passwordSalt { get; set; }
    }
}
