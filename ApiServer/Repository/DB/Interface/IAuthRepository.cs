﻿using ApiServer.Model;
using ApiServer.Model.DTO;

namespace ApiServer.Repository.DB.Interface
{
    public interface IAuthRepository
    {
        Task<Account?> GetAccount(string email);
        Task CreateAsync(Account entity);        
        Task Update(Account entity);
    }
}
