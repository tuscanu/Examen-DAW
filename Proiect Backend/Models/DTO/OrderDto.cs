public class OrderDto
{
    public List<int> ProductIds { get; set; }
    public List<int> UserIds { get; set; }
    public int UserId { get; set; }
}

public class CreateOrderDto
{
    public List<int> ProductIds { get; set; }
    public int UserId { get; set; }
}

public class UpdateOrderDto
{
    public List<int> ProductIds { get; set; }
}
