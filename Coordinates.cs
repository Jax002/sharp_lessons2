using System;
using System.Collections.Generic;
using System.Text;

namespace sharp_lessons2
{
    public struct Coordinates
    {
        public double x;
        public double y;
        public double z;
        public Coordinates(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double GetDistance(Coordinates other)
        {
            double deltaX = other.x - x;
            double deltaY = other.y - y;
            double deltaZ = other.z - z;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
