// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 14/04/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 28/01/2023
// ***********************************************************************
// <copyright file="OrderControlShipment.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using CrispyWaffle.Extensions;
using EditoraInovacao.Sankhya.Entities.Enums;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class OrderControlShipment.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="System.IEquatable{OrderControlShipment}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="System.IEquatable{OrderControlShipment}" />
[Entity("CPENVIOS")]
[DebuggerDisplay(
    "Tracker: {Tracker} - Tracking code: {TrackingCode} - Sequence: {Sequence} - Shipping date: {ShippingDate}"
)]
public sealed class OrderControlShipment : IEntity, IEquatable<OrderControlShipment>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(OrderControlShipment other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _sequence == other._sequence
                && _sequenceSet == other._sequenceSet
                && string.Equals(
                    _orderId,
                    other._orderId,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _orderIdSet == other._orderIdSet
                && _singleNumber == other._singleNumber
                && _singleNumberSet == other._singleNumberSet
                && string.Equals(
                    _trackingCode,
                    other._trackingCode,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _trackingCodeSet == other._trackingCodeSet
                && string.Equals(
                    _trackingCodeFinal,
                    other._trackingCodeFinal,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _trackingCodeFinalSet == other._trackingCodeFinalSet
                && string.Equals(
                    _serviceCode,
                    other._serviceCode,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _serviceCodeSet == other._serviceCodeSet
                && _codeCourier == other._codeCourier
                && _codeCourierSet == other._codeCourierSet
                && string.Equals(
                    _dataMatrix,
                    other._dataMatrix,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _dataMatrixSet == other._dataMatrixSet
                && _status == other._status
                && _statusSet == other._statusSet
                && _weight == other._weight
                && _weightSet == other._weightSet
                && _freightValue == other._freightValue
                && _freightValueSet == other._freightValueSet
                && _tracker == other._tracker
                && _trackerSet == other._trackerSet
                && _customerServiceDate.Equals(other._customerServiceDate)
                && _customerServiceDateSet == other._customerServiceDateSet
                && _cgeDate.Equals(other._cgeDate)
                && _cgeDateSet == other._cgeDateSet
                && _shippingDate.Equals(other._shippingDate)
                && _shippingDateSet == other._shippingDateSet
                && _shippingNotificationDate.Equals(other._shippingNotificationDate)
                && _shippingNotificationDateSet == other._shippingNotificationDateSet
                && _deliveredConfirmationDate.Equals(other._deliveredConfirmationDate)
                && _deliveredConfirmationDateSet == other._deliveredConfirmationDateSet
                && Equals(_tracking, other._tracking)
                && _trackingSet == other._trackingSet;
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
            || obj is OrderControlShipment shipment && Equals(shipment);
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
    // ReSharper disable once MethodTooLong
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _sequence;
            hashCode = (hashCode * 397) ^ _sequenceSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _orderId != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_orderId)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _orderIdSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _singleNumber;
            hashCode = (hashCode * 397) ^ _singleNumberSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _trackingCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_trackingCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _trackingCodeSet.GetHashCode();
            hashCode =
                (hashCode ^ 397)
                ^ (
                    _trackingCodeFinal != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_trackingCodeFinal)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _trackingCodeFinalSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _serviceCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_serviceCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _serviceCodeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeCourier.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeCourierSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _dataMatrix != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_dataMatrix)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _dataMatrixSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_status;
            hashCode = (hashCode * 397) ^ _statusSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _weight.GetHashCode();
            hashCode = (hashCode * 397) ^ _weightSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _freightValue.GetHashCode();
            hashCode = (hashCode * 397) ^ _freightValueSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_tracker;
            hashCode = (hashCode * 397) ^ _trackerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _customerServiceDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _customerServiceDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _cgeDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _cgeDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _shippingDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _shippingDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _shippingNotificationDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _shippingNotificationDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _deliveredConfirmationDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _deliveredConfirmationDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_tracking != null ? _tracking.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _trackingSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(OrderControlShipment left, OrderControlShipment right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(OrderControlShipment left, OrderControlShipment right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

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
    /// The tracking code final
    /// </summary>
    private string _trackingCodeFinal;

    /// <summary>
    /// The tracking code final set
    /// </summary>
    private bool _trackingCodeFinalSet;

    /// <summary>
    /// The service code
    /// </summary>
    /// <summary>
    /// The service code
    /// </summary>
    private string _serviceCode;

    /// <summary>
    /// The service code set
    /// </summary>
    /// <summary>
    /// The service code set
    /// </summary>
    private bool _serviceCodeSet;

    /// <summary>
    /// The code courier
    /// </summary>
    /// <summary>
    /// The code courier
    /// </summary>
    private long? _codeCourier;

    /// <summary>
    /// The code courier set
    /// </summary>
    /// <summary>
    /// The code courier set
    /// </summary>
    private bool _codeCourierSet;

    /// <summary>
    /// The data matrix
    /// </summary>
    /// <summary>
    /// The data matrix
    /// </summary>
    private string _dataMatrix;

    /// <summary>
    /// The data matrix set
    /// </summary>
    /// <summary>
    /// The data matrix set
    /// </summary>
    private bool _dataMatrixSet;

    /// <summary>
    /// The status
    /// </summary>
    /// <summary>
    /// The status
    /// </summary>
    private ShipmentStatus _status;

    /// <summary>
    /// The status set
    /// </summary>
    /// <summary>
    /// The status set
    /// </summary>
    private bool _statusSet;

    /// <summary>
    /// The weight
    /// </summary>
    /// <summary>
    /// The weight
    /// </summary>
    private int? _weight;

    /// <summary>
    /// The weight set
    /// </summary>
    /// <summary>
    /// The weight set
    /// </summary>
    private bool _weightSet;

    /// <summary>
    /// The freight value
    /// </summary>
    /// <summary>
    /// The freight value
    /// </summary>
    private decimal? _freightValue;

    /// <summary>
    /// The freight value set
    /// </summary>
    /// <summary>
    /// The freight value set
    /// </summary>
    private bool _freightValueSet;

    /// <summary>
    /// The shipment tracker
    /// </summary>
    /// <summary>
    /// The tracker
    /// </summary>
    private ShipmentTracker _tracker;

    /// <summary>
    /// The shipment tracker set
    /// </summary>
    /// <summary>
    /// The tracker set
    /// </summary>
    private bool _trackerSet;

    /// <summary>
    /// The customer service date
    /// </summary>
    /// <summary>
    /// The customer service date
    /// </summary>
    private DateTime? _customerServiceDate;

    /// <summary>
    /// The customer service date set
    /// </summary>
    /// <summary>
    /// The customer service date set
    /// </summary>
    private bool _customerServiceDateSet;

    /// <summary>
    /// The CGE date
    /// </summary>
    /// <summary>
    /// The cge date
    /// </summary>
    private DateTime? _cgeDate;

    /// <summary>
    /// The CGE date set
    /// </summary>
    /// <summary>
    /// The cge date set
    /// </summary>
    private bool _cgeDateSet;

    /// <summary>
    /// The shipping date
    /// </summary>
    /// <summary>
    /// The shipping date
    /// </summary>
    private DateTime _shippingDate;

    /// <summary>
    /// The shipping date set
    /// </summary>
    /// <summary>
    /// The shipping date set
    /// </summary>
    private bool _shippingDateSet;

    /// <summary>
    /// The shipping notification date
    /// </summary>
    /// <summary>
    /// The shipping notification date
    /// </summary>
    private DateTime? _shippingNotificationDate;

    /// <summary>
    /// The shipping notification date set
    /// </summary>
    /// <summary>
    /// The shipping notification date set
    /// </summary>
    private bool _shippingNotificationDateSet;

    /// <summary>
    /// The delivered confirmation date
    /// </summary>
    /// <summary>
    /// The delivered confirmation date
    /// </summary>
    private DateTime? _deliveredConfirmationDate;

    /// <summary>
    /// The delivered confirmation date set
    /// </summary>
    /// <summary>
    /// The delivered confirmation date set
    /// </summary>
    private bool _deliveredConfirmationDateSet;

    /// <summary>
    /// The tracking
    /// </summary>
    /// <summary>
    /// The tracking
    /// </summary>
    private ICollection<OrderControlShipmentTracking> _tracking;

    /// <summary>
    /// The tracking set
    /// </summary>
    /// <summary>
    /// The tracking set
    /// </summary>
    private bool _trackingSet;

    #endregion

    #region Public properties

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
    /// Gets or sets the tracking code final.
    /// </summary>
    /// <value>The tracking code final.</value>
    [EntityElement("CODENVIOFINAL")]
    public string TrackingCodeFinal
    {
        get => _trackingCodeFinal;
        set
        {
            _trackingCodeFinal = value;
            _trackingCodeFinalSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the service code
    /// </summary>
    /// <value>
    /// The service code
    /// </value>
    /// <summary>
    /// Gets or sets the service code.
    /// </summary>
    /// <value>The service code.</value>
    [EntityElement("OS")]
    public string ServiceCode
    {
        get => _serviceCode;
        set
        {
            _serviceCode = value;
            _serviceCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code courier
    /// </summary>
    /// <value>
    /// The code courier
    /// </value>
    /// <summary>
    /// Gets or sets the code courier.
    /// </summary>
    /// <value>The code courier.</value>
    [EntityElement("CODTRANSP")]
    public long? CodeCourier
    {
        get => _codeCourier;
        set
        {
            _codeCourier = value;
            _codeCourierSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the data matrix
    /// </summary>
    /// <value>
    /// The data matrix
    /// </value>
    /// <summary>
    /// Gets or sets the data matrix.
    /// </summary>
    /// <value>The data matrix.</value>
    [EntityElement("MATRIX")]
    public string DataMatrix
    {
        get => _dataMatrix;
        set
        {
            _dataMatrix = value;
            _dataMatrixSet = true;
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
    public ShipmentStatus Status
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
    /// <summary>
    /// Gets or sets the status internal.
    /// </summary>
    /// <value>The status internal.</value>
    [EntityElement("STATUS")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string StatusInternal
    {
        get => _status.GetInternalValue();
        set
        {
            _status = EnumExtensions.GetEnumByInternalValueAttribute<ShipmentStatus>(value);
            _statusSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the weight.
    /// </summary>
    /// <value>
    /// The weight.
    /// </value>
    /// <summary>
    /// Gets or sets the weight.
    /// </summary>
    /// <value>The weight.</value>
    [EntityIgnore]
    public int Weight
    {
        get => _weight ?? 0;
        set
        {
            _weight = value;
            _weightSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the weight internal.
    /// </summary>
    /// <value>
    /// The weight internal.
    /// </value>
    /// <summary>
    /// Gets or sets the weight internal.
    /// </summary>
    /// <value>The weight internal.</value>
    [EntityElement("PESO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string WeightInternal
    {
        get => _weight?.ToString() ?? string.Empty;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _weight = value.ToInt32();
            }

            _weightSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the freight value.
    /// </summary>
    /// <value>
    /// The freight value.
    /// </value>
    /// <summary>
    /// Gets or sets the freight value.
    /// </summary>
    /// <value>The freight value.</value>
    [EntityIgnore]
    public decimal FreightValue
    {
        get => _freightValue ?? 0;
        set
        {
            _freightValue = value;
            _freightValueSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the freight value internal.
    /// </summary>
    /// <value>
    /// The freight value internal.
    /// </value>
    /// <summary>
    /// Gets or sets the freight value internal.
    /// </summary>
    /// <value>The freight value internal.</value>
    [EntityElement("VLRFRETE")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string FreightValueInternal
    {
        get => _freightValue?.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _freightValue = value.ToDecimal();
            }

            _freightValueSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the tracker.
    /// </summary>
    /// <value>The tracker.</value>
    [EntityIgnore]
    public ShipmentTracker Tracker
    {
        get => _tracker;
        set
        {
            _tracker = value;
            _trackerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the tracker internal.
    /// </summary>
    /// <value>The tracker internal.</value>
    [EntityElement("TRACKER")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string TrackerInternal
    {
        get => _tracker.GetInternalValue();
        set
        {
            _tracker = EnumExtensions.GetEnumByInternalValueAttribute<ShipmentTracker>(value);
            _trackerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the customer service date.
    /// </summary>
    /// <value>
    /// The customer service date.
    /// </value>
    /// <summary>
    /// Gets or sets the customer service date.
    /// </summary>
    /// <value>The customer service date.</value>
    [EntityIgnore]
    public DateTime? CustomerServiceDate
    {
        get => _customerServiceDate;
        set
        {
            _customerServiceDate = value;
            _customerServiceDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the customer service date internal.
    /// </summary>
    /// <value>
    /// The customer service date internal.
    /// </value>
    /// <summary>
    /// Gets or sets the customer service date internal.
    /// </summary>
    /// <value>The customer service date internal.</value>
    [EntityElement("DTSAC")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string CustomerServiceDateInternal
    {
        get => _customerServiceDate?.ToString() ?? string.Empty;
        set
        {
            _customerServiceDateSet = true;
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var culture = new CultureInfo("pt-BR");
            if (value.TryToDateTime(out var date))
            {
                _customerServiceDate = date;
            }
            else if (
                DateTime.TryParseExact(
                    value,
                    @"dd/MM/yyyy HH:mm:ss",
                    culture,
                    DateTimeStyles.None,
                    out date
                )
            )
            {
                _customerServiceDate = date;
            }
            else if (
                DateTime.TryParseExact(value, @"dd/MM/yyyy", culture, DateTimeStyles.None, out date)
            )
            {
                _customerServiceDate = date;
            }
            else
            {
                throw new InvalidOperationException($@"Invalid date format for value {value}");
            }
        }
    }

    /// <summary>
    /// Gets or sets the cge date.
    /// </summary>
    /// <value>
    /// The cge date.
    /// </value>
    /// <summary>
    /// Gets or sets the cge date.
    /// </summary>
    /// <value>The cge date.</value>
    [EntityIgnore]
    public DateTime? CgeDate
    {
        get => _cgeDate;
        set
        {
            _cgeDate = value;
            _cgeDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the cge date internal.
    /// </summary>
    /// <value>
    /// The cge date internal.
    /// </value>
    /// <summary>
    /// Gets or sets the cge date internal.
    /// </summary>
    /// <value>The cge date internal.</value>
    [EntityElement("DTCGE")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string CgeDateInternal
    {
        get => _cgeDate?.ToString() ?? string.Empty;
        set
        {
            _cgeDateSet = true;
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var culture = new CultureInfo("pt-BR");
            if (value.TryToDateTime(out var date))
            {
                _cgeDate = date;
            }
            else if (
                DateTime.TryParseExact(
                    value,
                    @"dd/MM/yyyy HH:mm:ss",
                    culture,
                    DateTimeStyles.None,
                    out date
                )
            )
            {
                _cgeDate = date;
            }
            else if (
                DateTime.TryParseExact(value, @"dd/MM/yyyy", culture, DateTimeStyles.None, out date)
            )
            {
                _cgeDate = date;
            }
            else
            {
                throw new InvalidOperationException($@"Invalid date format for value {value}");
            }
        }
    }

    /// <summary>
    /// Gets or sets the shipping date.
    /// </summary>
    /// <value>
    /// The shipping date.
    /// </value>
    /// <summary>
    /// Gets or sets the shipping date.
    /// </summary>
    /// <value>The shipping date.</value>
    [EntityElement("DTENVIO")]
    public DateTime ShippingDate
    {
        get => _shippingDate;
        set
        {
            _shippingDate = value;
            _shippingDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the shipping notification date.
    /// </summary>
    /// <value>
    /// The shipping notification date.
    /// </value>
    /// <summary>
    /// Gets or sets the shipping notification date.
    /// </summary>
    /// <value>The shipping notification date.</value>
    [EntityIgnore]
    public DateTime? ShippingNotificationDate
    {
        get => _shippingNotificationDate;
        set
        {
            _shippingNotificationDate = value;
            _shippingNotificationDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the shipping notification date internal.
    /// </summary>
    /// <value>
    /// The shipping notification date internal.
    /// </value>
    /// <summary>
    /// Gets or sets the shipping notification date internal.
    /// </summary>
    /// <value>The shipping notification date internal.</value>
    [EntityElement("DTNOTIFICACAO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ShippingNotificationDateInternal
    {
        get => _shippingNotificationDate?.ToString() ?? string.Empty;
        set
        {
            _shippingNotificationDateSet = true;
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var culture = new CultureInfo("pt-BR");
            if (value.TryToDateTime(out var date))
            {
                _shippingNotificationDate = date;
            }
            else if (
                DateTime.TryParseExact(
                    value,
                    @"dd/MM/yyyy HH:mm:ss",
                    culture,
                    DateTimeStyles.None,
                    out date
                )
            )
            {
                _shippingNotificationDate = date;
            }
            else if (
                DateTime.TryParseExact(value, @"dd/MM/yyyy", culture, DateTimeStyles.None, out date)
            )
            {
                _shippingNotificationDate = date;
            }
            else
            {
                throw new InvalidOperationException($@"Invalid date format for value {value}");
            }
        }
    }

    /// <summary>
    /// Gets or sets the delivered confirmation date.
    /// </summary>
    /// <value>
    /// The delivered confirmation date.
    /// </value>
    /// <summary>
    /// Gets or sets the delivered confirmation date.
    /// </summary>
    /// <value>The delivered confirmation date.</value>
    [EntityIgnore]
    public DateTime? DeliveredConfirmationDate
    {
        get => _deliveredConfirmationDate;
        set
        {
            _deliveredConfirmationDate = value;
            _deliveredConfirmationDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the delivered confirmation date internal.
    /// </summary>
    /// <value>
    /// The delivered confirmation date internal.
    /// </value>
    /// <summary>
    /// Gets or sets the delivered confirmation date internal.
    /// </summary>
    /// <value>The delivered confirmation date internal.</value>
    [EntityElement("DTCONFENTREGA")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string DeliveredConfirmationDateInternal
    {
        get => _deliveredConfirmationDate?.ToString() ?? string.Empty;
        set
        {
            _deliveredConfirmationDateSet = true;
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var culture = new CultureInfo("pt-BR");
            if (value.TryToDateTime(out var date))
            {
                _deliveredConfirmationDate = date;
            }
            else if (
                DateTime.TryParseExact(
                    value,
                    @"dd/MM/yyyy HH:mm:ss",
                    culture,
                    DateTimeStyles.None,
                    out date
                )
            )
            {
                _deliveredConfirmationDate = date;
            }
            else if (
                DateTime.TryParseExact(value, @"dd/MM/yyyy", culture, DateTimeStyles.None, out date)
            )
            {
                _deliveredConfirmationDate = date;
            }
            else
            {
                throw new InvalidOperationException($@"Invalid date format for value {value}");
            }
        }
    }

    /// <summary>
    /// Gets or sets the tracking.
    /// </summary>
    /// <value>The tracking.</value>
    /// <summary>
    /// Gets or sets the tracking.
    /// </summary>
    /// <value>The tracking.</value>
    [EntityIgnore]
    public OrderControlShipmentTracking[] Tracking
    {
        get => _tracking.ToArray();
        set
        {
            if (value == null)
            {
                _tracking.Clear();
            }
            else
            {
                _tracking = value.ToList();
            }

            _trackingSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize sequence.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize sequence.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSequence() => _sequenceSet;

    /// <summary>
    /// Should the serialize order identifier.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize order identifier.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOrderId() => _orderIdSet;

    /// <summary>
    /// Should the serialize single number.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize single number.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSingleNumber() => _singleNumberSet;

    /// <summary>
    /// Should the serialize tracking code.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize tracking code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTrackingCode() => _trackingCodeSet;

    /// <summary>
    /// Should the serialize tracking code final.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize tracking code final.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTrackingCodeFinal() => _trackingCodeFinalSet;

    /// <summary>
    /// The should serialize service code serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize service code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeServiceCode() => _serviceCodeSet;

    /// <summary>
    /// The should serialize code courier serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeCourier() => _codeCourierSet;

    /// <summary>
    /// The should serialize data matrix serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDataMatrix() => _dataMatrixSet;

    /// <summary>
    /// Should the serialize status.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStatus() => _statusSet;

    /// <summary>
    /// Should the serialize weight.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeWeight() => _weightSet;

    /// <summary>
    /// Should the serialize freight value.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFreightValue() => _freightValueSet;

    /// <summary>
    /// The should serialize tracker serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTracker() => _trackerSet;

    /// <summary>
    /// Check if should serialize customer service date.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCustomerServiceDate() => _customerServiceDateSet;

    /// <summary>
    /// The should serialize cge date internal serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCgeDate() => _cgeDateSet;

    /// <summary>
    /// The should serialize shipping date serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeShippingDate() => _shippingDateSet;

    /// <summary>
    /// The should serialize shipping notification date internal serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeShippingNotificationDate() => _shippingNotificationDateSet;

    /// <summary>
    /// The should serialize delivered confirmation date serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDeliveredConfirmationDate() => _deliveredConfirmationDateSet;

    /// <summary>
    /// The should serialize tracking serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTracking() => _trackingSet;

    #endregion

    #region Methods

    /// <summary>
    /// Pushes the shipping tracking.
    /// </summary>
    /// <param name="tracking">The shipping tracking.</param>
    public void PushTracking(OrderControlShipmentTracking tracking) => AddTracking(tracking);

    /// <summary>
    /// Adds the tracking
    /// </summary>
    /// <param name="tracking">The shipping tracking.</param>
    /// <returns>OrderControlShipment.</returns>
    public OrderControlShipment AddTracking(OrderControlShipmentTracking tracking)
    {
        if (_tracking.Any(t => t.Status == tracking.Status && t.Date == tracking.Date))
        {
            _tracking.Remove(
                _tracking.Single(t => t.Status == tracking.Status && t.Date == tracking.Date)
            );
        }

        _tracking.Add(tracking);
        _trackingSet = true;
        return this;
    }

    #endregion

    #region ~Ctor

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderControlShipment" /> class.
    /// </summary>
    public OrderControlShipment() => _tracking = new Collection<OrderControlShipmentTracking>();

    #endregion
}
