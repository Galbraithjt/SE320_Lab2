using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//First, add a Class that describes a Point object. The members are x, y (int). Provide both a full and base 
//Constructor, Property methods (get/set) and a public display() method that returns a string with a formatted output of 
//“(x,y)”. Be sure to keep the class “generic” enough so it can be used anywhere (so no Console stuff!).

namespace SE320_Lab1
{ // start namespace
    class Point
    { // start class
        private int xpoint; // xpoint variable
        private int ypoint; // ypoint variable

        public Point() // base constructor
            : this(0, 0)
        {
            // empty space
        } // end base constructor

        public Point(int x, int y) // full constructor
        {
            Xpoint = x;
            Ypoint = y;
        }

        public int Xpoint// xpoint get and set
        {
            get // xpoint get
            {
                return xpoint;
            } // end get

            set // xpoint set
            {
                if (value > 0 || value < 0)
                {
                    xpoint = value; // sets xpoint to value if its a number
                }

                else
                {
                    throw new Exception("Please enter a integer"); // exception thrown when non-number entered
                }
            }// end set
        } // end xpoint get and set

        public int Ypoint
        {
            get // ypoint set
            {
                return ypoint;
            } // end get

            set // ypoint set
            {
                if (value > 0 || value < 0)
                {
                    ypoint = value; // sets ypoint to value if its a number
                }

                else
                {
                    throw new Exception("Please enter a integer"); // exception thrown when non-number entered
                }
            } // end set
        } // end ypoint get and set

        public string display()
        {
            return ("(" + Xpoint + "," + Ypoint +") " );
        }

    } // end class
} // end namespace
