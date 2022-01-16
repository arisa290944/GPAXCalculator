using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAXCalculator
{
    internal class Student
    {
        int age = 20;
        int birthyear; //2000
        string name;

        //creat as public class
        public int getAge() {
            return 2022 - this.birthyear;
        }
        public void setBirthYear(int birthYear) {
            this.birthyear = birthYear;
        }
    }
}
