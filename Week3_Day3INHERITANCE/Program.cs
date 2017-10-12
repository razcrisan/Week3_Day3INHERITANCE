using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3INHERITANCE
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vehicle baseVehicle = new Vehicle(4, 2000, "Brown", 55.0d);

            //baseVehicle.Move();
            //Console.WriteLine(baseVehicle.DistanceTraveled);

            Automobile merry = new Automobile(4, 14, 2, 4, 1500, "Blorange", 88.0d);
            merry.Move();
            merry.Move();
            Console.WriteLine("Automobile Distance Traveled: " + merry.DistanceTraveled);

            Boat boaty = new Boat(2, 500, "BLURPLE", 88.0d, .9d);
            boaty.Move();
            boaty.Move();
            Console.WriteLine("Boat Distance Traveled: " + boaty.DistanceTraveled);

            Aircraft plane1 = new Aircraft(70, 100000, "GREY", 600.0d);

            plane1.Move();
            plane1.Move();

            Console.WriteLine("Aircraft Distance Traveled: " + plane1.DistanceTraveled);


      

        }
    }
}
