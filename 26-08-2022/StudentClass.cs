using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAssignment
{
    public class Student
    {
		private int rollNo;

		public int getRollNo
		{
			get { return rollNo; }
			set { rollNo = value; }
		}

		private string name;

		public string getName
		{
			get { return name; }
			set { name = value; }
		}


	}
	struct StudentStruct
	{
		public	int rollNo;
		public string name;
		public void AcceptData(int rollNo , string name)
		{
			this.rollNo = rollNo;
			this.name = name;
		}
	}
}
