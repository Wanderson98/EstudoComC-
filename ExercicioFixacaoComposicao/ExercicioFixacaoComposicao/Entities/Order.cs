using System.Text;
using System.Globalization;
using ExercicioFixacaoComposicao.Entities.Enums;


namespace ExercicioFixacaoComposicao.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


        public Order() 
        { 
        }
        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;    
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }
        public double TotalOrdem()
        {
            double sum = 0;
            foreach(OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;

        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary");
            sb.AppendLine("Order Moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items");
            foreach (OrderItem c in OrderItems)
            {
                sb.AppendLine(c.ToString());
            }
            sb.AppendLine("Total Price: $ " + TotalOrdem().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }


    }
}
