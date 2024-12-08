﻿namespace MyLibrary
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual decimal CalculateMonthlyPayment()
        {
            return 12000;
        }
    }

    public class Secretary : Employee
    {
        public override decimal CalculateMonthlyPayment() => 15000;
    }

    public class Manager : Employee
    {
        public override decimal CalculateMonthlyPayment() => 35000;
        
    }

    public class Developer : Employee
    {

    }
}
