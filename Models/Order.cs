namespace OrderProcessingApp.Models
{
    public class Order
    {
        public decimal OrderAmount { get; set; }
        public required string CustomerType { get; set; }
        public decimal Discount { get; set; }
        public decimal FinalTotal { get; set; }

        public void CalculateDiscount()
        {
            if (OrderAmount >= 100 && CustomerType == "Loyal")
            {
                Discount = OrderAmount * 0.1m; // 10% discount
            }
            else
            {
                Discount = 0;
            }

            FinalTotal = OrderAmount - Discount;
        }

    }

}
