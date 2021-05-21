using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OrderRice.Model
{
  public class UserThieu
  {
    [Key]
    public string id { get; set; }
    public string name { get; set; }
    public int tienThieu { get; set; }
    public string ngayThieu { get; set; }
  }
}