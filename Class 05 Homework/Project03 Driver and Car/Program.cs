using System;

namespace Project03_Driver_and_Car

{
    #region Class Driver & Car
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
    }
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        public int CalculateSpeed(Driver driver)
        {
            int calcSpeed = driver.Skill * Speed;
            return calcSpeed;
        }

    }
    #endregion



    class Program
    {
        static int RaceCars(Driver driver, Car car)
        {
            return car.CalculateSpeed(driver);
        }
        

        static void Main(string[] args)
        {
            #region 4 Objects Driver & 4 Objects Car
            Driver Jill = new Driver()
            {
                Name = "Jill",
                Skill = 85,

            };
            Driver Greg = new Driver()
            {
                Name = "Greg",
                Skill = 99
            };
            Driver Anne = new Driver()
            {
                Name = "Anne",
                Skill = 80,
            };
            Driver Bob = new Driver()
            {
                Name = "Bob",
                Skill = 80,
            };
            //Console.WriteLine("--------------------------------------------");
            Car Hyundai = new Car()
            {
                Model = "Hyundai",
                Speed = 240,
                Driver = ""

            };
            Car Mazda = new Car()
            {
                Model = "Mazda",
                Speed = 285,
                Driver = ""

            };
            Car Ferarri = new Car()
            {
                Model = "Ferarri",
                Speed = 320,
                Driver = ""

            };
            Car Porshe = new Car()
            {
                Model = "Porshe",
                Speed = 280,
                Driver = ""

            };
            #endregion

            Console.WriteLine(Porshe.CalculateSpeed(Bob));
            Console.WriteLine(RaceCars(Greg, Porshe));
            // tuka treba da imas vo porakata primer vnesi broj od 1 - 4 za da izberes vozac
            // mozes ako sakas i da gi ispecatis vozacite za da znae koj e pod koj broj
            Console.WriteLine("Please select your first driver.");

            // ova bi se vikalo nesto kako userChoice ili chosenNumber
            string firstDriver = Console.ReadLine();

            // ova treba da ti bide Driver firstDriver = null;
            string driver = null;
            switch (driver)
            {
                case "1":
                    // ajde probaj tuka namesto string da stavas vo varijablata da go stavis celiot objekt
                    // znaci treba vo varijablata firstDriver sto ke ti bide inicijalno null (linija 101)
                    // da go stavis objektot vo koj go cuvas vozacot 1 (a toa e bob)
                    driver = "Bob";
                    break;
                case "2":
                    // istoto od prviot slucaj vazi sekade
                    driver = "Greg";
                    break;
                case "3":
                    driver = "Jill";
                    break;
                case "4":
                    driver = "Anne";
                    break;
                default:
                    break;
            }
            // ova e vishok
            firstDriver = driver;
            
           
        
            
            
           

            Console.ReadLine();
        }
    }
}


