using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.ValueObject
{
    public class Periodos
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Periodos(DateTime inicio, DateTime fim)
        {
            if (inicio > fim)

                throw new ArgumentException("Data inicial não pode ser maior que a final. ");

            DataInicio = inicio;
            DataFim = fim;

        }
        public bool EstaAtrasado()
        {
            return DateTime.Now.Date > DataFim.Date;
        }
    }
}