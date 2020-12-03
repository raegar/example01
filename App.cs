using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollercoasterApp
{
    class App
    {
        public App() { }

        public void Run()
        {
            Console.WriteLine("Rollercoaster App");

            Train train1 = new Train(7);

            bool endProgram = false;

            while (!endProgram)
            {
                int id = 1;
                foreach (Carriage carriage in train1.Carriages)
                {
                    Console.Write($"Carriage {id} is ");
                    if (carriage.IsOccupied)
                    {
                        Console.WriteLine("Occupied");
                    }
                    else
                    {
                        Console.WriteLine("Unoccupied");
                    }
                    id++;
                }
                Console.WriteLine("Select an empty carriage number or press Space to start train");
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);

                if (keyPressed.Key != ConsoleKey.Spacebar)
                {
                    int carriageSelected = Convert.ToInt32(keyPressed.KeyChar.ToString());
                    carriageSelected -= 1;
                    try
                    {
                        train1.Carriages[carriageSelected].ChangeOccupancy();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.ReadKey(true);
                    }
                }
                else
                {
                    //Depart
                    //Weeeeeeeee!
                    //Arrive
                }

                Console.Clear();
            }



            Console.ReadKey(true);
        }
    }
}
