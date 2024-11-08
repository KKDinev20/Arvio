﻿using Arvio.DAL.Enums;

namespace Arvio.DAL.Models;

public class User
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
    
    public ICollection<Order> Orders { get; set; } 
}