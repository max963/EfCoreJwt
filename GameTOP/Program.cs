using GameTOP.Domain;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoBom(
                new Jogador1("Ronaldo"), 
                new Jogador2());
                
            jogo.IniciarJogo();
        }
    }
}
