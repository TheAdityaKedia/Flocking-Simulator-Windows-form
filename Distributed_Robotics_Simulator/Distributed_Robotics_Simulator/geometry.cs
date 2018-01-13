using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributed_Robotics_Simulator
{
    /// <summary>
    /// Class that defines a point as two double values x, y
    /// this can also beused as a vector with i and j components
    /// </summary>
    class Point
    {
        public double X;
        public double Y;
        
        /// <summary>
        /// constructor for point class
        /// </summary>
        /// <param name="new_x">point's x value</param>
        /// <param name="new_y">point's y value</param>
        public Point(double new_x, double new_y)
        {
            this.X = new_x;
            this.Y = new_y;
        }

        /// <summary>
        /// overloading operator '+' to subtracts points
        /// </summary>
        /// <param name="a">first point</param>
        /// <param name="b">second point</param>
        /// <returns>the sum of points a nad b</returns>
        public static Point operator+ (Point a, Point b)
        {
            double new_x = a.X + b.X;
            double new_y = a.Y + b.Y;

            Point p = new Point(new_x, new_y);

            return p;
        }

        /// <summary>
        /// overloading operator '-' to subtracts points
        /// </summary>
        /// <param name="a">first point</param>
        /// <param name="b">second point</param>
        /// <returns>the difference between points a nad b</returns>
        public static Point operator- (Point a, Point b)
        {
            double new_x = a.X - b.X;
            double new_y = a.Y - b.Y;

            Point p = new Point(new_x, new_y);

            return p;
        }
        
        /// <summary>
        /// overloading operator '*' to multiply scalars to points
        /// </summary>
        /// <param name="num">scalar to be multiplied</param>
        /// <param name="p">point to which scalar is being multiplied</param>
        /// <returns>new point that has been scaled by the scalar</returns>
        public static Point operator* (double num, Point p)
        {
            Point new_point = new Point(num * p.X, num * p.Y);
            return new_point;
        }

        /// <summary>
        /// overloading operator '/' to divide scalars to points
        /// </summary>
        /// <param name="p">point to be divided by scalar</param>
        /// <param name="num">scalat that the point needs to be divided by</param>
        /// <returns></returns>
        public static Point operator/ (Point p, double num)
        {
            Point new_point = new Point(p.X / num, p.Y / num);
            return new_point;
        }

        /// <summary>
        /// Fucntion to get the norm when Point is used as vectror
        /// </summary>
        /// <returns> magnitude of vector as a double value</returns>
        public double GetNorm()
        {
            double Norm = Math.Sqrt(X * X + Y * Y);
            return Norm;
        }

        /// <summary>
        /// function to get the direction as a radian angle wharn point is used as a vector
        /// </summary>
        /// <returns>angle of the vector in radians</returns>
        public double GetDirection()
        {
            double direction = Math.Atan2(Y, X);

            return direction;
        }

        /// <summary>
        /// function to find the unit vector when point is used as a vector
        /// </summary>
        /// <returns>unit vector as point</returns>
        public Point GetUnitVector()
        {
            double norm = this.GetNorm();
            double new_x = 0;
            double new_y = 0;
            if (norm != 0)
            {
                new_x = X / norm;
                new_y = Y / norm;
            }
            Point new_point = new Point(new_x, new_y);
            return new_point;
        }

        public new String ToString()
        {
            string thispoint = String.Format("({0},{1})", this.X, this.Y);

            return thispoint;
        }

        /// <summary>
        /// function to find the cross product between 2 vectors
        /// </summary>
        /// <param name="p">the point that this point needs to be crossed with</param>
        /// <returns>returns the coss procut of this point with point p</returns>
        public double Cross(Point p)
        {
            double z_comp = this.X * p.Y - p.X * this.Y;

            return z_comp;
        }

        /// <summary>
        /// function to find the dot product of two vectors
        /// </summary>
        /// <param name="p">the point that this poin needs to be dotted with</param>
        /// <returns>the dot product of this point with poin p</returns>
        public double Dot(Point p)
        {
            return this.X * p.X + this.Y * p.Y;
        }

        /// <summary>
        /// Function to get the distance between 2 points
        /// </summary>
        /// <param name="p">the point from which the distance of this point is needed</param>
        /// <returns>the magnitude of the distance between the 2 points</returns>
        public double GetDistanceFrom(Point p)
        {
            Point distvector = p -this;

            return distvector.GetNorm();
        }
    }

    /// <summary>
    /// Class that defines a line given 2 points
    /// This can also be used as a vector from one point to the other
    /// 
    /// </summary>
    class Line
    {
        public Point p1;
        public Point p2;
        public Point vector;

        /// <summary>
        /// Constructor for the line class. Takes two points
        /// </summary>
        /// <param name="p1">The first point on the line</param>
        /// <param name="p2">The second point on the line</param>
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            vector = p2 - p1;
        }


        /// <summary>
        /// Function to find the slope of the line
        /// </summary>
        /// <returns>The slope of the line as a double</returns>
        public double GetSlope()
        {
            double slope = 0; //new variable to contain slope - to be returned

            double rise = p2.Y - p1.Y; 
            double run = p2.X - p1.X;

            slope = rise / run;

            return slope;
        }

        /// <summary>
        /// Function to get the negative of the line's y-intercept
        /// i.e. the value of c in the line equation y = mx + c
        /// </summary>
        /// <returns>negative of the line's y-intercept</returns>
        public double GetIntercept()
        {
            double intercept = 0;
            double slope = GetSlope();
            intercept = p1.Y - (slope * p1.X); // since c = y - mx
            return intercept;
        }

        /// <summary>
        /// Function to get the point on a line that is obtained by
        /// dropping a perpendicular from another point p
        /// </summary>
        /// <param name="p"> The point from which a perpendicular is being dropped </param>
        /// <returns>The point on the line which would give a perpendicular when connected to point p</returns>
        public Point PointOnPerpendicularFrom(Point p)
        {
            if (OnThisLine(p)) //if the point is already on the line, a perpendicular can't be dropped
            {
                return p; //This IS the point you are looking for
            }

            

            Point newPoint = new Point(0, 0);
            if (GetSlope() == 0)
            {
                newPoint.X = p.X;
                newPoint.Y = GetIntercept();
            }
            else if(double.IsInfinity(GetSlope()) || double.IsNaN(GetSlope()))
            {
                newPoint.X = p1.Y;
                newPoint.Y = p.Y;
            }
            else
            {
                double m2 = -1 / GetSlope(); // slope of perpendicular line
                double c2 = -p.Y / (m2 * p.X); // negative intercept of perpendicular line
                double c1 = this.GetIntercept(); // negative intercept of this line
                double m1 = this.GetSlope(); // slope of this line

                // x and y are solved for using cramer's rule
                newPoint.X = (c1 - c2) / (m2 - m1); // det(A1)/det(A)
                newPoint.Y = (m2 * c1 - m1 * c2) / (m2 - m1); // det(A2)/det(A)
            }
            
            return newPoint;
        }

        /// <summary>
        /// Function to determine if a point lies on this line 
        /// </summary>
        /// <param name="p">the point to be tested</param>
        /// <returns>true of false based on whether the point lies on this line</returns>
        public bool OnThisLine(Point p)
        {
            double characteristicValue = p.Y - (GetSlope()) * p.X - GetIntercept();

            if(characteristicValue == 0)
            {
                return true;
            }

            return false;
        }
    }
}
