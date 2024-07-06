

/*  Q 1 
 *  namespace assignment
{
    internal class Program
    {

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
    }
}
*/

/* Q 2
namespace assignment
{
    internal class Program
    {
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            people[0].Name = "Alice";
            people[0].Age = 25;

            people[1].Name = "Bob";
            people[1].Age = 30;

            people[2].Name = "Charlie";
            people[2].Age = 35;

            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
*/

/*Q 3
 * 
namespace assignment
{
    internal class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();
            Season season;

            if (Enum.TryParse(input, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
*/

/* Q 4
namespace assignment
{
    internal class Program
    {
        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        static void Main(string[] args)
        {
            Permissions userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine("Current Permissions: " + userPermissions);

            
            userPermissions |= Permissions.Delete;
            Console.WriteLine("Permissions after adding Delete: " + userPermissions);

           
            userPermissions &= ~Permissions.Write;
            Console.WriteLine("Permissions after removing Write: " + userPermissions);

            bool hasExecute = (userPermissions & Permissions.Execute) == Permissions.Execute;
            Console.WriteLine("Has Execute permission: " + hasExecute);
        }
    }
    }
*/

/* Q 5
namespace assignment
{
    internal class Program
    {
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a color (Red, Green, Blue): ");
            string input = Console.ReadLine();
            Colors color;

            if (Enum.TryParse(input, true, out color))
            {
                if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
                {
                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{color} is not a primary color.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
*/

/* Q 6
namespace assignment
{
    internal class Program
    {
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            Console.WriteLine("Enter the coordinates for the first point:");
            Console.Write("X: ");
            point1.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            point1.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates for the second point:");
            Console.Write("X: ");
            point2.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            point2.Y = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            Console.WriteLine($"The distance between the two points is: {distance}");
        }
    }
    }
*/



/* Q 7
namespace assignment
{
    internal class Program
    {
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");
                Console.Write("Name: ");
                people[i].Name = Console.ReadLine();
                Console.Write("Age: ");
                people[i].Age = Convert.ToInt32(Console.ReadLine());
            }

            Person oldest = people[0];

            foreach (var person in people)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }

            Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}.");
        }
    }
    }
*/


