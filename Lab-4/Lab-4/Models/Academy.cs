using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4.Models
{
    class Academy
    {
        public Student[] Students = { };

        public Student CreateStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
            return student;
        }
        public Student[] GetStudents()
        {
            return Students;
        }

        public void DeleteStudent(Student student)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id==student.Id)
                {
                    Students[i] = Students[Students.Length - 1];
                    Array.Resize(ref Students,Students.Length-1);
                }
            }
          
        }

        public Student Get(Student student)
        {
            Student stu=new Student();
            foreach (var item in Students)
            {
                if (item.Id==student.Id)
                {
                    return item;
                }
            }
            return stu;
        }

        public void Edit(int id,string fullname)
        {
            foreach (var item in Students)
            {
                if (item.Id==id)
                {
                    item.FullName = fullname;
                }
            }
        }

        public void Edit2(Student student,string Fullname)
        {
            foreach (var item in Students)
            {
                if (item.Id==student.Id)
                {
                    item.FullName = Fullname;   
                }
            }
        }
    }
}
