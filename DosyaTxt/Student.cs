using System;
using System.Collections.Generic;
using System.Text;

namespace DosyaTxt
{
    class Student
    {
        public string name;
        public string surname;
        public int no;
        public string gender;
        public double gano;
        public int Grade;
        public int classGre;
        public int depertmantGre;

        public Student()
        {

        }

        public Student(string name, string surname,int no, string gender, double gano, int Grade, int classGre, int depertmantGre)
        {
            this.name = name;
            this.surname = surname;
            this.no = no;
            this.gender = gender;
            this.gano = gano;
            this.Grade = Grade;
            this.classGre = classGre;
            this.depertmantGre = depertmantGre;
        }
      
        public string Write()
        {
            string toString = no + " - " + gano.ToString("0.000") + " - " + gender + " - " + Grade + " - " + classGre + " - " + depertmantGre+" - "+name+ " - "+surname;
            Console.WriteLine(toString);
            return toString;
        }

    }
}
