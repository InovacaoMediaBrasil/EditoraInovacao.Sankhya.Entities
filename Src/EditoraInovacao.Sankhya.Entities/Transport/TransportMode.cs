// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 12-26-2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="TransportMode.cs" company="Guilherme Branco Stracini ME">
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
/// Class TransportMode. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="IEquatable{T}" />
[Entity("MODTRANSPORTE")]
public class TransportMode : IEntity, IEquatable<TransportMode>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    public bool Equals(TransportMode other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _code == other._code
                && _codeSet == other._codeSet
                && _codePartner == other._codePartner
                && _codePartnerSet == other._codePartnerSet
                && string.Equals(
                    _description,
                    other._description,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _descriptionSet == other._descriptionSet
                && _active == other._active
                && _activeSet == other._activeSet
                && Equals(_partner, other._partner)
                && _partnerSet == other._partnerSet
                && _usesInWmw == other._usesInWmw
                && _usesInWmwSet == other._usesInWmwSet
                && string.Equals(_seal, other._seal, StringComparison.InvariantCultureIgnoreCase)
                && _sealSet == other._sealSet
                && _validatesZipCode == other._validatesZipCode
                && _validatesZipCodeSet == other._validatesZipCodeSet;
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

        return ReferenceEquals(this, obj) || obj is TransportMode mode && Equals(mode);
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
            hashCode = (hashCode * 397) ^ _codePartner;
            hashCode = (hashCode * 397) ^ _codePartnerSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _description != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_description)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _descriptionSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _active.GetHashCode();
            hashCode = (hashCode * 397) ^ _activeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_partner != null ? _partner.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _partnerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _usesInWmw.GetHashCode();
            hashCode = (hashCode * 397) ^ _usesInWmwSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _seal != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_seal) : 0
                );
            hashCode = (hashCode * 397) ^ _sealSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _validatesZipCode.GetHashCode();
            hashCode = (hashCode * 397) ^ _validatesZipCodeSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(TransportMode left, TransportMode right) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(TransportMode left, TransportMode right) => !Equals(left, right);

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
    /// The code partner
    /// </summary>
    private int _codePartner;

    /// <summary>
    /// The code partner set
    /// </summary>
    private bool _codePartnerSet;

    /// <summary>
    /// The description
    /// </summary>
    private string _description;

    /// <summary>
    /// The description set
    /// </summary>
    private bool _descriptionSet;

    /// <summary>
    /// The active
    /// </summary>
    private bool _active;

    /// <summary>
    /// The active set
    /// </summary>
    private bool _activeSet;

    /// <summary>
    /// The partner
    /// </summary>
    private Partner _partner;

    /// <summary>
    /// The partner set
    /// </summary>
    private bool _partnerSet;

    /// <summary>
    /// The uses in WMW
    /// </summary>
    private bool _usesInWmw;

    /// <summary>
    /// The uses in WMW set
    /// </summary>
    private bool _usesInWmwSet;

    /// <summary>
    /// The seal
    /// </summary>
    private string _seal;

    /// <summary>
    /// The seal set
    /// </summary>
    private bool _sealSet;

    /// <summary>
    /// The validates zip code
    /// </summary>
    private bool _validatesZipCode;

    /// <summary>
    /// The validates zip code set
    /// </summary>
    private bool _validatesZipCodeSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    [EntityElement("IDMOD")]
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
    /// Gets or sets the code partner.
    /// </summary>
    /// <value>The code partner.</value>
    [EntityElement("CODPARC")]
    public int CodePartner
    {
        get => _codePartner;
        set
        {
            _codePartner = value;
            _codePartnerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    [EntityElement("DECRMODTRANS")]
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
    /// Gets or sets the active.
    /// </summary>
    /// <value>The active.</value>
    [EntityIgnore]
    public bool Active
    {
        get => _active;
        set
        {
            _active = value;
            _activeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the active internal.
    /// </summary>
    /// <value>The active internal.</value>
    [EntityElement("ATIVO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ActiveInternal
    {
        get => _active.ToString(@"S", @"N");
        set
        {
            _active = value.ToBoolean();
            _activeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the uses in WMW.
    /// </summary>
    /// <value>The uses in WMW.</value>
    [EntityIgnore]
    public bool UsesInWmw
    {
        get => _usesInWmw;
        set
        {
            _usesInWmw = value;
            _usesInWmwSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the uses in WMW internal.
    /// </summary>
    /// <value>The uses in WMW internal.</value>
    [EntityElement("USAWMW")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string UsesInWmwInternal
    {
        get => _usesInWmw.ToString(@"S", @"N");
        set
        {
            _usesInWmw = value.ToBoolean();
            _usesInWmwSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the seal.
    /// </summary>
    /// <value>The seal.</value>
    [EntityElement("CHANCELA")]
    public string Seal
    {
        get => _seal;
        set
        {
            _seal = value;
            _sealSet = true;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether [validates zip code].
    /// </summary>
    /// <value><c>true</c> if [validates zip code]; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool ValidatesZipCode
    {
        get => _validatesZipCode;
        set
        {
            _validatesZipCode = value;
            _validatesZipCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the validates zip code internal.
    /// </summary>
    /// <value>The validates zip code internal.</value>
    [EntityElement("VALIDACEP")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ValidatesZipCodeInternal
    {
        get => _validatesZipCode.ToString(@"S", @"N");
        set
        {
            _validatesZipCode = value.ToBoolean();
            _validatesZipCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the partner.
    /// </summary>
    /// <value>The partner.</value>
    [EntityReference]
    public Partner Partner
    {
        get => _partner;
        set
        {
            _partner = value;
            _partnerSet = true;
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
    /// Should the serialize code partner.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePartner() => _codePartnerSet;

    /// <summary>
    /// Should the serialize description.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDescription() => _descriptionSet;

    /// <summary>
    /// Should the serialize active.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeActive() => _activeSet;

    /// <summary>
    /// Should the serialize partner.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePartner() => _partnerSet;

    /// <summary>
    /// Should the serialize uses in WMW.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUsesInWmw() => _usesInWmwSet;

    /// <summary>
    /// The should serialize seal serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSeal() => _sealSet;

    /// <summary>
    /// The should serialize validates zip code serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeValidatesZipCode() => _validatesZipCodeSet;

    #endregion
}
