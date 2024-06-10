using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApphotel.models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; }

        public int QntAdultos { get; set; }


        public int QntCriancas { get; set; }

        public DateTime DataCheckin { get; set; }

        public DateTime DataCheckOut { get; set;}

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckin).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_Adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulta;
                double valor_criacas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_Adultos + valor_criacas) * Estadia;

                return total;
            }  
        }
    }
}
