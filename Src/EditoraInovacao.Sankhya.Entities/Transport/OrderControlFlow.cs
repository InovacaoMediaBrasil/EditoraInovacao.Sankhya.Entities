// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 26/12/2016
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderControlFlow.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using CrispyWaffle.Log;
using CrispyWaffle.Serialization;
using EditoraInovacao.Sankhya.Entities.Enums;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class OrderControlFlow.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="System.IEquatable{OrderControlFlow}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="System.IEquatable{OrderControlFlow}" />
[Serializer]
[Entity("PEDIDOVTEXSCFLUXO")]
public class OrderControlFlow : IEntity, IEquatable<OrderControlFlow>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    public bool Equals(OrderControlFlow other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || string.Equals(_orderId, other._orderId, StringComparison.InvariantCultureIgnoreCase)
                && _orderIdSet == other._orderIdSet
                && _sequence == other._sequence
                && _sequenceSet == other._sequenceSet
                && _singleNumber == other._singleNumber
                && _singleNumberSet == other._singleNumberSet
                && _date.Equals(other._date)
                && _dateSet == other._dateSet
                && _codeUser == other._codeUser
                && _codeUserSet == other._codeUserSet
                && _flow == other._flow
                && _flowSet == other._flowSet
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

        return ReferenceEquals(this, obj)
            || obj.GetType() == GetType() && Equals((OrderControlFlow)obj);
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode =
                _orderId != null
                    ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_orderId)
                    : 0;
            hashCode = (hashCode * 397) ^ _orderIdSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _sequence;
            hashCode = (hashCode * 397) ^ _sequenceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _singleNumber;
            hashCode = (hashCode * 397) ^ _singleNumberSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _date.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeUser;
            hashCode = (hashCode * 397) ^ _codeUserSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_flow;
            hashCode = (hashCode * 397) ^ _flowSet.GetHashCode();
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
    public static bool operator ==(OrderControlFlow left, OrderControlFlow right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(OrderControlFlow left, OrderControlFlow right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The order identifier
    /// </summary>
    /// <summary>
    /// The order identifier
    /// </summary>
    private string _orderId;

    /// <summary>
    /// The order identifier set
    /// </summary>
    /// <summary>
    /// The order identifier set
    /// </summary>
    private bool _orderIdSet;

    /// <summary>
    /// The sequence
    /// </summary>
    /// <summary>
    /// The sequence
    /// </summary>
    private int _sequence;

    /// <summary>
    /// The sequence set
    /// </summary>
    /// <summary>
    /// The sequence set
    /// </summary>
    private bool _sequenceSet;

    /// <summary>
    /// The single number
    /// </summary>
    /// <summary>
    /// The single number
    /// </summary>
    private int _singleNumber;

    /// <summary>
    /// The single number set
    /// </summary>
    /// <summary>
    /// The single number set
    /// </summary>
    private bool _singleNumberSet;

    /// <summary>
    /// The date
    /// </summary>
    /// <summary>
    /// The date
    /// </summary>
    private DateTime _date;

    /// <summary>
    /// The date set
    /// </summary>
    /// <summary>
    /// The date set
    /// </summary>
    private bool _dateSet;

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
    /// The flow
    /// </summary>
    /// <summary>
    /// The flow
    /// </summary>
    private OrderFlow _flow;

    /// <summary>
    /// The flow set
    /// </summary>
    /// <summary>
    /// The flow set
    /// </summary>
    private bool _flowSet;

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
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    /// <summary>
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    [EntityKey]
    [EntityElement("ORDERID")]
    public string OrderId
    {
        get => _orderId;
        set
        {
            _orderId = value;
            _orderIdSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the sequence.
    /// </summary>
    /// <value>The sequence.</value>
    [EntityKey]
    [EntityElement("PEDORIGINAL")]
    public int Sequence
    {
        get => _sequence;
        set
        {
            _sequence = value;
            _sequenceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the single number.
    /// </summary>
    /// <value>The single number.</value>
    [EntityKey]
    [EntityElement("NUNOTA")]
    public int SingleNumber
    {
        get => _singleNumber;
        set
        {
            _singleNumber = value;
            _singleNumberSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    /// <value>The date.</value>
    [EntityElement("DATA")]
    public DateTime Date
    {
        get => _date;
        set
        {
            _date = value;
            _dateSet = true;
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
    /// Gets or sets the flow.
    /// </summary>
    /// <value>The flow.</value>
    [EntityIgnore]
    public OrderFlow Flow
    {
        get => _flow;
        set
        {
            _flow = value;
            _flowSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the flow internal.
    /// </summary>
    /// <value>The flow internal.</value>
    [EntityKey]
    [EntityElement("OCORRENCIA")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string FlowInternal
    {
        get => _flow.GetInternalValue();
        set
        {
            try
            {
                _flow = EnumExtensions.GetEnumByInternalValueAttribute<OrderFlow>(value);
                _flowSet = true;
            }
            catch (Exception e)
            {
                LogConsumer.Handle(e);
            }
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
    /// Should the serialize order identifier.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOrderId() => _orderIdSet;

    /// <summary>
    /// Should the serialize sequence.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSequence() => _sequenceSet;

    /// <summary>
    /// Should the serialize single number.
    /// </summary>/// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSingleNumber() => _singleNumberSet;

    /// <summary>
    /// Should the serialize date.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDate() => _dateSet;

    /// <summary>
    /// Should the serialize code user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// Should the serialize flow.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFlow() => _flowSet;

    /// <summary>
    /// Should the serialize user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUser() => _userSet;

    #endregion
}
