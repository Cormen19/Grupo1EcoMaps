using System;
using System.Collections.Generic;

namespace EcoMapsAPI.Entidades;

public partial class PuntosMovile
{
    public DateTime? Desde { get; set; }

    public DateTime? Hasta { get; set; }

    public string? Ubicacion { get; set; }

    public double? Lat { get; set; }

    public double? Lon { get; set; }
}
