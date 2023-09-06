// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 11/04/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="ShipmentStatus.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using CrispyWaffle.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// Enum ShipmentStatus
/// </summary>
public enum ShipmentStatus
{
    /// <summary>
    /// The not started
    /// </summary>
    [InternalValue("N")]
    [HumanReadable("Not started")]
    NotStarted,

    /// <summary>
    /// The in transport
    /// </summary>
    [InternalValue("T")]
    [HumanReadable("In transport")]
    InTransport,

    /// <summary>
    /// The delivered
    /// </summary>
    [InternalValue("E")]
    [HumanReadable("Delivered")]
    Delivered,

    /// <summary>
    /// The returned
    /// </summary>
    [InternalValue("D")]
    [HumanReadable("Returned")]
    Returned,

    /// <summary>
    /// The without tracking
    /// </summary>
    [InternalValue("S")]
    [HumanReadable("Without tracking")]
    WithoutTracking,

    /// <summary>
    /// The lost
    /// </summary>
    [InternalValue("P")]
    [HumanReadable("Lost")]
    Lost,

    /// <summary>
    /// The canceled
    /// </summary>
    [InternalValue("C")]
    [HumanReadable("Canceled")]
    Canceled,

    /// <summary>
    /// The not collected
    /// </summary>
    [InternalValue("M")]
    [HumanReadable("Not collected")]
    NotCollected,

    /// <summary>
    /// The past due.
    /// </summary>
    [InternalValue("V")]
    [HumanReadable("PLP past due")]
    PastDue,
}
