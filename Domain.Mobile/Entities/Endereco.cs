using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mobile.Entities
{
    public class Endereco
    {

        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        //public DbGeography Coordenadas { get; set; }

        private Endereco()
        {

        }

        public Endereco(string logradouro, int numero, string complemento, string cep)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Cep = cep;
        }
    }
}
