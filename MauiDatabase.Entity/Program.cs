using MauiDatabase.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabase.Entity;
public static class Program
{
    public static void Main(string[] args)
    {
    }
}

public class DbContextMigrationFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<AppDbContext>();
        builder.UseSqlite(ProjectConfig.DatabasePath);
        return new AppDbContext(builder.Options);
    }
}