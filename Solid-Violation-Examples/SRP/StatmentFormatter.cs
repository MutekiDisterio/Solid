using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Violation_Examples.SRP
{
    public class StatementFormatter
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private const string AMOUNT_FORMAT = "F2";

        public string FormatHeader()
        {
            return "DATE | AMOUNT | BALANCE";
        }
        public string StatementLine(Transaction transaction, int balance) =>
            $"{FormatDate(transaction.Date)} | {FormatNumber(transaction.Amount)} | {FormatNumber(balance)}";
        private string FormatDate(DateOnly date) =>
            date.ToString(DATE_FORMAT, CultureInfo.InvariantCulture);
        private string FormatNumber(int amount) =>
            amount.ToString(AMOUNT_FORMAT, CultureInfo.InvariantCulture);
    }
}