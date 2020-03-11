using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Practice.Entities.Customers;
using Practice.Entities.Items;

namespace Practice.Entities.Orders
{
    public class Order
    {
        public Order()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid OrderID { get; set; }

        [Required]
        public Guid CustomerID { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [MaxLength(128)]
        public string Description { get; set; }

        public ICollection<Item> Items { get; set; }

        public virtual Customer Customer { get; set; }
    }
}