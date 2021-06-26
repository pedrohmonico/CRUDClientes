using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDClientes.Models.Entidades
{
    [Table("Cliente")]
    public class Clientes
    {
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome")]
        public string NomeCliente {get; set;}

        [Display(Description = "Documento")]
        public string Documento { get; set; }

        [Display(Description = "Tipo de documento")]
        public int TipoDocumento { get; set; }

        [Display(Description = "Telefone")]
        public string Celular { get; set; }

        [Display(Description = "Telefone2")]
        public string Celular2 { get; set; }

        [Display(Description = "Telefone3")]
        public string Celular3 { get; set; }

        [Display(Description = "Tipo de telefone")]
       public int TipoCelular { get; set; }

        [Display(Description = "Tipo de telefone 2")]
        public int TipoCelular2 { get; set; }

        [Display(Description = "Tipo de telefone 3")]
        public int TipoCelular3 { get; set; }

        [Display(Description = "Endereço")]
        public string Endereco { get; set; }

        [Display(Description = "Endereço 2")]
        public string Endereco2 { get; set; }

        [Display(Description = "Endereço 3")]
        public string Endereco3 { get; set; }

        [Display(Description = "Tipo de endereço")]
        public int TipoEndereco { get; set; }

        [Display(Description = "Tipo de endereço 2")]
        public int TipoEndereco2 { get; set; }

        [Display(Description = "Tipo de endereço 2")]
        public int TipoEndereco3 { get; set; }
    }
}
