using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Employee
    {
        public string mrg { get; set; }
        private int _EmpId;

		public int EmpId
		{
			get { return _EmpId; }
			set { _EmpId = value; }
		}
		private string _EmpName;

		public string EmpName
		{
			get { return _EmpName; }
			set { _EmpName = value; }
		}

		private int _DeptNo;

		public int DeptNO
		{
			get { return _DeptNo; }
			set { _DeptNo = value; }
		}

		private double _Sal;

		public double Sal
		{
			get { return _Sal; }
			set { _Sal = value; }
		}

	}
}
