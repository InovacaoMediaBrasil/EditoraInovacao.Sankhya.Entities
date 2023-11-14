// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 18/04/2020
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderControlPayment.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CrispyWaffle.Extensions;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// The order control payment entity  class.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("CPPAGAMENTOS")]
public class OrderControlPayment : IEntity, IEquatable<OrderControlPayment>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(OrderControlPayment other)
    {
        if (other is null)
        {
            return false;
        }

        return _sequence == other._sequence
            && _sequenceSet == other._sequenceSet
            && string.Equals(_orderId, other._orderId, StringComparison.InvariantCultureIgnoreCase)
            && _orderIdSet == other._orderIdSet
            && string.Equals(
                _transactionCode,
                other._transactionCode,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _transactionCodeSet == other._transactionCodeSet
            && string.Equals(
                _paymentCode,
                other._paymentCode,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _paymentCodeSet == other._paymentCodeSet
            && string.Equals(_name, other._name, StringComparison.InvariantCultureIgnoreCase)
            && _nameSet == other._nameSet
            && _value == other._value
            && _valueSet == other._valueSet
            && _valueReference == other._valueReference
            && _valueReferenceSet == other._valueReferenceSet
            && string.Equals(_tid, other._tid, StringComparison.InvariantCultureIgnoreCase)
            && _tidSet == other._tidSet
            && _installments == other._installments
            && _installmentsSet == other._installmentsSet
            && string.Equals(
                _firstDigits,
                other._firstDigits,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _firstDigitsSet == other._firstDigitsSet
            && string.Equals(
                _lastDigits,
                other._lastDigits,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _lastDigitsSet == other._lastDigitsSet
            && string.Equals(
                _returnCode,
                other._returnCode,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _returnCodeSet == other._returnCodeSet
            && string.Equals(
                _returnMessage,
                other._returnMessage,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _returnMessageSet == other._returnMessageSet
            && string.Equals(
                _authorization,
                other._authorization,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _authorizationSet == other._authorizationSet
            && string.Equals(_nsu, other._nsu, StringComparison.InvariantCultureIgnoreCase)
            && _nsuSet == other._nsuSet
            && string.Equals(_arp, other._arp, StringComparison.InvariantCultureIgnoreCase)
            && _arpSet == other._arpSet
            && string.Equals(_eci, other._eci, StringComparison.InvariantCultureIgnoreCase)
            && _eciSet == other._eciSet
            && string.Equals(_lr, other._lr, StringComparison.InvariantCultureIgnoreCase)
            && _lrSet == other._lrSet
            && string.Equals(_numCv, other._numCv, StringComparison.InvariantCultureIgnoreCase)
            && _numCvSet == other._numCvSet
            && string.Equals(
                _nsuSettle,
                other._nsuSettle,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _nsuSettleSet == other._nsuSettleSet
            && string.Equals(
                _authenticationNumber,
                other._authenticationNumber,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _authenticationNumberSet == other._authenticationNumberSet
            && _settlementDate.Equals(other._settlementDate)
            && _settlementDateSet == other._settlementDateSet
            && string.Equals(
                _settlementToken,
                other._settlementToken,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _settlementTokenSet == other._settlementTokenSet
            && _settlementId.Equals(other._settlementId)
            && _settlementIdSet == other._settlementIdSet
            && _settlementValue == other._settlementValue
            && _settlementValueSet == other._settlementValueSet
            && string.Equals(_network, other._network)
            && _networkSet == other._networkSet;
    }

    /// <inheritdoc />
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

        return obj.GetType() == GetType() && Equals((OrderControlPayment)obj);
    }

    /// <inheritdoc />
    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
    // ReSharper disable once FunctionComplexityOverflow
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
            hashCode =
                (hashCode * 397)
                ^ (
                    _transactionCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_transactionCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _transactionCodeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _paymentCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_paymentCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _paymentCodeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _name != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_name) : 0
                );
            hashCode = (hashCode * 397) ^ _nameSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _value.GetHashCode();
            hashCode = (hashCode * 397) ^ _valueSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _valueReference.GetHashCode();
            hashCode = (hashCode * 397) ^ _valueReferenceSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_tid != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_tid) : 0);
            hashCode = (hashCode * 397) ^ _tidSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _installments;
            hashCode = (hashCode * 397) ^ _installmentsSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _firstDigits != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_firstDigits)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _firstDigitsSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _lastDigits != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_lastDigits)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _lastDigitsSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _returnCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_returnCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _returnCodeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _returnMessage != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_returnMessage)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _returnMessageSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _authorization != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_authorization)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _authorizationSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_nsu != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_nsu) : 0);
            hashCode = (hashCode * 397) ^ _nsuSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_arp != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_arp) : 0);
            hashCode = (hashCode * 397) ^ _arpSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_eci != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_eci) : 0);
            hashCode = (hashCode * 397) ^ _eciSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_lr != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_lr) : 0);
            hashCode = (hashCode * 397) ^ _lrSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _numCv != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_numCv)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _numCvSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _nsuSettle != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_nsuSettle)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _nsuSettleSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _authenticationNumber != null
                        ? StringComparer
                            .InvariantCultureIgnoreCase
                            .GetHashCode(_authenticationNumber)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _authenticationNumberSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _settlementDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _settlementDateSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _settlementToken != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_settlementToken)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _settlementTokenSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _settlementId.GetHashCode();
            hashCode = (hashCode * 397) ^ _settlementIdSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _settlementValue.GetHashCode();
            hashCode = (hashCode * 397) ^ _settlementValueSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _network.GetHashCode();
            hashCode = (hashCode * 397) ^ _networkSet.GetHashCode();
            return hashCode;
        }
    }

    #endregion

    #region Private fields

    /// <summary>
    /// The sequence
    /// </summary>
    private int _sequence;

    /// <summary>
    /// The sequence set
    /// </summary>
    private bool _sequenceSet;

    /// <summary>
    /// The order identifier
    /// </summary>
    private string _orderId;

    /// <summary>
    /// The order identifier set
    /// </summary>
    private bool _orderIdSet;

    /// <summary>
    /// The transaction code.
    /// </summary>
    private string _transactionCode;

    /// <summary>
    /// The transaction code set;
    /// </summary>
    private bool _transactionCodeSet;

    /// <summary>
    /// The payment code.
    /// </summary>
    private string _paymentCode;

    /// <summary>
    /// The payment code set.
    /// </summary>
    private bool _paymentCodeSet;

    /// <summary>
    /// The name
    /// </summary>
    private string _name;

    /// <summary>
    /// The name set
    /// </summary>
    private bool _nameSet;

    /// <summary>
    /// The value
    /// </summary>
    private decimal _value;

    /// <summary>
    /// The value set
    /// </summary>
    private bool _valueSet;

    /// <summary>
    /// The value reference
    /// </summary>
    private decimal _valueReference;

    /// <summary>
    /// The value reference set
    /// </summary>
    private bool _valueReferenceSet;

    /// <summary>
    /// The tid
    /// </summary>
    private string _tid;

    /// <summary>
    /// The tid set
    /// </summary>
    private bool _tidSet;

    /// <summary>
    /// The installments
    /// </summary>
    private int _installments;

    /// <summary>
    /// The installments set
    /// </summary>
    private bool _installmentsSet;

    /// <summary>
    /// The first digits
    /// </summary>
    private string _firstDigits;

    /// <summary>
    /// The first digits set
    /// </summary>
    private bool _firstDigitsSet;

    /// <summary>
    /// The last digits
    /// </summary>
    private string _lastDigits;

    /// <summary>
    /// The last digits set
    /// </summary>
    private bool _lastDigitsSet;

    /// <summary>
    /// The return code
    /// </summary>
    private string _returnCode;

    /// <summary>
    /// The return code set
    /// </summary>
    private bool _returnCodeSet;

    /// <summary>
    /// The return message
    /// </summary>
    private string _returnMessage;

    /// <summary>
    /// The return message set
    /// </summary>
    private bool _returnMessageSet;

    /// <summary>
    /// The authorization
    /// </summary>
    private string _authorization;

    /// <summary>
    /// The authorization set
    /// </summary>
    private bool _authorizationSet;

    /// <summary>
    /// The nsu
    /// </summary>
    private string _nsu;

    /// <summary>
    /// The nsu set
    /// </summary>
    private bool _nsuSet;

    /// <summary>
    /// The arp
    /// </summary>
    private string _arp;

    /// <summary>
    /// The arp set
    /// </summary>
    private bool _arpSet;

    /// <summary>
    /// The eci
    /// </summary>
    private string _eci;

    /// <summary>
    /// The eci set
    /// </summary>
    private bool _eciSet;

    /// <summary>
    /// The lr
    /// </summary>
    private string _lr;

    /// <summary>
    /// The lr set
    /// </summary>
    private bool _lrSet;

    /// <summary>
    /// The number cv
    /// </summary>
    private string _numCv;

    /// <summary>
    /// The number cv set
    /// </summary>
    private bool _numCvSet;

    /// <summary>
    /// The nsu settle
    /// </summary>
    private string _nsuSettle;

    /// <summary>
    /// The nsu settle set
    /// </summary>
    private bool _nsuSettleSet;

    /// <summary>
    /// The authentication number
    /// </summary>
    private string _authenticationNumber;

    /// <summary>
    /// The authentication number set
    /// </summary>
    private bool _authenticationNumberSet;

    /// <summary>
    /// The settlement date
    /// </summary>
    private DateTime? _settlementDate;

    /// <summary>
    /// The settlement date set
    /// </summary>
    private bool _settlementDateSet;

    /// <summary>
    /// The settlement token
    /// </summary>
    private string _settlementToken;

    /// <summary>
    /// The settlement token set
    /// </summary>
    private bool _settlementTokenSet;

    /// <summary>
    /// The settlement identifier
    /// </summary>
    private Guid? _settlementId;

    /// <summary>
    /// The settlement identifier set
    /// </summary>
    private bool _settlementIdSet;

    /// <summary>
    /// The settlement value
    /// </summary>
    private decimal? _settlementValue;

    /// <summary>
    /// The settlement value set
    /// </summary>
    private bool _settlementValueSet;

    /// <summary>
    /// The network
    /// </summary>
    private string _network;

    /// <summary>
    /// The network set
    /// </summary>
    private bool _networkSet;

    #endregion

    #region Public properties

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
    /// Gets or sets the transaction code.
    /// </summary>
    /// <value>The transaction code.</value>
    [EntityElement("CODTRANSACAO")]
    [EntityKey]
    public string TransactionCode
    {
        get => _transactionCode;
        set
        {
            _transactionCode = value;
            _transactionCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the payment code.
    /// </summary>
    /// <value>The payment code.</value>
    [EntityElement("CODPAGAMENTO")]
    [EntityKey]
    public string PaymentCode
    {
        get => _paymentCode;
        set
        {
            _paymentCode = value;
            _paymentCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [EntityElement("NOME")]
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            _nameSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    /// <value>The value.</value>
    [EntityIgnore]
    public decimal Value
    {
        get => _value;
        set
        {
            _value = value;
            _valueSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the value internal.
    /// </summary>
    /// <value>The value internal.</value>
    [EntityElement("VLR")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ValueInternal
    {
        get => _value.ToString(CultureInfo.InvariantCulture);
        set
        {
            _value = value.ToDecimal();
            _valueSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the value reference.
    /// </summary>
    /// <value>The value reference.</value>
    [EntityIgnore]
    public decimal ValueReference
    {
        get => _valueReference;
        set
        {
            _valueReference = value;
            _valueReferenceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the value reference internal.
    /// </summary>
    /// <value>The value reference internal.</value>
    [EntityElement("VLRREF")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ValueReferenceInternal
    {
        get => _valueReference.ToString(CultureInfo.InvariantCulture);
        set
        {
            _valueReference = value.ToDecimal();
            _valueReferenceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the tid.
    /// </summary>
    /// <value>The tid.</value>
    [EntityElement("TID")]
    public string Tid
    {
        get => _tid;
        set
        {
            _tid = value;
            _tidSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the installments.
    /// </summary>
    /// <value>The installments.</value>
    [EntityElement("PARCELAS")]
    public int Installments
    {
        get => _installments;
        set
        {
            _installments = value;
            _installmentsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the first digits.
    /// </summary>
    /// <value>The first digits.</value>
    [EntityElement("PRIDIGITOS")]
    public string FirstDigits
    {
        get => _firstDigits;
        set
        {
            _firstDigits = value;
            _firstDigitsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the last digits.
    /// </summary>
    /// <value>The last digits.</value>
    [EntityElement("ULTDIGITOS")]
    public string LastDigits
    {
        get => _lastDigits;
        set
        {
            _lastDigits = value;
            _lastDigitsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the return code.
    /// </summary>
    /// <value>The return code.</value>
    [EntityElement("CODRETORNO")]
    public string ReturnCode
    {
        get => _returnCode;
        set
        {
            _returnCode = value;
            _returnCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the return message.
    /// </summary>
    /// <value>The return message.</value>
    [EntityElement("MENSAGEM")]
    public string ReturnMessage
    {
        get => _returnMessage;
        set
        {
            _returnMessage = value;
            _returnMessageSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the authorization.
    /// </summary>
    /// <value>The authorization.</value>
    [EntityElement("AUTORIZACAO")]
    public string Authorization
    {
        get => _authorization;
        set
        {
            _authorization = value;
            _authorizationSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the nsu.
    /// </summary>
    /// <value>The nsu.</value>
    [EntityElement("NSU")]
    public string Nsu
    {
        get => _nsu;
        set
        {
            _nsu = value;
            _nsuSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the arp.
    /// </summary>
    /// <value>The arp.</value>
    [EntityElement("ARP")]
    public string Arp
    {
        get => _arp;
        set
        {
            _arp = value;
            _arpSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the eci.
    /// </summary>
    /// <value>The eci.</value>
    [EntityElement("ECI")]
    public string Eci
    {
        get => _eci;
        set
        {
            _eci = value;
            _eciSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the lr.
    /// </summary>
    /// <value>The lr.</value>
    [EntityElement("LR")]
    public string Lr
    {
        get => _lr;
        set
        {
            _lr = value;
            _lrSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the number cv.
    /// </summary>
    /// <value>The number cv.</value>
    [EntityElement("NUMCV")]
    public string NumCv
    {
        get => _numCv;
        set
        {
            _numCv = value;
            _numCvSet = true;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Object" /> class.
    /// </summary>
    /// <value>The nsu settle.</value>
    [EntityElement("NSUSETTLE")]
    public string NsuSettle
    {
        get => _nsuSettle;
        set
        {
            _nsuSettle = value;
            _nsuSettleSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the authentication number.
    /// </summary>
    /// <value>The authentication number.</value>
    [EntityElement("NUMAUTENT")]
    public string AuthenticationNumber
    {
        get => _authenticationNumber;
        set
        {
            _authenticationNumber = value;
            _authenticationNumberSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the settlement date.
    /// </summary>
    /// <value>The settlement date.</value>
    [EntityIgnore]
    public DateTime? SettlementDate
    {
        get => _settlementDate;
        set
        {
            _settlementDate = value;
            _settlementDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the settlement date internal.
    /// </summary>
    /// <value>The settlement date internal.</value>
    [EntityElement("DTLIQUIDACAO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SettlementDateInternal
    {
        get => _settlementDate?.ToString() ?? string.Empty;
        set
        {
            _settlementDateSet = true;

            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            var culture = new CultureInfo("pt-BR");
            if (value.TryToDateTime(out var date))
            {
                _settlementDate = date;
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
                _settlementDate = date;
            }
            else if (
                DateTime.TryParseExact(value, @"dd/MM/yyyy", culture, DateTimeStyles.None, out date)
            )
            {
                _settlementDate = date;
            }
            else
            {
                throw new InvalidOperationException($@"Invalid date format for value {value}");
            }
        }
    }

    /// <summary>
    /// Gets or sets the settlement token.
    /// </summary>
    /// <value>The settlement token.</value>
    [EntityElement("TOKENLIQUIDACAO")]
    public string SettlementToken
    {
        get => _settlementToken;
        set
        {
            _settlementToken = value;
            _settlementTokenSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the settlement identifier.
    /// </summary>
    /// <value>The settlement identifier.</value>
    [EntityIgnore]
    public Guid? SettlementId
    {
        get => _settlementId;
        set
        {
            _settlementId = value;
            _settlementIdSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the settlement identifier.
    /// </summary>
    /// <value>The settlement identifier.</value>
    [EntityElement("IDLIQUIDACAO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SettlementIdInternal
    {
        get => _settlementId?.ToString() ?? string.Empty;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || !Guid.TryParse(value, out var guid))
            {
                return;
            }

            _settlementId = guid;
            _settlementIdSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the settlement value.
    /// </summary>
    /// <value>The settlement value.</value>
    [EntityIgnore]
    public decimal SettlementValue
    {
        get => _settlementValue ?? 0;
        set
        {
            _settlementValue = value;
            _settlementValueSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the settlement value internal.
    /// </summary>
    /// <value>The settlement value internal.</value>
    [EntityElement("VLRLIQUIDACAO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SettlementValueInternal
    {
        get => _settlementValue?.ToString(CultureInfo.InvariantCulture) ?? string.Empty;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _settlementValue = value.ToDecimal();
            }

            _settlementValueSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the network.
    /// </summary>
    /// <value>The network.</value>
    [EntityElement("NETWORK")]
    public string Network
    {
        get => _network;
        set
        {
            _network = value;
            _networkSet = true;
        }
    }

    #endregion

    #region Serialization helpers

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
    /// Should the serialize transaction code.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTransactionCode() => _transactionCodeSet;

    /// <summary>
    /// Should the serialize payment code.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePaymentCode() => _paymentCodeSet;

    /// <summary>
    /// Should the serialize name.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeName() => _nameSet;

    /// <summary>
    /// Should the serialize value.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeValue() => _valueSet;

    /// <summary>
    /// Should the serialize value reference.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeValueReference() => _valueReferenceSet;

    /// <summary>
    /// Should the serialize TID.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTid() => _tidSet;

    /// <summary>
    /// Should the serialize installments.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeInstallments() => _installmentsSet;

    /// <summary>
    /// Should the serialize first digits.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFirstDigits() => _firstDigitsSet;

    /// <summary>
    /// Should the serialize last digits.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeLastDigits() => _lastDigitsSet;

    /// <summary>
    /// Should the serialize return code.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeReturnCode() => _returnCodeSet;

    /// <summary>
    /// Should the serialize return message.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeReturnMessage() => _returnMessageSet;

    /// <summary>
    /// Should the serialize authorization.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAuthorization() => _authorizationSet;

    /// <summary>
    /// Should the serialize NSU.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeNsu() => _nsuSet;

    /// <summary>
    /// Should the serialize ARP.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeArp() => _arpSet;

    /// <summary>
    /// Should the serialize ECI.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEci() => _eciSet;

    /// <summary>
    /// Should the serialize LR.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeLr() => _lrSet;

    /// <summary>
    /// The should serialize num cv serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeNumCv() => _numCvSet;

    /// <summary>
    /// The should serialize NSU settle serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeNsuSettle() => _nsuSettleSet;

    /// <summary>
    /// The should serialize authentication number serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAuthenticationNumber() => _authenticationNumberSet;

    /// <summary>
    /// The should serialize settlement date serialization helper method
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSettlementDate() => _settlementDateSet;

    /// <summary>
    /// The should serialize settlement token serialization helper method
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSettlementToken() => _settlementTokenSet;

    /// <summary>
    /// The should serialize settlement identifier serialization helper method
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSettlementId() => _settlementIdSet;

    /// <summary>
    /// The should serialize settlement value serialization helper method
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSettlementValue() => _settlementValueSet;

    /// <summary>
    /// Shoulds the serialize network.
    /// </summary>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeNetwork() => _networkSet;

    #endregion
}
