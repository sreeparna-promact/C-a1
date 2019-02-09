using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;string name;string dpname;
            Console.WriteLine("Enter the Employee Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Department Name");
            dpname = Console.ReadLine();
            void pId()
            {
                Console.WriteLine("GetId() is called");
            }
             void pName()
            {
                Console.WriteLine("GetName() is called");
            }
           void pdpname()
            {
                Console.WriteLine("GetDepartmentName() is called");
            }
            Employee emp = new Employee(id, name, dpname);
            emp.caller1 += new CallDelegate(pId);
            emp.caller2 += new CallDelegate(pName);
            emp.caller3 += new CallDelegate(pdpname);
            Console.WriteLine("Employee ID:"+ emp.GetId());
            
            Console.WriteLine("Employee Name:"+emp.GetName());
            Console.WriteLine("Employee Department Name:"+emp.GetDepartmentName());

            Console.WriteLine(" Update Employee Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Updated Employee ID is:"+emp.update(id));

            Console.WriteLine("Update Employee name");
            name = Console.ReadLine();
            
            Console.WriteLine("Updated Employee name is:" + emp.update(name));

            emp.update();

          

            

           






        }
    }
}
