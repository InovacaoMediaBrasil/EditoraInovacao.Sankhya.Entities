// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 24/06/2014
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="CorreiosStatus.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using CrispyWaffle.Attributes;
using EditoraInovacao.Sankhya.Entities.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// Values that represent CorreiosStatus.
/// </summary>
public enum TrackingStatus
{
    /// <summary>
    /// Unrecognized.
    /// </summary>
    [HumanReadable("Unrecognized")]
    Unrecognized,

    /// <summary>
    /// Postado.
    /// </summary>
    [InternalValue("A")]
    [HumanReadable("Aceito")]
    Acceptance,

    /// <summary>
    /// Returning
    /// </summary>
    [InternalValue("B")]
    [HumanReadable("Retornando ao remetente")]
    Returning,

    /// <summary>
    /// Checked.
    /// </summary>
    [InternalValue("C")]
    [HumanReadable("Conferido")]
    Checked,

    /// <summary>
    /// Delivering
    /// </summary>
    [InternalValue("D")]
    [HumanReadable("Saiu para entrega")]
    Delivering,

    /// <summary>
    /// Enroute.
    /// </summary>
    [InternalValue("E")]
    [HumanReadable("Em rota")]
    Enroute,

    /// <summary>
    /// Restriction.
    /// </summary>
    [InternalValue("F")]
    [HumanReadable("Restrição")]
    Restriction,

    /// <summary>
    /// Away.
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("G")]
    [HumanReadable("Ausente")]
    Away,

    /// <summary>
    /// Non delivery
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("H")]
    [HumanReadable("Não entregue")]
    Nondelivery,

    /// <summary>
    /// Canceled
    /// </summary>
    [InternalValue("I")]
    [HumanReadable("Cancelado")]
    Canceled,

    /// <summary>
    /// Address incomplete
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("J")]
    [HumanReadable("Endereço incompleto")]
    AddressIncomplete,

    /// <summary>
    /// Delivering sender.
    /// </summary>
    [InternalValue("K")]
    [HumanReadable("Saiu para entrega para o remetente (devolução)")]
    DeliveringSender,

    /// <summary>
    /// Delivered sender.
    /// </summary>
    [InternalValue("L")]
    [HumanReadable("Entregue ao remetente")]
    DeliveredSender,

    /// <summary>
    /// Address irregular.
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("M")]
    [HumanReadable("Endereço irregular")]
    AddressIrregular,

    /// <summary>
    /// Client refused.
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("N")]
    [HumanReadable("Cliente recusou")]
    ClientRefused,

    /// <summary>
    /// N�o localizado no fluxo postal.
    /// </summary>
    [InternalValue("O")]
    [HumanReadable("N�o localizado no fluxo postal")]
    Lost,

    /// <summary>
    /// Destinat�rio desconhecido.
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("P")]
    [HumanReadable("Destinatário desconhecido")]
    ClientUnknown,

    /// <summary>
    /// Reintegrado.
    /// </summary>
    [InternalValue("Q")]
    [HumanReadable("Reintegrado")]
    Reinstated,

    /// <summary>
    /// Entregue.
    /// </summary>
    [InternalValue("R")]
    [HumanReadable("Entregue")]
    Delivered,

    /// <summary>
    /// Distribui��o especial agendada.
    /// </summary>
    [InternalValue("S")]
    [HumanReadable("Distribuição especial agendada")]
    Scheduled,

    /// <summary>
    /// Estornado.
    /// </summary>
    [InternalValue("T")]
    [HumanReadable("Estornado")]
    Reversed,

    /// <summary>
    /// Mal encaminhado.
    /// </summary>
    [InternalValue("U")]
    [HumanReadable("Mal encaminhado")]
    WrongRoute,

    /// <summary>
    /// Destinat�rio mudou-se.
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("V")]
    [HumanReadable("Destinat�rio mudou-se")]
    ClientMoved,

    /// <summary>
    /// Aguardando. (Aguardando retirada pelo cliente na ag�ncia).
    /// </summary>
    [TrackingStatusReturningReason]
    [InternalValue("W")]
    [HumanReadable("Aguardando retirada")]
    Awaiting,

    /// <summary>
    /// The still not arrived
    /// </summary>
    [InternalValue("X")]
    [HumanReadable("Objeto ainda não chegou na unidade")]
    StillNotArrived,

    /// <summary>
    /// The with delivery scheduled
    /// </summary>
    [InternalValue("Y")]
    [HumanReadable("Com entrega agendada")]
    WithDeliveryScheduled,

    /// <summary>
    /// The inspection
    /// </summary>
    [InternalValue("Z")]
    [HumanReadable("Objeto retido pelo órgão de fiscalização")]
    Inspection,

    /// <summary>
    /// The collected
    /// </summary>
    [InternalValue("AA")]
    [HumanReadable("Coletado")]
    Collected,

    /// <summary>
    /// The delayed
    /// </summary>
    [InternalValue("AB")]
    [HumanReadable("Atrasado")]
    Delayed,

    /// <summary>
    /// The third party refused
    /// </summary>
    [InternalValue("AC")]
    [HumanReadable("Recusado por terceiros")]
    ThirdPartyRefused,

    /// <summary>
    /// The requested contact
    /// </summary>
    [InternalValue("AD")]
    [HumanReadable("Solicitado contato com o entregador")]
    RequestedContactCourier,

    /// <summary>
    /// The return requested by sender.
    /// </summary>
    [InternalValue("AE")]
    [HumanReadable("Devolução solicitada pelo remetente")]
    ReturnRequestedBySender,

    /// <summary>
    /// THe shipment cancelled.
    /// </summary>
    [InternalValue("AF")]
    [HumanReadable("Remessa cancelada")]
    ShipmentCancelled
}
