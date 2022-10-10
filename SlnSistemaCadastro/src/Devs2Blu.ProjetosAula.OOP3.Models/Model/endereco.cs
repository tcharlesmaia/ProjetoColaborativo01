using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Endereco
    {
        //******************************
        public int Id_endereco { get; set; }
        //*******************************


        public int Id { get; set; }

        public Pessoa Pessoa { get; set; }
        public String CEP { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }

        public Int32 Numero { get; set; }
        
        public Endereco()
        {

        }

        public Endereco(int id, Pessoa pessoa, string cEP, string rua, string bairro, string cidade, string uF, int numero)
        {
            Id = id;
            Pessoa = pessoa;
            CEP = cEP;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            Numero = numero;
        }
}

}
