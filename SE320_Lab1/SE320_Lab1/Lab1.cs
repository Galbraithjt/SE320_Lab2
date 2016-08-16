using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Console Application and do the following:
 
//First, add a Class that describes a Point object. The members are x, y (int). Provide both a full and base 
//Constructor, Property methods (get/set) and a public display() method that returns a string with a formatted output of 
//“(x,y)”. Be sure to keep the class “generic” enough so it can be used anywhere (so no Console stuff!).
 
//Next, add a Class that describes a Line object. The members are 2 Point objects. Again, provide all methods. 
//The public display() method for the Line (returns a string) should use the Point’s display methods and then concatenate 
//onto that the length of the Line. Find the length by calling a protected calcLength() method that returns an int 
//(so you have to convert this to a String before using it in a concatenation). The units are in pixels.
 
//Distance Formula: Square root of [ (x2 – x1)2 + (y2 – y1)2 ]
// to do the square root, use Math.Sqrt()
// to do the power, use Math.Pow()
 
//Now, add a Class that describes a StraightLine object. This should extend or inherit from the base class Line. 
//The Line class members can be set to protected or remain private (your design choice). Add a 2 members to the 
//StraightLine class called length (int) and direction (int). Provide only the required methods and do not allow 
//values below 0 or above 50 for length. Direction should only take values 0 – 3… where 0 = up, 1 = right, 
//2 = down, and 3 = left.
 
//Add a new private method called determinePoint2() that uses the length and direction provided to create the 
//2nd Point object. Do this by Adding or Subtracting the length from either the x1 or y1 value of the first point. 
//The other value will remain the same (so if solve for x2, then y2 will be equal to y1. If you solve for y2, 
//then x2 = x1).
//StraighLine needs to continue using the parent (Line) object’s display() method (do not override it!).
//Back in Main(), prompt the user to enter 6 integer values x1, y1, x2, y2, length and direction (0-3). Make a new 
//Line and display it. Then, using only the x1, y1, length and direction, make a StrightLine and display that. Use 
//loops in Main() and proper Exception Handling throughout your application (in Main and in the setters)!
 
//NOTE: There is an issue in the design of the derived class. The full constructor for the StraightLine takes only 
//1 point, but the base full constructor requires 2 points. How would you still be able to call the base constructor in 
//the derived class constructor? Think about it.
//Include comments!! Don’t forget to add detailed comments before each function!!
 
//Submit as a github project or upload the entire SOLUTION to the Portal as a single zip file
//Retain for future labs and exams!

namespace SE320_Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            bool exception = false; // variable for exception loop
            int x1 = 0; // variable to store x of point 1
            int y1 = 0;// variable to store y of point 1
            int x2 = 0;// variable to store x of point 2
            int y2 = 0;// variable to store y of point 2
            int length = 0;// variable to store length of the line 
            int direction = 0;// variable to store direction of the line

            do // start exception loop
            {
                try // try first to get x of point 1
                {
                    Console.WriteLine("Please enter the X of first point");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    exception = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    exception = true;
                }

                try // try first to get y of point 1
                {
                    Console.WriteLine("Please enter the Y of first point");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    exception = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    exception = true;
                }

                try // try first to get x of point 2
                {
                    Console.WriteLine("Please enter the X of second point");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    exception = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    exception = true;
                }

                try // try first to get y of point 2
                {
                    Console.WriteLine("Please enter the Y of second point");
                    y2 = Convert.ToInt32(Console.ReadLine());
                    exception = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    exception = true;
                }

                try // try to get length of the line
                {
                    Console.WriteLine("Please enter the length of the line must be 0 to 50");
                    length = Convert.ToInt32(Console.ReadLine());
                    exception = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    exception = true;
                }

                try // try to get direction of the line
                {
                    Console.WriteLine("Please enter the direction of the line 0 = up, 1 = right, 2 = down, and 3 = left");
                    direction = Convert.ToInt32(Console.ReadLine());
                    exception = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    exception = true;
                }

                try // try to create points and make line
                {
                    Point pnt1 = new Point(x1, y1);
                    Point pnt2 = new Point(x2, y2);
                    Console.WriteLine(pnt1.display() + pnt2.display());
                    StraightLine stline = new StraightLine(pnt1, length, direction);
                    Line line = new Line(pnt1, pnt2);
                    Console.WriteLine(stline.display());
                    Line lineAdd = stline + line;
                    Line lineSub = stline - line;
                    Console.WriteLine(stline.display() + " + " + line.display() + " = " + lineAdd.display());
                    Console.WriteLine(stline.display() + " - " + line.display() + " = " + lineSub.display());
                    exception = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    exception = true;
                }
            } while (exception);
            
            Console.ReadLine(); // pause console for display
        }
    }
}
