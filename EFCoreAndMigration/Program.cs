using EFCoreAndMigration.Contexts;

namespace EFCoreAndMigration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AppDBContext context = new AppDBContext();
            // Through this object i olready connet to database 
            // becouse new call user define constractor if exist
            // U D Constractor chians to the parent that calls OnConfiguring inside to connet to database
            // so we already call to OnConfiguring once i create an object 
        }
    }
}
