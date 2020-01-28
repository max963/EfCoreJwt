using GameTOP.Interfaces;

namespace GameTOP.Domain
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return $"Jogador 2 esta Chutando";
        }

        public string Corre()
        {
            return $"Jogador 2 esta Correndo";
        }

        public string Passa()
        {
            return $"Jogador 2 esta Passando";
        }
    }
}