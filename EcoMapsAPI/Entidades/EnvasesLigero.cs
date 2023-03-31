using System;
using System.Collections.Generic;

namespace EcoMapsAPI.Entidades;

public partial class EnvasesLigero
{
    public double? Id { get; set; }

    public double? UdalerriaKodeaCodMunicipio { get; set; }

    public string? UdalerriaMunicipio { get; set; }

    public double? EkitaldiaEjercicio { get; set; }

    public double? EdukiontziKodeaCodContenedor { get; set; }

    public string? EdukiontziarenModeloaEuModeloContenedorEu { get; set; }

    public string? EdukiontziarenModeloaCasModeloContenedorCas { get; set; }

    public string? HondakinarenFrakzioaEuFraccionDelResiduoEu { get; set; }

    public string? HondakinarenFrakzioaCasFraccionDelResiduoCas { get; set; }

    public string? Longitude { get; set; }

    public string? Latitude { get; set; }

    public string? LatitudeGeo { get; set; }

    public string? LongitudeGeo { get; set; }
}
