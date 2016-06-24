using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VideoStore.Models
{
    public class videos
    {
        public int ID { get; set; }


    }

    public class videosDBContext : DbContext
    {
        public videosDBContext() : base("VideoStoreEntities")
        {

        }
        public DbSet<videos> Albums { get; set; }
    }
}