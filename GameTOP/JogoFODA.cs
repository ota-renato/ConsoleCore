using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _jogador1;
        private readonly iJogador _jogador2;

        private readonly iJogador _jogador3;
        public JogoFODA(iJogador jogador1, iJogador jogador2, iJogador jogador3)
        {
            _jogador1 = jogador1;

            _jogador2 = jogador2;

            _jogador3 = jogador3;
        }

        public void IniciarJogo()
        {
            System.Console.WriteLine(_jogador1.Corre());
            System.Console.WriteLine(_jogador1.Chuta());
            System.Console.WriteLine(_jogador1.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.WriteLine(_jogador2.Corre());
            System.Console.WriteLine(_jogador2.Chuta());
            System.Console.WriteLine(_jogador2.Passe());

            System.Console.Write("\n PRÓXIMO JOGADOR \n");

            System.Console.WriteLine(_jogador3.Corre());
            System.Console.WriteLine(_jogador3.Chuta());
            System.Console.WriteLine(_jogador3.Passe());
        }
    }
}