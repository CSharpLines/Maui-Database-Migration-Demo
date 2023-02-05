using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabase.Models;
public class BaseEntity : IBaseEntity
{
    public int Id { get; set; }
}

public interface IBaseEntity
{
    public int Id { get; set; }
}