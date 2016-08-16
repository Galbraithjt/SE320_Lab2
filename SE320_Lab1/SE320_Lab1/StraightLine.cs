using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Now, add a Class that describes a StraightLine object. This should extend or inherit from the base class Line. 
//The Line class members can be set to protected or remain private (your design choice). Add a 2 members to the 
//StraightLine class called length (int) and direction (int). Provide only the required methods and do not allow 
//values below 0 or above 50 for length. Direction should only take values 0 – 3… where 0 = up, 1 = right, 
//2 = down, and 3 = left.

//Add a new private method called determinePoint2() that uses the length and direction provided to create the 
//2nd Point object. Do this by Adding or Subtracting the length from either the x1 or y1 value of the first point. 
//The other value will remain the same (so if solve for x2, then y2 will be equal to y1. If you solve for y2, 
//then x2 = x1).

namespace SE320_Lab1
{
    class StraightLine : Line
    {
        private int length;
        private int direction;

        public StraightLine() : this(new Point(), 0, 0) // base constructor
        {
            //empty 
        }

        public StraightLine(Point p, int l, int d) : base (new Point(p.Xpoint, p.Ypoint) , p) // full constructor
        {
            Length = l;
            Direction = d;
            determinePoint2(p);
        }

        private enum dirEnum
        {
            UP = 0,
            RIGHT = 1,
            DOWN = 2,
            LEFT = 3
        }

        public int Length // get and set for length
        {
            get
            {
                return length;
            }

            set
            {
                if (value >= 0 && value <= 50)
                {
                    length = value;
                }

                else
                {
                    throw new Exception("Length out of range");
                }
            }
        } // end get and set for length

        public int Direction // get and set for direction
        {
            get
            {
                return direction;
            }

            set
            {
                if (value >= 0 && value <=3)
                {
                    direction = value;
                }

                else
                {
                    throw new Exception("Length out of range");
                }
            }
        } // end get and set for direction

        public void determinePoint2(Point b) // switch for direction 0 = up, 1 = right, 2 = down, and 3 = left.
        {
            switch ((dirEnum ) Direction )
            {
                case dirEnum.UP:
                    b.Ypoint += Length;
                    break;
                case dirEnum.RIGHT:
                    b.Xpoint += Length;
                    break;
                case dirEnum.DOWN:
                    b.Ypoint -= Length;
                    break;
                case dirEnum.LEFT:
                    b.Xpoint -= Length;
                    break;
            }
        }
    }
}
