using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiDatabase.Shared;
public static class ProjectConfig
{
    public static string DatabasePath => $"Filename={Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\maui-test-database.db";
}