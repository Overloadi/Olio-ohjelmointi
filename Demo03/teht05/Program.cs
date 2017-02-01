using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            Student joni = new Student();
            Student mankine = new Student();
            Student tanja = new Student();
            Student reps = new Student();
            joni.Name = "Joni";
            joni.Address = "Katu123";
            joni.Age = 22;
            joni.ID = "AASD";
            mankine.Name = "Mankine";
            mankine.Address = "Katukatu";
            mankine.Age = 12;
            mankine.ID = "JJJ1";
            tanja.Name = "Tanja Pee";
            tanja.Address = "Junaraide";
            tanja.Age = 13;
            tanja.ID = "3B1N";
            reps.Name = "Repps";
            reps.Age = 49;
            reps.Address = "Hiisikatu";
            reps.ID = "421-1";
            Student[] students = { joni, mankine, tanja, reps };
            foreach(Student stu in students)
            {
                stu.PrintData();
            }
        }
    }
}
