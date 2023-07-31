using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTelas
{
    class Model
    {
        private double num1;
        private double num2;

        public Model()
        {
            getnum1 = 0;
            getnum2 = 0;
        }

        public double getnum1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double getnum2
        {
            get { return num2; }
            set { num2 = value; }
        }


        public double Somar()
        {
            
            return  getnum1 + getnum2;
        }

        public double Subtrair()
        {
            return getnum1 - getnum2;
        }

        public double Divisao()
        {
            return getnum1 / getnum2;
        }

        public double Multiplicar()
        {
            return getnum1 * getnum2;
        }

        
    }

    
}
