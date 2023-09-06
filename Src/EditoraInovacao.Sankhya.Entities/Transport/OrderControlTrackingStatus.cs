// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 08-06-2020
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderControlTrackingStatus.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using EditoraInovacao.Sankhya.Entities.Enums;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class OrderControlTrackingStatus.
/// Implements the <see cref="IEntity" />
/// </summary>
/// <seealso cref="IEntity" />
[Entity("AD_CPSTATUSMONITORAMENTO")]
public class OrderControlTrackingStatus : IEntity, IEquatable<OrderControlTrackingStatus>
{
    #region Equality members

    /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>
    /// <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    public bool Equals(OrderControlTrackingStatus other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return _codeStatus == other._codeStatus
            && _codeStatusSet == other._codeStatusSet
            && _status == other._status
            && _statusSet == other._statusSet
            && string.Equals(_text, other._text, StringComparison.InvariantCultureIgnoreCase)
            && _textSet == other._textSet;
    }

    /// <summary>Determines whether the specified object is equal to the current object.</summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>
    /// <see langword="true" /> if the specified object  is equal to the current object; otherwise, <see langword="false" />.</returns>
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

        if (obj.GetType() != GetType())
        {
            return false;
        }

        return Equals((OrderControlTrackingStatus)obj);
    }

    /// <summary>Serves as the default hash function.</summary>
    /// <returns>A hash code for the current object.</returns>
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _codeStatus;
            hashCode = (hashCode * 397) ^ _codeStatusSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_status;
            hashCode = (hashCode * 397) ^ _statusSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _text != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_text) : 0
                );
            hashCode = (hashCode * 397) ^ _textSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>Returns a value that indicates whether the values of two <see cref="T:EditoraInovacao.Sankhya.Entities.Transport.OrderControlTrackingStatus" /> objects are equal.</summary>
    /// <param name="left">The first value to compare.</param>
    /// <param name="right">The second value to compare.</param>
    /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
    public static bool operator ==(
        OrderControlTrackingStatus left,
        OrderControlTrackingStatus right
    ) => Equals(left, right);

    /// <summary>Returns a value that indicates whether two <see cref="T:EditoraInovacao.Sankhya.Entities.Transport.OrderControlTrackingStatus" /> objects have different values.</summary>
    /// <param name="left">The first value to compare.</param>
    /// <param name="right">The second value to compare.</param>
    /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
    public static bool operator !=(
        OrderControlTrackingStatus left,
        OrderControlTrackingStatus right
    ) => !Equals(left, right);

    #endregion

    #region Private fields

    /// <summary>
    /// The code status
    /// </summary>
    private int _codeStatus;

    /// <summary>
    /// The code status set
    /// </summary>
    private bool _codeStatusSet;

    /// <summary>
    /// The status
    /// </summary>
    private TrackingStatus _status;

    /// <summary>
    /// The status set
    /// </summary>
    private bool _statusSet;

    /// <summary>
    /// The text
    /// </summary>
    private string _text;

    /// <summary>
    /// The text set
    /// </summary>
    private bool _textSet;

    #endregion

    #region Public properties

    /// <summary>
    /// Gets or sets the code status.
    /// </summary>
    /// <value>The code status.</value>
    [EntityElement("CODSTATUS")]
    [EntityKey]
    public int CodeStatus
    {
        get => _codeStatus;
        set
        {
            _codeStatus = value;
            _codeStatusSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
    [EntityIgnore]
    public TrackingStatus Status
    {
        get => _status;
        set
        {
            _status = value;
            _statusSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the status internal.
    /// </summary>
    /// <value>The status internal.</value>
    [EntityElement("STATUS")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [EntityKey]
    public string StatusInternal
    {
        get => _status.GetInternalValue();
        set
        {
            _status = EnumExtensions.GetEnumByInternalValueAttribute<TrackingStatus>(value);
            _statusSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the text.
    /// </summary>
    /// <value>The text.</value>
    [EntityElement("TEXTO")]
    public string Text
    {
        get => _text;
        set
        {
            _text = value;
            _textSet = true;
        }
    }

    #endregion

    #region Serialization helpers

    /// <summary>
    /// Shoulds the serialize code status.
    /// </summary>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeStatus() => _codeStatusSet;

    /// <summary>
    /// Shoulds the serialize status.
    /// </summary>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStatus() => _statusSet;

    /// <summary>
    /// Shoulds the serialize text.
    /// </summary>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeText() => _textSet;

    #endregion
}
