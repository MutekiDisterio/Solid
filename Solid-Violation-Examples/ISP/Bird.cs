namespace Solid_Violation_Examples.ISP
{
    public class Bird : IAnimalFly, IAnimalRun
    {
        public void Run() => Console.WriteLine("Bird is running");
        public void Fly() => Console.WriteLine("Bird is flying");
    }
}
