using Core;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new Gallery();

            bool check = true;


            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Car elave et");
                Console.WriteLine("2. Bütün Carlara bax");
                Console.WriteLine("3. Id uzre axtarış et");
                Console.WriteLine("4. CarCode uzre axtarış et");
                Console.WriteLine("5. Speed uzre axtarış et");
                Console.WriteLine("0. Proqramı bitir");
                Console.WriteLine("");
                string choiceStr;
                byte choice;

                do
                {
                    Console.WriteLine("");
                    Console.Write("Sechim edin: ");
                    choiceStr = Console.ReadLine();
                } while (!byte.TryParse(choiceStr, out choice));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Car elave et");
                        Console.WriteLine("");

                        Console.Write("Car Name daxil et: ");
                        string name = Console.ReadLine();


                        string speedStr = "";
                        double speed;

                        do
                        {
                            Console.Write("Car Speed daxil et: ");
                            speedStr = Console.ReadLine();
                        } while (!double.TryParse(speedStr, out speed));

                        Car car = new Car(name, speed);

                        gallery.AddEmployee(car);

                        break;

                    case 2:

                        Console.WriteLine("");
                        Console.WriteLine("Bütün Carlara bax");
                        Console.WriteLine("");
                        gallery.ShowAllCars();

                        break;

                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("3. Id uzre axtarış et");
                        Console.WriteLine("");
                        string idStr = "";
                        int id;

                        do
                        {
                            Console.Write("Id daxil et: ");
                            idStr = Console.ReadLine();
                        }while(!int.TryParse(idStr, out id));

                        bool searchId = false;

                        for(int i = 0;i<gallery.Cars.Length; i++)
                        {
                            Car carId = gallery.Cars[i];

                            if (id == carId.Id)
                            {
                                Console.WriteLine("");
                                Console.WriteLine($" {carId.Id}, {carId.Name}, {carId.Speed}, {carId.CarCode}");
                                searchId = true;
                            }
                        }
                        if (!searchId)
                        {
                            Console.WriteLine("Bele bir car yoxdur");
                        }

                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("CarCode uzre axtarış et");
                        Console.WriteLine("");

                        Console.Write("CarCode daxil et: ");
                        string carcode = Console.ReadLine();

                        bool searchCode = false;

                        for(int i = 0; i < gallery.Cars.Length; i++)
                        {
                            Car carCode = gallery.Cars[i];

                            if(carcode == carCode.CarCode)
                            {
                                Console.WriteLine("");
                                Console.WriteLine($" {carCode.Id}, {carCode.Name}, {carCode.Speed}, {carCode.CarCode}");
                                searchCode = true;
                            }
                        }
                        if (!searchCode)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Bele bir car yoxdur");
                        }

                        break;

                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Speed uzre axtarış et");
                        Console.WriteLine("");

                        string minStr = "";
                        double minspeed;
                        do
                        {
                            Console.Write("Minimum speed: ");
                            minStr = Console.ReadLine();
                        } while (!double.TryParse(minStr, out minspeed));

        

                        string maxStr = "";
                        double maxspeed;
                        do
                        {
                            Console.Write("Maksimum speed: ");
                            maxStr = Console.ReadLine();
                        } while (!double.TryParse(maxStr, out maxspeed));

                        bool searchSpeed = false;

                        for(int i = 0;i < gallery.Cars.Length; i++)
                        {
                            Car carSpeed = gallery.Cars[i];

                            if(carSpeed.Speed >= minspeed &&  carSpeed.Speed <= maxspeed)
                            {
                                Console.WriteLine("");
                                Console.WriteLine($" {carSpeed.Id}, {carSpeed.Name}, {carSpeed.Speed}, {carSpeed.CarCode}");
                                searchSpeed = true;
                            }
                        }
                        if (!searchSpeed)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Bu speed  araliginda  car yoxdur");
                        }
                        break;

                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("Proqram bitdi");
                        check = false;                    
                        break;

                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Duzgun sechim et");
                        break;
                }


            } while (check);

        }
    }
}
