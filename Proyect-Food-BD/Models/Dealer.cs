namespace Proyect_Food_BD.Models
{
    public class Dealer : User
    {
        public Dealer() 
        {
           // UserType = UserType.
        }
        public string MotorcycleName {  get; set; }
        public ICollection<Orders> Orders { get; set; } = new List<Orders>();
        
    }
}
