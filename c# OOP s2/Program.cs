using System.Drawing;

namespace c__OOP_s2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Part 01 Try all what we have learned in the lecture.

            //phonebook
            //phoneBook note = new phoneBook(3);
            //note.AddPerson(0, "mostafa", 01080871181);
            //note.AddPerson(1, "mohamed", 01234555666);
            //note.AddPerson(2, "afify", 01132123133);

            //note.SetNumber("afify", 565656);
            //Console.WriteLine(note.GetNumber("afify"));
            //Console.WriteLine(note["mostafa"]);

            ////string Name = "Maha";
            ////Console.WriteLine(Name[0]); // M
            //for (int i = 0; i < note.Size; i++)
            //{
            //    Console.WriteLine(note[i]);
            //} 
            //car c1 = new car(10);
            //Console.WriteLine(c1.ToString());





            #endregion
            #region #2 Part 02
            //Employee em1 = new Employee(10,"mostafa",securityPrivileges.developer,2500,9,20,2000,Gender.M);
            //Console.WriteLine(em1.ToString());
            Employee[] empArr = new Employee[3];
            empArr[0] = new Employee(10, "DBA", (securityPrivileges)8, 500, 9, 20, 2000, Gender.M);
            empArr[1] = new Employee(20, "guest", (securityPrivileges)0, 500, 7, 23, 2000, Gender.M);
            empArr[2] = new Employee(30, "securityOfficer", (securityPrivileges)14, 500, 6, 10, 2000, Gender.M);

            for (int i = 0; i < empArr.Length; i++)
            {
                Console.WriteLine(empArr[i]);


            } 
            #endregion









        }
    }
}
