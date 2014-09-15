using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFeatures.EntityFramework;

namespace CSharpFeatures
{
    class EntityFrameworkClass
    {
        public void Execute()
        {
            var db = new EFDbContext();
            Employee e = new Employee();
            e.EmpId = Guid.NewGuid().ToString();
            e.Name = "test";
            db.Employees.Add(e);
            db.SaveChanges();

            Console.WriteLine("saved to db");
        }
    }
}
