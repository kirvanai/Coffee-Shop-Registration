using System;
using System.Collections.Generic;
using Coffee_Shop_Registration.Models;

namespace Coffee_Shop_Registration.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public string? Category { get; set; }
}
