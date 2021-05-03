using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab  { get; protected set; }

        //Construtores:
        public Peca(Tabuleiro tab, Cor cor)
        {

        }

        public Peca( Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            qteMovimento = 0;
        }

      
    }
}
