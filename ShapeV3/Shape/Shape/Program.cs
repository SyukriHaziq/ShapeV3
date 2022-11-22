using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle aRec = new Rectangle();

            Console.WriteLine("Width = {0}, Height = {1}", aRec.Width, aRec.Height);
            aRec.Width = 4;
            aRec.Height = 5;
            Console.WriteLine("Width = {0}, Height = {1}", aRec.Width, aRec.Height);

            Console.ReadKey();

            Square aSq = new Square(8);

            Console.WriteLine("Length = {0}", aSq.len);
            Console.WriteLine("Area = {0}, Circumference = {1}", aSq.Area(), aSq.Circumference());

            Console.ReadKey();
        }
    }
}
