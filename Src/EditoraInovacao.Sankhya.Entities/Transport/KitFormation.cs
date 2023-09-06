// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 03/05/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="KitFormation.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class KitFormation.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="System.IEquatable{KitFormation}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="System.IEquatable{KitFormation}" />
[Entity("FORMACAOKIT")]
public class KitFormation : IEntity, IEquatable<KitFormation>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    public bool Equals(KitFormation other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _code == other._code
                && _codeSet == other._codeSet
                && _codeProduct == other._codeProduct
                && _codeProductSet == other._codeProductSet
                && _codeComponent == other._codeComponent
                && _codeComponentSet == other._codeComponentSet
                && _apportionment == other._apportionment
                && _apportionmentSet == other._apportionmentSet
                && _isValidated == other._isValidated
                && _isValidatedSet == other._isValidatedSet
                && Equals(_component, other._component)
                && _componentSet == other._componentSet;
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

        var a = obj as KitFormation;
        return a != null && Equals(a);
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _code;
            hashCode = (hashCode * 397) ^ _codeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeProduct;
            hashCode = (hashCode * 397) ^ _codeProductSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeComponent;
            hashCode = (hashCode * 397) ^ _codeComponentSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _apportionment.GetHashCode();
            hashCode = (hashCode * 397) ^ _apportionmentSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _isValidated.GetHashCode();
            hashCode = (hashCode * 397) ^ _isValidatedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_component != null ? _component.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _componentSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(KitFormation left, KitFormation right) => Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(KitFormation left, KitFormation right) => !Equals(left, right);

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
    /// The code product
    /// </summary>
    /// <summary>
    /// The code product
    /// </summary>
    private int _codeProduct;

    /// <summary>
    /// The code product set
    /// </summary>
    /// <summary>
    /// The code product set
    /// </summary>
    private bool _codeProductSet;

    /// <summary>
    /// The code component
    /// </summary>
    /// <summary>
    /// The code component
    /// </summary>
    private int _codeComponent;

    /// <summary>
    /// The code component set
    /// </summary>
    /// <summary>
    /// The code component set
    /// </summary>
    private bool _codeComponentSet;

    /// <summary>
    /// The apportionment
    /// </summary>
    /// <summary>
    /// The apportionment
    /// </summary>
    private decimal _apportionment;

    /// <summary>
    /// The apportionment set
    /// </summary>
    /// <summary>
    /// The apportionment set
    /// </summary>
    private bool _apportionmentSet;

    /// <summary>
    /// The is validated
    /// </summary>
    /// <summary>
    /// The is validated
    /// </summary>
    private bool _isValidated;

    /// <summary>
    /// The is validated set
    /// </summary>
    /// <summary>
    /// The is validated set
    /// </summary>
    private bool _isValidatedSet;

    /// <summary>
    /// The component
    /// </summary>
    /// <summary>
    /// The component
    /// </summary>
    private Product _component;

    /// <summary>
    /// The component set
    /// </summary>
    /// <summary>
    /// The component set
    /// </summary>
    private bool _componentSet;

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
    [EntityElement("IDKIT")]
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
    /// Gets or sets the code product.
    /// </summary>
    /// <value>The code product.</value>
    /// <summary>
    /// Gets or sets the code product.
    /// </summary>
    /// <value>The code product.</value>
    [EntityElement("CODPROD")]
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
    /// Gets or sets the code component.
    /// </summary>
    /// <value>The code component.</value>
    /// <summary>
    /// Gets or sets the code component.
    /// </summary>
    /// <value>The code component.</value>
    [EntityElement("PRODKIT")]
    public int CodeComponent
    {
        get => _codeComponent;
        set
        {
            _codeComponent = value;
            _codeComponentSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the apportionment.
    /// </summary>
    /// <value>The apportionment.</value>
    [EntityElement("RATEIO")]
    public decimal Apportionment
    {
        get => _apportionment;
        set
        {
            _apportionment = value;
            _apportionmentSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is validated.
    /// </summary>
    /// <value>The is validated.</value>
    [EntityIgnore]
    public bool IsValidated
    {
        get => _isValidated;
        set
        {
            _isValidated = value;
            _isValidatedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is validated internal.
    /// </summary>
    /// <value>The is validated internal.</value>
    [EntityElement("VALIDADO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IsValidatedInternal
    {
        get => _isValidated.ToString(@"S", @"N");
        set
        {
            _isValidated = value.ToBoolean();
            _isValidatedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the component.
    /// </summary>
    /// <value>The component.</value>
    [EntityReference]
    public Product Component
    {
        get => _component;
        set
        {
            _component = value;
            _componentSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize code.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCode() => _codeSet;

    /// <summary>
    /// Should the serialize code product.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeProduct() => _codeProductSet;

    /// <summary>
    /// Should the serialize code component.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeComponent() => _codeComponentSet;

    /// <summary>
    /// Should the serialize apportionment.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeApportionment() => _apportionmentSet;

    /// <summary>
    /// Should the serialize is validated.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsValidated() => _isValidatedSet;

    /// <summary>
    /// Should the serialize component.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeComponent() => _componentSet;

    #endregion
}
