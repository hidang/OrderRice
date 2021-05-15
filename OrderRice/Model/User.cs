using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OrderRice.Model
{
  public class User
  {
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public List<Dish> dishs { get; set; }
    public string note { get; set; }
    public int tongTien { get; set; }
    public int tienDaNhan { get; set; }
  }
}