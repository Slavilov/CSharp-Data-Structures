using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Student_Management_System
{
    internal class Student
    {
        public Student(int grade, string name, int id)
        {
			this.grade = grade;
			this.name = name;
			this.id = id;
        }

        private int grade;
		private string name;
		private int id;

		public int Grade
		{
			get { return grade; }
			set { grade = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
