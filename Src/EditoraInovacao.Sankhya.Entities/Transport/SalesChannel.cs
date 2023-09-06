// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 2016-12-26
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="SalesChannel.cs" company="Guilherme Branco Stracini ME">
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
/// The product store (Marketplace -&gt; Sales Channels - Inovação) class
/// </summary>
/// <seealso cref="IEntity" />
[Entity("PRODUTOLOJA")]
public class SalesChannel : IEntity, IEquatable<SalesChannel>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(SalesChannel other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _code == other._code
                && _codeSet == other._codeSet
                && _codeStore == other._codeStore
                && _codeStoreSet == other._codeStoreSet
                && _codeCategory == other._codeCategory
                && _codeCategorySet == other._codeCategorySet
                && _codeUser == other._codeUser
                && _codeUserSet == other._codeUserSet
                && _stockPercent == other._stockPercent
                && _stockPercentSet == other._stockPercentSet
                && _isActive == other._isActive
                && _isActiveSet == other._isActiveSet
                && _salePrice == other._salePrice
                && _salePriceSet == other._salePriceSet
                && _listPrice == other._listPrice
                && _listPriceSet == other._listPriceSet
                && _dateChanged.Equals(other._dateChanged)
                && _dateChangedSet == other._dateChangedSet
                && string.Equals(
                    _description,
                    other._description,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _descriptionSet == other._descriptionSet
                && Equals(_store, other._store)
                && _storeSet == other._storeSet
                && Equals(_category, other._category)
                && _categorySet == other._categorySet
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

        return ReferenceEquals(this, obj) || obj is SalesChannel other && Equals(other);
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
            var hashCode = _code;
            hashCode = (hashCode * 397) ^ _codeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeStore;
            hashCode = (hashCode * 397) ^ _codeStoreSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeCategory;
            hashCode = (hashCode * 397) ^ _codeCategorySet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeUser;
            hashCode = (hashCode * 397) ^ _codeUserSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _stockPercent.GetHashCode();
            hashCode = (hashCode * 397) ^ _stockPercentSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _isActive.GetHashCode();
            hashCode = (hashCode * 397) ^ _isActiveSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _salePrice.GetHashCode();
            hashCode = (hashCode * 397) ^ _salePriceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _listPrice.GetHashCode();
            hashCode = (hashCode * 397) ^ _listPriceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateChanged.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateChangedSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _description != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_description)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _descriptionSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_store != null ? _store.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _storeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_category != null ? _category.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _categorySet.GetHashCode();
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
    public static bool operator ==(SalesChannel left, SalesChannel right) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(SalesChannel left, SalesChannel right) => !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The code
    /// </summary>
    private int _code;

    /// <summary>
    /// The code set
    /// </summary>
    private bool _codeSet;

    /// <summary>
    /// The code store
    /// </summary>
    private int _codeStore;

    /// <summary>
    /// The code store set
    /// </summary>
    private bool _codeStoreSet;

    /// <summary>
    /// The code category
    /// </summary>
    private int _codeCategory;

    /// <summary>
    /// The code category set
    /// </summary>
    private bool _codeCategorySet;

    /// <summary>
    /// The code user
    /// </summary>
    private int _codeUser;

    /// <summary>
    /// The code user set
    /// </summary>
    private bool _codeUserSet;

    /// <summary>
    /// The stock percent
    /// </summary>
    private decimal _stockPercent;

    /// <summary>
    /// The stock percent set
    /// </summary>
    private bool _stockPercentSet;

    /// <summary>
    /// The is active
    /// </summary>
    private bool _isActive;

    /// <summary>
    /// The is active set
    /// </summary>
    private bool _isActiveSet;

    /// <summary>
    /// The sale price
    /// </summary>
    private decimal _salePrice;

    /// <summary>
    /// The sale price set
    /// </summary>
    private bool _salePriceSet;

    /// <summary>
    /// The list price
    /// </summary>
    private decimal _listPrice;

    /// <summary>
    /// The list price set
    /// </summary>
    private bool _listPriceSet;

    /// <summary>
    /// The date changed
    /// </summary>
    private DateTime _dateChanged;

    /// <summary>
    /// The date changed set
    /// </summary>
    private bool _dateChangedSet;

    /// <summary>
    /// The description
    /// </summary>
    private string _description;

    /// <summary>
    /// The description set
    /// </summary>
    private bool _descriptionSet;

    /// <summary>
    /// The store
    /// </summary>
    private Store _store;

    /// <summary>
    /// The store set
    /// </summary>
    private bool _storeSet;

    /// <summary>
    /// The category
    /// </summary>
    private Category _category;

    /// <summary>
    /// The category set
    /// </summary>
    private bool _categorySet;

    /// <summary>
    /// The user
    /// </summary>
    private User _user;

    /// <summary>
    /// The user set
    /// </summary>
    private bool _userSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    [EntityKey]
    [EntityElement("CODPROD")]
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
    /// Gets or sets the code store.
    /// </summary>
    /// <value>The code store.</value>
    [EntityKey]
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
    /// Gets or sets the code category.
    /// </summary>
    /// <value>The code category.</value>
    [EntityElement("CODCAT")]
    public int CodeCategory
    {
        get => _codeCategory;
        set
        {
            _codeCategory = value;
            _codeCategorySet = true;
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
    /// Gets or sets the stock percent.
    /// </summary>
    /// <value>The stock percent.</value>
    [EntityElement("PESTTLOJA")]
    public decimal StockPercent
    {
        get => _stockPercent;
        set
        {
            _stockPercent = value;
            _stockPercentSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is active.
    /// </summary>
    /// <value>The is active.</value>
    [EntityIgnore]
    public bool IsActive
    {
        get => _isActive;
        set
        {
            _isActive = value;
            _isActiveSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is active internal.
    /// </summary>
    /// <value>The is active internal.</value>
    [EntityElement("ATIVO")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IsActiveInternal
    {
        get => _isActive.ToString(@"S", @"N");
        set
        {
            _isActive = value.ToBoolean();
            _isActiveSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sale price.
    /// </summary>
    /// <value>The sale price.</value>
    [EntityElement("VLRVENDA")]
    public decimal SalePrice
    {
        get => _salePrice;
        set
        {
            _salePrice = value;
            _salePriceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the list price.
    /// </summary>
    /// <value>The list price.</value>
    [EntityElement("VLRVENDADE")]
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
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    [EntityElement("DESCRICAO")]
    public string Description
    {
        get => _description;
        set
        {
            _description = value;
            _descriptionSet = true;
        }
    }

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
    /// Gets or sets the category.
    /// </summary>
    /// <value>The category.</value>
    [EntityReference]
    public Category Category
    {
        get => _category;
        set
        {
            _category = value;
            _categorySet = true;
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
    /// Should the serialize code store.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeStore() => _codeStoreSet;

    /// <summary>
    /// Should the serialize code category.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeCategory() => _codeCategorySet;

    /// <summary>
    /// Should the serialize code user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// Should the serialize stock percent.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStockPercent() => _stockPercentSet;

    /// <summary>
    /// Should the serialize is active.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsActive() => _isActiveSet;

    /// <summary>
    /// Should the serialize sale price.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSalePrice() => _salePriceSet;

    /// <summary>
    /// Should the serialize list price.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeListPrice() => _listPriceSet;

    /// <summary>
    /// Should the serialize date changed.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateChanged() => _dateChangedSet;

    /// <summary>
    /// The should serialize description serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDescription() => _descriptionSet;

    /// <summary>
    /// Should the serialize store.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStore() => _storeSet;

    /// <summary>
    /// Should the serialize category.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCategory() => _categorySet;

    /// <summary>
    /// Should the serialize user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUser() => _userSet;

    #endregion
}
