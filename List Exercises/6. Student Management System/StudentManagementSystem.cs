using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Student_Management_System
{
    //internal class StudentManagementSystem
    //{
    //    public StudentManagementSystem()
    //    {
    //        students = new List<Student>();
    //    }
    //
    //    private List<Student> students;
    //
    //	public List<Student> Students
    //	{
    //		get { return students; }
    //		private set { students = value; }
    //	}
    //
    //    public void AddStudent(int grade, string name, int id)
    //    {
    //        Student newStudent = Student()
    //    }
    //
    //    public void EditStudent(int id, string newName, double newGrade)
    //    {
    //        var student = students.Find(s => s.ID == id);
    //        if (student != null)
    //        {
    //            student.Name = newName;
    //            student.Grade = newGrade;
    //        }
    //    }
    //
    //    public void DeleteStudent(int id)
    //    {
    //        var student = students.Find(s => s.ID == id);
    //        if (student != null)
    //        {
    //            students.Remove(student);
    //        }
    //    }
    //
    //    public void ViewStudents()
    //    {
    //        foreach (var student in students)
    //        {
    //            Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Grade: {student.Grade}");
    //        }
    //    }
    //
    //}

    public class StudentManagementSystem
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(int id, string name, int grade)
        {
            students.Add(new Student { Id = id, Name = name, Grade = grade });
        }

        public void EditStudent(int id, string newName, double newGrade)
        {
            var student = students.Find(s => s.ID == id);
            if (student != null)
            {
                student.Name = newName;
                student.Grade = newGrade;
            }
        }

        public void DeleteStudent(int id)
        {
            var student = students.Find(s => s.ID == id);
            if (student != null)
            {
                students.Remove(student);
            }
        }

        public void ViewStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Grade: {student.Grade}");
            }
        }
    }

}
