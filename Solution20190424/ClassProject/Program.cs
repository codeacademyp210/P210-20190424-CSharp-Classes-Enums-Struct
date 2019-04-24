using System;

namespace ClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student std1 = new Student();

            //Console.Write("Adinizi daxil edin: ");
            //std1.Name = Console.ReadLine();

            //Console.Write("Soyadinizi daxil edin:");
            //std1.Surname = Console.ReadLine();

            //Console.WriteLine("Salam {0} {1}", std1.Name, std1.Surname);


            //Area myArea = new Area(5,15);
            //Console.WriteLine(myArea.Calculate());

            //Area myArea2 = new Area(20, 30);
            //Console.WriteLine(myArea2.Calculate());



            //double result = myArea.Calculate();
            //Console.WriteLine(result);

            //Car.Year = 2000;

            //Car bmw = new Car();
            //bmw.Manufacturer = "BMW";
            //bmw.FuelCapacity = 80;
            //bmw.Fuel = 20;
            //bmw.FuelIndex = 10;
            //Console.WriteLine(bmw.CalculateDistance());
            //bmw.Forsaj();
            //Console.WriteLine(bmw.CalculateDistance());
            //Console.WriteLine(Car.Year);


            //Car optima = new Car
            //{
            //    Manufacturer = "Kia",
            //    FuelCapacity = 64
            //};

            //optima.Fuel = 60;
            //optima.FuelIndex = 5;

            //Car.Year = 3000;
            //Console.WriteLine(Car.Year);

            //Console.WriteLine(optima.CalculateDistance());
            //optima.Forsaj();
            //Console.WriteLine(optima.CalculateDistance());

            int a = Convert.ToInt32("123");
           
            Student.GroupName = "P210";

            Student st1 = new Student
            {
                Name = "Rustem",
                Surname = "Sheydayev"
            };
            Student st2 = new Student
            {
                Name = "Qeshem",
                Surname = "Qarayev"
            };
            Student st3 = new Student
            {
                Name = "Ekber",
                Surname = "Amanov"
            };


            Console.ReadLine();
        }
    }
    
    class Area
    {

        private double _Width;
        private double _Height;

        public Area()
        {
            _Width = 10;
            _Height = 10;
        }

        public Area(double w, double h)
        {
            _Width = w;
            _Height = h;
        }

        ~Area()
        {
            Console.WriteLine("Desctructor worked");
        }

        public void SetWidth(double w)
        {
            if (w > 0)
            {
                _Width = w;
            }
        }
        public void SetHeight(double h)
        {
            if (h > 0)
            {
                _Height = h;
            }
        }



        //public double Width
        //{
        //    set
        //    {
        //        _Width = value;
        //    }
        //}

        //public double Height
        //{
        //    set
        //    {
        //        _Height = value;
        //    }
        //}

        public double Calculate()
        {
            return _Height * _Width;
        }

    }
    class Student
    {
        public static string GroupName;

        public string Name { get; set; }
        public string Surname { get; set; }

        public string GetGroup()
        {
            return GroupName;
        }
    }
    class Car
    {
        public static int Year;
        public string Manufacturer { get; set; }
        public float Fuel { get; set; }
        public float FuelCapacity { get; set; }
        public float FuelIndex { get; set; }
    


        public float CalculateDistance()
        {
            return Fuel / FuelIndex * 100;
        }

        public void Forsaj()
        {
            FuelIndex = FuelIndex * 2;
        }

    }

   
}
