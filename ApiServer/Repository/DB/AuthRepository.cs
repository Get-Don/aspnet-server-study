using ApiServer.Data;
using ApiServer.Model;
using ApiServer.Model.DTO;
using ApiServer.Repository.DB.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiServer.Repository.DB;

public class AuthRepository : IAuthRepository
{
    private readonly ApplicationDbContext _db;
    private readonly IMapper _mapper;

    public AuthRepository(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<Account?> GetAccount(string email) => await _db.Accounts.SingleOrDefaultAsync(x => x.Email == email);

    public async Task CreateAsync(Account entity)
    {
        await _db.Accounts.AddAsync(entity);
        await _db.SaveChangesAsync();            
    }

    public async Task Update(Account entity) 
    {
        _db.Update(entity);
        await _db.SaveChangesAsync();
    }
}
