using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OrderRice.Model
{
    public class User
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string dish { get; set; }
        public string note { get; set; }
        public int tongTien { get; set; }
        public int tienDaNhan { get; set; }
    }
}