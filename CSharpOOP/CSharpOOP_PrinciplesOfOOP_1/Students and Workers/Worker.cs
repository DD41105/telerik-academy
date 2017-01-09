using System;

namespace Students_and_Workers
{
    class Worker : Human, ICalculateMoneyPerHour
    {
        // fields and properties
        private decimal weeklySalary;
        private decimal workHoursPerDay;

        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public decimal WeeklySalary
        {
            get { return weeklySalary; }
            set { weeklySalary = value; }
        }

        // constructor that also calls the base constructor (the one in the Human class)
        public Worker(string firstName, string lastName, decimal weeklySalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weeklySalary = weeklySalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        // implement the MoneyPerHour method from the ICalculateMoneyPerHour interface
        public decimal MoneyPerHour()
        {
            // divide the WeeklySalary by 5 because we assume that the worker works 5 days per week.
            decimal result = (this.WeeklySalary / 5) / this.WorkHoursPerDay;
            return Math.Round(result, 2);
        }
    }
}