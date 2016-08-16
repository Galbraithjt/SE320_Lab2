using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Next, add a Class that describes a Line object. The members are 2 Point objects. Again, provide all methods. 
//The public display() method for the Line (returns a string) should use the Point’s display methods and then concatenate 
//onto that the length of the Line. Find the length by calling a protected calcLength() method that returns an int 
//(so you have to convert this to a String before using it in a concatenation). The units are in pixels.

//Distance Formula: Square root of [ (x2 – x1)2 + (y2 – y1)2 ]
// to do the square root, use Math.Sqrt()
// to do the power, use Math.Pow()

namespace SE320_Lab1
{ // start namespace
    class Line
    { // start class
        private Point PointA { set; get; }
        private Point PointB { set; get; }

        public Line() // base constructor
        {
            PointA = new Point();
            PointB = new Point();
        } // end base constructor
        
        public Line(Point a, Point b) // full constructor
        {
            PointA = a;
            PointB = b;
        } // end full constructor

        public static Line operator +(Line a, Line b)
        {
            return new Line(a.PointA, b.PointB);
        }

        public static Line operator- (Line a, Line b)
        {
            return new Line(a.PointB, b.PointA);
        }

        public int calcLength() // calculate length method
        {
            return Convert.ToInt32(Math.Sqrt(Math.Pow(this.PointB.Xpoint - this.PointA.Xpoint, 2) + Math.Pow(this.PointB.Ypoint - this.PointA.Ypoint, 2)));
        } // end calculate length medthod

        public string display() // display method
        {
            return PointA.display() + PointB.display() + " Length is " + Convert.ToString(calcLength());
        } // end display method
    } // end class
} // end namespace
