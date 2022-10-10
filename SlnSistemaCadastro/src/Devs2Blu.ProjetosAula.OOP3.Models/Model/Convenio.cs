using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Convenio
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public FlconvStatus Status { get; set; }
       
        public Convenio()
        {
            Status = FlconvStatus.A;
        }

        public Convenio(string nome)
        {
            Nome = nome;
           }
    }

    public enum FlconvStatus
    {
        [Description("Inativo")]
        I=0,

        [Description("Ativo")]
        A = 1

    }
}
