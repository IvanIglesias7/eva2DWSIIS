using System;
using System.Collections.Generic;

//Tabla eva_tch_notas_evaluación


namespace DAL.Model;

public partial class EvaTchNotasEvaluacion
{
    public string? MdUuid { get; set; }

    public DateTime? MdFch { get; set; }

    public int IdNotaEvaluacion { get; set; }

    public string? CodAlumno { get; set; }

    public int? NotaEvaluacion { get; set; }

    public string CodEvaluacion { get; set; } = null!;

    public virtual EvaCatEvaluacion CodEvaluacionNavigation { get; set; } = null!;
}
