using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Serialization;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class ProductInventory. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("Estoque")]
[Serializer]
public class ProductInventoryCustom : ProductInventory, IEquatable<ProductInventoryCustom>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(ProductInventoryCustom other)
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
            && _lastCountDate.Equals(other._lastCountDate)
            && _lastCountDateSet == other._lastCountDateSet;
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
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

        return Equals((ProductInventoryCustom)obj);
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
            hashCode = (hashCode * 397) ^ _lastCountDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _lastCountDateSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(ProductInventoryCustom left, ProductInventoryCustom right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(ProductInventoryCustom left, ProductInventoryCustom right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The last count date
    /// </summary>
    private DateTime _lastCountDate;

    /// <summary>
    /// The last count date set
    /// </summary>
    private bool _lastCountDateSet;

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
    /// Gets or sets the last count date.
    /// </summary>
    /// <value>The last count date.</value>
    [EntityElement("AD_DTULTCONT")]
    public DateTime LastCountDate
    {
        get => _lastCountDate;
        set
        {
            _lastCountDate = value;
            _lastCountDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    /// <value>The product.</value>
    [EntityReference]
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
    /// Should the serialize product.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool ShouldSerializeProduct() => _productSet;

    /// <summary>
    /// Should the serialize last count date.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeLastCountDate() => _lastCountDateSet;

    #endregion
}
