using CrispyWaffle.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// Enum PaymentStatus
/// </summary>
public enum PaymentStatus
{
    /// <summary>
    /// The pending
    /// </summary>
    [InternalValue("P")]
    [HumanReadable("Pendente")]
    Pending,

    /// <summary>
    /// The paid
    /// </summary>
    [InternalValue("E")]
    [HumanReadable("Efetuado")]
    Paid,

    /// <summary>
    /// The reversal
    /// </summary>
    [InternalValue("R")]
    [HumanReadable("Estornado")]
    Reversal,

    /// <summary>
    /// The billed
    /// </summary>
    [InternalValue("F")]
    [HumanReadable("Faturado")]
    Billed,
}
