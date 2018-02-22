using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  ** INSTRUCTIONS **
 * Using inheritance, abstraction, classes and objects, implement a military unit. Create super or abstract classes 
 * representing several components of a military unit. Examples might include personnel, weapons, equipment, vehicles,
 * missions, etc. Each parent class should be subclassed several times. Thinking about test first development, you may want 
 * to write the main program first, before you create any other classes or objects. That way, you can create classes with the
 * appropriate properties and methods, and instantiate objects as needed to carry out the mission.  */
namespace Exercise_6A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic game instructions
            Console.WriteLine("** WELCOME TO THE UNIT! **\n");
            Console.WriteLine("You are a combat controller and your job is to complete missions.\n");
            Console.WriteLine("Hit enter to continue.");
            Console.ReadLine();

            //Instantiation of the Unit class
            Unit TheUnit = new Unit();
            TheUnit.Run();
        }
    }
}
