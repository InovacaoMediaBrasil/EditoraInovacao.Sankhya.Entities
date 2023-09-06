using System;
using System.Diagnostics.CodeAnalysis;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class ItemMakeupProduct. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("ItemComposicaoProduto")]
public sealed class ItemMakeupProductCustom : ItemMakeupProduct, IEquatable<ItemMakeupProductCustom>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(ItemMakeupProductCustom other)
    {
        if (ReferenceEquals(null, other))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return base.Equals(other)
            && _gift == other._gift
            && _giftSet == other._giftSet
            && _locked == other._locked
            && _lockedSet == other._lockedSet
            && _price == other._price
            && _priceSet == other._priceSet
            && Equals(_product, other._product)
            && _productSet == other._productSet;
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj) =>
        ReferenceEquals(this, obj) || obj is ItemMakeupProductCustom other && Equals(other);

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
            hashCode = (hashCode * 397) ^ _gift.GetHashCode();
            hashCode = (hashCode * 397) ^ _giftSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _locked.GetHashCode();
            hashCode = (hashCode * 397) ^ _lockedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _price.GetHashCode();
            hashCode = (hashCode * 397) ^ _priceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_product != null ? _product.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _productSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(ItemMakeupProductCustom left, ItemMakeupProductCustom right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(ItemMakeupProductCustom left, ItemMakeupProductCustom right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The gift
    /// </summary>
    private bool _gift;

    /// <summary>
    /// The gift set
    /// </summary>
    private bool _giftSet;

    /// <summary>
    /// The locked
    /// </summary>
    private bool _locked;

    /// <summary>
    /// The locked set
    /// </summary>
    private bool _lockedSet;

    /// <summary>
    /// The price
    /// </summary>
    private decimal _price;

    /// <summary>
    /// The price set
    /// </summary>
    private bool _priceSet;

    /// <summary>
    /// The product
    /// </summary>
    private ProductCustom _product;

    /// <summary>
    /// The product set
    /// </summary>
    private bool _productSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the gift.
    /// </summary>
    /// <value>The gift.</value>
    [EntityElement("AD_BRINDE")]
    public bool Gift
    {
        get => _gift;
        set
        {
            _gift = value;
            _giftSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the locked.
    /// </summary>
    /// <value>The locked.</value>
    [EntityElement("AD_TRAVADO")]
    public bool Locked
    {
        get => _locked;
        set
        {
            _locked = value;
            _lockedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the price.
    /// </summary>
    /// <value>The price.</value>
    [EntityElement("AD_VLRVENDA")]
    public decimal Price
    {
        get => _price;
        set
        {
            _price = value;
            _priceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    /// <value>The product.</value>
    [EntityReference("ProdutoMateriaPrima")]
    public new ProductCustom Product
    {
        get => _product;
        set
        {
            _product = value;
            _productSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize gift.
    /// </summary>
    /// <returns>Boolean.</returns>
    public bool ShouldSerializeGift() => _giftSet;

    /// <summary>
    /// Should the serialize locked.
    /// </summary>
    /// <returns>Boolean.</returns>
    public bool ShouldSerializeLocked() => _lockedSet;

    /// <summary>
    /// Should the serialize price.
    /// </summary>
    /// <returns>Boolean.</returns>
    public bool ShouldSerializePrice() => _priceSet;

    /// <summary>
    /// Should the serialize product.
    /// </summary>
    /// <returns>Boolean.</returns>
    public new bool ShouldSerializeProduct() => _productSet;

    #endregion
}
