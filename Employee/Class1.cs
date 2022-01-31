using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Entity
    {
        public class Employee
        {
            private int Id;
            private string Name;
            private string Add;
            private string city;
            private string dept;
            private double salary;

            public void setId(int Id)
            {
                this.Id = Id;
            }

            public void setName(string Name)
            {
                this.Name = Name;
            }
            public void setAddress(string Add)
            {
                this.Add = Add;
            }
            public void setcity(string city)
            {
                this.city = city;
            }
            public void setdepartment(string dept)
            {
                this.dept = dept;
            }
            public void setsalary(double salary)
            {
                this.salary = salary;
            }

            public int getId()
            {
                return Id;
            }
            public string getName()
            {
                return Name;
            }
            public string getAdd()
            {
                return Add;
            }
            public string getcity()
            {
                return city;
            }
            public string getdept()
            {
                return dept;
            }
            public double getsalary()
            {
                return salary;
            }



        }
    }
}
