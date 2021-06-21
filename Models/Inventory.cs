using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Inventory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Quantity{ get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
