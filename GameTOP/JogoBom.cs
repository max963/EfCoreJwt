using System;
using GameTOP.Interfaces;

namespace GameTOP
{
    class JogoBom
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;
        public JogoBom(IJogador jogador1, IJogador jogador2)
        {
            this._jogador2 = jogador2;
            this._jogador1 = jogador1;

        }
        public void IniciarJogo()
        {
            Console.WriteLine(_jogador1.Corre());
            Console.WriteLine(_jogador2.Chuta());
        }
    }
}
