using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreckenUPunkte
{
    public class Strecke
    {
        public Punkt p1 { get; set; }

        public Punkt p2 { get; set; }

        public Strecke(Punkt p1, Punkt p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double length()
        {
            return Math.Sqrt(Math.Pow((p2.x - p1.x),2) + Math.Pow((p2.y - p1.y),2));
        }

        public override string ToString()
        {
            return "Strecke: Punkt1: " + p1.ToString() + " Punkt2: " + p2.ToString() + ", Länge:" + Math.Round(length(), 2);
        }
    }
}
