namespace Solid_Violation_Examples.OCP
{
    public abstract class Employee
    {
        protected int _salary;
        protected int _bonus;

        public Employee(int salary, int bonus)
        {
            _salary = salary;
            _bonus = bonus;
        }

        public abstract int PayAmount();
    }
}

