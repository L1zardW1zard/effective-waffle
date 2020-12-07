using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Garage
{
    public List<Car> myCars = new List<Car>();

    public void AddNewCar()
    {
        string name;
        string color;
        int speed;
        int year;

        Console.Write("\nEnter a name of car: ");
        name = Console.ReadLine();

        Console.Write("Enter a color of car: ");
        color = Console.ReadLine();

        Console.Write("Enter a car`s speed: ");
        while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
        {
            Console.Write("Enter a correct speed value, please: ");
        }

        Console.Write("Enter a car`s year of issue: ");
        while (!int.TryParse(Console.ReadLine(), out year) || year > 2019 || year < 1900)
        {
            Console.Write("Enter a correct year, please: ");
        }

        Car newCar = new Car(name, color, speed, year);

        myCars.Add(newCar);
    }

    public void DisplayAllCars()
    {
        int i = 1;
        foreach (Car c in myCars)
        {
            DisplayInfo(c);
            i++;
        }
    }

    public void RemoveCar()
    {
        int position;
        Console.Write("Chose a position to remove: ");
        while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > myCars.Count)
        {
            Console.Write("There are no cars on this position! Position: ");
        }
        myCars.RemoveAt(position - 1);
        Console.WriteLine("The car on {0} position was deleted", position);
    }

    public void SearchByOneCharacteristic(string characteristic)
    {
        int i = 0;
        switch (characteristic)
        {
            case "name":
                Console.Write("What name would you like to find: ");
                string name = Console.ReadLine();

                foreach (Car c in myCars)
                {
                    if (c.Name == name)
                    {
                        DisplayInfo(c);
                        i++;
                    }
                }
                if (i == 0) Console.WriteLine("Sorry, no matches found.");
                i = 0;
                break;

            case "color":
                Console.Write("What color would you like to find: ");
                string color = Console.ReadLine();
                foreach (Car c in myCars)
                {
                    if (c.Color == color)
                    {
                        DisplayInfo(c);
                        i++;
                    }
                }
                if (i == 0) Console.WriteLine("Sorry, no matches found.");
                i = 0;
                break;

            case "speed":
                Console.Write("What name would you like to find: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                foreach (Car c in myCars)
                {
                    if (c.Speed == speed)
                    {
                        DisplayInfo(c);
                        i++;
                    }
                }
                if (i == 0) Console.WriteLine("Sorry, no matches found.");
                i = 0;
                break;

            case "year":
                Console.Write("What year would you like to find: ");
                int year = Convert.ToInt32(Console.ReadLine());
                foreach (Car c in myCars)
                {
                    if (c.YearOfIssue == year)
                    {
                        DisplayInfo(c);
                        i++;
                    }
                }
                if (i == 0) Console.WriteLine("Sorry, no matches found.");
                i = 0;
                break;

            default:
                Console.WriteLine("Sorry, no such characteristic.");
                break;
        }

    }

    public void DisplayInfo(Car car)
    {
        Console.WriteLine("\nProperties");
        Console.WriteLine("\nName  : {0}\nColor  : {1}\nSpeed  : {2}\nYear  : {3}", car.Name, car.Color, car.Speed, car.YearOfIssue);
        Console.WriteLine("--------------------------");
    }
}



class Car
{
    public string Name { get; }
    public string Color { get; }
    public int Speed { get; }
    public int YearOfIssue { get; }

    public Car(string name, string color, int speed, int yearOfIssue)
    {
        Name = name;
        Color = color;
        Speed = speed;
        YearOfIssue = yearOfIssue;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Garage GarageSheikha = new Garage();
        Console.WriteLine("Garage Sheikha");
        int choice;

        do
        {

            Console.WriteLine();
            if (GarageSheikha.myCars.Count == 0)
            {
                Console.WriteLine("[1] - add a new car");
                Console.WriteLine("[0] - close the garage");
            }
            else
            {

                Console.WriteLine("[1] - add a new car");
                Console.WriteLine("[2] - show all my cars");
                Console.WriteLine("[3] - delete a car");
                Console.WriteLine("[4] - find cars by one characteristic");
                Console.WriteLine("[0] - close the garage");

            }
            Console.Write("Chose an option:");
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Enter a correct option: ");
            }
            switch (choice)
            {
                case 1:
                    GarageSheikha.AddNewCar();
                    Console.Clear();
                    Console.WriteLine("Car was added in garage: " + GarageSheikha.myCars.Count);
                    break;
                case 2:
                    GarageSheikha.DisplayAllCars();
                    break;
                case 3:
                    GarageSheikha.RemoveCar();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Okay, which characteristic would you like to find?");
                    string characteristic;
                    Console.WriteLine("[name]\tfor name search");
                    Console.WriteLine("[color]\tfor color search");
                    Console.WriteLine("[speed]\tfor speed search");
                    Console.WriteLine("[year]\tfor year search");
                    characteristic = Console.ReadLine();
                    GarageSheikha.SearchByOneCharacteristic(characteristic);
                    break;
                case 0:
                    Console.WriteLine("Garage closed.");
                    return;
                default:
                    Console.WriteLine("Incorect option");
                    break;

            }




        } while (choice != 0);

    }
}
