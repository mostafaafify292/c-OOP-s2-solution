using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_s2
{
    internal enum Gender
    {
        m , M , f ,F , male ,Male , female , Female
         
    }
    [Flags]
    internal enum securityPrivileges 
    {
        guest = 0 , developer = 2 , secretary = 4 , DBA = 8 

    }
    internal class Employee
    {
        private int id;
        private string name;
        private securityPrivileges securityLevel;
        private double salary;
        private hirestruct hiredate = new hirestruct();
        private Gender gender;

        public Employee()
        { }

        public Employee(int _id, string _name, securityPrivileges _securityLevel, double _salary,int month , int day , int year , Gender _gender)
        {
            this.id = _id;
            this.name = _name;
            this.securityLevel = _securityLevel;
            this.salary = _salary;
            hiredate.theMonth = month;
            hiredate.theDay = day;
            hiredate.Year = year;
            gender = _gender;

        }
        

        public override string ToString()
        {
            return $"id : {id}\nname : {name}\nsecurityLevel : {securityLevel}\nsalary : {salary :c}\nhiringDate : {hiredate.theDay}/{hiredate.theMonth}/{hiredate.Year}\ngender : {gender}";
        }


    }
    
    

}
