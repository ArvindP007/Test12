namespace BillGenerator.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum PaymentType
    {
        Cash,
        UPI
    }
}
