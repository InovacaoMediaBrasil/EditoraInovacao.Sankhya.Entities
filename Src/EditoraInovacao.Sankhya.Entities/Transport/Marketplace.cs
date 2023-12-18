// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 2016-12-13
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="Marketplace.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using CrispyWaffle.Serialization;
using EditoraInovacao.Sankhya.Entities.Enums;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class Marketplace.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="System.IEquatable{Marketplace}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="System.IEquatable{Marketplace}" />
[Serializer]
[Entity("MULTILOJA")]
public class Marketplace : IEntity, IEquatable<Marketplace>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(Marketplace other)
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
            && _codeBrand == other._codeBrand
            && _codeBrandSet == other._codeBrandSet
            && _codeUser == other._codeUser
            && _codeUserSet == other._codeUserSet
            && _codePriorityStore == other._codePriorityStore
            && _codePriorityStoreSet == other._codePriorityStoreSet
            && _registerDate.Equals(other._registerDate)
            && _registerDateSet == other._registerDateSet
            && _changedDate.Equals(other._changedDate)
            && _changedDateSet == other._changedDateSet
            && _exportedDate.Equals(other._exportedDate)
            && _exportedDateSet == other._exportedDateSet
            && _synchronizedDate.Equals(other._synchronizedDate)
            && _synchronizedDateSet == other._synchronizedDateSet
            && _stockChanged == other._stockChanged
            && _stockChangedSet == other._stockChangedSet
            && _productChanged == other._productChanged
            && _productChangedSet == other._productChangedSet
            && _salesChannelChanged == other._salesChannelChanged
            && _salesChannelChangedSet == other._salesChannelChangedSet
            && _priceChanged == other._priceChanged
            && _priceChangedSet == other._priceChangedSet
            && _availableQuantity == other._availableQuantity
            && _availableQuantitySet == other._availableQuantitySet
            && _priority == other._priority
            && _prioritySet == other._prioritySet
            && string.Equals(_history, other._history, StringComparison.InvariantCultureIgnoreCase)
            && _historySet == other._historySet
            && string.Equals(
                _complement,
                other._complement,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _complementSet == other._complementSet
            && string.Equals(
                _keyWords,
                other._keyWords,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _keyWordsSet == other._keyWordsSet
            && string.Equals(
                _descriptionMetaTag,
                other._descriptionMetaTag,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _descriptionMetaTagSet == other._descriptionMetaTagSet
            && string.Equals(
                _videoUrl,
                other._videoUrl,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _videoUrlSet == other._videoUrlSet
            && _relationshipCode == other._relationshipCode
            && _relationshipCodeSet == other._relationshipCodeSet
            && string.Equals(
                _technicalSpecification,
                other._technicalSpecification,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _technicalSpecificationSet == other._technicalSpecificationSet
            && _codeTeacherA == other._codeTeacherA
            && _codeTeacherASet == other._codeTeacherASet
            && _codeTeacherB == other._codeTeacherB
            && _codeTeacherBSet == other._codeTeacherBSet
            && _codeTechniqueA == other._codeTechniqueA
            && _codeTechniqueASet == other._codeTechniqueASet
            && _codeTechniqueB == other._codeTechniqueB
            && _codeTechniqueBSet == other._codeTechniqueBSet
            && _codeTechniqueC == other._codeTechniqueC
            && _codeTechniqueCSet == other._codeTechniqueCSet
            && Equals(_product, other._product)
            && _productSet == other._productSet
            && Equals(_brand, other._brand)
            && _brandSet == other._brandSet
            && Equals(_user, other._user)
            && _userSet == other._userSet
            && Equals(_priorityStore, other._priorityStore)
            && _priorityStoreSet == other._priorityStoreSet
            && Equals(_teacherA, other._teacherA)
            && _teacherASet == other._teacherASet
            && Equals(_teacherB, other._teacherB)
            && _teacherBSet == other._teacherBSet
            && Equals(_techniqueA, other._techniqueA)
            && _techniqueASet == other._techniqueASet
            && Equals(_techniqueB, other._techniqueB)
            && _techniqueBSet == other._techniqueBSet
            && Equals(_techniqueC, other._techniqueC)
            && _techniqueCSet == other._techniqueCSet
            && Equals(SalesChannels, other.SalesChannels);
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

        return obj.GetType() == GetType() && Equals((Marketplace)obj);
    }

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once MethodTooLong
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _code;
            hashCode = (hashCode * 397) ^ _codeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeBrand;
            hashCode = (hashCode * 397) ^ _codeBrandSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeUser;
            hashCode = (hashCode * 397) ^ _codeUserSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codePriorityStore;
            hashCode = (hashCode * 397) ^ _codePriorityStoreSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _registerDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _registerDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _changedDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _changedDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _exportedDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _exportedDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _synchronizedDate.GetHashCode();
            hashCode = (hashCode * 397) ^ _synchronizedDateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _stockChanged.GetHashCode();
            hashCode = (hashCode * 397) ^ _stockChangedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _productChanged.GetHashCode();
            hashCode = (hashCode * 397) ^ _productChangedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _salesChannelChanged.GetHashCode();
            hashCode = (hashCode * 397) ^ _salesChannelChangedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _priceChanged.GetHashCode();
            hashCode = (hashCode * 397) ^ _priceChangedSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _availableQuantity.GetHashCode();
            hashCode = (hashCode * 397) ^ _availableQuantitySet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_priority;
            hashCode = (hashCode * 397) ^ _prioritySet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _history != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_history)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _historySet.GetHashCode();
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
                    _keyWords != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_keyWords)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _keyWordsSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _descriptionMetaTag != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_descriptionMetaTag)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _descriptionMetaTagSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _videoUrl != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_videoUrl)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _videoUrlSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _relationshipCode;
            hashCode = (hashCode * 397) ^ _relationshipCodeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _technicalSpecification != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(
                            _technicalSpecification
                        )
                        : 0
                );
            hashCode = (hashCode * 397) ^ _technicalSpecificationSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTeacherA;
            hashCode = (hashCode * 397) ^ _codeTeacherASet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTeacherB;
            hashCode = (hashCode * 397) ^ _codeTeacherBSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTechniqueA;
            hashCode = (hashCode * 397) ^ _codeTechniqueASet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTechniqueB;
            hashCode = (hashCode * 397) ^ _codeTechniqueBSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTechniqueC;
            hashCode = (hashCode * 397) ^ _codeTechniqueCSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_product != null ? _product.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _productSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_brand != null ? _brand.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _brandSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_user != null ? _user.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _userSet.GetHashCode();
            hashCode =
                (hashCode * 397) ^ (_priorityStore != null ? _priorityStore.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _priorityStoreSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_teacherA != null ? _teacherA.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _teacherASet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_teacherB != null ? _teacherB.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _teacherBSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_techniqueA != null ? _techniqueA.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _techniqueASet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_techniqueB != null ? _techniqueB.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _techniqueBSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_techniqueC != null ? _techniqueC.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _techniqueCSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (SalesChannels != null ? SalesChannels.GetHashCode() : 0);
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(Marketplace left, Marketplace right) => Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(Marketplace left, Marketplace right) => !Equals(left, right);

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
    /// The code brand
    /// </summary>
    /// <summary>
    /// The code brand
    /// </summary>
    private int _codeBrand;

    /// <summary>
    /// The code brand set
    /// </summary>
    /// <summary>
    /// The code brand set
    /// </summary>
    private bool _codeBrandSet;

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
    /// The code priority store
    /// </summary>
    /// <summary>
    /// The code priority store
    /// </summary>
    private int _codePriorityStore;

    /// <summary>
    /// The code priority store set
    /// </summary>
    /// <summary>
    /// The code priority store set
    /// </summary>
    private bool _codePriorityStoreSet;

    /// <summary>
    /// The register date
    /// </summary>
    /// <summary>
    /// The register date
    /// </summary>
    private DateTime _registerDate;

    /// <summary>
    /// The register date set
    /// </summary>
    /// <summary>
    /// The register date set
    /// </summary>
    private bool _registerDateSet;

    /// <summary>
    /// The changed date
    /// </summary>
    /// <summary>
    /// The changed date
    /// </summary>
    private DateTime _changedDate;

    /// <summary>
    /// The changed date set
    /// </summary>
    /// <summary>
    /// The changed date set
    /// </summary>
    private bool _changedDateSet;

    /// <summary>
    /// The exported date
    /// </summary>
    /// <summary>
    /// The exported date
    /// </summary>
    private DateTime _exportedDate;

    /// <summary>
    /// The exported date set
    /// </summary>
    /// <summary>
    /// The exported date set
    /// </summary>
    private bool _exportedDateSet;

    /// <summary>
    /// The synchronized date
    /// </summary>
    /// <summary>
    /// The synchronized date
    /// </summary>
    private DateTime _synchronizedDate;

    /// <summary>
    /// The synchronized date set
    /// </summary>
    /// <summary>
    /// The synchronized date set
    /// </summary>
    private bool _synchronizedDateSet;

    /// <summary>
    /// The stock changed
    /// </summary>
    /// <summary>
    /// The stock changed
    /// </summary>
    private bool _stockChanged;

    /// <summary>
    /// The stock changed set
    /// </summary>
    /// <summary>
    /// The stock changed set
    /// </summary>
    private bool _stockChangedSet;

    /// <summary>
    /// The product changed
    /// </summary>
    /// <summary>
    /// The product changed
    /// </summary>
    private bool _productChanged;

    /// <summary>
    /// The product changed set
    /// </summary>
    /// <summary>
    /// The product changed set
    /// </summary>
    private bool _productChangedSet;

    /// <summary>
    /// The sales channel changed
    /// </summary>
    /// <summary>
    /// The sales channel changed
    /// </summary>
    private bool _salesChannelChanged;

    /// <summary>
    /// The sales channel changed set
    /// </summary>
    /// <summary>
    /// The sales channel changed set
    /// </summary>
    private bool _salesChannelChangedSet;

    /// <summary>
    /// The price changed
    /// </summary>
    /// <summary>
    /// The price changed
    /// </summary>
    private bool _priceChanged;

    /// <summary>
    /// The price changed set
    /// </summary>
    /// <summary>
    /// The price changed set
    /// </summary>
    private bool _priceChangedSet;

    /// <summary>
    /// The available quantity
    /// </summary>
    /// <summary>
    /// The available quantity
    /// </summary>
    private decimal _availableQuantity;

    /// <summary>
    /// The available quantity set
    /// </summary>
    /// <summary>
    /// The available quantity set
    /// </summary>
    private bool _availableQuantitySet;

    /// <summary>
    /// The priority
    /// </summary>
    /// <summary>
    /// The priority
    /// </summary>
    private MultiStorePriority _priority;

    /// <summary>
    /// The priority set
    /// </summary>
    /// <summary>
    /// The priority set
    /// </summary>
    private bool _prioritySet;

    /// <summary>
    /// The history
    /// </summary>
    /// <summary>
    /// The history
    /// </summary>
    private string _history;

    /// <summary>
    /// The history set
    /// </summary>
    /// <summary>
    /// The history set
    /// </summary>
    private bool _historySet;

    /// <summary>
    /// The complement
    /// </summary>
    /// <summary>
    /// The complement
    /// </summary>
    private string _complement;

    /// <summary>
    /// The complement set
    /// </summary>
    /// <summary>
    /// The complement set
    /// </summary>
    private bool _complementSet;

    /// <summary>
    /// The key words
    /// </summary>
    /// <summary>
    /// The key words
    /// </summary>
    private string _keyWords;

    /// <summary>
    /// The key words set
    /// </summary>
    /// <summary>
    /// The key words set
    /// </summary>
    private bool _keyWordsSet;

    /// <summary>
    /// The description meta tag
    /// </summary>
    /// <summary>
    /// The description meta tag
    /// </summary>
    private string _descriptionMetaTag;

    /// <summary>
    /// The description meta tag set
    /// </summary>
    /// <summary>
    /// The description meta tag set
    /// </summary>
    private bool _descriptionMetaTagSet;

    /// <summary>
    /// The video URL
    /// </summary>
    /// <summary>
    /// The video URL
    /// </summary>
    private string _videoUrl;

    /// <summary>
    /// The video URL set
    /// </summary>
    /// <summary>
    /// The video URL set
    /// </summary>
    private bool _videoUrlSet;

    /// <summary>
    /// The relationship code
    /// </summary>
    /// <summary>
    /// The relationship code
    /// </summary>
    private int _relationshipCode;

    /// <summary>
    /// The relationship code set
    /// </summary>
    /// <summary>
    /// The relationship code set
    /// </summary>
    private bool _relationshipCodeSet;

    /// <summary>
    /// The technical specification
    /// </summary>
    /// <summary>
    /// The technical specification
    /// </summary>
    private string _technicalSpecification;

    /// <summary>
    /// The technical specification set
    /// </summary>
    /// <summary>
    /// The technical specification set
    /// </summary>
    private bool _technicalSpecificationSet;

    /// <summary>
    /// The code teacher a
    /// </summary>
    /// <summary>
    /// The code teacher a
    /// </summary>
    private int _codeTeacherA;

    /// <summary>
    /// The code teacher a set
    /// </summary>
    /// <summary>
    /// The code teacher a set
    /// </summary>
    private bool _codeTeacherASet;

    /// <summary>
    /// The code teacher b
    /// </summary>
    /// <summary>
    /// The code teacher b
    /// </summary>
    private int _codeTeacherB;

    /// <summary>
    /// The code teacher b set
    /// </summary>
    /// <summary>
    /// The code teacher b set
    /// </summary>
    private bool _codeTeacherBSet;

    /// <summary>
    /// The code technique a
    /// </summary>
    /// <summary>
    /// The code technique a
    /// </summary>
    private int _codeTechniqueA;

    /// <summary>
    /// The code technique a set
    /// </summary>
    /// <summary>
    /// The code technique a set
    /// </summary>
    private bool _codeTechniqueASet;

    /// <summary>
    /// The code technique b
    /// </summary>
    /// <summary>
    /// The code technique b
    /// </summary>
    private int _codeTechniqueB;

    /// <summary>
    /// The code technique b set
    /// </summary>
    /// <summary>
    /// The code technique b set
    /// </summary>
    private bool _codeTechniqueBSet;

    /// <summary>
    /// The code technique c
    /// </summary>
    /// <summary>
    /// The code technique c
    /// </summary>
    private int _codeTechniqueC;

    /// <summary>
    /// The code technique c set
    /// </summary>
    /// <summary>
    /// The code technique c set
    /// </summary>
    private bool _codeTechniqueCSet;

    /// <summary>
    /// The product
    /// </summary>
    /// <summary>
    /// The product
    /// </summary>
    private ProductCustom _product;

    /// <summary>
    /// The product set
    /// </summary>
    /// <summary>
    /// The product set
    /// </summary>
    private bool _productSet;

    /// <summary>
    /// The brand
    /// </summary>
    /// <summary>
    /// The brand
    /// </summary>
    private Brand _brand;

    /// <summary>
    /// The brand set
    /// </summary>
    /// <summary>
    /// The brand set
    /// </summary>
    private bool _brandSet;

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

    /// <summary>
    /// The priority store
    /// </summary>
    /// <summary>
    /// The priority store
    /// </summary>
    private Store _priorityStore;

    /// <summary>
    /// The priority store set
    /// </summary>
    /// <summary>
    /// The priority store set
    /// </summary>
    private bool _priorityStoreSet;

    /// <summary>
    /// The teacher a
    /// </summary>
    /// <summary>
    /// The teacher a
    /// </summary>
    private Teacher _teacherA;

    /// <summary>
    /// The teacher a set
    /// </summary>
    /// <summary>
    /// The teacher a set
    /// </summary>
    private bool _teacherASet;

    /// <summary>
    /// The teacher b
    /// </summary>
    /// <summary>
    /// The teacher b
    /// </summary>
    private Teacher _teacherB;

    /// <summary>
    /// The teacher b set
    /// </summary>
    /// <summary>
    /// The teacher b set
    /// </summary>
    private bool _teacherBSet;

    /// <summary>
    /// The technique a
    /// </summary>
    /// <summary>
    /// The technique a
    /// </summary>
    private Technique _techniqueA;

    /// <summary>
    /// The technique a set
    /// </summary>
    /// <summary>
    /// The technique a set
    /// </summary>
    private bool _techniqueASet;

    /// <summary>
    /// The technique b/
    /// </summary>
    /// <summary>
    /// The technique b
    /// </summary>
    private Technique _techniqueB;

    /// <summary>
    /// The technique b set
    /// </summary>
    /// <summary>
    /// The technique b set
    /// </summary>
    private bool _techniqueBSet;

    /// <summary>
    /// The technique c
    /// </summary>
    /// <summary>
    /// The technique c
    /// </summary>
    private Technique _techniqueC;

    /// <summary>
    /// The technique c set
    /// </summary>
    /// <summary>
    /// The technique c set
    /// </summary>
    private bool _techniqueCSet;

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
    /// Gets or sets the code brand.
    /// </summary>
    /// <value>The code brand.</value>
    /// <summary>
    /// Gets or sets the code brand.
    /// </summary>
    /// <value>The code brand.</value>
    [EntityElement("CODMARCA")]
    public int CodeBrand
    {
        get => _codeBrand;
        set
        {
            _codeBrand = value;
            _codeBrandSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code user.
    /// </summary>
    /// <value>
    /// The code user.
    /// </value>
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
    /// Gets or sets the code priority store.
    /// </summary>
    /// <value>The code priority store.</value>
    /// <summary>
    /// Gets or sets the code priority store.
    /// </summary>
    /// <value>The code priority store.</value>
    [EntityElement("CODLOJAPRIO")]
    public int CodePriorityStore
    {
        get => _codePriorityStore;
        set
        {
            _codePriorityStore = value;
            _codePriorityStoreSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the register date.
    /// </summary>
    /// <value>
    /// The register date.
    /// </value>
    /// <summary>
    /// Gets or sets the register date.
    /// </summary>
    /// <value>The register date.</value>
    [EntityElement("DTCADASTRO")]
    public DateTime RegisterDate
    {
        get => _registerDate;
        set
        {
            _registerDate = value;
            _registerDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the changed date.
    /// </summary>
    /// <value>The changed date.</value>
    /// <summary>
    /// Gets or sets the changed date.
    /// </summary>
    /// <value>The changed date.</value>
    [EntityElement("DTMODIF")]
    public DateTime ChangedDate
    {
        get => _changedDate;
        set
        {
            _changedDate = value;
            _changedDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the exported date.
    /// </summary>
    /// <value>The exported date.</value>
    /// <summary>
    /// Gets or sets the exported date.
    /// </summary>
    /// <value>The exported date.</value>
    [EntityElement("DTINTEGRACAO")]
    public DateTime ExportedDate
    {
        get => _exportedDate;
        set
        {
            _exportedDate = value;
            _exportedDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the synchronized date.
    /// </summary>
    /// <value>The synchronized date.</value>
    /// <summary>
    /// Gets or sets the synchronized date.
    /// </summary>
    /// <value>The synchronized date.</value>
    [EntityElement("DTSINCRONIZACAO")]
    public DateTime SynchronizedDate
    {
        get => _synchronizedDate;
        set
        {
            _synchronizedDate = value;
            _synchronizedDateSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the stock changed.
    /// </summary>
    /// <value>The stock changed.</value>
    /// <summary>
    /// Gets or sets a value indicating whether [stock changed].
    /// </summary>
    /// <value><c>true</c> if [stock changed]; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool StockChanged
    {
        get => _stockChanged;
        set
        {
            _stockChanged = value;
            _stockChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the stock changed internal.
    /// </summary>
    /// <value>The stock changed internal.</value>
    /// <summary>
    /// Gets or sets the stock changed internal.
    /// </summary>
    /// <value>The stock changed internal.</value>
    [EntityElement("ALTESTOQUE")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string StockChangedInternal
    {
        get => _stockChanged.ToString(@"S", @"N");
        set
        {
            _stockChanged = value.ToBoolean();
            _stockChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product changed.
    /// </summary>
    /// <value>The product changed.</value>
    /// <summary>
    /// Gets or sets a value indicating whether [product changed].
    /// </summary>
    /// <value><c>true</c> if [product changed]; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool ProductChanged
    {
        get => _productChanged;
        set
        {
            _productChanged = value;
            _productChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product changed internal.
    /// </summary>
    /// <value>The product changed internal.</value>
    /// <summary>
    /// Gets or sets the product changed internal.
    /// </summary>
    /// <value>The product changed internal.</value>
    [EntityElement("ALTPRODUTO")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string ProductChangedInternal
    {
        get => _productChanged.ToString(@"S", @"N");
        set
        {
            _productChanged = value.ToBoolean();
            _productChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sales channel changed.
    /// </summary>
    /// <value>The sales channel changed.</value>
    /// <summary>
    /// Gets or sets a value indicating whether [sales channel changed].
    /// </summary>
    /// <value><c>true</c> if [sales channel changed]; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool SalesChannelChanged
    {
        get => _salesChannelChanged;
        set
        {
            _salesChannelChanged = value;
            _salesChannelChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sales channel changed internal.
    /// </summary>
    /// <value>The sales channel changed internal.</value>
    /// <summary>
    /// Gets or sets the sales channel changed internal.
    /// </summary>
    /// <value>The sales channel changed internal.</value>
    [EntityElement("ALTLOJA")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string SalesChannelChangedInternal
    {
        get => _salesChannelChanged.ToString(@"S", @"N");
        set
        {
            _salesChannelChanged = value.ToBoolean();
            _salesChannelChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the price changed.
    /// </summary>
    /// <value>The price changed.</value>
    /// <summary>
    /// Gets or sets a value indicating whether [price changed].
    /// </summary>
    /// <value><c>true</c> if [price changed]; otherwise, <c>false</c>.</value>
    [EntityIgnore]
    public bool PriceChanged
    {
        get => _priceChanged;
        set
        {
            _priceChanged = value;
            _priceChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the price changed internal.
    /// </summary>
    /// <value>The price changed internal.</value>
    /// <summary>
    /// Gets or sets the price changed internal.
    /// </summary>
    /// <value>The price changed internal.</value>
    [EntityElement("ALTPRECO")]
    [Browsable(true)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string PriceChangedInternal
    {
        get => _priceChanged.ToString(@"S", @"N");
        set
        {
            _priceChanged = value.ToBoolean();
            _priceChangedSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the available quantity.
    /// </summary>
    /// <value>The available quantity.</value>
    /// <summary>
    /// Gets or sets the available quantity.
    /// </summary>
    /// <value>The available quantity.</value>
    [EntityElement("ESTOQUE")]
    public decimal AvailableQuantity
    {
        get => _availableQuantity;
        set
        {
            _availableQuantity = value;
            _availableQuantitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the complement.
    /// </summary>
    /// <value>
    /// The complement.
    /// </value>
    /// <summary>
    /// Gets or sets the complement.
    /// </summary>
    /// <value>The complement.</value>
    [EntityElement("COMPLEMENTO")]
    public string Complement
    {
        get => _complement;
        set
        {
            _complement = value;
            _complementSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the key words.
    /// </summary>
    /// <value>
    /// The key words.
    /// </value>
    /// <summary>
    /// Gets or sets the key words.
    /// </summary>
    /// <value>The key words.</value>
    [EntityElement("PALAVRASCHAVES")]
    public string KeyWords
    {
        get => _keyWords;
        set
        {
            _keyWords = value;
            _keyWordsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the description meta tag.
    /// </summary>
    /// <value>
    /// The description meta tag.
    /// </value>
    /// <summary>
    /// Gets or sets the description meta tag.
    /// </summary>
    /// <value>The description meta tag.</value>
    [EntityElement("DESCRICAOMETA")]
    public string DescriptionMetaTag
    {
        get => _descriptionMetaTag;
        set
        {
            _descriptionMetaTag = value;
            _descriptionMetaTagSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the video URL.
    /// </summary>
    /// <value>
    /// The video URL.
    /// </value>
    /// <summary>
    /// Gets or sets the video URL.
    /// </summary>
    /// <value>The video URL.</value>
    [EntityElement("VIDEO")]
    public string VideoUrl
    {
        get => _videoUrl;
        set
        {
            _videoUrl = value;
            _videoUrlSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the relationship code.
    /// </summary>
    /// <value>
    /// The relationship code.
    /// </value>
    /// <summary>
    /// Gets or sets the relationship code.
    /// </summary>
    /// <value>The relationship code.</value>
    [EntityElement("CODRELACIONAMENTO")]
    public int RelationshipCode
    {
        get => _relationshipCode;
        set
        {
            _relationshipCode = value;
            _relationshipCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the technical specification.
    /// </summary>
    /// <value>
    /// The technical specification.
    /// </value>
    /// <summary>
    /// Gets or sets the technical specification.
    /// </summary>
    /// <value>The technical specification.</value>
    [EntityElement("ESPECTECNICA")]
    public string TechnicalSpecification
    {
        get => _technicalSpecification;
        set
        {
            _technicalSpecification = value;
            _technicalSpecificationSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the priority.
    /// </summary>
    /// <value>
    /// The priority.
    /// </value>
    /// <summary>
    /// Gets or sets the priority.
    /// </summary>
    /// <value>The priority.</value>
    [EntityIgnore]
    public MultiStorePriority Priority
    {
        get => _priority;
        set
        {
            _priority = value;
            _prioritySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the priority internal.
    /// </summary>
    /// <value>
    /// The priority internal.
    /// </value>
    /// <summary>
    /// Gets or sets the priority internal.
    /// </summary>
    /// <value>The priority internal.</value>
    [EntityElement("PRIORIDADE")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string PriorityInternal
    {
        get => _priority.GetInternalValue();
        set
        {
            _priority = EnumExtensions.GetEnumByInternalValueAttribute<MultiStorePriority>(value);
            _prioritySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the history.
    /// </summary>
    /// <value>The history.</value>
    /// <summary>
    /// Gets or sets the history.
    /// </summary>
    /// <value>The history.</value>
    [EntityElement("HISTORICO")]
    public string History
    {
        get => _history;
        set
        {
            _history = value;
            _historySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code teacher a.
    /// </summary>
    /// <value>
    /// The code teacher a.
    /// </value>
    /// <summary>
    /// Gets or sets the code teacher a.
    /// </summary>
    /// <value>The code teacher a.</value>
    [EntityElement("CODPROFA")]
    public int CodeTeacherA
    {
        get => _codeTeacherA;
        set
        {
            _codeTeacherA = value;
            _codeTeacherASet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code teacher b.
    /// </summary>
    /// <value>
    /// The code teacher b.
    /// </value>
    /// <summary>
    /// Gets or sets the code teacher b.
    /// </summary>
    /// <value>The code teacher b.</value>
    [EntityElement("CODPROFB")]
    public int CodeTeacherB
    {
        get => _codeTeacherB;
        set
        {
            _codeTeacherB = value;
            _codeTeacherBSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code technique a.
    /// </summary>
    /// <value>
    /// The code technique a.
    /// </value>
    /// <summary>
    /// Gets or sets the code technique a.
    /// </summary>
    /// <value>The code technique a.</value>
    [EntityElement("CODTECA")]
    public int CodeTechniqueA
    {
        get => _codeTechniqueA;
        set
        {
            _codeTechniqueA = value;
            _codeTechniqueASet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code technique b.
    /// </summary>
    /// <value>
    /// The code technique b.
    /// </value>
    /// <summary>
    /// Gets or sets the code technique b.
    /// </summary>
    /// <value>The code technique b.</value>
    [EntityElement("CODTECB")]
    public int CodeTechniqueB
    {
        get => _codeTechniqueB;
        set
        {
            _codeTechniqueB = value;
            _codeTechniqueBSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code technique c.
    /// </summary>
    /// <value>
    /// The code technique c.
    /// </value>
    /// <summary>
    /// Gets or sets the code technique c.
    /// </summary>
    /// <value>The code technique c.</value>
    [EntityElement("CODTECC")]
    public int CodeTechniqueC
    {
        get => _codeTechniqueC;
        set
        {
            _codeTechniqueC = value;
            _codeTechniqueCSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    /// <value>The product.</value>
    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    /// <value>The product.</value>
    [EntityReference]
    public ProductCustom Product
    {
        get => _product;
        set
        {
            _product = value;
            _productSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the brand.
    /// </summary>
    /// <value>The brand.</value>
    /// <summary>
    /// Gets or sets the brand.
    /// </summary>
    /// <value>The brand.</value>
    [EntityReference]
    public Brand Brand
    {
        get => _brand;
        set
        {
            _brand = value;
            _brandSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the user.
    /// </summary>
    /// <value>
    /// The user.
    /// </value>
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

    /// <summary>
    /// Gets or sets the priority store.
    /// </summary>
    /// <value>The priority store.</value>
    /// <summary>
    /// Gets or sets the priority store.
    /// </summary>
    /// <value>The priority store.</value>
    [EntityReference]
    public Store PriorityStore
    {
        get => _priorityStore;
        set
        {
            _priorityStore = value;
            _priorityStoreSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the teacher a.
    /// </summary>
    /// <value>The teacher a.</value>
    /// <summary>
    /// Gets or sets the teacher a.
    /// </summary>
    /// <value>The teacher a.</value>
    [EntityReference]
    public Teacher TeacherA
    {
        get => _teacherA;
        set
        {
            _teacherA = value;
            _teacherASet = true;
        }
    }

    /// <summary>
    /// Gets or sets the teacher b.
    /// </summary>
    /// <value>The teacher b.</value>
    /// <summary>
    /// Gets or sets the teacher b.
    /// </summary>
    /// <value>The teacher b.</value>
    [EntityReference("VTEXPROFESSORES_AD001")]
    public Teacher TeacherB
    {
        get => _teacherB;
        set
        {
            _teacherB = value;
            _teacherBSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the technique a.
    /// </summary>
    /// <value>
    /// The technique a.
    /// </value>
    /// <summary>
    /// Gets or sets the technique a.
    /// </summary>
    /// <value>The technique a.</value>
    [EntityReference]
    public Technique TechniqueA
    {
        get => _techniqueA;
        set
        {
            _techniqueA = value;
            _techniqueASet = true;
        }
    }

    /// <summary>
    /// Gets or sets the technique b.
    /// </summary>
    /// <value>
    /// The technique b.
    /// </value>
    /// <summary>
    /// Gets or sets the technique b.
    /// </summary>
    /// <value>The technique b.</value>
    [EntityReference("VTEXTECNICAS_AD001")]
    public Technique TechniqueB
    {
        get => _techniqueB;
        set
        {
            _techniqueB = value;
            _techniqueBSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the technique c.
    /// </summary>
    /// <value>
    /// The technique c.
    /// </value>
    /// <summary>
    /// Gets or sets the technique c.
    /// </summary>
    /// <value>The technique c.</value>
    [EntityReference("VTEXTECNICAS_AD002")]
    public Technique TechniqueC
    {
        get => _techniqueC;
        set
        {
            _techniqueC = value;
            _techniqueCSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sales channels.
    /// </summary>
    /// <value>The sales channels.</value>
    /// <summary>
    /// Gets or sets the sales channels.
    /// </summary>
    /// <value>The sales channels.</value>
    [EntityIgnore]
    public List<SalesChannel> SalesChannels { get; set; }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// Should the serialize code.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCode() => _codeSet;

    /// <summary>
    /// Should the serialize code brand.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code brand.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeBrand() => _codeBrandSet;

    /// <summary>
    /// The should serialize code user serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize code user.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// Should the serialize code priority store.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize code priority store.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePriorityStore() => _codePriorityStoreSet;

    /// <summary>
    /// The should serialize register date serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize register date.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeRegisterDate() => _registerDateSet;

    /// <summary>
    /// Should the serialize changed date.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize changed date.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeChangedDate() => _changedDateSet;

    /// <summary>
    /// Should the serialize exported date.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize exported date.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeExportedDate() => _exportedDateSet;

    /// <summary>
    /// Should the serialize synchronized date.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize synchronized date.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSynchronizedDate() => _synchronizedDateSet;

    /// <summary>
    /// Should the serialize stock changed.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize stock changed.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeStockChanged() => _stockChangedSet;

    /// <summary>
    /// Should the serialize product changed.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize product changed.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeProductChanged() => _productChangedSet;

    /// <summary>
    /// Should the serialize sales channel changed.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize sales channel changed.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSalesChannelChanged() => _salesChannelChangedSet;

    /// <summary>
    /// Should the serialize price changed.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize price changed.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePriceChanged() => _priceChangedSet;

    /// <summary>
    /// Should the serialize available quantity.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize available quantity.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeAvailableQuantity() => _availableQuantitySet;

    /// <summary>
    /// The should serialize complement serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize complement.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeComplement() => _complementSet;

    /// <summary>
    /// The should serialize key words serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize key words.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeKeyWords() => _keyWordsSet;

    /// <summary>
    /// The should serialize description meta tag serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize description meta tag.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDescriptionMetaTag() => _descriptionMetaTagSet;

    /// <summary>
    /// The should serialize video url serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize video URL.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeVideoUrl() => _videoUrlSet;

    /// <summary>
    /// The should serialize relationship code serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize relationship code.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeRelationshipCode() => _relationshipCodeSet;

    /// <summary>
    /// The should serialize technical specification serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize technical specification.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTechnicalSpecification() => _technicalSpecificationSet;

    /// <summary>
    /// The should serialize priority serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize priority.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePriority() => _prioritySet;

    /// <summary>
    /// Should the serialize history.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize history.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeHistory() => _historySet;

    /// <summary>
    /// The should serialize code teacher a serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize code teacher a.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTeacherA() => _codeTeacherASet;

    /// <summary>
    /// The should serialize code teacher b serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize code teacher b.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTeacherB() => _codeTeacherBSet;

    /// <summary>
    /// The should serialize code technique a serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize code technique a.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTechniqueA() => _codeTechniqueASet;

    /// <summary>
    /// The should serialize code technique b serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize code technique b.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTechniqueB() => _codeTechniqueBSet;

    /// <summary>
    /// The should serialize code technique c serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize code technique c.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTechniqueC() => _codeTechniqueCSet;

    /// <summary>
    /// Should the serialize product.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize product.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeProduct() => _productSet;

    /// <summary>
    /// Should the serialize brand.
    /// </summary>
    /// <returns>Boolean.</returns>
    /// <summary>
    /// Check if should serialize brand.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeBrand() => _brandSet;

    /// <summary>
    /// The should serialize user serialization helper method
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the field should be serialized, false otherwise
    /// </returns>
    /// <summary>
    /// Check if should serialize user.
    /// </summary>
    /// <returns><c>true</c> if should serialize, <c>false</c> otherwise.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUser() => _userSet;

    /// <summary>
    /// Should the serialize priority store.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePriorityStore() => _priorityStoreSet;

    /// <summary>
    /// The should serialize teacher a serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTeacherA() => _teacherASet;

    /// <summary>
    /// The should serialize teacher b serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTeacherB() => _teacherBSet;

    /// <summary>
    /// The should serialize technique a serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTechniqueA() => _techniqueASet;

    /// <summary>
    /// The should serialize technique b serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTechniqueB() => _techniqueBSet;

    /// <summary>
    /// The should serialize technique c serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTechniqueC() => _techniqueCSet;

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="Marketplace" /> class.
    /// </summary>
    public Marketplace() => SalesChannels = new();

    #endregion
}
