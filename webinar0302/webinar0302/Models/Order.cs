using System;
using System.Collections.Generic;

namespace webinar0302.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string? Customer { get; set; }
        public string? Staff { get; set; }
        public string? Product { get; set; }
        public int? Unitprice { get; set; }
        public int? Number { get; set; }
        public int? Price { get; set; }
    }
}
