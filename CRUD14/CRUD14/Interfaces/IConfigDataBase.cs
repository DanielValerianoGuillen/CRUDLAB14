using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD14
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
