using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6A
{
    class Unit
    {
       
        public string Vehicle1 = "**";
        public string Vehicle2 = "**";

        public string Noise1 = "**";
        public string Noise2 = "**";
       

        // Allows user to play the game until they are done and choose to quit
        public void Run()
        {
            bool quit;

            do
            {
                Console.Clear();
                Mission();
                DispayMainMenu();
                quit = ElicitUserInput();
            }
            while (!quit);
        }

        // Displays Mission Name
        public void Mission()
        {
            Console.WriteLine($" MISSION | ** Mission Secret Squirrel ** |");
            Console.WriteLine($" VEHICLE | {Vehicle1} | {Vehicle2} |");
            Console.WriteLine($" NOISE   | {Noise1} | {Noise2}");
        }

        // Displays main menu options
        void DispayMainMenu()
        {
            Console.WriteLine("Choose a vehicle and wait for the sound of freedom:");
            Console.WriteLine(" 1) Aircraft");
            Console.WriteLine(" 2) Ship");
            Console.WriteLine(" 2) Exit");
        }

        // Handles main navigation
        bool ElicitUserInput()
        {
            bool quit = false;
            bool isValid = false;

            do
            {
                try
                {
                    Console.Write("Please select an option:");
                    int choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Mission();
                    isValid = true;

                    switch (choice)
                    {
                        
                        case 1:

                            Console.WriteLine("\nFlight crew boarding Aircraft.");
                            Aircraft Plane = new Aircraft();
                            Vehicle1 = Plane.AircraftType("C-5");
                            Noise1 = Plane.StartEngine("whoshhhhh");

                            break;

                        case 2:

                            Console.WriteLine("\nFlight crew boarding Aircraft.");
                            Ship Warship = new Ship();
                            Vehicle2 = Ship.ShipType("USS Ronald Reagan");
                            Noise2 = Ship.StartEngine("frackkkkkkaaakakak");

                            break;


                        case 3:
                            Console.WriteLine("\nGreat job out there! ** MISSION COMPLETE **\n");
                            Console.Write("Press enter to exit.");
                            Console.ReadLine();
                            quit = true;
                            break;

                        default:
                            isValid = false;
                            Console.WriteLine("You have selected an invalid option. Please choose a valid" +
                                              "option.");
                            DispayMainMenu();
                            break;
                    }
                }

                catch (FormatException)
                {
                    isValid = false;
                }
            }
            while (!quit && !isValid);

            return quit;
        }

    }
}
