using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    internal class Program
    {
        // Note we are now returning an int, rather than a void.
        static int Main(string[] args)
        {
            // Helper method within the Program class.
            ShowEnvironmentDetails();

            Console.ReadLine();

            //Return an arbitrary error code.
            return -1;

        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives of this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

                Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",
                Environment.Version);
        }


    }
}
