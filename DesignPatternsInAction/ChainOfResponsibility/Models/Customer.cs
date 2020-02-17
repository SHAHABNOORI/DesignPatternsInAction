namespace ChainOfResponsibility.Models
{
    public class Customer
    {
        public int AccountValue { get; set; }

        public bool Active { get; set; }

        public int MaxDateValue { get; set; }

        public string Password { get; set; }
    }
}