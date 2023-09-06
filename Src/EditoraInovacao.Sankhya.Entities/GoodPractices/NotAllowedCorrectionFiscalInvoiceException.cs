// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 15/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 06/03/2023
// ***********************************************************************
// <copyright file="NotAllowedCorrectionFiscalInvoiceException.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Globalization;
using System.Runtime.Serialization;
using CrispyWaffle.Extensions;
using Sankhya.Enums;

namespace EditoraInovacao.Sankhya.Entities.GoodPractices;

/// <summary>
/// Class NotAllowedCorrectionFiscalInvoiceException.
/// Implements the <see cref="Exception" />
/// </summary>
/// <seealso cref="Exception" />
[Serializable]
public class NotAllowedCorrectionFiscalInvoiceException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotAllowedCorrectionFiscalInvoiceException"/> class.
    /// </summary>
    /// <param name="singleNumber">The single number.</param>
    /// <param name="status">The status.</param>
    public NotAllowedCorrectionFiscalInvoiceException(int singleNumber, FiscalInvoiceStatus status)
        : base(
            string.Format(
                CultureInfo.CurrentCulture,
                "The fiscal invoice {0} with >fiscal invoice status {1} does not allow correction",
                singleNumber,
                status.GetHumanReadableValue()
            )
        ) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="NotAllowedCorrectionFiscalInvoiceException"/> class.
    /// </summary>
    /// <param name="singleNumber">The single number.</param>
    /// <param name="operationType">Type of the operation.</param>
    public NotAllowedCorrectionFiscalInvoiceException(int singleNumber, int operationType)
        : base(
            string.Format(
                CultureInfo.CurrentCulture,
                "The fiscal invoice {0} with operation type {1} does not allow correction",
                singleNumber,
                operationType
            )
        ) => OperationType = operationType;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotAllowedCorrectionFiscalInvoiceException"/> class.
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
    protected NotAllowedCorrectionFiscalInvoiceException(
        SerializationInfo info,
        StreamingContext context
    )
        : base(info, context) { }

    /// <summary>
    /// Gets the type of the operation.
    /// </summary>
    /// <value>The type of the operation.</value>
    public int OperationType { get; }
}
