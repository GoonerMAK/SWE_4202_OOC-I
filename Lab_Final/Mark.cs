using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final
{
    internal class Mark
    {
        string att, q1, q2, q3, q4, mid, final, viva;

        public Mark()
        {

        }

        public Mark(string att, string q1, string q2, string q3, string q4, string mid, string final, string viva)
        {
            this.att = att;
            this.q1 = q1;
            this.q2 = q2;
            this.q3 = q3;
            this.q4 = q4;
                
            this.mid = mid;
            this.final = final;
            this.viva = viva;

        }

        

        
    }
}
