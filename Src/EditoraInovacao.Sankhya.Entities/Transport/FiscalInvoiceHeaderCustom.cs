using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class FiscalInvoiceHeader.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("CabecalhoNota")]
public class FiscalInvoiceHeaderCustom : FiscalInvoiceHeader, IEquatable<FiscalInvoiceHeaderCustom>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    public bool Equals(FiscalInvoiceHeaderCustom other)
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
            && _originalOrder == other._originalOrder
            && _originalOrderSet == other._originalOrderSet;
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

        return Equals((FiscalInvoiceHeaderCustom)obj);
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
            hashCode = (hashCode * 397) ^ _originalOrder;
            hashCode = (hashCode * 397) ^ _originalOrderSet.GetHashCode();
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
        FiscalInvoiceHeaderCustom left,
        FiscalInvoiceHeaderCustom right
    ) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(
        FiscalInvoiceHeaderCustom left,
        FiscalInvoiceHeaderCustom right
    ) => !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The original order
    /// </summary>
    private int _originalOrder;

    /// <summary>
    /// The original order set
    /// </summary>
    private bool _originalOrderSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the original order.
    /// </summary>
    /// <value>The original order.</value>
    [EntityElement("AD_PEDORIGINAL")]
    public int OriginalOrder
    {
        get => _originalOrder;
        set
        {
            _originalOrder = value;
            _originalOrderSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize original order.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOriginalOrder() => _originalOrderSet;

    #endregion
}
