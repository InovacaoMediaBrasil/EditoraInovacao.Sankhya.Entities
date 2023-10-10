// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 18/04/2020
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="PartnerCustom.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Serialization;
using CrispyWaffle.Extensions;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class PartnerCustom. This class cannot be inherited.
/// Implements the <see cref="Partner" />
/// Implements the <see cref="IEquatable{PartnerCustom}" />
/// </summary>
/// <seealso cref="Partner" />
/// <seealso cref="IEquatable{PartnerCustom}" />
[Serializer]
[Entity("Parceiro")]
public sealed class PartnerCustom : Partner, IEquatable<PartnerCustom>
{
    #region Equality members

    /// <inheritdoc />
    public bool Equals(PartnerCustom other)
    {
        if (other is null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return base.Equals(other)
            && Equals(_howKnow, other._howKnow)
            && _howKnowSet == other._howKnowSet;
    }

    /// <inheritdoc />
    public override bool Equals(object obj) =>
        ReferenceEquals(this, obj) || obj is Partner other && Equals(other);

    /// <inheritdoc />
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = base.GetHashCode();
            hashCode = (hashCode * 397) ^ (_howKnow != null ? _howKnow.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _howKnowSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(PartnerCustom left, PartnerCustom right) => Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(PartnerCustom left, PartnerCustom right) => !Equals(left, right);

    #endregion

    #region Private fields

    /// <summary>
    /// The code how know
    /// </summary>
    private int _codeHowKnow;

    /// <summary>
    /// The code how know set
    /// </summary>
    private bool _codeHowKnowSet;

    /// <summary>
    /// The is craftsman
    /// </summary>
    private bool _isCraftsman;

    /// <summary>
    /// The is craftsman set
    /// </summary>
    private bool _isCraftsmanSet;

    /// <summary>
    /// The is inventory counter
    /// </summary>
    private bool _isInventoryCounter;

    /// <summary>
    /// The is inventory counter set
    /// </summary>
    private bool _isInventoryCounterSet;

    /// <summary>
    /// The exclude from mailing
    /// </summary>
    private bool _excludeFromMailing;

    /// <summary>
    /// The exclude from mailing set
    /// </summary>
    private bool _excludeFromMailingSet;

    /// <summary>
    /// The date indexed
    /// </summary>
    private DateTime _dateIndexed;

    /// <summary>
    /// The date indexed set
    /// </summary>
    private bool _dateIndexedSet;

    /// <summary>
    /// The how know
    /// </summary>
    private HowKnow _howKnow;

    /// <summary>
    /// The how know set
    /// </summary>
    private bool _howKnowSet;

    #endregion

    #region Public properties

    /// <summary>
    /// Gets or sets the code how know.
    /// </summary>
    /// <value>The code how know.</value>
    [EntityElement("AD_ID")]
    public int CodeHowKnow
    {
        get => _codeHowKnow;
        set
        {
            _codeHowKnow = value;
            _codeHowKnowSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is craftsman.
    /// </summary>
    /// <value>The is craftsman.</value>
    [EntityIgnore]
    public bool IsCraftsman
    {
        get => _isCraftsman;
        set
        {
            _isCraftsman = value;
            _isCraftsmanSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is craftsman internal.
    /// </summary>
    /// <value>The is craftsman internal.</value>
    [EntityElement("AD_ARTESAO")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IsCraftsmanInternal
    {
        get => _isCraftsman.ToString(@"S", @"N");
        set
        {
            _isCraftsman = value != null && value.ToBoolean();
            _isCraftsmanSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is inventory counter.
    /// </summary>
    /// <value>The is inventory counter.</value>
    [EntityIgnore]
    public bool IsInventoryCounter
    {
        get => _isInventoryCounter;
        set
        {
            _isInventoryCounter = value;
            _isInventoryCounterSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the is inventory counter internal.
    /// </summary>
    /// <value>The is inventory counter internal.</value>
    [EntityElement("AD_CONTADORESTOQUE")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string IsInventoryCounterInternal
    {
        get => _isInventoryCounter.ToString(@"S", @"N");
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            _isInventoryCounter = value.ToBoolean();
            _isInventoryCounterSet = true;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether [exclude from mailing].
    /// </summary>
    /// <value><c>true</c> if [exclude from mailing]; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool ExcludeFromMailing
    {
        get => _excludeFromMailing;
        set
        {
            _excludeFromMailing = value;
            _excludeFromMailingSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the exclude from mailing internal.
    /// </summary>
    /// <value>The exclude from mailing internal.</value>
    [EntityElement("AD_INCMAILING")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ExcludeFromMailingInternal
    {
        get => _excludeFromMailing.ToString(@"S", @"N");
        set
        {
            _excludeFromMailing = value.ToBoolean();
            _excludeFromMailingSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date indexed.
    /// </summary>
    /// <value>The date indexed.</value>
    [EntityElement("AD_DT_IDX")]
    public DateTime DateIndexed
    {
        get => _dateIndexed;
        set
        {
            _dateIndexed = value;
            _dateIndexedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the how know.
    /// </summary>
    /// <value>The how know.</value>
    [EntityReference]
    public HowKnow HowKnow
    {
        get => _howKnow;
        set
        {
            _howKnow = value;
            _howKnowSet = true;
        }
    }

    #endregion

    #region Serializer helpers

    /// <summary>
    /// Should the serialize code how know.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeHowKnow() => _codeHowKnowSet;

    /// <summary>
    /// Should the serialize is craftsman.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsCraftsman() => _isCraftsmanSet;

    /// <summary>
    /// Should the serialize is inventory counter.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeIsInventoryCounter() => _isInventoryCounterSet;

    /// <summary>
    /// The should serialize exclude from mailing serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeExcludeFromMailing() => _excludeFromMailingSet;

    /// <summary>
    /// The should serialize date indexed serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateIndexed() => _dateIndexedSet;

    /// <summary>
    /// Should the serialize how know.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeHowKnow() => _howKnowSet;

    #endregion
}
