namespace WPF11Lab
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}