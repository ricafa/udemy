namespace gametop
{
    public class CarroFoda
    {
        private readonly iMotorista _motorista;
        public CarroFoda(iMotorista motorista){
            _motorista = motorista;
        }

        public void Ligar(){
            System.Console.Write($"{_motorista._Nome} ligou o carro");
            _motorista.Acelera();
            _motorista.MudaMarcha();
            _motorista.Freia();
        }
    }
}