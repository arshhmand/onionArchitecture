using System;
using System.Collections.Generic;

namespace MyFakeDatabaseProject.Models;

public class Order
{
    public Guid Id { get; set; }
    public DateTime? OrderDate { get; set; }
    public Status Status { get; set; }
    public Customer Customer { get; set; }
    public decimal TotalAmount { get; set; }
    public Address ShippingAddress { get; set; }
}
