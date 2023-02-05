using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabase.Models;
public class Note : BaseEntity
{
    public string Content { get; set; }
}