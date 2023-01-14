using BillGenerator.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BillGenerator.ViewModel
{
    public class BillViewModel
    {
        public int CustomerId{ get; set; }
        public string CustomerName { get; set; }
        public PaymentType PaymentType{ get; set; }
        public int ItemId { get; set; }
        public List<SelectListItem> ItemList { get; set; }
        public decimal ItemPrice { get; set; }
        public int Quantity { get; set; }
        public int DiscountPercentage { get; set; }
        public decimal Total { get; set; }
        public decimal GrandTotal { get; set; }
    }
}
