// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 2016-12-24
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderControl.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using CrispyWaffle.Extensions;
using CrispyWaffle.Serialization;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// The order control class.
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="IEquatable{T}" />
/// <summary>
/// Class OrderControl.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="IEquatable{OrderControl}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="IEquatable{OrderControl}" />
[Serializer]
[Entity("PEDIDOVTEXSC")]
public class OrderControl : IEntity, IEquatable<OrderControl>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(OrderControl other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return string.Equals(_orderId, other._orderId, StringComparison.InvariantCultureIgnoreCase)
            && _orderIdSet == other._orderIdSet
            && _orderIdMarketplace == other._orderIdMarketplace
            && _orderIdMarketplaceSet == other._orderIdMarketplaceSet
            && _sequence == other._sequence
            && _sequenceSet == other._sequenceSet
            && _codeStore == other._codeStore
            && _codeStoreSet == other._codeStoreSet
            && _codeSeller == other._codeSeller
            && _codeSellerSet == other._codeSellerSet
            && _codePartner == other._codePartner
            && _codePartnerSet == other._codePartnerSet
            && _hasDigitalCourse == other._hasDigitalCourse
            && _hasDigitalCourseSet == other._hasDigitalCourseSet
            && _dateIndexedOrder.Equals(other._dateIndexedOrder)
            && _dateIndexedOrderSet == other._dateIndexedOrderSet
            && _isIndexedOrder == other._isIndexedOrder
            && _isIndexedOrderSet == other._isIndexedOrderSet
            && _isIndexedItems == other._isIndexedItems
            && _isIndexedItemsSet == other._isIndexedItemsSet
            && string.Equals(_source, other._source, StringComparison.InvariantCultureIgnoreCase)
            && _sourceSet == other._sourceSet
            && string.Equals(_medium, other._medium, StringComparison.InvariantCultureIgnoreCase)
            && _mediumSet == other._mediumSet
            && string.Equals(
                _campaign,
                other._campaign,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _campaignSet == other._campaignSet
            && _codePromotion == other._codePromotion
            && _codePromotionSet == other._codePromotionSet
            && string.Equals(
                _promotion,
                other._promotion,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _promotionSet == other._promotionSet
            && string.Equals(_coupon, other._coupon, StringComparison.InvariantCultureIgnoreCase)
            && _couponSet == other._couponSet
            && Equals(_seller, other._seller)
            && _sellerSet == other._sellerSet
            && Equals(_store, other._store)
            && _storeSet == other._storeSet
            && Equals(_partner, other._partner)
            && _partnerSet == other._partnerSet
            && Equals(_flows, other._flows)
            && _flowsSet == other._flowsSet
            && Equals(_payments, other._payments)
            && _paymentsSet == other._paymentsSet
            && Equals(_shipments, other._shipments)
            && _shipmentsSet == other._shipmentsSet;
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

        return obj.GetType() == GetType() && Equals((OrderControl)obj);
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
            var hashCode =
                _orderId != null
                    ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_orderId)
                    : 0;
            hashCode = (hashCode * 397) ^ _orderIdSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _orderIdMarketplace.GetHashCode();
            hashCode = (hashCode * 397) ^ _orderIdMarketplaceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _sequence;
            hashCode = (hashCode * 397) ^ _sequenceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeStore;
            hashCode = (hashCode * 397) ^ _codeStoreSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeSeller;
            hashCode = (hashCode * 397) ^ _codeSellerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codePartner;
            hashCode = (hashCode * 397) ^ _codePartnerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _hasDigitalCourse.GetHashCode();
            hashCode = (hashCode * 397) ^ _hasDigitalCourseSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateIndexedOrder.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateIndexedOrderSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _isIndexedOrder.GetHashCode();
            hashCode = (hashCode * 397) ^ _isIndexedOrderSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _isIndexedItems.GetHashCode();
            hashCode = (hashCode * 397) ^ _isIndexedItemsSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _source != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_source)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _sourceSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _medium != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_medium)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _mediumSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _campaign != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_campaign)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _campaignSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codePromotion;
            hashCode = (hashCode * 397) ^ _codePromotionSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _promotion != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_promotion)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _promotionSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _coupon != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_coupon)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _couponSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_seller != null ? _seller.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _sellerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_store != null ? _store.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _storeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_partner != null ? _partner.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _partnerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_flows != null ? _flows.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _flowsSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_payments != null ? _payments.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _paymentsSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_shipments != null ? _shipments.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _shipmentsSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(OrderControl left, OrderControl right) => Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(OrderControl left, OrderControl right) => !Equals(left, right);

    #endregion

    #region Private Members

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
    /// The order identifier marketplace
    /// </summary>
    /// <summary>
    /// The order identifier marketplace
    /// </summary>
    private long _orderIdMarketplace;

    /// <summary>
    /// The order identifier marketplace set
    /// </summary>
    /// <summary>
    /// The order identifier marketplace set
    /// </summary>
    private bool _orderIdMarketplaceSet;

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
    /// The code store
    /// </summary>
    /// <summary>
    /// The code store
    /// </summary>
    private int _codeStore;

    /// <summary>
    /// The code store set
    /// </summary>
    /// <summary>
    /// The code store set
    /// </summary>
    private bool _codeStoreSet;

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
    /// The has digital course
    /// </summary>
    /// <summary>
    /// The has digital course
    /// </summary>
    private bool _hasDigitalCourse;

    /// <summary>
    /// The has digital course set
    /// </summary>
    /// <summary>
    /// The has digital course set
    /// </summary>
    private bool _hasDigitalCourseSet;

    /// <summary>
    /// The date indexed order
    /// </summary>
    /// <summary>
    /// The date indexed order
    /// </summary>
    private DateTime _dateIndexedOrder;

    /// <summary>
    /// The date indexed order set
    /// </summary>
    /// <summary>
    /// The date indexed order set
    /// </summary>
    private bool _dateIndexedOrderSet;

    /// <summary>
    /// The is indexed order
    /// </summary>
    /// <summary>
    /// The is indexed order
    /// </summary>
    private bool _isIndexedOrder;

    /// <summary>
    /// The is indexed order set
    /// </summary>
    /// <summary>
    /// The is indexed order set
    /// </summary>
    private bool _isIndexedOrderSet;

    /// <summary>
    /// The is indexed items
    /// </summary>
    /// <summary>
    /// The is indexed items
    /// </summary>
    private bool _isIndexedItems;

    /// <summary>
    /// The is indexed items set
    /// </summary>
    /// <summary>
    /// The is indexed items set
    /// </summary>
    private bool _isIndexedItemsSet;

    /// <summary>
    /// The source
    /// </summary>
    /// <summary>
    /// The source
    /// </summary>
    private string _source;

    /// <summary>
    /// The source set
    /// </summary>
    /// <summary>
    /// The source set
    /// </summary>
    private bool _sourceSet;

    /// <summary>
    /// The medium
    /// </summary>
    /// <summary>
    /// The medium
    /// </summary>
    private string _medium;

    /// <summary>
    /// The medium set
    /// </summary>
    /// <summary>
    /// The medium set
    /// </summary>
    private bool _mediumSet;

    /// <summary>
    /// The campaign
    /// </summary>
    /// <summary>
    /// The campaign
    /// </summary>
    private string _campaign;

    /// <summary>
    /// The campaign set
    /// </summary>
    /// <summary>
    /// The campaign set
    /// </summary>
    private bool _campaignSet;

    /// <summary>
    /// The code promotion
    /// </summary>
    /// <summary>
    /// The code promotion
    /// </summary>
    private int _codePromotion;

    /// <summary>
    /// The code promotion set
    /// </summary>
    /// <summary>
    /// The code promotion set
    /// </summary>
    private bool _codePromotionSet;

    /// <summary>
    /// The promotion
    /// </summary>
    /// <summary>
    /// The promotion
    /// </summary>
    private string _promotion;

    /// <summary>
    /// The promotion set
    /// </summary>
    /// <summary>
    /// The promotion set
    /// </summary>
    private bool _promotionSet;

    /// <summary>
    /// The coupon
    /// </summary>
    /// <summary>
    /// The coupon
    /// </summary>
    private string _coupon;

    /// <summary>
    /// The coupon set
    /// </summary>
    /// <summary>
    /// The coupon set
    /// </summary>
    private bool _couponSet;

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
    /// The store
    /// </summary>
    /// <summary>
    /// The store
    /// </summary>
    private Store _store;

    /// <summary>
    /// The store set
    /// </summary>
    /// <summary>
    /// The store set
    /// </summary>
    private bool _storeSet;

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

    /// <summary>
    /// The flows
    /// </summary>
    /// <summary>
    /// The flows
    /// </summary>
    private ICollection<OrderControlFlow> _flows;

    /// <summary>
    /// The flows set
    /// </summary>
    /// <summary>
    /// The flows set
    /// </summary>
    private bool _flowsSet;

    /// <summary>
    /// The payments.
    /// </summary>
    /// <summary>
    /// The payments
    /// </summary>
    private ICollection<OrderControlPayment> _payments;

    /// <summary>
    /// The payments set.
    /// </summary>
    /// <summary>
    /// The payments set
    /// </summary>
    private bool _paymentsSet;

    /// <summary>
    /// The shipments
    /// </summary>
    /// <summary>
    /// The shipments
    /// </summary>
    private ICollection<OrderControlShipment> _shipments;

    /// <summary>
    /// The shipments set
    /// </summary>
    /// <summary>
    /// The shipments set
    /// </summary>
    private bool _shipmentsSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    /// <summary>
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    [EntityKey]
    [EntityElement("ORDERID")]
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
    /// Gets or sets the order identifier marketplace.
    /// </summary>
    /// <value>The order identifier marketplace.</value>
    /// <summary>
    /// Gets or sets the order identifier marketplace.
    /// </summary>
    /// <value>The order identifier marketplace.</value>
    [EntityElement("MARKETPLACEORDERID")]
    public long OrderIdMarketplace
    {
        get => _orderIdMarketplace;
        set
        {
            _orderIdMarketplace = value;
            _orderIdMarketplaceSet = true;
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
    [EntityKey]
    [EntityElement("PEDORIGINAL")]
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
    /// Gets or sets the code store.
    /// </summary>
    /// <value>The code store.</value>
    /// <summary>
    /// Gets or sets the code store.
    /// </summary>
    /// <value>The code store.</value>
    [EntityElement("CODLOJA")]
    public int CodeStore
    {
        get => _codeStore;
        set
        {
            _codeStore = value;
            _codeStoreSet = true;
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
    /// Gets or sets the code partner.
    /// </summary>
    /// <value>
    /// The code partner.
    /// </value>
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
    /// Gets or sets the has digital course.
    /// </summary>
    /// <value>The has digital course.</value>
    /// <summary>
    /// Gets or sets a value indicating whether this instance has digital course.
    /// </summary>
    /// <value><c>true</c> if this instance has digital course; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool HasDigitalCourse
    {
        get => _hasDigitalCourse;
        set
        {
            _hasDigitalCourse = value;
            _hasDigitalCourseSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the has digital course internal.
    /// </summary>
    /// <value>The has digital course internal.</value>
    /// <summary>
    /// Gets or sets the has digital course internal.
    /// </summary>
    /// <value>The has digital course internal.</value>
    [EntityElement("POSSUICURSODIGITAL")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string HasDigitalCourseInternal
    {
        get => _hasDigitalCourse.ToString(@"S", @"N");
        set
        {
            _hasDigitalCourse = value != null && value.ToBoolean();
            _hasDigitalCourseSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date indexed order.
    /// </summary>
    /// <value>
    /// The date indexed order.
    /// </value>
    /// <summary>
    /// Gets or sets the date indexed order.
    /// </summary>
    /// <value>The date indexed order.</value>
    [EntityElement("DTIDXPED")]
    public DateTime DateIndexedOrder
    {
        get => _dateIndexedOrder;
        set
        {
            _dateIndexedOrder = value;
            _dateIndexedOrderSet = true;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is indexed order.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is indexed order; otherwise, <c>false</c>.
    /// </value>
    /// <summary>
    /// Gets or sets a value indicating whether this instance is indexed order.
    /// </summary>
    /// <value><c>true</c> if this instance is indexed order; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool IsIndexedOrder
    {
        get => _isIndexedOrder;
        set
        {
            _isIndexedOrder = value;
            _isIndexedOrderSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is indexed order internal.
    /// </summary>
    /// <value>
    /// The is indexed order internal.
    /// </value>
    /// <summary>
    /// Gets or sets the is indexed order internal.
    /// </summary>
    /// <value>The is indexed order internal.</value>
    [EntityElement("IDXPED")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IsIndexedOrderInternal
    {
        get => _isIndexedOrder.ToString(@"S", @"N");
        set
        {
            _isIndexedOrder = value.ToBoolean();
            _isIndexedOrderSet = true;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is indexed items.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is indexed items; otherwise, <c>false</c>.
    /// </value>
    /// <summary>
    /// Gets or sets a value indicating whether this instance is indexed items.
    /// </summary>
    /// <value><c>true</c> if this instance is indexed items; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool IsIndexedItems
    {
        get => _isIndexedItems;
        set
        {
            _isIndexedItems = value;
            _isIndexedItemsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is indexed items internal.
    /// </summary>
    /// <value>
    /// The is indexed items internal.
    /// </value>
    /// <summary>
    /// Gets or sets the is indexed items internal.
    /// </summary>
    /// <value>The is indexed items internal.</value>
    [EntityElement("IDXITENS")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IsIndexedItemsInternal
    {
        get => _isIndexedItems.ToString(@"S", @"N");
        set
        {
            _isIndexedItems = value.ToBoolean();
            _isIndexedItemsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the source.
    /// </summary>
    /// <value>The source.</value>
    /// <summary>
    /// Gets or sets the source.
    /// </summary>
    /// <value>The source.</value>
    [EntityElement("ORIGEM")]
    public string Source
    {
        get => _source;
        set
        {
            _source = value;
            _sourceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the medium.
    /// </summary>
    /// <value>The medium.</value>
    /// <summary>
    /// Gets or sets the medium.
    /// </summary>
    /// <value>The medium.</value>
    [EntityElement("MIDIA")]
    public string Medium
    {
        get => _medium;
        set
        {
            _medium = value;
            _mediumSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the campaign.
    /// </summary>
    /// <value>The campaign.</value>
    /// <summary>
    /// Gets or sets the campaign.
    /// </summary>
    /// <value>The campaign.</value>
    [EntityElement("CAMPANHA")]
    public string Campaign
    {
        get => _campaign;
        set
        {
            _campaign = value;
            _campaignSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code promotion.
    /// </summary>
    /// <value>The code promotion.</value>
    /// <summary>
    /// Gets or sets the code promotion.
    /// </summary>
    /// <value>The code promotion.</value>
    [EntityElement("CODPROMOCAO")]
    public int CodePromotion
    {
        get => _codePromotion;
        set
        {
            _codePromotion = value;
            _codePromotionSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the promotion.
    /// </summary>
    /// <value>The promotion.</value>
    /// <summary>
    /// Gets or sets the promotion.
    /// </summary>
    /// <value>The promotion.</value>
    [EntityElement("PROMOCAO")]
    public string Promotion
    {
        get => _promotion;
        set
        {
            _promotion = value;
            _promotionSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the coupon.
    /// </summary>
    /// <value>The coupon.</value>
    /// <summary>
    /// Gets or sets the coupon.
    /// </summary>
    /// <value>The coupon.</value>
    [EntityElement("CUPOM")]
    public string Coupon
    {
        get => _coupon;
        set
        {
            _coupon = value;
            _couponSet = true;
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
    /// Gets or sets the store.
    /// </summary>
    /// <value>The store.</value>
    /// <summary>
    /// Gets or sets the store.
    /// </summary>
    /// <value>The store.</value>
    [EntityReference]
    public Store Store
    {
        get => _store;
        set
        {
            _store = value;
            _storeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the partner.
    /// </summary>
    /// <value>
    /// The partner.
    /// </value>
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

    /// <summary>
    /// Gets or sets the flows.
    /// </summary>
    /// <value>The flows.</value>
    /// <summary>
    /// Gets or sets the flows.
    /// </summary>
    /// <value>The flows.</value>
    [EntityIgnore]
    public OrderControlFlow[] Flows
    {
        get => _flows.ToArray();
        set
        {
            if (value == null)
            {
                _flows.Clear();
            }
            else
            {
                _flows = value.ToList();
            }

            _flowsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the payments.
    /// </summary>
    /// <value>The payments.</value>
    /// <summary>
    /// Gets or sets the payments.
    /// </summary>
    /// <value>The payments.</value>
    [EntityIgnore]
    public OrderControlPayment[] Payments
    {
        get => _payments.ToArray();
        set
        {
            if (value == null)
            {
                _payments.Clear();
            }
            else
            {
                _payments = value.ToList();
            }

            _paymentsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the shipments.
    /// </summary>
    /// <value>The shipments.</value>
    /// <summary>
    /// Gets or sets the shipments.
    /// </summary>
    /// <value>The shipments.</value>
    [EntityIgnore]
    public OrderControlShipment[] Shipments
    {
        get => _shipments.ToArray();
        set
        {
            if (value == null)
            {
                _shipments.Clear();
            }
            else
            {
                _shipments = value.ToList();
            }

            _shipmentsSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

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
    /// Should the serialize order identifier marketplace.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize order identifier marketplace.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOrderIdMarketplace() => _orderIdMarketplaceSet;

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
    /// Should the serialize code store.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code store.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeStore() => _codeStoreSet;

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
    /// The should serialize code partner serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize code partner.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePartner() => _codePartnerSet;

    /// <summary>
    /// Should the serialize has digital course.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize has digital course.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeHasDigitalCourse() => _hasDigitalCourseSet;

    /// <summary>
    /// The should serialize date indexed order serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize date indexed order.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateIndexedOrder() => _dateIndexedOrderSet;

    /// <summary>
    /// The should serialize is indexed order serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize is indexed order.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsIndexedOrder() => _isIndexedOrderSet;

    /// <summary>
    /// The should serialize is indexed items serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize is indexed items.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsIndexedItems() => _isIndexedItemsSet;

    /// <summary>
    /// Should the serialize source.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize source.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSource() => _sourceSet;

    /// <summary>
    /// Should the serialize medium.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize medium.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeMedium() => _mediumSet;

    /// <summary>
    /// Should the serialize campaign.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize campaign.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCampaign() => _campaignSet;

    /// <summary>
    /// Should the serialize code promotion.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code promotion.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePromotion() => _codePromotionSet;

    /// <summary>
    /// Should the serialize promotion.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize promotion.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePromotion() => _promotionSet;

    /// <summary>
    /// Should the serialize coupon.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize coupon.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCoupon() => _couponSet;

    /// <summary>
    /// Should the serialize seller.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize seller.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSeller() => _sellerSet;

    /// <summary>
    /// Should the serialize store.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize store.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStore() => _storeSet;

    /// <summary>
    /// The should serialize partner serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize partner.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePartner() => _partnerSet;

    /// <summary>
    /// The should serialize tracking code serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize tracking code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Remove this when finish process missing tracking")]
    public bool ShouldSerializeTrackingCode() => false;

    /// <summary>
    /// The should serialize weight serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize weight.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Remove this when finish process missing tracking")]
    public bool ShouldSerializeWeight() => false;

    /// <summary>
    /// The should serialize freight value serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize freight value.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Remove this when finish process missing tracking")]
    public bool ShouldSerializeFreightValue() => false;

    #endregion

    #region Methods

    /// <summary>
    /// Pushes the flow.
    /// </summary>
    /// <param name="flow">The flow.</param>
    public void PushFlow(OrderControlFlow flow) => AddFlow(flow);

    /// <summary>
    /// Pushes the payment.
    /// </summary>
    /// <param name="payment">The payment.</param>
    public void PushPayment(OrderControlPayment payment) => AddPayment(payment);

    /// <summary>
    /// Pushes the shipment.
    /// </summary>
    /// <param name="shipment">The shipment.</param>
    public void PushShipment(OrderControlShipment shipment) => AddShipment(shipment);

    /// <summary>
    /// Adds a flow.
    /// </summary>
    /// <param name="flow">The flow.</param>
    /// <returns>OrderControl</returns>
    public OrderControl AddFlow(OrderControlFlow flow)
    {
        if (_flows.Any(f => f.SingleNumber == flow.SingleNumber && f.Flow == flow.Flow))
        {
            _flows.Remove(
                _flows.Single(f => f.SingleNumber == flow.SingleNumber && f.Flow == flow.Flow)
            );
        }

        _flows.Add(flow);
        _flowsSet = true;
        return this;
    }

    /// <summary>
    /// Adds a payment
    /// </summary>
    /// <param name="payment">The payment.</param>
    /// <returns>OrderControl</returns>
    public OrderControl AddPayment(OrderControlPayment payment)
    {
        if (
            _payments.Any(p =>
                p.TransactionCode == payment.TransactionCode && p.PaymentCode == payment.PaymentCode
            )
        )
        {
            _payments.Remove(
                _payments.Single(p =>
                    p.TransactionCode == payment.TransactionCode
                    && p.PaymentCode == payment.PaymentCode
                )
            );
        }

        _payments.Add(payment);
        _paymentsSet = true;
        return this;
    }

    /// <summary>
    /// Adds the shipment.
    /// </summary>
    /// <param name="shipment">The shipment.</param>
    /// <returns>OrderControl</returns>
    public OrderControl AddShipment(OrderControlShipment shipment)
    {
        if (
            _shipments.Any(s =>
                s.SingleNumber == shipment.SingleNumber && s.TrackingCode == shipment.TrackingCode
            )
        )
        {
            _shipments.Remove(
                _shipments.Single(s =>
                    s.SingleNumber == shipment.SingleNumber
                    && s.TrackingCode == shipment.TrackingCode
                )
            );
        }

        _shipments.Add(shipment);
        _shipmentsSet = true;
        return this;
    }

    #endregion

    #region ~Ctor

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderControl" /> class.
    /// </summary>
    public OrderControl()
    {
        _flows = new Collection<OrderControlFlow>();
        _payments = new Collection<OrderControlPayment>();
        _shipments = new Collection<OrderControlShipment>();
    }

    #endregion
}
