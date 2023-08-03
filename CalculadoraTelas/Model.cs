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
        private double operacao;
        public Model()
        {
            ConsultarOperacao = 0;
        }//fim do construtor

        public double ConsultarOperacao
        {
            get { return operacao;}
            set { this.operacao = value;}
        }//fim do método

        public double Somar(double getnum)
        {
            return ConsultarOperacao = getnum + getnum;
        }//fim do somar

        public double Subtrair(double getnum)
        {
            return ConsultarOperacao = getnum - getnum ;
        }//fim do subtrair

        public double Dividir(double getnum)
        {
            if(getnum == 0)
            {
                return 0;
            }

            return ConsultarOperacao = getnum / getnum;
        }//fim do somar

        public double Multiplicar(double getnum)
        {
            return ConsultarOperacao = getnum * getnum;
        }//fim do multiplicar

        public double Raiz(double getnum)
        {
            return ConsultarOperacao + Math.Sqrt(getnum);
        }//fim da Raiz

        public double Potencia (double getnum)
        {
            return ConsultarOperacao = Math.Pow(getnum, getnum);
        }//fim da potencia

        public double Limpa(double num)
        {
            return 0;
        }
              
    }

    
}
