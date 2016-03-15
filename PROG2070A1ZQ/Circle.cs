using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A1ZQ
{
    public class Circle
    {
        private bool negRadius = false;
        private double tempRadius;
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public bool NegRadius
        {
            get
            {
                return negRadius;
            }

            set
            {
                negRadius = value;
            }
        }
        public Circle()
        {
            radius = 16;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void AddToRadius(double num)
        {
            tempRadius = radius;
            radius = radius + num;
            if (radius < 0)
            {
                NegRadius = true;
                radius = tempRadius;
            }
            else
            {
                NegRadius = false;
            }
        }
        public void SubtractFromRadius(double num)
        {
            tempRadius = radius;
            radius = radius - num;
            if (radius < 0)
            {
                NegRadius = true;
                radius = tempRadius;
            }
            else
            {
                NegRadius = false;
            }
        }
        public double GetCircumference()
        {
            double circum = 2 * Math.PI * radius;
            circum = Math.Round(circum, 2);
            return circum;
        }
        public double GetArea()
        {
            double area = Math.PI * radius * radius;
            area = Math.Round(area, 2);
            return area;
        }
    }
}
