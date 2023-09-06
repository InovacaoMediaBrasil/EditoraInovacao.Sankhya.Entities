// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 01-16-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderFlow.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using CrispyWaffle.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// Enum OrderFlow
/// </summary>
public enum OrderFlow
{
    /// <summary>
    /// The none.
    /// </summary>
    [HumanReadable("None")]
    None,

    /// <summary>
    /// The payment approved.
    /// </summary>
    [InternalValue("B")]
    [HumanReadable("Payment approved")]
    Payment,

    /// <summary>
    /// The canceled.
    /// </summary>
    [InternalValue("C")]
    [HumanReadable("Canceled")]
    Canceled,

    /// <summary>
    /// The returned.
    /// </summary>
    [InternalValue("D")]
    [HumanReadable("Returned")]
    Returned,

    /// <summary>
    /// The expedition.
    /// </summary>
    [InternalValue("E")]
    [HumanReadable("Expedition")]
    Expedition,

    /// <summary>
    /// The payment notification.
    /// </summary>
    [InternalValue("H")]
    [HumanReadable("Payment notification")]
    PaymentNotification,

    /// <summary>
    /// The printed.
    /// </summary>
    [InternalValue("I")]
    [HumanReadable("Printed")]
    Printed,

    /// <summary>
    /// The customer service.
    /// </summary>
    [InternalValue("K")]
    [HumanReadable("Customer service")]
    CustomerService,

    /// <summary>
    /// The invoice digital course.
    /// </summary>
    [InternalValue("M")]
    [HumanReadable("Fiscal invoice - digital course")]
    InvoiceDigitalCourse,

    /// <summary>
    /// NF-e.
    /// </summary>
    [InternalValue("N")]
    [HumanReadable("Fiscal invoice")]
    FiscalInvoice,

    /// <summary>
    /// The order.
    /// </summary>
    [InternalValue("P")]
    [HumanReadable("Order")]
    Order,

    /// <summary>
    /// The digital delivered.
    /// </summary>
    [InternalValue("Q")]
    [HumanReadable("Delivered digitally")]
    DigitalDelivered,

    /// <summary>
    /// The reversal.
    /// </summary>
    [InternalValue("R")]
    [HumanReadable("Reversed")]
    Reversal,

    /// <summary>
    /// The invoice.
    /// </summary>
    [InternalValue("V")]
    [HumanReadable("Invoice")]
    Invoice,

    /// <summary>
    /// The digital canceled.
    /// </summary>
    [InternalValue("W")]
    [HumanReadable("Canceled digitally")]
    DigitalCanceled,

    /// <summary>
    /// The removed.
    /// </summary>
    [InternalValue("X")]
    [HumanReadable("Removed")]
    Removed,

    /// <summary>
    /// The change items.
    /// </summary>
    [InternalValue("A")]
    [HumanReadable("Change items")]
    ChangeItems,
}
