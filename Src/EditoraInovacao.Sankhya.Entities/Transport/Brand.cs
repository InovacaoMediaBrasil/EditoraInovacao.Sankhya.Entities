// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 11-11-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="Brand.cs" company="Guilherme Branco Stracini ME">
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
/// Class Brand. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
[Entity("MARCASVTEX")]
public class Brand : IEntity, IEquatable<Brand>
{
    #region Equality Members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(Brand other)
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

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj.GetType() == GetType() && Equals((Brand)obj);
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
    public static bool operator ==(Brand left, Brand right) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(Brand left, Brand right) => !Equals(left, right);

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
    /// The code user
    /// </summary>
    private int _codeUser;

    /// <summary>
    /// The code user set
    /// </summary>
    private bool _codeUserSet;

    /// <summary>
    /// The name
    /// </summary>
    private string _name;

    /// <summary>
    /// The name set
    /// </summary>
    private bool _nameSet;

    /// <summary>
    /// The title
    /// </summary>
    private string _title;

    /// <summary>
    /// The title set
    /// </summary>
    private bool _titleSet;

    /// <summary>
    /// The description
    /// </summary>
    private string _description;

    /// <summary>
    /// The description set
    /// </summary>
    private bool _descriptionSet;

    /// <summary>
    /// The keywords
    /// </summary>
    private string _keywords;

    /// <summary>
    /// The keywords set
    /// </summary>
    private bool _keywordsSet;

    /// <summary>
    /// The is active
    /// </summary>
    private bool _isActive;

    /// <summary>
    /// The is active set
    /// </summary>
    private bool _isActiveSet;

    /// <summary>
    /// The is in platform
    /// </summary>
    private bool _isInPlatform;

    /// <summary>
    /// The is in platform set
    /// </summary>
    private bool _isInPlatformSet;

    /// <summary>
    /// The date changed
    /// </summary>
    private DateTime _dateChanged;

    /// <summary>
    /// The date changed set
    /// </summary>
    private bool _dateChangedSet;

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
    [EntityElement("CODMARCA")]
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
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCode() => _codeSet;

    /// <summary>
    /// Should the serialize code user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// Should the name of the serialize.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeName() => _nameSet;

    /// <summary>
    /// Should the serialize title.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTitle() => _titleSet;

    /// <summary>
    /// Should the serialize description.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDescription() => _descriptionSet;

    /// <summary>
    /// Should the serialize keywords.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeKeywords() => _keywordsSet;

    /// <summary>
    /// Should the serialize is active.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsActive() => _isActiveSet;

    /// <summary>
    /// Should the serialize is in platform.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsInPlatform() => _isInPlatformSet;

    /// <summary>
    /// Should the serialize date changed.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateChanged() => _dateChangedSet;

    /// <summary>
    /// Should the serialize user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUser() => _userSet;

    #endregion
}
