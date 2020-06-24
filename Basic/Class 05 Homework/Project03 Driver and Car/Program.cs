using System;

namespace Project03_Driver_and_Car

{
    
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
    }

    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver DriverOfCar { get; set; }


        public int CalculateSpeed(Driver theDriver)
        {
            int speedScore = theDriver.Skill * Speed;
            return speedScore;
        }

    }

    class Program
    {

        static void RaceCars(Car car1, Car car2)
        {
            int performance1 = car1.CalculateSpeed(car1.DriverOfCar);
            int performance2 = car2.CalculateSpeed(car2.DriverOfCar);
            if (performance1 > performance2)
            {

                Console.WriteLine($"The winner of the race is {car1.Model}!! It crossed the finnish line at an amazing {car1.Speed} KM/H" +
                    $"and it was driven by {car1.DriverOfCar.Name}");
            }
            else if (performance1 < performance2)
            {

                Console.WriteLine($"The winner of the race is {car2.Model}!! It crossed the finnish line at an amazing {car2.Speed} KM/H " +
                   $"and it was driven by {car2.DriverOfCar.Name}");

            }
            else
            {
                Console.WriteLine($"Both cars {car1.Model} and {car2.Model} crossed the finnish line at the same time!! They crossed the " +
                    $"finnish line at an amazing {car1.Speed} KM/H and they were driven by" +
                    $" {car1.DriverOfCar.Name} and {car2.DriverOfCar.Name} respectevly");
            }
        }

        static Car ChooseCar(int counter)
        {
            Car chosenCar = new Car();

            Car hyundai = new Car();
            hyundai.Model = "Hyundai";
            hyundai.Speed = 210;


            Car mazda = new Car();
            mazda.Model = "Mazda";
            mazda.Speed = 220;

            Car ferrari = new Car();
            ferrari.Model = "Ferrari";
            ferrari.Speed = 340;

            Car porsche = new Car();
            porsche.Model = "Porsche";
            porsche.Speed = 290;
            //...................................

            Console.WriteLine($@"Choose car number: {counter}
For Hyundai press- 1
For Mazda press- 2
For Ferrari press- 3
For Porsche press- 4");

            bool carSucces = int.TryParse(Console.ReadLine(), out int carSelect);

            switch (carSelect)
            {
                case 1:
                    chosenCar = hyundai;
                    break;
                case 2:
                    chosenCar = mazda;
                    break;
                case 3:
                    chosenCar = ferrari;
                    break;
                case 4:
                    chosenCar = porsche;
                    break;
                default:
                    Console.WriteLine("Wrong input.");
                    ChooseCar(counter);
                    break;
            }

            return chosenCar;

        }

        static Driver ChooseDriver(int counter)
        {
            Driver chosenDriver = new Driver();

            Driver bob = new Driver();
            bob.Name = "Bob";
            bob.Skill = 10;

            Driver greg = new Driver();
            greg.Name = "Greg";
            greg.Skill = 8;

            Driver jill = new Driver();
            jill.Name = "Jill";
            jill.Skill = 6;

            Driver anne = new Driver();
            anne.Name = "Anne";
            anne.Skill = 9;

            //.......................................................

            Console.WriteLine($@"Choose Driver number {counter}
To select Bob press- 1
To select Greg press- 2
To select Jill press- 3
To sellect Anne press- 4");

            bool driverSucces = int.TryParse(Console.ReadLine(), out int driverSelect);


            switch (driverSelect)
            {
                case 1:
                    chosenDriver = bob;
                    break;
                case 2:
                    chosenDriver = greg;
                    break;
                case 3:
                    chosenDriver = jill;
                    break;
                case 4:
                    chosenDriver = anne;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    ChooseDriver(counter);
                    break;
            }

            return chosenDriver;
        }




        static void Main(string[] args)
        {

            Car car1 = new Car();
            Car car2 = new Car();

            Driver driver1 = new Driver();
            Driver driver2 = new Driver();

            while (true)
            {
                car1 = ChooseCar(1);
                while (true)
                {
                    car2 = ChooseCar(2);
                    string carValid1 = car1.Model;
                    string carValid2 = car2.Model;
                    if (carValid1 == carValid2)
                    {
                        Console.WriteLine("That car has already been taken.");
                        continue;
                    }
                    break;
                }

                driver1 = ChooseDriver(1);

                while (true)
                {
                    driver2 = ChooseDriver(2);
                    string driverValid1 = driver1.Name;
                    string driverValid2 = driver2.Name;

                    if (driverValid1 == driverValid2)
                    {
                        Console.WriteLine("That driver has already been selected.");
                        continue;
                    }
                    break;
                }

                car1.DriverOfCar = driver1;
                car2.DriverOfCar = driver2;

                RaceCars(car1, car2);

                int newGame;
                while (true)
                {
                    Console.WriteLine(@"Do you want to watch another race ?
For yes press 1
For no press 2");
                    bool succesGame = int.TryParse(Console.ReadLine(), out newGame);

                    if (!succesGame || newGame < 1 || newGame > 2)
                    {
                        Console.WriteLine("Invalid iput");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                if (newGame == 1)
                {
                    continue;
                }
                if (newGame == 2)
                {
                    break;
                }

            }


            Console.ReadLine();
        }
    }
}

