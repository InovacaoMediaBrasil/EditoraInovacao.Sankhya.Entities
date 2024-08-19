using CrispyWaffle.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// The multi store priority enumeration.
/// </summary>
public enum MultiStorePriority
{
    /// <summary>
    /// The above normal.
    /// </summary>
    [InternalValue("-1")]
    [HumanReadable("Above normal")]
    AboveNormal = -1,

    /// <summary>
    /// The normal.
    /// </summary>
    [InternalValue("0")]
    [HumanReadable("Normal")]
    Normal = 0,

    /// <summary>
    /// The below normal.
    /// </summary>
    [InternalValue("1")]
    [HumanReadable("Below normal")]
    BelowNormal = 1,

    /// <summary>
    /// The highest.
    /// </summary>
    [InternalValue("2")]
    [HumanReadable("Highest")]
    Highest = 2,
}
