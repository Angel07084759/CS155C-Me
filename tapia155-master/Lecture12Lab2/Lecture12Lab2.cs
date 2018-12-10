/// Lecture12	        Exercise No. Lab2
/// File Name:          Lecture12Lab2.cs
/// @author:            Angel Tapia
/// Date:               November 26, 2018
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture12Lab2
{
    class Lecture12Lab2
    {
        //* Add two 3D vectors together. (1, 2, 3) + (3, 3, 3) should be(4, 5, 6).
        //* Subtract one 3D vector from another. (1, 2, 3) - (3, 3, 3) should be(-2, -1, 0).
        //* Negate a 3D vector.For example, using the negative sign on(2, 0, -4) should be(-2, 0, 4).
        //* Multiply a vector by a number(scalar) so(1, 2, 3) * 4 should be(4, 8, 12).
        //* Divide a vector by a number(scalar) so(2, 4, 6) / 2 should be(1, 2, 3).
        static void Main(string[] args)
        {
            Vector vec1 = new Vector(1, 2, 3);
            Vector vec2 = new Vector(3, 3, 3);
            Vector vec3 = new Vector(2, 0, -4);
            Vector vec4 = new Vector(4, 8, 12);
            Vector vec5 = new Vector(2, 4, 6);
            Vector addVec = vec1 + vec2;
            Vector subtractVec = vec1 - vec2;
            Vector negateVec = -vec3;
            Vector multiplyVec = vec1 * 4;
            Vector divideVec = vec5 / 2;



            Console.WriteLine("vec1: " +  vec1);
            Console.WriteLine("vec2: " +  vec2);
            Console.WriteLine("vec3: " +  vec3);
            Console.WriteLine("vec4: " +  vec4);
            Console.WriteLine("vec5: " +  vec5);
            Console.WriteLine();

            Console.WriteLine("Add = vec1 + vec2:      " +  addVec);
            Console.WriteLine("Subtract = vec1 - vec2: " + subtractVec);
            Console.WriteLine("Negate = -vec3:         " + negateVec);
            Console.WriteLine("Multiply = vec1 * 4:    " + multiplyVec);
            Console.WriteLine("Divide = vec5 / 2:      " + divideVec);


            Console.ReadLine();


        }
    }
}
