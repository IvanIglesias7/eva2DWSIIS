using System;
using System.Collections.Generic;

//Tabla eva_cat_evaluacion

namespace DAL.Model;

public partial class EvaCatEvaluacion
{
    public string CodEvaluacion { get; set; } = null!;

    public string? DescEvaluacion { get; set; }

    public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();
}
