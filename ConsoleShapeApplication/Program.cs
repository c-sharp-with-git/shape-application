using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;

namespace ConsoleShapeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("radius = ");
            //double radius = Convert.ToDouble(
            //    Console.ReadLine());
            //Circle c = new Circle(radius);
            //Console.WriteLine("area = {0}", c.Area());

            Circle c = new Circle();
            Console.Write("radius = ");
            double radius = Convert.ToDouble(
                Console.ReadLine());
            try
            {
                c.Radius = radius;
                Console.WriteLine("area = {0}", c.Area());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        

    }
}
