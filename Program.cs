using System;
using System.Linq;

namespace mysqlEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using(var db = new jumpmanjiContext()){
               var users = db.Users.Where(t=>t.Name !="mango").ToList();
               foreach (var item in users)
               {
                   Console.WriteLine(item.Name);
               }
            }
        }
    }
}
