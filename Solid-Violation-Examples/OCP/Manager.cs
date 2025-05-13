using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Violation_Examples.OCP
{
    public class Manager : Employee
    {
        public Manager(int salary, int bonus) : base(salary, bonus) { }

        public override int PayAmount()
        {
            return _salary + _bonus;
        }
    }
}
