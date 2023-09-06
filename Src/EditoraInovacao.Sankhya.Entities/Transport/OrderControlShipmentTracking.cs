// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 14/04/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderControlShipmentTracking.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using EditoraInovacao.Sankhya.Entities.Enums;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class OrderControlShippingTracking. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
/// <summary>
/// Class OrderControlShipmentTracking.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="IEquatable{OrderControlShipmentTracking}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="IEquatable{OrderControlShipmentTracking}" />
[Entity("CPENVIOSMONITORAMENTOS")]
public class OrderControlShipmentTracking : IEntity, IEquatable<OrderControlShipmentTracking>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(OrderControlShipmentTracking other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return _singleNumber == other._singleNumber
            && _singleNumberSet == other._singleNumberSet
            && string.Equals(
                _trackingCode,
                other._trackingCode,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _trackingCodeSet == other._trackingCodeSet
            && _sequence == other._sequence
            && _sequenceSet == other._sequenceSet
            && string.Equals(_orderId, other._orderId, StringComparison.InvariantCultureIgnoreCase)
            && _orderIdSet == other._orderIdSet
            && _status == other._status
            && _statusSet == other._statusSet
            && _date.Equals(other._date)
            && _dateSet == other._dateSet
            && _codeCity == other._codeCity
            && _codeCitySet == other._codeCitySet
            && string.Equals(_unit, other._unit, StringComparison.InvariantCultureIgnoreCase)
            && _unitSet == other._unitSet
            && string.Equals(_message, other._message, StringComparison.InvariantCultureIgnoreCase)
            && _messageSet == other._messageSet
            && string.Equals(_zipCode, other._zipCode, StringComparison.InvariantCultureIgnoreCase)
            && _zipCodeSet == other._zipCodeSet
            && Equals(_city, other._city)
            && _citySet == other._citySet;
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

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj.GetType() == GetType() && Equals((OrderControlShipmentTracking)obj);
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _singleNumber;
            hashCode = (hashCode * 397) ^ _singleNumberSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _trackingCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_trackingCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _trackingCodeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _sequence;
            hashCode = (hashCode * 397) ^ _sequenceSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _orderId != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_orderId)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _orderIdSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_status;
            hashCode = (hashCode * 397) ^ _statusSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _date.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeCity;
            hashCode = (hashCode * 397) ^ _codeCitySet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _unit != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_unit) : 0
                );
            hashCode = (hashCode * 397) ^ _unitSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _message != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_message)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _messageSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _zipCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_zipCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _zipCodeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_city != null ? _city.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _citySet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(
        OrderControlShipmentTracking left,
        OrderControlShipmentTracking right
    ) => Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(
        OrderControlShipmentTracking left,
        OrderControlShipmentTracking right
    ) => !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The single number
    /// </summary>
    /// <summary>
    /// The single number
    /// </summary>
    private int _singleNumber;

    /// <summary>
    /// The single number set
    /// </summary>
    /// <summary>
    /// The single number set
    /// </summary>
    private bool _singleNumberSet;

    /// <summary>
    /// The tracking code
    /// </summary>
    /// <summary>
    /// The tracking code
    /// </summary>
    private string _trackingCode;

    /// <summary>
    /// The tracking code set
    /// </summary>
    /// <summary>
    /// The tracking code set
    /// </summary>
    private bool _trackingCodeSet;

    /// <summary>
    /// The sequence
    /// </summary>
    /// <summary>
    /// The sequence
    /// </summary>
    private int _sequence;

    /// <summary>
    /// The sequence set
    /// </summary>
    /// <summary>
    /// The sequence set
    /// </summary>
    private bool _sequenceSet;

    /// <summary>
    /// The order identifier
    /// </summary>
    /// <summary>
    /// The order identifier
    /// </summary>
    private string _orderId;

    /// <summary>
    /// The order identifier set
    /// </summary>
    /// <summary>
    /// The order identifier set
    /// </summary>
    private bool _orderIdSet;

    /// <summary>
    /// The status
    /// </summary>
    /// <summary>
    /// The status
    /// </summary>
    private TrackingStatus _status;

    /// <summary>
    /// The status set
    /// </summary>
    /// <summary>
    /// The status set
    /// </summary>
    private bool _statusSet;

    /// <summary>
    /// The date
    /// </summary>
    /// <summary>
    /// The date
    /// </summary>
    private DateTime _date;

    /// <summary>
    /// The date set
    /// </summary>
    /// <summary>
    /// The date set
    /// </summary>
    private bool _dateSet;

    /// <summary>
    /// The code city
    /// </summary>
    /// <summary>
    /// The code city
    /// </summary>
    private int _codeCity;

    /// <summary>
    /// The code city set
    /// </summary>
    /// <summary>
    /// The code city set
    /// </summary>
    private bool _codeCitySet;

    /// <summary>
    /// The unit
    /// </summary>
    /// <summary>
    /// The unit
    /// </summary>
    private string _unit;

    /// <summary>
    /// The unit set
    /// </summary>
    /// <summary>
    /// The unit set
    /// </summary>
    private bool _unitSet;

    /// <summary>
    /// The message
    /// </summary>
    /// <summary>
    /// The message
    /// </summary>
    private string _message;

    /// <summary>
    /// The message set
    /// </summary>
    /// <summary>
    /// The message set
    /// </summary>
    private bool _messageSet;

    /// <summary>
    /// The zip code
    /// </summary>
    /// <summary>
    /// The zip code
    /// </summary>
    private string _zipCode;

    /// <summary>
    /// The zip code set
    /// </summary>
    /// <summary>
    /// The zip code set
    /// </summary>
    private bool _zipCodeSet;

    /// <summary>
    /// The city
    /// </summary>
    /// <summary>
    /// The city
    /// </summary>
    private City _city;

    /// <summary>
    /// The city set
    /// </summary>
    /// <summary>
    /// The city set
    /// </summary>
    private bool _citySet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the single number.
    /// </summary>
    /// <value>The single number.</value>
    /// <summary>
    /// Gets or sets the single number.
    /// </summary>
    /// <value>The single number.</value>
    [EntityElement("NUNOTA")]
    [EntityKey]
    public int SingleNumber
    {
        get => _singleNumber;
        set
        {
            _singleNumber = value;
            _singleNumberSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the tracking code.
    /// </summary>
    /// <value>The tracking code.</value>
    /// <summary>
    /// Gets or sets the tracking code.
    /// </summary>
    /// <value>The tracking code.</value>
    [EntityElement("CODENVIO")]
    [EntityKey]
    public string TrackingCode
    {
        get => _trackingCode;
        set
        {
            _trackingCode = value;
            _trackingCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sequence.
    /// </summary>
    /// <value>The sequence.</value>
    /// <summary>
    /// Gets or sets the sequence.
    /// </summary>
    /// <value>The sequence.</value>
    [EntityElement("PEDORIGINAL")]
    [EntityKey]
    public int Sequence
    {
        get => _sequence;
        set
        {
            _sequence = value;
            _sequenceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    /// <summary>
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    [EntityElement("ORDERID")]
    [EntityKey]
    public string OrderId
    {
        get => _orderId;
        set
        {
            _orderId = value;
            _orderIdSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
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
    /// Gets or sets the date.
    /// </summary>
    /// <value>The date.</value>
    [EntityElement("DATA")]
    [EntityKey]
    public DateTime Date
    {
        get => _date;
        set
        {
            _date = value;
            _dateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code city.
    /// </summary>
    /// <value>The code city.</value>
    [EntityElement("CODCID")]
    public int CodeCity
    {
        get => _codeCity;
        set
        {
            _codeCity = value;
            _codeCitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the unit.
    /// </summary>
    /// <value>The unit.</value>
    [EntityElement("UNIDADE")]
    public string Unit
    {
        get => _unit;
        set
        {
            _unit = value;
            _unitSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    /// <value>The message.</value>
    [EntityElement("MENSAGEM")]
    public string Message
    {
        get => _message;
        set
        {
            _message = value;
            _messageSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the zip code.
    /// </summary>
    /// <value>The zip code.</value>
    [EntityElement("CEP")]
    public string ZipCode
    {
        get => _zipCode;
        set
        {
            _zipCode = value;
            _zipCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    /// <value>The city.</value>
    [EntityReference]
    public City City
    {
        get => _city;
        set
        {
            _city = value;
            _citySet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize single number.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSingleNumber() => _singleNumberSet;

    /// <summary>
    /// Should the serialize tracking code.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTrackingCode() => _trackingCodeSet;

    /// <summary>
    /// Should the serialize sequence.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSequence() => _sequenceSet;

    /// <summary>
    /// Should the serialize order identifier.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOrderId() => _orderIdSet;

    /// <summary>
    /// Should the serialize status.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStatus() => _statusSet;

    /// <summary>
    /// Should the serialize date.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDate() => _dateSet;

    /// <summary>
    /// Should the serialize code city.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeCity() => _codeCitySet;

    /// <summary>
    /// Should the serialize unit.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUnit() => _unitSet;

    /// <summary>
    /// Should the serialize message.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeMessage() => _messageSet;

    /// <summary>
    /// The should serialize zip code serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeZipCode() => _zipCodeSet;

    /// <summary>
    /// Should the serialize city.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCity() => _citySet;

    #endregion
}
