using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebTime7.Models;

namespace WebTime7.Context
{
    public class RespContext:DbContext
    {
        public DbSet<TrasportModel> trasporte { get; set; }
        public RespContext():base("Data Source=192.168.0.157;Initial Catalog=Time7;Persist Security Info=True;User ID=time7;Password=123321@")
        {

        }
    }
}
