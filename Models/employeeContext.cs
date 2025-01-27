using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FileUpload.Models
{
    public class employeeContext : DbContext
    {
        public DbSet<employee> employees { get; set; }
    }
}