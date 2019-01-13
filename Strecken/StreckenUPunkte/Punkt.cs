using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreckenUPunkte
{
    public class Punkt
    {
        public int x { get; set; }
        public int y { get; set; }

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y; 
        }
    }
}
