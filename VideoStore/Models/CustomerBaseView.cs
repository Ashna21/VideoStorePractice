using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.Linq.Mapping;

using System.ComponentModel.DataAnnotations;

namespace VideoStore.Models
{
    [Table(Name = "Users")]
    public class CustomerBaseView
    {
        [Column(IsPrimaryKey = true)]
        public int UserId { get; set; }
        [Column]
        public string UserName { get; set; }
       
    }

    

}