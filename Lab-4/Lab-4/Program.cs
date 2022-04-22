
using Lab_4.Models;
using System;
using System.Collections.Generic;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student()
            {
                Id=1,
                FullName="Metin Necefov"
            };
            Student student1 = new Student()
            {
                Id = 2,
                FullName = "Murad Abdullayev"
            };
         
            Academy academy = new Academy();
            academy.CreateStudent(student);
            academy.CreateStudent(student1);

            academy.Edit(2, "Ziver Babayeva");
            //academy.Edit2(student,"Ziver Babayeva");


            foreach (Student stu in academy.GetStudents())
            {
                Console.WriteLine($"Telebenin adSoyad: {stu.FullName} telebenin id-si {stu.Id}");
            }


        }

    }
}
