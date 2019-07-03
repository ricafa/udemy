using System;

namespace gametop.Lib
{
    public class Motorista1 : iMotorista
    {
        public readonly string _Nome;

        public Motorista1(string nome){
            _Nome = nome;
        }
         public String Acelera()
         {
            return $"{_Nome} está acelerando \n";
         }
         public String Freia()
         {
            return $"{_Nome} está frenando \n";
         }

         public String MudaMarcha()
         {
             return $"{_Nome} trocou a marcha \n";
         }   
    }
}