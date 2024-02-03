namespace Proiect_Backend.DTO
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<UserOrder> UserOrders { get; set; } 
    }

    public class UserOrder
    {
        public int UserId { get; set; }
        public User User { get; set; } 
        public int OrderId { get; set; }
        public Order Order { get; set; } 
    }

}
