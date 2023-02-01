using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMSBlazor.Shared.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }
        [Column("ordername")]
        public string OrderName { get; set; } = null!;
        [Column("state")]
        public string State { get; set; } = null!;
        [Column("productname")]
        public string ProductName { get; set; } = null!;
        [Column("quantity")]
        public string Quantity { get; set; } = null!;
        [Column("type")]
        public string Type { get; set; } = null!;
        [Column("width")]
        public string Width { get; set; } = null!;
        [Column("height")]
        public string Height { get; set; } = null!;
    }
}
