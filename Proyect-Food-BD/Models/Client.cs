namespace Proyect_Food_BD.Models
{
    public class Client : User
    {
        public Client() : base() 
        {
           // UserType = UserType = UserType.
        }
        public string Adress {  get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();

    }
}
