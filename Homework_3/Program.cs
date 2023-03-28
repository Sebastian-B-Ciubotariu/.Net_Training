namespace Homework_3_Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.StartEngine();    // Engine started.
            myCar.Accelerate();     // Accelerating. Current speed: 10 km/h, current gear: 1.
            myCar.Accelerate();     // Accelerating. Current speed: 20 km/h, current gear: 2.
            myCar.Brake();          // Decelerating. Current speed: 10 km/h, current gear: 1.
            myCar.Brake();          // Decelerating. Current speed: 0 km/h, current gear: 0.
            myCar.StopEngine();     // Engine stopped.
        }
    }
}