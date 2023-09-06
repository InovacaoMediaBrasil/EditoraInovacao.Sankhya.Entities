using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class InvoiceHeaderExclusion. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="IEquatable{InvoiceHeaderExclusion}" />
[Entity("CabecalhoNotaExcluida")]
public class InvoiceHeaderExclusionCustom
    : InvoiceHeaderExclusion,
        IEquatable<InvoiceHeaderExclusionCustom>
{
    #region Equality Members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once CyclomaticComplexity
    // ReSharper disable once FunctionComplexityOverflow
    public bool Equals(InvoiceHeaderExclusionCustom other)
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
            && _codeResend == other._codeResend
            && _codeResendSet == other._codeResendSet
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

        return Equals((InvoiceHeaderExclusionCustom)obj);
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
    // ReSharper disable once MethodTooLong
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = base.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeResend;
            hashCode = (hashCode * 397) ^ _codeResendSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _originalOrder;
            hashCode = (hashCode * 397) ^ _originalOrderSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Returns a value that indicates whether the values of two <see cref="InvoiceHeaderExclusionCustom" /> objects are equal.
    /// </summary>
    /// <param name="left">The first value to compare.</param>
    /// <param name="right">The second value to compare.</param>
    /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
    public static bool operator ==(
        InvoiceHeaderExclusionCustom left,
        InvoiceHeaderExclusionCustom right
    ) => Equals(left, right);

    /// <summary>
    /// Returns a value that indicates whether two <see cref="InvoiceHeaderExclusionCustom" /> objects have different values.
    /// </summary>
    /// <param name="left">The first value to compare.</param>
    /// <param name="right">The second value to compare.</param>
    /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
    public static bool operator !=(
        InvoiceHeaderExclusionCustom left,
        InvoiceHeaderExclusionCustom right
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

    /// <summary>
    /// The code resend
    /// </summary>
    private int _codeResend;

    /// <summary>
    /// The code resend set
    /// </summary>
    private bool _codeResendSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the original order.
    /// </summary>
    /// <value>
    /// The original order.
    /// </value>
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

    /// <summary>
    /// Gets or sets the code resend.
    /// </summary>
    /// <value>
    /// The code resend.
    /// </value>
    [EntityElement("AD_CODREENVIO")]
    public int CodeResend
    {
        get => _codeResend;
        set
        {
            _codeResend = value;
            _codeResendSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// The should serialize original order serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOriginalOrder() => _originalOrderSet;

    /// <summary>
    /// The should serialize code resend serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeResend() => _codeResendSet;

    #endregion
}
