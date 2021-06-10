using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class Arithmetic
    {
        double a, b;

        public double Addition(double f, double s)
        {
            a = f;
            b = s;
            double c = a + b;
            return c;
        }

        public double Subtract(double f, double s) {
            a = f;
            b = s;
            double c = a - b;
            return c;
        }

        public double Division(double f, double s)
        {
            a = f;
            b = s;
            double c = a / b;
            return c;
        }

        public double Multiplication(double f, double s)
        {
            a = f;
            b = s;
            double c = a * b;
            return c;
        }


    }
}
