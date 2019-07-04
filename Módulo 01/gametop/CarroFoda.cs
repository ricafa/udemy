namespace gametop
{
    public class CarroFoda
    {
        private readonly iMotorista _motorista1;
        private readonly iMotorista _motorista2;
        public CarroFoda(iMotorista motorista1,iMotorista motorista2){
            _motorista1 = motorista1;
            _motorista2 = motorista2;
        }

        public void Ligar(){
            System.Console.WriteLine(_motorista1.Acelera());
            System.Console.WriteLine(_motorista1.MudaMarcha());
            System.Console.WriteLine(_motorista1.Freia());
            
            System.Console.WriteLine("\n Proximo Jogador \n");

            System.Console.WriteLine(_motorista2.Acelera());
            System.Console.WriteLine(_motorista2.MudaMarcha());
            System.Console.WriteLine(_motorista2.Freia());
        }
    }
}