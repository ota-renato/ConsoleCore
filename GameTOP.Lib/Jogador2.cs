using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Jogador2 esta chutando";
        }

        public string Corre()
        {
            return "Jogador2 esta correndo";
        }

        public string Passe()
        {
            return "Jogador2 esta passando";
        }
    }
}