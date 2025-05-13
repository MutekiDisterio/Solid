using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Violation_Examples.OCP
{
    public class Engineer : Employee
    {
        public Engineer(int salary) : base(salary, 0) { }

        public override int PayAmount()
        {
            return _salary;
        }
    }
}
