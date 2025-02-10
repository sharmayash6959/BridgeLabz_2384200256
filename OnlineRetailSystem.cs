using System;

// Base class: Order
class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order placed";
    }
}

// Subclass: ShippedOrder
class ShippedOrder : Order
{
    public string TrackingNumber { get; set; }

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order shipped";
    }
}

// Subclass: DeliveredOrder
class DeliveredOrder : ShippedOrder
{
    public DateTime DeliveryDate { get; set; }

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate) 
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order delivered";
    }
}

class OnlineRetailSystem
{
    static void Main()
    {
        Order order = new Order(1001, DateTime.Now);
        ShippedOrder shippedOrder = new ShippedOrder(1002, DateTime.Now, "TRK123456");
        DeliveredOrder deliveredOrder = new DeliveredOrder(1003, DateTime.Now, "TRK654321", DateTime.Now.AddDays(3));

        Console.WriteLine("Order ID: "+order.OrderId+", Status: "+order.GetOrderStatus());
        Console.WriteLine("Order ID: "+shippedOrder.OrderId+", Tracking: "+shippedOrder.TrackingNumber+", Status: "+shippedOrder.GetOrderStatus());
        Console.WriteLine("Order ID: "+deliveredOrder.OrderId+", Tracking: "+deliveredOrder.TrackingNumber+", Delivery Date: "+deliveredOrder.DeliveryDate+", Status: "+deliveredOrder.GetOrderStatus());
    }
}
