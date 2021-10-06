﻿using System;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class Order : BaseEntity
    {
        public string BuyerId { get; set; }
        public DateTimeOffset OrderDate { get; set; } = DateTimeOffset.Now;
        public Address ShipToAddress { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
