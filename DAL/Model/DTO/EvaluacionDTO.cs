using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.DTO
{
    public class EvaluacionDTO
    {
        public string? CodAlumno { get; set; }

        public int? NotaEvaluacion { get; set; }

        public string CodEvaluacion { get; set; } = null!;


        public EvaluacionDTO(string? codAlumno, int? notaEvaluacion, string codEvaluacion)
        {
            this.CodAlumno = codAlumno;
            this.NotaEvaluacion = notaEvaluacion;
            CodEvaluacion = codEvaluacion;
        }
    }
}
