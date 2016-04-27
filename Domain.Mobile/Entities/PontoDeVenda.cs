using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Mobile.Entities
{
    public class PontoDeVenda
    {

        public int Id { get; set; }
        public string NomeEstabelecimento { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public string NomeContato { get; set; }

        public virtual List<Pedido> Pedidos { get; set; }

        private PontoDeVenda()
        {

        }

        public PontoDeVenda(Endereco endereco, string nomeEstabelecimento, string telefone, string nomeContato)
        {
            this.Endereco = endereco;
            this.NomeEstabelecimento = nomeEstabelecimento;
            this.Telefone = telefone;
            this.NomeContato = nomeContato;
        }
    }
}
