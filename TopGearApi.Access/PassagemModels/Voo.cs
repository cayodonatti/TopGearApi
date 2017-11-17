using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopGearApi.Access.PassagemModels
{
    public class Voo
    {
        public int idVoo { get; set; }
        public string codigo { get; set; }
        public DateTime partida { get; set; }
        public DateTime chegada { get; set; }
        public int preco { get; set; }
        public string aeroporto_partida { get; set; }
        public string cidade_partida { get; set; }
        public string estado_partida { get; set; }
        public string pais_partida { get; set; }
        public string sigla_aeroporto_partida { get; set; }
        public string aeroporto_destino { get; set; }
        public string cidade_destino { get; set; }
        public string estado_destino { get; set; }
        public string pais_destino { get; set; }
        public string sigla_aeroporto_destino { get; set; }
        public string modelo_aviao { get; set; }
        public int capacidade_aviao { get; set; }
        public string fabricante_aviao { get; set; }
    }
}
