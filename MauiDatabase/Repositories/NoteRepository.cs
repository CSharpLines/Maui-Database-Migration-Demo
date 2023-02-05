using MauiDatabase.Models;

namespace MauiDatabase.Repositories;
public class NoteRepository : BaseRepository<Note>, INoteRepository
{
    public NoteRepository(AppDbContext context) : base(context)
    {
    }
}

public interface INoteRepository : IBaseRepository<Note>
{

}