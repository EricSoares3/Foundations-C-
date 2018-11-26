using System;

namespace Curso // Pascal case 
{
    class ContaBancaria // Pascal case
    {
        public string Titular /*Propriedade = pascal case*/ { get; set; }
        private double _saldo /* atributo interno da classe = padrão */;
        public void Deposito /*Nome de método = pascal case */  (double quantia /*parâmetro = camel case */)
        {
            _saldo /*atributo interno de um método = padrão */ += quantia /*atributo interno de um método = padrão */ ;
        }
        public double GetSaldo /*Nome de método = pascal case */ ()
        {
            return _saldo /*atributo interno de um método = padrão */ ;
        }
    }
}