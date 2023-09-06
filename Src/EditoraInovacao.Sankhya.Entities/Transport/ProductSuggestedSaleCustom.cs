using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using Sankhya.Attributes;
using Sankhya.Enums;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class ProductSuggestedSale. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("VendaCasada")]
public class ProductSuggestedSaleCustom
    : ProductSuggestedSale,
        IEquatable<ProductSuggestedSaleCustom>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    public bool Equals(ProductSuggestedSaleCustom other)
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
            && _suggestionType == other._suggestionType
            && _suggestionTypeSet == other._suggestionTypeSet
            && Equals(_productSuggestion, other._productSuggestion)
            && _productSuggestionSet == other._productSuggestionSet;
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

        return Equals((ProductSuggestedSaleCustom)obj);
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
            hashCode = (hashCode * 397) ^ (int)_suggestionType;
            hashCode = (hashCode * 397) ^ _suggestionTypeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_productSuggestion != null ? _productSuggestion.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _productSuggestionSet.GetHashCode();
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
        ProductSuggestedSaleCustom left,
        ProductSuggestedSaleCustom right
    ) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(
        ProductSuggestedSaleCustom left,
        ProductSuggestedSaleCustom right
    ) => !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The suggestion type
    /// </summary>
    private ProductSuggestionType _suggestionType;

    /// <summary>
    /// The suggestion type set
    /// </summary>
    private bool _suggestionTypeSet;

    /// <summary>
    /// The product suggestion
    /// </summary>
    private ProductCustom _productSuggestion;

    /// <summary>
    /// The product suggestion set
    /// </summary>
    private bool _productSuggestionSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the type of the suggestion.
    /// </summary>
    /// <value>The type of the suggestion.</value>
    [EntityIgnore]
    public ProductSuggestionType SuggestionType
    {
        get => _suggestionType;
        set
        {
            _suggestionType = value;
            _suggestionTypeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the suggestion type internal.
    /// </summary>
    /// <value>The suggestion type internal.</value>
    [EntityElement("AD_TIPOVENDA")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SuggestionTypeInternal
    {
        get => _suggestionType.GetInternalValue();
        set
        {
            _suggestionType = EnumExtensions.GetEnumByInternalValueAttribute<ProductSuggestionType>(
                value
            );
            _suggestionTypeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product suggestion.
    /// </summary>
    /// <value>The product suggestion.</value>
    [EntityReference]
    public new ProductCustom ProductSuggestion
    {
        get => _productSuggestion;
        set
        {
            _productSuggestion = value;
            _productSuggestionSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the type of the serialize suggestion.
    /// </summary>
    /// <returns>Boolean.</returns>
    public bool ShouldSerializeSuggestionType() => _suggestionTypeSet;

    /// <summary>
    /// Should the serialize product suggestion.
    /// </summary>
    /// <returns>Boolean.</returns>
    public new bool ShouldSerializeProductSuggestion() => _productSuggestionSet;

    #endregion
}
