using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace order_api.domain.Config
{ 
    public static class EntityConfigExtensions
    {
        public static ModelBuilder AddEntities(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityConfigExtensions).Assembly);

            return modelBuilder;
        }
    }
}
