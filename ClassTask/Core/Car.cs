using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Car
    {
        private static int _id = 1000;
        public int Id { get; set; }

        public string Name { get; set; }
        private double _speed; 

        public double Speed
        {
            get { return _speed; }

            set
            {
                bool check = false;
                do
                {
                    if (value > 0)
                    {
                        _speed = value;
                        check = true;
                    }
                    else
                    {
                        Console.WriteLine("Speed duzgun daxil et");
                        string newspeed;
                        do
                        {
                            Console.Write("Speed: ");
                            newspeed = Console.ReadLine();
                        } while (!double.TryParse(newspeed, out value));
                    }
                } while (!check);
            }
        }


        public string CarCode {  get;}
        

        public Car(string name, double speed) 
        {
            _id++;
            Id = _id;
            Name = name;
            Speed = speed;
            CarCode = Code();

        }

        private string Code()
        {
            string code = Name.Substring(0,2).ToUpper();
            return code + Id;
        }




    }
}
