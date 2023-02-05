using MauiDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabase.Repositories;
public class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : class, IBaseEntity
{
    public DbSet<TModel> Models { get; set; }
    public AppDbContext Context { get; set; }

    public BaseRepository(AppDbContext context)
    {
        Context = context;
        Models = Context.Set<TModel>();
    }

    public async Task<bool> CreateAsync(TModel model)
    {
        try
        {
            Models.Add(model);
            Context.Entry(model).State = EntityState.Added;
            await Context.SaveChangesAsync();

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<List<TModel>> GetAllAsync()
    {
        return Models.AsNoTracking().ToList();
    }
}

public interface IBaseRepository<TModel> where TModel : class, IBaseEntity
{
    public DbSet<TModel> Models { get; set; }
    public AppDbContext Context { get; set; }

    public Task<bool> CreateAsync(TModel model);
    public Task<List<TModel>> GetAllAsync();
}
