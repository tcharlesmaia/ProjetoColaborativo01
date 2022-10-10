using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enum
{
    public enum FlStatus
    {
        [Description("Excluído")]
        E = 0,
        [Description("Ativo")]
        A = 1,
        [Description("Inativo")]
        I = 2
    }
}
