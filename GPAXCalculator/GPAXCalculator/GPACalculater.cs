using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAXCalculator
{
    internal class GPACalculater
    {
        private double gpa_sum = 0;
        private int n = 0;
        private double gpa_min = 0;
        private double gpa_max = 0;
        
        
        public void setGPA(double gpa) {
            this.gpa_sum += gpa;
            this.n++;
        }
        public double getGPAx() {
            return gpa_sum / n;
        }

        /*public double GetMaxGPA() {
            return gpa_max = double.Max(gpa_sum);
        }*/
        //public double GetMinGPA() { }
    }
}
