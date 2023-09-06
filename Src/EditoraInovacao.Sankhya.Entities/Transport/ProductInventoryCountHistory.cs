// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 26/12/2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="ProductInventoryCountHistory.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CrispyWaffle.Extensions;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class ProductInventoryCountHistory. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("ESTHIST")]
public sealed class ProductInventoryCountHistory : IEntity, IEquatable<ProductInventoryCountHistory>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(ProductInventoryCountHistory other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _codePartner == other._codePartner
                && _codePartnerSet == other._codePartnerSet
                && _codeProduct == other._codeProduct
                && _codeProductSet == other._codeProductSet
                && _codeUser == other._codeUser
                && _codeUserSet == other._codeUserSet
                && _dateCounted.Equals(other._dateCounted)
                && _dateCountedSet == other._dateCountedSet
                && Equals(_partner, other._partner)
                && _partnerSet == other._partnerSet
                && Equals(_product, other._product)
                && _productSet == other._productSet
                && _quantity == other._quantity
                && _quantitySet == other._quantitySet
                && _reserved == other._reserved
                && _reservedSet == other._reservedSet
                && Equals(_user, other._user)
                && _userSet == other._userSet;
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

        return ReferenceEquals(this, obj)
            || obj is ProductInventoryCountHistory history && Equals(history);
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
            var hashCode = _codePartner;
            hashCode = (hashCode * 397) ^ _codePartnerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeProduct;
            hashCode = (hashCode * 397) ^ _codeProductSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeUser;
            hashCode = (hashCode * 397) ^ _codeUserSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateCounted.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateCountedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_partner != null ? _partner.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _partnerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_product != null ? _product.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _productSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _quantity.GetHashCode();
            hashCode = (hashCode * 397) ^ _quantitySet.GetHashCode();
            hashCode = (hashCode * 397) ^ _reserved.GetHashCode();
            hashCode = (hashCode * 397) ^ _reservedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_user != null ? _user.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _userSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(
        ProductInventoryCountHistory left,
        ProductInventoryCountHistory right
    ) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(
        ProductInventoryCountHistory left,
        ProductInventoryCountHistory right
    ) => !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The code product
    /// </summary>
    private int _codeProduct;

    /// <summary>
    /// The code product set
    /// </summary>
    private bool _codeProductSet;

    /// <summary>
    /// The code user
    /// </summary>
    private int _codeUser;

    /// <summary>
    /// The code user set
    /// </summary>
    private bool _codeUserSet;

    /// <summary>
    /// The code partner
    /// </summary>
    private int _codePartner;

    /// <summary>
    /// The code partner set
    /// </summary>
    private bool _codePartnerSet;

    /// <summary>
    /// The date counted
    /// </summary>
    private DateTime _dateCounted;

    /// <summary>
    /// The date counted set
    /// </summary>
    private bool _dateCountedSet;

    /// <summary>
    /// The quantity
    /// </summary>
    private decimal _quantity;

    /// <summary>
    /// The quantity set
    /// </summary>
    private bool _quantitySet;

    /// <summary>
    /// The reserved
    /// </summary>
    private decimal _reserved;

    /// <summary>
    /// The reserved set
    /// </summary>
    private bool _reservedSet;

    /// <summary>
    /// The product
    /// </summary>
    private ProductCustom _product;

    /// <summary>
    /// The product set
    /// </summary>
    private bool _productSet;

    /// <summary>
    /// The user
    /// </summary>
    private User _user;

    /// <summary>
    /// The user set
    /// </summary>
    private bool _userSet;

    /// <summary>
    /// The partner
    /// </summary>
    private Partner _partner;

    /// <summary>
    /// The partner set
    /// </summary>
    private bool _partnerSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code product.
    /// </summary>
    /// <value>The code product.</value>
    [EntityElement("CODPROD")]
    [EntityKey]
    public int CodeProduct
    {
        get => _codeProduct;
        set
        {
            _codeProduct = value;
            _codeProductSet = true;
        }
    }

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
    /// Gets or sets the date counted.
    /// </summary>
    /// <value>The date counted.</value>
    [EntityElement("DATACONT")]
    public DateTime DateCounted
    {
        get => _dateCounted;
        set
        {
            _dateCounted = value;
            _dateCountedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    /// <value>The quantity.</value>
    [EntityIgnore]
    public decimal Quantity
    {
        get => _quantity;
        set
        {
            _quantity = value;
            _quantitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the quantity internal.
    /// </summary>
    /// <value>The quantity internal.</value>
    [EntityElement("ESTOQUE")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string QuantityInternal
    {
        get => _quantity.ToString(CultureInfo.InvariantCulture);
        set
        {
            _quantity = value.ToDecimal();
            _quantitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the reserved.
    /// </summary>
    /// <value>The reserved.</value>
    [EntityIgnore]
    public decimal Reserved
    {
        get => _reserved;
        set
        {
            _reserved = value;
            _reservedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the reserved internal.
    /// </summary>
    /// <value>The reserved internal.</value>
    [EntityElement("RESERVADO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ReservedInternal
    {
        get => _reserved.ToString(CultureInfo.InvariantCulture);
        set
        {
            _reserved = value.ToDecimal();
            _reservedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    /// <value>The product.</value>
    [EntityReference]
    public ProductCustom Product
    {
        get => _product;
        set
        {
            _product = value;
            _productSet = true;
        }
    }

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
    /// Should the serialize code product.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeProduct() => _codeProductSet;

    /// <summary>
    /// Should the serialize code user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// Should the serialize code partner.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePartner() => _codePartnerSet;

    /// <summary>
    /// Should the serialize date counted.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateCounted() => _dateCountedSet;

    /// <summary>
    /// Should the serialize quantity.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeQuantity() => _quantitySet;

    /// <summary>
    /// Should the serialize reserved.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeReserved() => _reservedSet;

    /// <summary>
    /// Should the serialize product.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeProduct() => _productSet;

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
