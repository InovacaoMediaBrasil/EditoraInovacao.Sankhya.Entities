// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 26/12/2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderImportPending.cs" company="Guilherme Branco Stracini ME">
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
/// Class OrderImportPending.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="System.IEquatable{OrderImportPending}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="System.IEquatable{OrderImportPending}" />
[Entity("IMPORTACAOPEDPENDENTE")]
public class OrderImportPending : IEntity, IEquatable<OrderImportPending>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(OrderImportPending other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _code == other._code
                && _codeSet == other._codeSet
                && _correlationId.Equals(other._correlationId)
                && _correlationIdSet == other._correlationIdSet
                && _codeSeller == other._codeSeller
                && _codeSellerSet == other._codeSellerSet
                && _codeUser == other._codeUser
                && _codeUserSet == other._codeUserSet
                && _codePartner == other._codePartner
                && _codePartnerSet == other._codePartnerSet
                && _singleNumber == other._singleNumber
                && _singleNumberSet == other._singleNumberSet
                && _dateOrder.Equals(other._dateOrder)
                && _dateOrderSet == other._dateOrderSet
                && _dateImport.Equals(other._dateImport)
                && _dateImportSet == other._dateImportSet
                && _dateChanged.Equals(other._dateChanged)
                && _dateChangedSet == other._dateChangedSet
                && _status == other._status
                && _statusSet == other._statusSet
                && string.Equals(
                    _history,
                    other._history,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _historySet == other._historySet
                && string.Equals(
                    _partnerName,
                    other._partnerName,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _partnerNameSet == other._partnerNameSet
                && string.Equals(
                    _partnerCorporateName,
                    other._partnerCorporateName,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _partnerCorporateNameSet == other._partnerCorporateNameSet
                && string.Equals(
                    _document,
                    other._document,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _documentSet == other._documentSet
                && string.Equals(
                    _emailAddress,
                    other._emailAddress,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _emailAddressSet == other._emailAddressSet
                && string.Equals(
                    _telephone,
                    other._telephone,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _telephoneSet == other._telephoneSet
                && string.Equals(
                    _zipCode,
                    other._zipCode,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _zipCodeSet == other._zipCodeSet
                && string.Equals(
                    _address,
                    other._address,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _addressSet == other._addressSet
                && string.Equals(
                    _addressNumber,
                    other._addressNumber,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _addressNumberSet == other._addressNumberSet
                && string.Equals(
                    _addressComplement,
                    other._addressComplement,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _addressComplementSet == other._addressComplementSet
                && string.Equals(
                    _neighborhood,
                    other._neighborhood,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _neighborhoodSet == other._neighborhoodSet
                && string.Equals(_city, other._city, StringComparison.InvariantCultureIgnoreCase)
                && _citySet == other._citySet
                && string.Equals(
                    _stateInitials,
                    other._stateInitials,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _stateInitialsSet == other._stateInitialsSet
                && Equals(_seller, other._seller)
                && _sellerSet == other._sellerSet
                && Equals(_user, other._user)
                && _userSet == other._userSet
                && Equals(_partner, other._partner)
                && _partnerSet == other._partnerSet
                && IsManual == other.IsManual
                && string.Equals(_host, other._host)
                && _hostSet == other._hostSet;
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

        return obj.GetType() == GetType() && Equals((OrderImportPending)obj);
    }

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
            var hashCode = _code;
            hashCode = (hashCode * 397) ^ _codeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _correlationId.GetHashCode();
            hashCode = (hashCode * 397) ^ _correlationIdSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeSeller;
            hashCode = (hashCode * 397) ^ _codeSellerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeUser;
            hashCode = (hashCode * 397) ^ _codeUserSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codePartner;
            hashCode = (hashCode * 397) ^ _codePartnerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _singleNumber;
            hashCode = (hashCode * 397) ^ _singleNumberSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateOrder.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateOrderSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateImport.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateImportSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateChanged.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateChangedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_status;
            hashCode = (hashCode * 397) ^ _statusSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _history != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_history)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _historySet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _partnerName != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_partnerName)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _partnerNameSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _partnerCorporateName != null
                        ? StringComparer
                            .InvariantCultureIgnoreCase
                            .GetHashCode(_partnerCorporateName)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _partnerCorporateNameSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _document != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_document)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _documentSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _emailAddress != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_emailAddress)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _emailAddressSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _telephone != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_telephone)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _telephoneSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _zipCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_zipCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _zipCodeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _address != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_address)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _addressSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _addressNumber != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_addressNumber)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _addressNumberSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _addressComplement != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_addressComplement)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _addressComplementSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _neighborhood != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_neighborhood)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _neighborhoodSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _city != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_city) : 0
                );
            hashCode = (hashCode * 397) ^ _citySet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _stateInitials != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_stateInitials)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _stateInitialsSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_seller != null ? _seller.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _sellerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_user != null ? _user.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _userSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_partner != null ? _partner.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _partnerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ IsManual.GetHashCode();
            hashCode = (hashCode * 397) ^ _host.GetHashCode();
            hashCode = (hashCode * 397) ^ _hostSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(OrderImportPending left, OrderImportPending right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(OrderImportPending left, OrderImportPending right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The code
    /// </summary>
    /// <summary>
    /// The code
    /// </summary>
    private int _code;

    /// <summary>
    /// The code set
    /// </summary>
    /// <summary>
    /// The code set
    /// </summary>
    private bool _codeSet;

    /// <summary>
    /// The correlation identifier
    /// </summary>
    private string _correlationId;

    /// <summary>
    /// The correlation identifier set
    /// </summary>
    private bool _correlationIdSet;

    /// <summary>
    /// The code seller
    /// </summary>
    /// <summary>
    /// The code seller
    /// </summary>
    private int _codeSeller;

    /// <summary>
    /// The code seller set
    /// </summary>
    /// <summary>
    /// The code seller set
    /// </summary>
    private bool _codeSellerSet;

    /// <summary>
    /// The code user
    /// </summary>
    /// <summary>
    /// The code user
    /// </summary>
    private int _codeUser;

    /// <summary>
    /// The code user set
    /// </summary>
    /// <summary>
    /// The code user set
    /// </summary>
    private bool _codeUserSet;

    /// <summary>
    /// The code partner
    /// </summary>
    /// <summary>
    /// The code partner
    /// </summary>
    private int _codePartner;

    /// <summary>
    /// The code partner set
    /// </summary>
    /// <summary>
    /// The code partner set
    /// </summary>
    private bool _codePartnerSet;

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
    /// The date order
    /// </summary>
    /// <summary>
    /// The date order
    /// </summary>
    private DateTime _dateOrder;

    /// <summary>
    /// The date order set
    /// </summary>
    /// <summary>
    /// The date order set
    /// </summary>
    private bool _dateOrderSet;

    /// <summary>
    /// The date import
    /// </summary>
    /// <summary>
    /// The date import
    /// </summary>
    private DateTime _dateImport;

    /// <summary>
    /// The date import set
    /// </summary>
    /// <summary>
    /// The date import set
    /// </summary>
    private bool _dateImportSet;

    /// <summary>
    /// The date changed
    /// </summary>
    /// <summary>
    /// The date changed
    /// </summary>
    private DateTime _dateChanged;

    /// <summary>
    /// The date changed set
    /// </summary>
    /// <summary>
    /// The date changed set
    /// </summary>
    private bool _dateChangedSet;

    /// <summary>
    /// The status
    /// </summary>
    /// <summary>
    /// The status
    /// </summary>
    private OrderImportStatus _status;

    /// <summary>
    /// The status set
    /// </summary>
    /// <summary>
    /// The status set
    /// </summary>
    private bool _statusSet;

    /// <summary>
    /// The history
    /// </summary>
    /// <summary>
    /// The history
    /// </summary>
    private string _history;

    /// <summary>
    /// The history set
    /// </summary>
    /// <summary>
    /// The history set
    /// </summary>
    private bool _historySet;

    /// <summary>
    /// The partner name
    /// </summary>
    /// <summary>
    /// The partner name
    /// </summary>
    private string _partnerName;

    /// <summary>
    /// The partner name set
    /// </summary>
    /// <summary>
    /// The partner name set
    /// </summary>
    private bool _partnerNameSet;

    /// <summary>
    /// The partner corporate name
    /// </summary>
    /// <summary>
    /// The partner corporate name
    /// </summary>
    private string _partnerCorporateName;

    /// <summary>
    /// The partner corporate name set
    /// </summary>
    /// <summary>
    /// The partner corporate name set
    /// </summary>
    private bool _partnerCorporateNameSet;

    /// <summary>
    /// The document
    /// </summary>
    /// <summary>
    /// The document
    /// </summary>
    private string _document;

    /// <summary>
    /// The document set
    /// </summary>
    /// <summary>
    /// The document set
    /// </summary>
    private bool _documentSet;

    /// <summary>
    /// The email address
    /// </summary>
    /// <summary>
    /// The email address
    /// </summary>
    private string _emailAddress;

    /// <summary>
    /// The email address set
    /// </summary>
    /// <summary>
    /// The email address set
    /// </summary>
    private bool _emailAddressSet;

    /// <summary>
    /// The telephone
    /// </summary>
    /// <summary>
    /// The telephone
    /// </summary>
    private string _telephone;

    /// <summary>
    /// The telephone set
    /// </summary>
    /// <summary>
    /// The telephone set
    /// </summary>
    private bool _telephoneSet;

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
    /// The address
    /// </summary>
    /// <summary>
    /// The address
    /// </summary>
    private string _address;

    /// <summary>
    /// The address set
    /// </summary>
    /// <summary>
    /// The address set
    /// </summary>
    private bool _addressSet;

    /// <summary>
    /// The address number
    /// </summary>
    /// <summary>
    /// The address number
    /// </summary>
    private string _addressNumber;

    /// <summary>
    /// The address number set
    /// </summary>
    /// <summary>
    /// The address number set
    /// </summary>
    private bool _addressNumberSet;

    /// <summary>
    /// The address complement
    /// </summary>
    /// <summary>
    /// The address complement
    /// </summary>
    private string _addressComplement;

    /// <summary>
    /// The address complement set
    /// </summary>
    /// <summary>
    /// The address complement set
    /// </summary>
    private bool _addressComplementSet;

    /// <summary>
    /// The neighborhood
    /// </summary>
    /// <summary>
    /// The neighborhood
    /// </summary>
    private string _neighborhood;

    /// <summary>
    /// The neighborhood set
    /// </summary>
    /// <summary>
    /// The neighborhood set
    /// </summary>
    private bool _neighborhoodSet;

    /// <summary>
    /// The city
    /// </summary>
    /// <summary>
    /// The city
    /// </summary>
    private string _city;

    /// <summary>
    /// The city set
    /// </summary>
    /// <summary>
    /// The city set
    /// </summary>
    private bool _citySet;

    /// <summary>
    /// The state initials
    /// </summary>
    /// <summary>
    /// The state initials
    /// </summary>
    private string _stateInitials;

    /// <summary>
    /// The state initials set
    /// </summary>
    /// <summary>
    /// The state initials set
    /// </summary>
    private bool _stateInitialsSet;

    /// <summary>
    /// The host
    /// </summary>
    private string _host;

    /// <summary>
    /// The host set
    /// </summary>
    private bool _hostSet;

    /// <summary>
    /// The seller
    /// </summary>
    /// <summary>
    /// The seller
    /// </summary>
    private Seller _seller;

    /// <summary>
    /// The seller set
    /// </summary>
    /// <summary>
    /// The seller set
    /// </summary>
    private bool _sellerSet;

    /// <summary>
    /// The user
    /// </summary>
    /// <summary>
    /// The user
    /// </summary>
    private User _user;

    /// <summary>
    /// The user set
    /// </summary>
    /// <summary>
    /// The user set
    /// </summary>
    private bool _userSet;

    /// <summary>
    /// The partner
    /// </summary>
    /// <summary>
    /// The partner
    /// </summary>
    private Partner _partner;

    /// <summary>
    /// The partner set
    /// </summary>
    /// <summary>
    /// The partner set
    /// </summary>
    private bool _partnerSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    [EntityElement("CODPED")]
    [EntityKey]
    public int Code
    {
        get => _code;
        set
        {
            _code = value;
            _codeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the correlation identifier.
    /// </summary>
    /// <value>The correlation identifier.</value>
    [EntityElement("CORRELATIONID")]
    public string CorrelationId
    {
        get => _correlationId;
        set
        {
            _correlationId = value;
            _correlationIdSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code seller.
    /// </summary>
    /// <value>The code seller.</value>
    /// <summary>
    /// Gets or sets the code seller.
    /// </summary>
    /// <value>The code seller.</value>
    [EntityElement("CODVEND")]
    public int CodeSeller
    {
        get => _codeSeller;
        set
        {
            _codeSeller = value;
            _codeSellerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code user.
    /// </summary>
    /// <value>The code user.</value>
    /// <summary>
    /// Gets or sets the code user.
    /// </summary>
    /// <value>The code user.</value>
    [EntityElement("CODUSU")]
    public int CodeUser
    {
        get => _codeUser;
        set
        {
            _codeUser = value;
            _codeUserSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code partner.
    /// </summary>
    /// <value>The code partner.</value>
    /// <summary>
    /// Gets or sets the code partner.
    /// </summary>
    /// <value>The code partner.</value>
    [EntityElement("CODPARC")]
    public int CodePartner
    {
        get => _codePartner;
        set
        {
            _codePartner = value;
            _codePartnerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the single number.
    /// </summary>
    /// <value>
    /// The single number.
    /// </value>
    /// <summary>
    /// Gets or sets the single number.
    /// </summary>
    /// <value>The single number.</value>
    [EntityElement("NUNOTA")]
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
    /// Gets or sets the date order.
    /// </summary>
    /// <value>The date order.</value>
    /// <summary>
    /// Gets or sets the date order.
    /// </summary>
    /// <value>The date order.</value>
    [EntityElement("DTPEDIDO")]
    public DateTime DateOrder
    {
        get => _dateOrder;
        set
        {
            _dateOrder = value;
            _dateOrderSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date import.
    /// </summary>
    /// <value>The date import.</value>
    /// <summary>
    /// Gets or sets the date import.
    /// </summary>
    /// <value>The date import.</value>
    [EntityElement("DTIMPORTACAO")]
    public DateTime DateImport
    {
        get => _dateImport;
        set
        {
            _dateImport = value;
            _dateImportSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date changed.
    /// </summary>
    /// <value>The date changed.</value>
    /// <summary>
    /// Gets or sets the date changed.
    /// </summary>
    /// <value>The date changed.</value>
    [EntityElement("DTALTER")]
    public DateTime DateChanged
    {
        get => _dateChanged;
        set
        {
            _dateChanged = value;
            _dateChangedSet = true;
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
    public OrderImportStatus Status
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
            _status = EnumExtensions.GetEnumByInternalValueAttribute<OrderImportStatus>(value);
            _statusSet = true;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is manual.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is manual; otherwise, <c>false</c>.
    /// </value>
    /// <summary>
    /// Gets or sets a value indicating whether this instance is manual.
    /// </summary>
    /// <value><c>true</c> if this instance is manual; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool IsManual { get; set; }

    /// <summary>
    /// Gets or sets the history.
    /// </summary>
    /// <value>The history.</value>
    /// <summary>
    /// Gets or sets the history.
    /// </summary>
    /// <value>The history.</value>
    [EntityElement("HISTORICO")]
    public string History
    {
        get => _history;
        set
        {
            _history = value;
            _historySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the name of the partner.
    /// </summary>
    /// <value>The name of the partner.</value>
    /// <summary>
    /// Gets or sets the name of the partner.
    /// </summary>
    /// <value>The name of the partner.</value>
    [EntityElement("NOMEPARC")]
    public string PartnerName
    {
        get => _partnerName;
        set
        {
            _partnerName = value;
            _partnerNameSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the name of the partner corporate.
    /// </summary>
    /// <value>The name of the partner corporate.</value>
    /// <summary>
    /// Gets or sets the name of the partner corporate.
    /// </summary>
    /// <value>The name of the partner corporate.</value>
    [EntityElement("RAZAOSOCIAL")]
    public string PartnerCorporateName
    {
        get => _partnerCorporateName;
        set
        {
            _partnerCorporateName = value;
            _partnerCorporateNameSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the document.
    /// </summary>
    /// <value>The document.</value>
    /// <summary>
    /// Gets or sets the document.
    /// </summary>
    /// <value>The document.</value>
    [EntityElement("CPF_CNPJ", true)]
    public string Document
    {
        get => _document;
        set
        {
            _document = value;
            _documentSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    /// <value>The email address.</value>
    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    /// <value>The email address.</value>
    [EntityElement("EMAIL")]
    public string EmailAddress
    {
        get => _emailAddress;
        set
        {
            _emailAddress = value;
            _emailAddressSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the telephone.
    /// </summary>
    /// <value>The telephone.</value>
    /// <summary>
    /// Gets or sets the telephone.
    /// </summary>
    /// <value>The telephone.</value>
    [EntityElement("TELEFONE")]
    public string Telephone
    {
        get => _telephone;
        set
        {
            _telephone = value;
            _telephoneSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the zip code.
    /// </summary>
    /// <value>The zip code.</value>
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
    /// Gets or sets the address.
    /// </summary>
    /// <value>The address.</value>
    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    /// <value>The address.</value>
    [EntityElement("LOGRADOURO")]
    public string Address
    {
        get => _address;
        set
        {
            _address = value;
            _addressSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the address number.
    /// </summary>
    /// <value>The address number.</value>
    /// <summary>
    /// Gets or sets the address number.
    /// </summary>
    /// <value>The address number.</value>
    [EntityElement("NUMERO")]
    public string AddressNumber
    {
        get => _addressNumber;
        set
        {
            _addressNumber = value;
            _addressNumberSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the address complement.
    /// </summary>
    /// <value>The address complement.</value>
    /// <summary>
    /// Gets or sets the address complement.
    /// </summary>
    /// <value>The address complement.</value>
    [EntityElement("COMPLEMENTO")]
    public string AddressComplement
    {
        get => _addressComplement;
        set
        {
            _addressComplement = value;
            _addressComplementSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the neighborhood.
    /// </summary>
    /// <value>The neighborhood.</value>
    /// <summary>
    /// Gets or sets the neighborhood.
    /// </summary>
    /// <value>The neighborhood.</value>
    [EntityElement("BAIRRO")]
    public string Neighborhood
    {
        get => _neighborhood;
        set
        {
            _neighborhood = value;
            _neighborhoodSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    /// <value>The city.</value>
    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    /// <value>The city.</value>
    [EntityElement("CIDADE")]
    public string City
    {
        get => _city;
        set
        {
            _city = value;
            _citySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the state initials.
    /// </summary>
    /// <value>The state initials.</value>
    /// <summary>
    /// Gets or sets the state initials.
    /// </summary>
    /// <value>The state initials.</value>
    [EntityElement("UF")]
    public string StateInitials
    {
        get => _stateInitials;
        set
        {
            _stateInitials = value;
            _stateInitialsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the host.
    /// </summary>
    /// <value>The host.</value>
    [EntityElement("HOST")]
    public string Host
    {
        get => _host;
        set
        {
            _host = value;
            _hostSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the seller.
    /// </summary>
    /// <value>The seller.</value>
    /// <summary>
    /// Gets or sets the seller.
    /// </summary>
    /// <value>The seller.</value>
    [EntityReference]
    public Seller Seller
    {
        get => _seller;
        set
        {
            _seller = value;
            _sellerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    /// <value>The user.</value>
    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    /// <value>The user.</value>
    [EntityReference]
    public User User
    {
        get => _user;
        set
        {
            _user = value;
            _userSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the partner.
    /// </summary>
    /// <value>The partner.</value>
    /// <summary>
    /// Gets or sets the partner.
    /// </summary>
    /// <value>The partner.</value>
    [EntityReference]
    public Partner Partner
    {
        get => _partner;
        set
        {
            _partner = value;
            _partnerSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize code.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCode() => _codeSet;

    /// <summary>
    /// Should the serialize correlation identifier.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize correlation identifier.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCorrelationId() => _correlationIdSet;

    /// <summary>
    /// Should the serialize code seller.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code seller.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeSeller() => _codeSellerSet;

    /// <summary>
    /// Should the serialize code user.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code user.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// Should the serialize code partner.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code partner.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePartner() => _codePartnerSet;

    /// <summary>
    /// The should serialize single number serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize single number.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSingleNumber() => _singleNumberSet;

    /// <summary>
    /// Should the serialize date order.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize date order.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateOrder() => _dateOrderSet;

    /// <summary>
    /// Should the serialize date import.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize date import.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateImport() => _dateImportSet;

    /// <summary>
    /// Should the serialize date changed.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize date changed.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateChanged() => _dateChangedSet;

    /// <summary>
    /// Should the serialize status.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize status.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStatus() => _statusSet;

    /// <summary>
    /// Should the serialize history.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize history.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeHistory() => _historySet;

    /// <summary>
    /// Should the name of the serialize partner.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should name of the serialize partner.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePartnerName() => _partnerNameSet;

    /// <summary>
    /// Should the name of the serialize partner corporate.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should name of the serialize partner corporate.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePartnerCorporateName() => _partnerCorporateNameSet;

    /// <summary>
    /// Should the serialize document.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize document.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDocument() => _documentSet;

    /// <summary>
    /// Should the serialize email address.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize email address.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEmailAddress() => _emailAddressSet;

    /// <summary>
    /// Should the serialize telephone.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize telephone.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTelephone() => _telephoneSet;

    /// <summary>
    /// Should the serialize zip code.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize zip code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeZipCode() => _zipCodeSet;

    /// <summary>
    /// Should the serialize address.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAddress() => _addressSet;

    /// <summary>
    /// Should the serialize address number.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAddressNumber() => _addressNumberSet;

    /// <summary>
    /// Should the serialize address complement.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAddressComplement() => _addressComplementSet;

    /// <summary>
    /// Should the serialize neighborhood.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeNeighborhood() => _neighborhoodSet;

    /// <summary>
    /// Should the serialize city.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCity() => _citySet;

    /// <summary>
    /// Should the serialize state initials.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStateInitials() => _stateInitialsSet;

    /// <summary>
    /// Shoulds the serialize host.
    /// </summary>
    /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
    public bool ShouldSerializeHost() => _hostSet;

    /// <summary>
    /// Should the serialize seller.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSeller() => _sellerSet;

    /// <summary>
    /// Should the serialize user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUser() => _userSet;

    /// <summary>
    /// Should the serialize partner.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePartner() => _partnerSet;

    #endregion
}
