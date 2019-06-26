namespace gametop
{
    public class JogoFoda
    {
        public global::System.String _Nome { get; }
        public JogoFoda(string nome){
            _Nome = nome;
        }

        public void IniciarJogo(){
            System.Console.Write($"{_Nome} 1 deu um passe");
        }
    }
}