
namespace Homework_3_Classes
{
    public class Car
    {
        private int speed;
        private int gear;
        private bool engineStarted;

        public Car()
        {
            speed = 0;
            gear = 0;
            engineStarted = false;
        }

        public void StartEngine()
        {
            engineStarted = true;
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            engineStarted = false;
            speed = 0;
            gear = 0;
            Console.WriteLine("Engine stopped.");
        }

        public void Accelerate()
        {
            if (engineStarted)
            {
                speed += 10;
                gear = speed / 10;
                Console.WriteLine("Accelerating. Current speed: {0} km/h, current gear: {1}.", speed, gear);
            }
            else
            {
                Console.WriteLine("The engine is not started.");
            }
        }

        public void Brake()
        {
            if (engineStarted)
            {
                speed -= 10;
                gear = speed / 10;
                Console.WriteLine("Decelerating. Current speed: {0} km/h, current gear: {1}.", speed, gear);
            }
            else
            {
                Console.WriteLine("The engine is not started.");
            }
        }

        public void GetCurrentSpeed()
        {
            Console.WriteLine("Current speed: {0} km/h.", speed);
        }

        public void GetCurrentGear()
        {
            Console.WriteLine("Current gear: {0}.", gear);
        }
    }
}
