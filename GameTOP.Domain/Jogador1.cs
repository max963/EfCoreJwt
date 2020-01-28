using GameTOP.Interfaces;

namespace GameTOP.Domain
{
    public class Jogador1 : IJogador
    {
        public string Nome { get; set; }

        public Jogador1(string nome)
        {
            Nome = nome;
        }


        public string Chuta(){
            return $"{Nome} Chuta";
        }
        public string Corre(){
            return $"{Nome} Corre";
        }
        public string Passa(){
            return $"{Nome} Passe";
        }
    }
}