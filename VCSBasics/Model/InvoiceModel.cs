using System.Collections.Generic;

namespace VCSBasics.Model
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public int InvoiceNumber { get; set; }
        public ContactModel Customer { get; set; }
        public List<InvoiceDetailsModel> Details { get; set; }

        public InvoiceModel()
        {
            Details = new List<InvoiceDetailsModel>();
        }
    }

    public abstract class InvoiceDetailsModel
    {
        public int Id { get; set; }
        public ItemModel Item { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
    }
}