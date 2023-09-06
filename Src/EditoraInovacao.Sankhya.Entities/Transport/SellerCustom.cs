using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using EditoraInovacao.Sankhya.Entities.Enums;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class Seller. This class cannot be inherited.
/// </summary>
/// <seealso cref="IEquatable{T}" />
/// <seealso cref="IEntity" />
[Entity("Vendedor")]
public class SellerCustom : Seller, IEquatable<SellerCustom>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    public bool Equals(SellerCustom other)
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
            && _codeSupervisor == other._codeSupervisor
            && _codeSupervisorSet == other._codeSupervisorSet
            && string.Equals(
                _codeAffiliated,
                other._codeAffiliated,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _codeAffiliatedSet == other._codeAffiliatedSet
            && _mobility == other._mobility
            && _mobilitySet == other._mobilitySet
            && _sector == other._sector
            && _sectorSet == other._sectorSet;
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

        return Equals((SellerCustom)obj);
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
            hashCode = (hashCode * 397) ^ _codeSupervisor;
            hashCode = (hashCode * 397) ^ _codeSupervisorSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _codeAffiliated != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_codeAffiliated)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _codeAffiliatedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _mobility.GetHashCode();
            hashCode = (hashCode * 397) ^ _mobilitySet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_sector;
            hashCode = (hashCode * 397) ^ _sectorSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(SellerCustom left, SellerCustom right) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(SellerCustom left, SellerCustom right) => !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The code supervisor
    /// </summary>
    private int _codeSupervisor;

    /// <summary>
    /// The code supervisor set
    /// </summary>
    private bool _codeSupervisorSet;

    /// <summary>
    /// The code affiliated
    /// </summary>
    private string _codeAffiliated;

    /// <summary>
    /// The code affiliated set
    /// </summary>
    private bool _codeAffiliatedSet;

    /// <summary>
    /// The mobility
    /// </summary>
    private bool _mobility;

    /// <summary>
    /// The mobility set
    /// </summary>
    private bool _mobilitySet;

    /// <summary>
    /// The sector
    /// </summary>
    private SellerSector _sector;

    /// <summary>
    /// The sector set
    /// </summary>
    private bool _sectorSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code supervisor.
    /// </summary>
    /// <value>The code supervisor.</value>
    [EntityElement("AD_CODSUPERVISOR")]
    public int CodeSupervisor
    {
        get => _codeSupervisor;
        set
        {
            _codeSupervisor = value;
            _codeSupervisorSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code affiliated.
    /// </summary>
    /// <value>The code affiliated.</value>
    [EntityElement("AD_CODAFILIADO")]
    public string CodeAffiliated
    {
        get => _codeAffiliated;
        set
        {
            _codeAffiliated = value;
            _codeAffiliatedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the mobility.
    /// </summary>
    /// <value>The mobility.</value>
    [EntityIgnore]
    public bool Mobility
    {
        get => _mobility;
        set
        {
            _mobility = value;
            _mobilitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the mobility internal.
    /// </summary>
    /// <value>The mobility internal.</value>
    [EntityElement("AD_MOBILIDADE")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string MobilityInternal
    {
        get => _mobility.ToString();
        set
        {
            _mobility = value.ToBoolean(@"S|N");
            _mobilitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sector.
    /// </summary>
    /// <value>The sector.</value>
    [EntityIgnore]
    public SellerSector Sector
    {
        get => _sector;
        set
        {
            _sector = value;
            _sectorSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sector internal.
    /// </summary>
    /// <value>The sector internal.</value>
    [EntityElement("AD_SETORVEND")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SectorInternal
    {
        get => _sector.GetInternalValue();
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }

            _sector = EnumExtensions.GetEnumByInternalValueAttribute<SellerSector>(value);
            _sectorSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize code supervisor.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeSupervisor() => _codeSupervisorSet;

    /// <summary>
    /// Should the serialize code affiliated.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeAffiliated() => _codeAffiliatedSet;

    /// <summary>
    /// Should the serialize mobility.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeMobility() => _mobilitySet;

    /// <summary>
    /// Should the serialize sector.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSector() => _sectorSet;

    #endregion
}
