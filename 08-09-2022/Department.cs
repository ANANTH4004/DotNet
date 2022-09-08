using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	public  delegate void AddDeleteEmp(Employee e);
	public delegate void DeleteById(int e);
	public delegate void PrintList(List<Employee> list);
    public class Department
    {
		public int EmpCount = 0;
		public static event DeleteById RemoveEid;
		public static event AddDeleteEmp AddEmp;
		public static event AddDeleteEmp DeleteEmp;
		public   List<Employee> EmpList = new List<Employee>();

		public void Reporting(List<Employee> list)
		{
			Func<List<Employee>, List<Employee>> ans = (s1) => s1.FindAll(e => e.mrg != null).ToList();
			var sam = ans(list);
			foreach (var item in sam)
			{
				Console.WriteLine(item.EmpName);
			}
			Console.WriteLine("==========================");
		}
		private int _DeptNo;

		public int DeptNo
		{
			get { return _DeptNo; }
			set { _DeptNo = value; }
		}
		private string _DeptName;

		public string DeptName
		{
			get { return _DeptName; }
			set { _DeptName = value; }
		}
		public void PrintList(List<Employee> list)
		{
			if(list == null)
			{
				Console.WriteLine("Empty List......");
			}
			else
			{
				foreach (var item in list)
				{
					Console.WriteLine(item.EmpName);
				}
			}
		}
		public void ShowList()
		{
			if (EmpList == null)
			{
				Console.WriteLine("Emplty List...");
			}
			else
			{
				foreach (var item in EmpList)
				{
					Console.WriteLine(item.EmpName);
				}
			}
		}

		public void RemoveByID(int e)
		{
            RemoveEid = DeleteByIdDelecate;
			RemoveEid(e);
        }
		public void Operation(Employee e)
		{
			AddEmp = AddDelecate;
			DeleteEmp   = DeleteDelecate;
			
			Console.WriteLine("1.Add Employee\t2.Remove Employee");
			int choice = Convert.ToInt32(Console.ReadLine());
			switch (choice)
			{
				case 1:
					if(EmpCount > 10)
					{
						Console.WriteLine("Deparment Full...");
						break;
					}
					else
					{
                        EmpCount++;
                        AddEmp(e);
                    }
					
					break;
				case 2:
					if(EmpCount ==0)
					{
						Console.WriteLine("Empty department Nothing to Delete...");
						break;
					}
					else
					{
                        DeleteEmp(e);
						EmpCount--;
                    }
					
					
					break;
				
				default:
					Environment.Exit(1);
					break;
			}
		}
		public void AddDelecate(Employee e)
		{
			AddDeleteEmp a = new AddDeleteEmp(AddEmpToList);
			a.Invoke(e);
		}
		private void AddEmpToList(Employee e)
		{
			EmpList.Add(e);
			Console.WriteLine("Employee Added Successfully...");
		}

		public void DeleteDelecate(Employee e)
		{
			AddDeleteEmp d = new AddDeleteEmp(DeleteEmpFromList);
			d.Invoke(e); 
		}
		public void DeleteEmpFromList(Employee e)
		{
			EmpList.RemoveAll(e1 => e1.EmpId == e.EmpId);
			Console.WriteLine("Employee Removed Successfully.....");
		}
		public void DeleteByIdDelecate(int e)
		{
			DeleteById d = new DeleteById(DeleteEmpID);
			d.Invoke(e);
		}
        private void DeleteEmpID(int e)
        {
            EmpList.RemoveAll(e1 => e1.EmpId == e);
			Console.WriteLine("Employee Removed Successfully......");
        }



		// Predicate 
		
			
		
		






















    }
}
