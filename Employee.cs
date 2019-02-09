using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private int ID;
        private string Name;
        private string DepartmentName;


        
           
            public Employee (int id,string name,string dpname)
            {
            ID = id;
            Name = name;
            DepartmentName = dpname;
          
            }
        public int GetId()
        {
            caller1();
            
            return ID;
            
        }

        public string GetName()
        {
            caller2();
            return Name;
        }

        public string GetDepartmentName()
        {
            caller3();
            return DepartmentName;
        }
     
        public event CallDelegate caller1;
        public event CallDelegate caller2;
        public event CallDelegate caller3;

        public int update(int id)
        {
            ID = id;
            return ID;
        }

        public string update(string name)
        {
            Name= name;
            return Name;
        }

        public void update()
        {
            Console.WriteLine("Update employee department:");
            DepartmentName = Console.ReadLine();
            Console.WriteLine("Updated Employee department name"+DepartmentName);
        }



    }
}

