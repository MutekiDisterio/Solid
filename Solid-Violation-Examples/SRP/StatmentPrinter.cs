using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Violation_Examples.SRP
{
    public class StatementPrinter
    {
        private readonly ConsolePrinter _printer;
        private readonly StatementFormatter _formatter;

        public StatementPrinter(ConsolePrinter printer, StatementFormatter formatter)
        {
            _printer = printer;
            _formatter = formatter;
        }
        public void Print(List<Transaction> transactions)
        {
            int balance = 0;
            _printer.PrintLine(_formatter.FormatHeader());

            foreach (var transaction in transactions.OrderByDescending(t => t.Date))
            {
                balance += transaction.Amount;
                _printer.PrintLine(_formatter.StatementLine(transaction, balance));
            }
        }
    }
}