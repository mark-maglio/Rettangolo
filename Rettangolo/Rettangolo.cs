using System;

namespace Rettangolo
{
    public class Rettangolo
    {
        private double x;
        private double y;
        private double widht;
        private double height;

        public Rettangolo(double x , double y, double w,double h)
        {
            this.x = x;
            this.y = y;
            this.widht = w;
            this.height = h;
        } 
        public double Area
        {
            get
            {
                return widht * height;
            }
        }
        public double Perimetro
        {
            get
            {
                return widht * 2 + height * 2;
            }
        }
        public bool Contiene(Rettangolo r)
        {
            if (x <= r.x && x + widht >= r.x + r.widht && y <= r.y && y + height >= r.y + r.height)
                return true;
            return false;
        }
    }
}
