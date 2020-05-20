using System;
using System.Collections.Generic;
using System.Text;

namespace Financerio
{
    class Dados
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public string Consumidor { get; set; }
        public string Estabelecimento { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public string FormaPagamento { get; set; }
        public string TipoDeCartao { get; set; }
        public int QuantidadeDeParcelas { get; set; }
        public double ValorTotal { get; set; }

        public Dados(int codigo, DateTime data, string consumidor)
        {
            Codigo = codigo;
            Data = data;
            Consumidor = consumidor;        }

        public Dados(int codigo, string data, string nome)
        {

        }

        public override string ToString()
        {
            return
                Codigo
                + ", "
                + Data
                + ", "
                + Consumidor;
        }

    }
}
