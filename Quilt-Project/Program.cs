﻿using System;
using System.Collections.Generic;

namespace Quilt_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            string selectedOption = " ";
            string color = " ";
            int length = 0;
            int width = 0;
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            var shapes = new List<Shape>();


            while (keepGoing)
            {
                Console.WriteLine("Welcome to Guy's Shape Recorder Program!\n\n");
                Console.WriteLine("1. Add a rectangle shape.");
                Console.WriteLine("2. Add a square shape.");
                Console.WriteLine("3. Add a triangle shape.");
                Console.WriteLine("4. List all of your current shapes.");
                Console.WriteLine("5. Exit the program.\n");
                Console.WriteLine("Please select an option:");
                selectedOption = Console.ReadLine();
                

                switch (Convert.ToInt32(selectedOption))
                {
                    case 1:
                        Console.WriteLine("You picked a rectangle.");
                        Console.WriteLine("Please enter the color.");
                        color = Console.ReadLine();
                        Console.WriteLine("Please enter the length.");
                        length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the width.");
                        width = Convert.ToInt32(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(color, length, width);
                        shapes.Add(shapes);
                        Console.WriteLine("Thank you!\n\n");
                        break;

                    case 2:
                        Console.WriteLine("You picked a square.");
                        Console.WriteLine("Please enter the color.");
                        color = Console.ReadLine();
                        Console.WriteLine("\nPlease enter the length of a side.");
                        length = Convert.ToInt32(Console.ReadLine());
                        Square square = new Square(color, length);
                        // Add to list
                        Console.WriteLine("Thank you!\n\n");
                        break;

                    case 3:
                        Console.WriteLine("You picked a triangle.");
                        Console.WriteLine("Please enter the color.");
                        color = Console.ReadLine();
                        Console.WriteLine("Please enter the length of the first side.");
                        side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the length of the second side.");
                        side2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the length of the third side.");
                        side3 = Convert.ToInt32(Console.ReadLine());
                        Triangle triangle = new Triangle(color, side1, side2, side3);
                        // Add to list
                        Console.WriteLine("Thank you!\n\n");
                        break;

                    case 4:
                        Console.WriteLine("Your current shapes are:\n");
                        foreach (var shape in shapes)
                        {
                            Console.WriteLine($"{shape.Color} {shape.Name} with area {shape.ShapeArea()}.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        keepGoing = false;
                        break;
                }

            }
        }
    }
}