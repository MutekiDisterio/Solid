using System.Globalization;

namespace Solid_Violation_Examples.SRP
{
    public class AccountService
    {
        private const string STATEMENT_HEADER = "DATE | AMOUNT | BALANCE";


        private readonly ITransactionRepository _transactionRepository;
        private readonly Clock _clock;
        private readonly StatementPrinter _statementPrinter;

        public AccountService(ITransactionRepository transactionRepository, Clock clock, StatementPrinter statementPrinter)
        {
            _transactionRepository = transactionRepository;
            _clock = clock;
            _statementPrinter = statementPrinter;
        }

        public void Deposit(int amount) => _transactionRepository.Add(TransactionWith(amount));
        public void Withdraw(int amount) => _transactionRepository.Add(TransactionWith(-amount));
        public void PrintStatement()
        {
            var t = _transactionRepository.GetAll();
            _statementPrinter.Print(t);
        }
        private Transaction TransactionWith(int amount) => new Transaction(DateOnly.FromDateTime(DateTime.Today), amount);
    }
}