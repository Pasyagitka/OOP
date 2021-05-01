namespace WPF11Lab.Models
{
    public class ClientsAddress
    {
        public int Id { get; set; }
        public string Country{ get; set; }
        public string City{ get; set; }
        public string Street{ get; set; }
        public int House{ get; set; }
        public int PostalCode { get; set; }
        
        public Client Client { get; set; }
    }
}