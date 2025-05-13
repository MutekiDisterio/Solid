using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Violation_Examples.DIP
{
    public interface IEmailSender
    {
        public void Send(Email email);
    }
}
