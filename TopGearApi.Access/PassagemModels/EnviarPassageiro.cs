using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopGearApi.Access.PassagemModels
{
    public class EnviarPassageiro
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public DateTime? dataNascimento { get; set; }
    }
}
