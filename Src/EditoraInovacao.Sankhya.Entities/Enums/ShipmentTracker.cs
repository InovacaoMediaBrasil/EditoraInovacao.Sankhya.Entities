using CrispyWaffle.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// Enum ShipmentTracker
/// </summary>
public enum ShipmentTracker
{
    /// <summary>
    /// The Correios
    /// </summary>
    [HumanReadable("Correios")]
    [InternalValue("C")]
    Correios,

    /// <summary>
    /// The Mandaê
    /// </summary>
    [HumanReadable("Mandaê")]
    [InternalValue("M")]
    Mandae,

    /// <summary>
    /// The B2W Entrega.
    /// </summary>
    [HumanReadable("B2W Entrega")]
    [InternalValue("B")]
    B2WEntrega,
}
