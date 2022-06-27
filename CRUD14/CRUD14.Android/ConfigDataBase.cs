using CRUD14.Droid;
using System.IO;
using Xamarin.Forms;


[assembly: Dependency(typeof(ConfigDataBase))]
namespace CRUD14.Droid
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}