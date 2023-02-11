using MauiDatabase.Entity.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabase.Utilities;
public static class DatabaseSeeder
{
    public static void SeedDatabase(this MauiApp mauiApp)
    {
        using var scope = mauiApp.Services.CreateScope();
        var context = scope.ServiceProvider.GetService(typeof(AppDbContext)) as AppDbContext;

        if (context == null) return;

        var notes = NotesSeeder.NotesToSeed.Where(a => !context.Notes.Any(b => b.Content == a.Content))?.ToList();

        context.Notes.AddRange(notes);

        context.SaveChanges();
    }
}