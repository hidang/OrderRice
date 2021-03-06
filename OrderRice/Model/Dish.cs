using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OrderRice.Model
{
    public class Dish
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string note { get; set; }
        public int gia { get; set; }
        public int giaDoAn { get; set; }
        public List<User> users { get; set; }
    }
}
