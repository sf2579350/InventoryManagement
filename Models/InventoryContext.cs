using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Models
{
    public class InventoryContext:DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
                : base(options)
        {
        }

        public DbSet<Inventory> Inventorys { get; set; }
    }
}
