namespace Exercicio033.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Client()
        {
        }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;
        }
        public Client(string name, string email, int room) : this(name, email)
        {
            Room = room;
        }
    }
}
