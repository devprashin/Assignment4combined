﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Assignment4
{
    [Table("products")]
    public class Product
    {
        [Column("productid")]
        public int Id { get; set; }
        [Column("productname")]
        public string Name { get; set; }
        [Column("unitprice")]
        public int UntPrice { get; set; }
        [Column("quantityperunit")]
        public int QuantityPerUnit { get; set; }
        [Column("unitsinstock")]
        public int UnitsInStock { get; set; }
    }
}
