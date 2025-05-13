namespace Solid_Violation_Examples.ISP
{
    public class Dog : IAnimalBark, IAnimalRun
    {

        public void Run() => Console.WriteLine("Dog is running");
        public void Bark() => Console.WriteLine("Dog is barking");
    }
}
