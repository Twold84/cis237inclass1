using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        //No Variables 
        // No Properties
        // No Constructor. Default is fine.

        public bool ImportCsv(string pathToCSVFILE, Employee[] employees)
        {
            //Declare the streamReader
            StreamReader streamReader = null;

            try
            {
                // Declare a string for the line 
                string line;

                // Instanciate the stream reader
                streamReader = new StreamReader(pathToCSVFILE);

                int counter = 0;

                // While we are still reading a line from the file
                 while ((line = streamReader.ReadLine()) != null)
                {
                    //Process the line
                    processLine(line, employees, counter++);
                }

                 // Read through the whole file, so we can return true.
                return true;
            }
            catch (Exception e)
            {
                // Output the exception and the stacktrace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                // Return false since it didnt succeed
                return false;
            }

            finally
            {
                //Finally block will always be excecuted no matter what

                // If the stream reader was instanciated, make sure it is closed before exiting the reader

                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }
        private void processLine(string line, Employee[] employees, int index)
        {
            // Declare array of parts that will contain the results of splitting the read in string
            string[] parts = line.Split(',');

            //Assign each part to variable 
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            //Add a new employee into the arrau that was passed in
            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
