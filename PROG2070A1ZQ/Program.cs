using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A1ZQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            double addRadius;
            double subRadius;
            bool chosen = false;
            bool keepGoing = false;
            do
            {
                Console.WriteLine("Please enter the radius of the circle.");
                string radiusString = Console.ReadLine();
                try
                {
                    c1.Radius = double.Parse(radiusString);
                    keepGoing = true;
                    if (c1.Radius < 0)
                    {
                        keepGoing = false;
                        Console.WriteLine("Enter double that's bigger than 0, try again!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter double, try again!");
                }
            }
            while (!keepGoing);
            do
            {
                Console.WriteLine("The radius is "+c1.Radius+".\nPlease choose one of the following\n1.Add to Circle Radius\n2.Subtract from Circle Radius\n3.Calculate Circle Circumference\n4.Calculate Circle Area\n5.Exit");
                string chosenString = Console.ReadLine();
                if (chosenString == "1")
                {
                    keepGoing = false;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Tell me how much you want to add");
                            addRadius = double.Parse(Console.ReadLine());
                            keepGoing = true;
                            c1.AddToRadius(addRadius);
                            if (c1.NegRadius)
                                {
                                    keepGoing = false;
                                    Console.WriteLine("The end result is negative, radius is now back to "+c1.Radius+", try again!");
                                    c1.NegRadius = false;
                                }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter double, try again!");
                        }
                    }
                    while (!keepGoing);
                    
                }
                else if (chosenString == "2")
                {
                    keepGoing = false;
                    do
                    {
                        try
                        {
                            Console.WriteLine("Tell me how much you want to subtract");
                            subRadius = double.Parse(Console.ReadLine());
                                keepGoing = true;
                                c1.SubtractFromRadius(subRadius);
                                if (c1.NegRadius)
                                {
                                    keepGoing = false;
                                    Console.WriteLine("The end result is negative, radius is now back to "+c1.Radius+", try again!");
                                    c1.NegRadius = false;
                                }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Enter double, try again!");
                        }
                    }
                    while (!keepGoing);
                    Console.WriteLine("The radius is now " + c1.Radius + "\n--------------------------------------------------------------------------------------------------");
                }
                else if (chosenString == "3")
                {
                    Console.WriteLine("The Circumference is " + c1.GetCircumference() + "\n--------------------------------------------------------------------------------------------------");
                }
                else if (chosenString == "4")
                {
                    Console.WriteLine("The Area is " + c1.GetArea()+ "\n--------------------------------------------------------------------------------------------------");
                }
                else if (chosenString == "5")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Please only choose from 1 to 5, try again!\n--------------------------------------------------------------------------------------------------");
                }
            }
            while (!chosen);
        }
    }
}
