using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDispositivo.Models
{
    public class Dispositivo
    {
        public int Id { get; set; }
        public decimal Aliquota { get; set; }
        public string Descricao { get; set; }
        public string StatusDispositivo { get; set; }

        public int fabricante_id { get; set; }
        public string NomeFabricante { get; set; }

        // Construtor padrão
        public Dispositivo() { }

        // Construtor com parâmetros
        public Dispositivo(int id, decimal aliquota, string descricao, string statusDispositivo)
        {
            Id = id;
            Aliquota = aliquota;
            Descricao = descricao;
            StatusDispositivo = statusDispositivo;
        }
    }
}
