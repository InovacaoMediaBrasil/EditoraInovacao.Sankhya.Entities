// ***********************************************************************
// Assembly         : IntegracaoService.Commons
// Author           : Guilherme Branco Stracini
// Created          : 12-26-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="InvalidDriveException.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.Runtime.Serialization;
using CrispyWaffle.Extensions;
using EditoraInovacao.Sankhya.Entities.Enums;

namespace EditoraInovacao.Sankhya.Entities.GoodPractices;

/// <summary>
/// Class InvalidDriveException.
/// Implements the <see cref="System.Exception" />
/// </summary>
/// <seealso cref="System.Exception" />
[Serializable]
public class InvalidDriveException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidDriveException"/> class.
    /// </summary>
    /// <param name="currentStatus">The current status.</param>
    /// <param name="orderId">The order identifier.</param>
    /// <param name="innerException">The inner exception.</param>
    public InvalidDriveException(
        TrackingStatus currentStatus,
        int orderId,
        Exception innerException
    )
        : base(
            $"Unable to process the order drive {currentStatus.GetHumanReadableValue()} for the order {orderId}",
            innerException
        ) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidDriveException"/> class.
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
    protected InvalidDriveException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }
}
