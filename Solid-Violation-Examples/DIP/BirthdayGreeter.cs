namespace Solid_Violation_Examples.DIP
{
    public class BirthdayGreeter
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly Clock _clock;
        private readonly IEmailSender _emailSender;

        public BirthdayGreeter(IEmployeeRepository employeeRepository, Clock clock, IEmailSender emailSender)
        {
            _employeeRepository = employeeRepository;
            _clock = clock;
            _emailSender = emailSender;
        }
        public void SendGreetings()
        {
            DateOnly today = _clock.MonthDay();
            _employeeRepository.FindEmployeesBornOn(today)
                .Select(EmailFor)
                .ToList()
                .ForEach(email => _emailSender.Send(email));
        }
        private Email EmailFor(Employee employee)
        {
            string message = $"Happy birthday, dear {employee.FirstName}";
            return new Email(employee.Email, "Happy birthday!", message);
        }
    }
}
