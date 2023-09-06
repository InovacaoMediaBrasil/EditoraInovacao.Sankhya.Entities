// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 20/12/2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderControlFlowResend.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Serialization;
using Sankhya.Attributes;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// A pedido smart checkout reenvio fluxo dto.
/// </summary>
/// <seealso cref="OrderControlFlow" />
[Serializer]
[Entity("PEDIDOVTEXSCREENVIOFLUXO")]
public sealed class OrderControlFlowResend : OrderControlFlow, IEquatable<OrderControlFlowResend>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    public bool Equals(OrderControlFlowResend other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || base.Equals(other)
                && _codeResend == other._codeResend
                && _codeResendSet == other._codeResendSet;
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        var a = obj as OrderControlFlowResend;
        return a != null && Equals(a);
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = base.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeResend;
            hashCode = (hashCode * 397) ^ _codeResendSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(OrderControlFlowResend left, OrderControlFlowResend right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(OrderControlFlowResend left, OrderControlFlowResend right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The code resend
    /// </summary>
    private int _codeResend;

    /// <summary>
    /// The code resend set
    /// </summary>
    private bool _codeResendSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code resend.
    /// </summary>
    /// <value>The code resend.</value>
    [EntityKey]
    [EntityElement("CODREENVIO")]
    public int CodeResend
    {
        get => _codeResend;
        set
        {
            _codeResend = value;
            _codeResendSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize code resend.
    /// </summary>
    /// <returns>Boolean.</returns>
    public bool ShouldSerializeCodeResend() => _codeResendSet;

    #endregion
}
