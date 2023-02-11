using MauiDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabase.Entity.Seeding;
public static class NotesSeeder
{
    public static List<Note> NotesToSeed = new List<Note>
    {
        new Note
        {
            Content = "My Seeded Note"
        },
        new Note
        {
            Content = "My 2nd Seeded Note"
        },
        new Note
        {
            Content = "My 3rd Seeded Note"
        },
        new Note
        {
            Content = "My 4th Seeded Note"
        },
        new Note
        {
            Content = "This note was added to the seeded list after the first four were seeded"
        },
    };
}