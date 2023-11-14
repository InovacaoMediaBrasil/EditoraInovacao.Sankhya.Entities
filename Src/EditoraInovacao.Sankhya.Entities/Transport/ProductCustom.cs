//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// A produto dto.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("Produto")]
public class ProductCustom : Product, IEquatable<ProductCustom>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    [SuppressMessage("ReSharper", "CyclomaticComplexity")]
    public bool Equals(ProductCustom other)
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
            && string.Equals(_name, other._name, StringComparison.InvariantCultureIgnoreCase)
            && _nameSet == other._nameSet
            && string.Equals(
                _complement,
                other._complement,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _complementSet == other._complementSet
            && string.Equals(
                _description,
                other._description,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _descriptionSet == other._descriptionSet
            && _isNegativeStockAllowed == other._isNegativeStockAllowed
            && _isNegativeStockAllowedSet == other._isNegativeStockAllowedSet
            && _usesGrid == other._usesGrid
            && _usesGridSet == other._usesGridSet
            && _listPrice == other._listPrice
            && _listPriceSet == other._listPriceSet
            && _codeFather == other._codeFather
            && _codeFatherSet == other._codeFatherSet
            && _codeReplacement == other._codeReplacement
            && _codeReplacementSet == other._codeReplacementSet
            && Equals(_productFather, other._productFather)
            && _productFatherSet == other._productFatherSet
            && Equals(_productReplacement, other._productReplacement)
            && _productReplacementSet == other._productReplacementSet;
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

        return Equals((ProductCustom)obj);
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once MethodTooLong
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = base.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _name != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_name) : 0
                );
            hashCode = (hashCode * 397) ^ _nameSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _complement != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_complement)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _complementSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _description != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_description)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _descriptionSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _isNegativeStockAllowed.GetHashCode();
            hashCode = (hashCode * 397) ^ _isNegativeStockAllowedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _usesGrid.GetHashCode();
            hashCode = (hashCode * 397) ^ _usesGridSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _listPrice.GetHashCode();
            hashCode = (hashCode * 397) ^ _listPriceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeFather;
            hashCode = (hashCode * 397) ^ _codeFatherSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeReplacement;
            hashCode = (hashCode * 397) ^ _codeReplacementSet.GetHashCode();
            hashCode =
                (hashCode * 397) ^ (_productFather != null ? _productFather.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _productFatherSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_productReplacement != null ? _productReplacement.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _productReplacementSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(ProductCustom left, ProductCustom right) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(ProductCustom left, ProductCustom right) => !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The name
    /// </summary>
    private string _name;

    /// <summary>
    /// The name set
    /// </summary>
    private bool _nameSet;

    /// <summary>
    /// The complement
    /// </summary>
    private string _complement;

    /// <summary>
    /// The complement set
    /// </summary>
    private bool _complementSet;

    /// <summary>
    /// The description
    /// </summary>
    private string _description;

    /// <summary>
    /// The description set
    /// </summary>
    private bool _descriptionSet;

    /// <summary>
    /// The is negative stock allowed
    /// </summary>
    private bool _isNegativeStockAllowed;

    /// <summary>
    /// The is negative stock allowed set
    /// </summary>
    private bool _isNegativeStockAllowedSet;

    /// <summary>
    /// The uses grid
    /// </summary>
    private bool _usesGrid;

    /// <summary>
    /// The uses grid set
    /// </summary>
    private bool _usesGridSet;

    /// <summary>
    /// The list price
    /// </summary>
    private decimal _listPrice;

    /// <summary>
    /// The list price set
    /// </summary>
    private bool _listPriceSet;

    /// <summary>
    /// The code father
    /// </summary>
    private int _codeFather;

    /// <summary>
    /// The code father set
    /// </summary>
    private bool _codeFatherSet;

    /// <summary>
    /// The code replacement
    /// </summary>
    private int _codeReplacement;

    /// <summary>
    /// The code replacement set
    /// </summary>
    private bool _codeReplacementSet;

    /// <summary>
    /// The product father
    /// </summary>
    private ProductCustom _productFather;

    /// <summary>
    /// The product father set
    /// </summary>
    private bool _productFatherSet;

    /// <summary>
    /// The product replacement
    /// </summary>
    private ProductCustom _productReplacement;

    /// <summary>
    /// The product replacement set
    /// </summary>
    private bool _productReplacementSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [EntityElement("DESCRPROD")]
    [Localizable(false)]
    public new string Name
    {
        get => _name;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _name = value
                    .RemoveExcessSpaces()
                    .Trim()
                    .Split(' ')
                    .UcWords(ProductValidation.WordsUpperCase, ProductValidation.WordsLowerCase);
            }

            _nameSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the complement.
    /// </summary>
    /// <value>The complement.</value>
    [EntityElement("COMPLDESC")]
    [Localizable(false)]
    public new string Complement
    {
        get => _complement;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _complement = value
                    .RemoveExcessSpaces()
                    .Trim()
                    .Split(' ')
                    .UcWords(ProductValidation.WordsUpperCase, ProductValidation.WordsLowerCase);
            }

            _complementSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    [EntityElement("CARACTERISTICAS")]
    [Localizable(false)]
    public new string Description
    {
        get => _description;
        set
        {
            _description =
                value == null
                    ? null
                    : ProductValidation
                        .InvalidDescriptionPattern
                        .Replace(value.Replace(@"${nl}", @"\r\n"), "");
            _descriptionSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is negative stock allowed.
    /// </summary>
    /// <value>The is negative stock allowed.</value>
    [EntityElement("AD_PESTNEG")]
    public bool IsNegativeStockAllowed
    {
        get => _isNegativeStockAllowed;
        set
        {
            _isNegativeStockAllowed = value;
            _isNegativeStockAllowedSet = value;
        }
    }

    /// <summary>
    /// Gets or sets the uses grid.
    /// </summary>
    /// <value>The uses grid.</value>
    [EntityElement("AD_USAGRADE")]
    public bool UsesGrid
    {
        get => _usesGrid;
        set
        {
            _usesGrid = value;
            _usesGridSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the list price.
    /// </summary>
    /// <value>The list price.</value>
    [EntityElement("AD_VLRDE")]
    public decimal ListPrice
    {
        get => _listPrice;
        set
        {
            _listPrice = value;
            _listPriceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code father.
    /// </summary>
    /// <value>The code father.</value>
    [EntityElement("AD_CODPAI")]
    public int CodeFather
    {
        get => _codeFather;
        set
        {
            _codeFather = value;
            _codeFatherSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code replacement.
    /// </summary>
    /// <value>
    /// The code replacement.
    /// </value>
    [EntityElement("AD_CODPRODSUBSTITUTO")]
    public int CodeReplacement
    {
        get => _codeReplacement;
        set
        {
            _codeReplacement = value;
            _codeReplacementSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product father.
    /// </summary>
    /// <value>The product father.</value>
    [EntityReference("Produto_AD001")]
    public new ProductCustom ProductFather
    {
        get => _productFather;
        set
        {
            _productFather = value;
            _productFatherSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product replacement.
    /// </summary>
    /// <value>
    /// The product replacement.
    /// </value>
    [EntityReference("Produto_AD002")]
    public new ProductCustom ProductReplacement
    {
        get => _productReplacement;
        set
        {
            _productReplacement = value;
            _productReplacementSet = true;
        }
    }

    /// <summary>
    /// The components
    /// </summary>
    public new readonly List<ProductCustom> Components = new();

    /// <summary>
    /// The suggestions
    /// </summary>
    public new readonly List<ProductSuggestedSaleCustom> Suggestions = new();

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the name of the serialize.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool ShouldSerializeName() => _nameSet;

    /// <summary>
    /// Should the serialize complement.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool ShouldSerializeComplement() => _complementSet;

    /// <summary>
    /// Should the serialize description.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool ShouldSerializeDescription() => _descriptionSet;

    /// <summary>
    /// Should the serialize is negative stock allowed.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsNegativeStockAllowed() => _isNegativeStockAllowedSet;

    /// <summary>
    /// Should the serialize uses grid.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUsesGrid() => _usesGridSet;

    /// <summary>
    /// Should the serialize code father.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeFather() => _codeFatherSet;

    /// <summary>
    /// The should serialize code replacement serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeReplacement() => _codeReplacementSet;

    /// <summary>
    /// Should the serialize product father.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool ShouldSerializeProductFather() => _productFatherSet;

    /// <summary>
    /// The should serialize product replacement serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool ShouldSerializeProductReplacement() => _productReplacementSet;

    #endregion
}
