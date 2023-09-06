// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 11-29-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderImportStatus.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using CrispyWaffle.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Enums;

/// <summary>
/// Enum OrderImportStatus
/// </summary>
public enum OrderImportStatus
{
    /// <summary>
    /// The successful
    /// </summary>
    [InternalValue("S")]
    [HumanReadable("Importado com sucesso")]
    Successful,

    /// <summary>
    /// The error
    /// </summary>
    [InternalValue("E")]
    [HumanReadable("Com erro")]
    Error,

    /// <summary>
    /// The awaiting
    /// </summary>
    [InternalValue("A")]
    [HumanReadable("Aguardando nova tentativa")]
    Awaiting,

    /// <summary>
    /// The manual
    /// </summary>
    [InternalValue("M")]
    [HumanReadable("Importação manual")]
    Manual,

    /// <summary>
    /// The importing
    /// </summary>
    [InternalValue("P")]
    [HumanReadable("Em processamento")]
    Importing
}
