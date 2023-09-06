// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 18/04/2020
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="TransportModeMarketplace.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Serialization;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// The transport mode marketplace entity class.
/// This class maps a <see cref="TransportMode" /> to a VTEX/Marketplace courier code.
/// This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="IEntity" />
/// <seealso cref="IEquatable{TransportModeMarketplace}" />
[Serializer]
[Entity("MODTRANSPMKTPLC")]
public class TransportModeMarketplace : IEntity, IEquatable<TransportModeMarketplace>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    public bool Equals(TransportModeMarketplace other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || string.Equals(_code, other._code, StringComparison.InvariantCultureIgnoreCase)
                && _codeSet == other._codeSet
                && _codeTransportMode == other._codeTransportMode
                && _codeTransportModeSet == other._codeTransportModeSet
                && Equals(_transportMode, other._transportMode)
                && _transportModeSet == other._transportModeSet;
    }

    /// <summary>
    /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
    public override bool Equals(object obj)
    {
        if (obj is null)
        {
            return false;
        }

        return ReferenceEquals(this, obj)
            || obj is TransportModeMarketplace marketplace && Equals(marketplace);
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
            var hashCode =
                _code != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_code) : 0;
            hashCode = (hashCode * 397) ^ _codeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTransportMode;
            hashCode = (hashCode * 397) ^ _codeTransportModeSet.GetHashCode();
            hashCode =
                (hashCode * 397) ^ (_transportMode != null ? _transportMode.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _transportModeSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Returns a value that indicates whether the values of two <see cref="T:EditoraInovacao.Sankhya.Entities.Transport.TransportModeMarketplace" /> objects are equal.
    /// </summary>
    /// <param name="left">The first value to compare.</param>
    /// <param name="right">The second value to compare.</param>
    /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
    public static bool operator ==(TransportModeMarketplace left, TransportModeMarketplace right) =>
        Equals(left, right);

    /// <summary>
    /// Returns a value that indicates whether two <see cref="T:EditoraInovacao.Sankhya.Entities.Transport.TransportModeMarketplace" /> objects have different values.
    /// </summary>
    /// <param name="left">The first value to compare.</param>
    /// <param name="right">The second value to compare.</param>
    /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
    public static bool operator !=(TransportModeMarketplace left, TransportModeMarketplace right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The code
    /// </summary>
    private string _code;

    /// <summary>
    /// The code set
    /// </summary>
    private bool _codeSet;

    /// <summary>
    /// The code transport mode
    /// </summary>
    private int _codeTransportMode;

    /// <summary>
    /// The code transport mode set
    /// </summary>
    private bool _codeTransportModeSet;

    /// <summary>
    /// The transport mode
    /// </summary>
    private TransportMode _transportMode;

    /// <summary>
    /// The transport mode set
    /// </summary>
    private bool _transportModeSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    [EntityElement("CODTRANSPMKTPL")]
    public string Code
    {
        get => _code;
        set
        {
            _code = value;
            _codeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code transport mode.
    /// </summary>
    /// <value>The code transport mode.</value>
    [EntityElement("CODMODTRANSP")]
    public int CodeTransportMode
    {
        get => _codeTransportMode;
        set
        {
            _codeTransportMode = value;
            _codeTransportModeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the transport mode.
    /// </summary>
    /// <value>The transport mode.</value>
    [EntityReference]
    public TransportMode TransportMode
    {
        get => _transportMode;
        set
        {
            _transportMode = value;
            _transportModeSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCode() => _codeSet;

    /// <summary>
    /// The should serialize code transport mode serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTransportMode() => _codeTransportModeSet;

    /// <summary>
    /// The should serialize transport mode serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTransportMode() => _transportModeSet;

    #endregion
}
