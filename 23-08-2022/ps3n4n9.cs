﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_08_2022
{
    internal class ps3n4n9
    {
    }
    struct Employee
    {
        public  int empNo;
        public string ename;
        public double sal;
        public int deptNo;

        public int dept
        {
            set {
                if (value == null)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Enter a valid deptNo");
                }
            }
            get { return deptNo; }
        }
        public string empname
        {
            set {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name can not be null");
                }
                else
                {
                    ename = value;
                   
                }
            }
            get { return ename; }
        }
        public double Sal
        {
            get { return sal; }
            set { sal = value; }
        }
        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }
        public void AcceptData(int empNo , string ename , double sal , int deptNo)
        {
            this.empNo = empNo;
            this.ename = ename;
            this.sal = sal;
            this.deptNo = deptNo;
        }
        public void Display1()
        {
            Console.WriteLine("EmployeeNo : {0} EmployeeName: {1} EmployeeSal: {2} EmployeeDeptNo : {3}   ", this.empNo,this.ename,this.sal ,this.deptNo);
            //Console.Write("EmployeeName : {0}   ",this.ename);
            //Console.Write("EmployeeSal : {0}   ",this.sal);
            //Console.Write("EmployeeDeptNo : {0}  ",this.deptNo);
        }
    }
}
