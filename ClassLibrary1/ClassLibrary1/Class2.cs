﻿using System;

namespace ClassLibrary1
{
    abstract class Employee12
    {
        public int EmpId; public string EName; public double GrassSalary;
        public void AccaptData()
        {
            Console.Write("Enter Employee Id and Name: ");
            this.EmpId = Convert.ToInt32(Console.ReadLine());
            this.EName = Console.ReadLine();
        }
        public override string ToString()
        {
            string output = "\nEmployee Id is" + this.EmpId + "\nEmployee Name is" + this.EName;
            return output;
        }
        public abstract void Calculet(Employee1 E);
    }
    class fullTimeEmployee1 : Employee1
    {
        public double Basic, DA, HRA;
        public new void AccaptData()
        {
            Console.Write("Enter Basic salary: ");
            this.Basic = Convert.ToDouble(Console.ReadLine());
        }
        public override string ToString()
        {
            string output = base.ToString() + "\nBasic salary is" + this.Basic + "\nDA is" + this.DA +
                           "\nHRA is" + this.HRA + "\nGrass Salary is" + this.GrassSalary;
            return output;
        }
        public override void Calculet(Employee1 E)
        {
            this.DA = 0.4 * this.Basic;
            this.HRA = 0.25 * this.Basic;
            E.GrassSalary = this.Basic + this.DA + this.HRA;
        }
    }
    public class Class12
    {
        static void Main(string[] args)
        {
            fullTimeEmployee FE1 = new fullTimeEmployee();
            FE1.AccaptData();
            FE1.Calculet(FE1);
            Console.WriteLine(FE1);
        }
    }
}
