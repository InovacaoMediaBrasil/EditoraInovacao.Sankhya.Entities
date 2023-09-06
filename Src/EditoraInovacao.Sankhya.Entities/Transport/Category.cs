// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 11-11-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="Category.cs" company="Guilherme Branco Stracini ME">
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
/// Class Category. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
/// <summary>
/// Class Category.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="IEquatable{Category}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="IEquatable{Category}" />
[Entity("CATEGORIASVTEX")]
public class Category : IEntity, IEquatable<Category>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(Category other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return _code == other._code
            && _codeSet == other._codeSet
            && _codeStore == other._codeStore
            && _codeStoreSet == other._codeStoreSet
            && _codeFather == other._codeFather
            && _codeFatherSet == other._codeFatherSet
            && _codeUser == other._codeUser
            && _codeUserSet == other._codeUserSet
            && string.Equals(_name, other._name, StringComparison.InvariantCultureIgnoreCase)
            && _nameSet == other._nameSet
            && string.Equals(_title, other._title, StringComparison.InvariantCultureIgnoreCase)
            && _titleSet == other._titleSet
            && string.Equals(
                _description,
                other._description,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _descriptionSet == other._descriptionSet
            && string.Equals(
                _keywords,
                other._keywords,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _keywordsSet == other._keywordsSet
            && _isActive == other._isActive
            && _isActiveSet == other._isActiveSet
            && _isInPlatform == other._isInPlatform
            && _isInPlatformSet == other._isInPlatformSet
            && _dateChanged.Equals(other._dateChanged)
            && _dateChangedSet == other._dateChangedSet
            && Equals(_store, other._store)
            && _storeSet == other._storeSet
            && Equals(_father, other._father)
            && _fatherSet == other._fatherSet
            && Equals(_user, other._user)
            && _userSet == other._userSet;
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

        return obj.GetType() == GetType() && Equals((Category)obj);
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
            hashCode = (hashCode * 397) ^ _codeStore;
            hashCode = (hashCode * 397) ^ _codeStoreSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeFather;
            hashCode = (hashCode * 397) ^ _codeFatherSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeUser;
            hashCode = (hashCode * 397) ^ _codeUserSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _name != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_name) : 0
                );
            hashCode = (hashCode * 397) ^ _nameSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _title != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_title)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _titleSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _description != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_description)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _descriptionSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _keywords != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_keywords)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _keywordsSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _isActive.GetHashCode();
            hashCode = (hashCode * 397) ^ _isActiveSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _isInPlatform.GetHashCode();
            hashCode = (hashCode * 397) ^ _isInPlatformSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateChanged.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateChangedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_store != null ? _store.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _storeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_father != null ? _father.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _fatherSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_user != null ? _user.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _userSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(Category left, Category right) => Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(Category left, Category right) => !Equals(left, right);

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
    /// The code father
    /// </summary>
    /// <summary>
    /// The code father
    /// </summary>
    private int _codeFather;

    /// <summary>
    /// The code father set
    /// </summary>
    /// <summary>
    /// The code father set
    /// </summary>
    private bool _codeFatherSet;

    /// <summary>
    /// The code user
    /// </summary>
    /// <summary>
    /// The code user
    /// </summary>
    private int _codeUser;

    /// <summary>
    /// The code user set
    /// </summary>
    /// <summary>
    /// The code user set
    /// </summary>
    private bool _codeUserSet;

    /// <summary>
    /// The name
    /// </summary>
    /// <summary>
    /// The name
    /// </summary>
    private string _name;

    /// <summary>
    /// The name set
    /// </summary>
    /// <summary>
    /// The name set
    /// </summary>
    private bool _nameSet;

    /// <summary>
    /// The title
    /// </summary>
    /// <summary>
    /// The title
    /// </summary>
    private string _title;

    /// <summary>
    /// The title set
    /// </summary>
    /// <summary>
    /// The title set
    /// </summary>
    private bool _titleSet;

    /// <summary>
    /// The description
    /// </summary>
    /// <summary>
    /// The description
    /// </summary>
    private string _description;

    /// <summary>
    /// The description set
    /// </summary>
    /// <summary>
    /// The description set
    /// </summary>
    private bool _descriptionSet;

    /// <summary>
    /// The keywords
    /// </summary>
    /// <summary>
    /// The keywords
    /// </summary>
    private string _keywords;

    /// <summary>
    /// The keywords set
    /// </summary>
    /// <summary>
    /// The keywords set
    /// </summary>
    private bool _keywordsSet;

    /// <summary>
    /// The is active
    /// </summary>
    /// <summary>
    /// The is active
    /// </summary>
    private bool _isActive;

    /// <summary>
    /// The is active set
    /// </summary>
    /// <summary>
    /// The is active set
    /// </summary>
    private bool _isActiveSet;

    /// <summary>
    /// The is in platform
    /// </summary>
    /// <summary>
    /// The is in platform
    /// </summary>
    private bool _isInPlatform;

    /// <summary>
    /// The is in platform set
    /// </summary>
    /// <summary>
    /// The is in platform set
    /// </summary>
    private bool _isInPlatformSet;

    /// <summary>
    /// The date changed
    /// </summary>
    /// <summary>
    /// The date changed
    /// </summary>
    private DateTime _dateChanged;

    /// <summary>
    /// The date changed set
    /// </summary>
    /// <summary>
    /// The date changed set
    /// </summary>
    private bool _dateChangedSet;

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
    /// The father
    /// </summary>
    /// <summary>
    /// The father
    /// </summary>
    private Category _father;

    /// <summary>
    /// The father set
    /// </summary>
    /// <summary>
    /// The father set
    /// </summary>
    private bool _fatherSet;

    /// <summary>
    /// The user
    /// </summary>
    /// <summary>
    /// The user
    /// </summary>
    private User _user;

    /// <summary>
    /// The user set
    /// </summary>
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
    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    [EntityKey]
    [EntityElement("CODCAT")]
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
    /// Gets or sets the code father.
    /// </summary>
    /// <value>The code father.</value>
    /// <summary>
    /// Gets or sets the code father.
    /// </summary>
    /// <value>The code father.</value>
    [EntityElement("CODCATPAI")]
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
    /// Gets or sets the code user.
    /// </summary>
    /// <value>The code user.</value>
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
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [EntityElement("NOME")]
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
            _nameSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>The title.</value>
    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>The title.</value>
    [EntityElement("NOMEHTML")]
    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            _titleSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
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
    /// Gets or sets the keywords.
    /// </summary>
    /// <value>The keywords.</value>
    /// <summary>
    /// Gets or sets the keywords.
    /// </summary>
    /// <value>The keywords.</value>
    [EntityElement("PALAVRASCHAVES")]
    public string Keywords
    {
        get => _keywords;
        set
        {
            _keywords = value;
            _keywordsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is active.
    /// </summary>
    /// <value>The is active.</value>
    /// <summary>
    /// Gets or sets a value indicating whether this instance is active.
    /// </summary>
    /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
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
    /// <summary>
    /// Gets or sets the is active internal.
    /// </summary>
    /// <value>The is active internal.</value>
    [EntityElement("ATIVO")]
    [Browsable(true)]
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
    /// Gets or sets the is in platform.
    /// </summary>
    /// <value>The is in platform.</value>
    /// <summary>
    /// Gets or sets a value indicating whether this instance is in platform.
    /// </summary>
    /// <value><c>true</c> if this instance is in platform; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool IsInPlatform
    {
        get => _isInPlatform;
        set
        {
            _isInPlatform = value;
            _isInPlatformSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is in platform internal.
    /// </summary>
    /// <value>The is in platform internal.</value>
    /// <summary>
    /// Gets or sets the is in platform internal.
    /// </summary>
    /// <value>The is in platform internal.</value>
    [EntityElement("EXISTEVTEX")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IsInPlatformInternal
    {
        get => _isInPlatform.ToString(@"S", @"N");
        set
        {
            _isInPlatform = value.ToBoolean();
            _isInPlatformSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date changed.
    /// </summary>
    /// <value>The date changed.</value>
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
    /// Gets or sets the father.
    /// </summary>
    /// <value>The father.</value>
    /// <summary>
    /// Gets or sets the father.
    /// </summary>
    /// <value>The father.</value>
    [EntityReference("CATEGORIASVTEX_AD001")]
    public Category Father
    {
        get => _father;
        set
        {
            _father = value;
            _fatherSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    /// <value>The user.</value>
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
    /// Check if should serialize code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCode() => _codeSet;

    /// <summary>
    /// Check if should serialize code store.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeStore() => _codeStoreSet;

    /// <summary>
    /// Check if should serialize code father.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeFather() => _codeFatherSet;

    /// <summary>
    /// Check if should serialize code user.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// Check if should name of the serialize.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeName() => _nameSet;

    /// <summary>
    /// Check if should serialize title.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTitle() => _titleSet;

    /// <summary>
    /// Check if should serialize description.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDescription() => _descriptionSet;

    /// <summary>
    /// Check if should serialize keywords.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeKeywords() => _keywordsSet;

    /// <summary>
    /// Check if should serialize is active.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsActive() => _isActiveSet;

    /// <summary>
    /// Check if should serialize is in platform.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsInPlatform() => _isInPlatformSet;

    /// <summary>
    /// Check if should serialize date changed.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateChanged() => _dateChangedSet;

    /// <summary>
    /// Check if should serialize store.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStore() => _storeSet;

    /// <summary>
    /// Check if should serialize father.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFather() => _fatherSet;

    /// <summary>
    /// Check if should serialize user.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUser() => _userSet;

    #endregion
}
