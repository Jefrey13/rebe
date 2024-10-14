﻿using Domain.Entities;

namespace Domain.Repositories; 
public interface IUserRepository : IRepository<User>
{
    Task<User> GetUserByEmailAsync(string email);
    Task<User> GetUserByPhoneNumberAsync(string phoneNumber);
}