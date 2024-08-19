// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="SellerSector.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using CrispyWaffle.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// Enum SellerSector
/// </summary>
public enum SellerSector
{
    /// <summary>
    /// The none.
    /// </summary>
    [HumanReadable("Nenhum")]
    [InternalValue("0")]
    None,

    /// <summary>
    /// The e-commerce.
    /// </summary>
    [HumanReadable("e-Commerce")]
    [InternalValue("E-COMMERCE")]
    ECommerce,

    /// <summary>
    /// The active.
    /// </summary>
    [HumanReadable("Ativo")]
    [InternalValue("ATIVO")]
    Active,

    /// <summary>
    /// The receptive.
    /// </summary>
    [HumanReadable("Receptivo")]
    [InternalValue("RECEPTIVO")]
    Receptive,

    /// <summary>
    /// The customer service.
    /// </summary>
    [HumanReadable("SAC")]
    [InternalValue("SAC")]
    CustomerService,

    /// <summary>
    /// The commercial.
    /// </summary>
    [HumanReadable("Comercial")]
    [InternalValue("COMERCIAL")]
    Commercial,

    /// <summary>
    /// The production.
    /// </summary>
    [HumanReadable("Produção")]
    [InternalValue("PRODUCAO")]
    Production,

    /// <summary>
    /// The registration.
    /// </summary>
    [HumanReadable("Cadastro")]
    [InternalValue("CADASTRO")]
    Registration,

    /// <summary>
    /// The marketing.
    /// </summary>
    [HumanReadable("Marketing")]
    [InternalValue("MARKETING")]
    Marketing,

    /// <summary>
    /// The leads.
    /// </summary>
    [HumanReadable("LEADS")]
    [InternalValue("LEADS")]
    Leads,

    /// <summary>
    /// The representative.
    /// </summary>
    [HumanReadable("Representante")]
    [InternalValue("REP")]
    Representative,

    /// <summary>
    /// The IT.
    /// </summary>
    [HumanReadable("IT")]
    [InternalValue("TI")]
    It,

    /// <summary>
    /// The logistics.
    /// </summary>
    [HumanReadable("Logistics")]
    [InternalValue("LOGISTICA")]
    Logistics,

    /// <summary>
    /// The administrative.
    /// </summary>
    [HumanReadable("Administrative")]
    [InternalValue("ADM")]
    Administrative,

    /// <summary>
    /// The board of directors.
    /// </summary>
    [HumanReadable("Board of directors")]
    [InternalValue("DIRETORIA")]
    BoardOfDirectors,
}
