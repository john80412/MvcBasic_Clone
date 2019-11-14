using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class MvcBasic_CloneContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MvcBasic_CloneContext() : base("name=MvcBasic_CloneContext")
        {
        }

        public System.Data.Entity.DbSet<MvcBasic_Clone.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<MvcBasic_Clone.Models.Family> Families { get; set; }
    }
}
