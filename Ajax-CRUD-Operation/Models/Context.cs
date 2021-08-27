using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Ajax_CRUD_Operation.Models
{
    public class Context: DbContext
    {
        public Context() : base("StringDBContext") { }
        public DbSet<Users> User { get; set; }
    }
}