﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Lets make a new UI Class that we can use below

            // Commented to use the static version
            //UserInterface ui = new UserInterface();

            // Her is a new Employee being created just to make sure that our Employee class works
            Employee myEmployee = new Employee("Thomas", "Wold", 835.0m);

            Console.WriteLine(myEmployee);
            Console.WriteLine(myEmployee.FirstAndLastName());

            // Let's make an array to hold a bunch of instances of the Employee class (this should be done in WineItemCollection)
            // We have the new keyword. That means memory allocation.
            //The array is going to be in the Heap.
            Employee[] employees = new Employee[10];

            // Commented since we are using CSV file now

            //employees[0] = new Employee("James", "Kirk", 1701.00m);
            //employees[1] = new Employee("Jean-Luc", "Picard", 1701.00m);
            //employees[2] = new Employee("Benjamin", "Sisko", 587.00m);
            //employees[3] = new Employee("Kathryn", "Janeway", 287.00m);
            //employees[4] = new Employee("Johnathan", "Archer", 127.00m);

            // Make the string for the path to the csv file
            string pathToCsv = "employees.csv";

            // Instanciate the csvProcessor
            CSVProcessor csvProcessor = new CSVProcessor();

            // Call the importCSV method sending over the path and the array to store the read in records to.
            csvProcessor.ImportCsv(pathToCsv, employees);

            // Get some input from the user
            int choice = StaticUserInterface.GetUserInput();

            // While the user has chosen something other than 2
            while (choice != 2)
            {


                //Create a string that can be concatenaited 
                string outputString = "";

                // Print out the employees i nthe array
                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        //Concat the employee to the outputString
                        outputString += employee.ToString() + Environment.NewLine;
                    }
                }

                // Output the outputString to the console
                StaticUserInterface.Output(outputString);

                // Re-promt the uer for some new input
                choice = StaticUserInterface.GetUserInput();
            }

        }
    }
}
