using System;

namespace gametop
{
    class Program
    {
        static void Main(string[] args){
            CarroFoda carro = new CarroFoda(new Motorista1("Ricardo"));
            carro.Ligar();
        }
    }
}
