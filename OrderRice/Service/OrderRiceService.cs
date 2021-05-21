using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderRice.Data;
using OrderRice.Model;

namespace OrderRice.Service
{
  public class OrderRiceService
  {
    private OrderRiceContext _context;

    public OrderRiceService(OrderRiceContext context)
    {
      _context = context;
    }

    //-------------------Dish------------------------
    //get all dish
    public async Task<List<Dish>> GetDishAsync()
    {
      return await _context.Dish.ToListAsync();
    }

    //add Dish
    public async Task<bool> AddDishAsync(List<Dish> dish)
    {
      _context.Dish.AddRange(dish);
      await _context.SaveChangesAsync();
      return true;
    }

    //update Dish
    public async Task<bool> UpdateDishAsync(Dish dish)
    {
      _context.Dish.Update(dish);
      await _context.SaveChangesAsync();
      return true;
    }

    //delete Dish
    public async Task<bool> DeleteDishAsync(string id)
    {
      Dish dish = _context.Dish.Find(id);
      _context.Remove(dish);
      await _context.SaveChangesAsync();
      return true;
    }
    //delete all Dishes
    public async Task<bool> DeleteAllDishAsync()
    {
      List<Dish> dish = await GetDishAsync();
      _context.Dish.RemoveRange(dish);
      _context.SaveChanges();
      return true;
    }

    //-------------------User Order------------------------
    //get all User
    public async Task<List<User>> GetUserAsync()
    {
      return await _context.User.Include(c => c.dishs).ToListAsync();
    }

    //add User and add to UserThieu
    public async Task<bool> AddUserAsync(User user)
    {
      _context.User.Add(user);
      await _context.SaveChangesAsync();
      return true;
    }

    //update User
    public async Task<bool> UpdateUserAsync(User user)
    {
      _context.User.Update(user);
      await _context.SaveChangesAsync();
      return true;
    }

    //delete User
    public async Task<bool> DeleteUserAsync(string id)
    {
      User user = _context.User.Find(id);
      _context.Remove(user);
      await _context.SaveChangesAsync();
      return true;
    }

    //delete all Users
    public async Task<bool> DeleteAllUserAsync()
    {
      List<User> users = await GetUserAsync();
      _context.User.RemoveRange(users);
      await _context.SaveChangesAsync();
      return true;
    }
    //-------------------User Thieu------------------------
    //get all UserThieu
    public async Task<List<UserThieu>> GetUserThieuAsync()
    {
      return await _context.UserThieu.ToListAsync();
    }
    //add UserThieu
    public async Task<bool> AddUserThieuAsync(List<UserThieu> userThieu)
    {
      _context.UserThieu.AddRange(userThieu);
      await _context.SaveChangesAsync();
      return true;
    }
    //update UserThieu
    public async Task<bool> UpdateUserThieuAsync(UserThieu userThieu)
    {
      _context.UserThieu.Update(userThieu);
      await _context.SaveChangesAsync();
      return true;
    }
    //delete UserThieu
    public async Task<bool> DeleteUserThieuAsync(string id)
    {
      UserThieu userThieu = _context.UserThieu.Find(id);
      _context.Remove(userThieu);
      await _context.SaveChangesAsync();
      return true;
    }
    //-----------Yeuu Anh Nhat, Bop dit anh Minh, PenHouse voi anh Huy--------------------
  }
}
