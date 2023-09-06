// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 18/04/2020
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="OrderHistory.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using CrispyWaffle.Extensions;
using Sankhya.Attributes;
using Sankhya.Enums;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class OrderHistory.
/// Implements the <see cref="IEntity" />
/// </summary>
/// <seealso cref="IEntity" />
[Entity("HistoricoPedido")]
public class OrderHistory : IEntity
{
    #region Private Members

    /// <summary>
    /// The event number
    /// </summary>
    private int _eventNumber;

    /// <summary>
    /// The event number set
    /// </summary>
    private bool _eventNumberSet;

    /// <summary>
    /// The single number
    /// </summary>
    private int _singleNumber;

    /// <summary>
    /// The single number set
    /// </summary>
    private bool _singleNumberSet;

    /// <summary>
    /// The sequence
    /// </summary>
    private int _sequence;

    /// <summary>
    /// The sequence set
    /// </summary>
    private bool _sequenceSet;

    /// <summary>
    /// The event/
    /// </summary>
    private OrderHistoryEvent _event;

    /// <summary>
    /// The event set
    /// </summary>
    private bool _eventSet;

    /// <summary>
    /// The date changed
    /// </summary>
    private DateTime _dateChanged;

    /// <summary>
    /// The date changed set
    /// </summary>
    private bool _dateChangedSet;

    /// <summary>
    /// The code user
    /// </summary>
    private int _codeUser;

    /// <summary>
    /// The code user set
    /// </summary>
    private bool _codeUserSet;

    /// <summary>
    /// The code product
    /// </summary>
    private int _codeProduct;

    /// <summary>
    /// The code product set
    /// </summary>
    private bool _codeProductSet;

    /// <summary>
    /// The control
    /// </summary>
    private string _control;

    /// <summary>
    /// The control set
    /// </summary>
    private bool _controlSet;

    /// <summary>
    /// The traded quantity
    /// </summary>
    private decimal _tradedQuantity;

    /// <summary>
    /// The traded quantity set
    /// </summary>
    private bool _tradedQuantitySet;

    /// <summary>
    /// The delivered quantity
    /// </summary>
    private decimal _deliveredQuantity;

    /// <summary>
    /// The delivered quantity set
    /// </summary>
    private bool _deliveredQuantitySet;

    /// <summary>
    /// The unit value
    /// </summary>
    private decimal _unitValue;

    /// <summary>
    /// The unit value set
    /// </summary>
    private bool _unitValueSet;

    /// <summary>
    /// The discount percent
    /// </summary>
    private decimal _discountPercent;

    /// <summary>
    /// The discount percent set
    /// </summary>
    private bool _discountPercentSet;

    /// <summary>
    /// The code event source
    /// </summary>
    private int _codeEventSource;

    /// <summary>
    /// The code event source set
    /// </summary>
    private bool _codeEventSourceSet;

    /// <summary>
    /// The pending quantity
    /// </summary>
    private decimal _pendingQuantity;

    /// <summary>
    /// The pending quantity set
    /// </summary>
    private bool _pendingQuantitySet;

    /// <summary>
    /// The user
    /// </summary>
    private User _user;

    /// <summary>
    /// The user set
    /// </summary>
    private bool _userSet;

    /// <summary>
    /// The product
    /// </summary>
    private Product _product;

    /// <summary>
    /// The product set
    /// </summary>
    private bool _productSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the event number.
    /// </summary>
    /// <value>The event number.</value>
    [EntityElement("NUEVENTO")]
    public int EventNumber
    {
        get => _eventNumber;
        set
        {
            _eventNumber = value;
            _eventNumberSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the single number.
    /// </summary>
    /// <value>The single number.</value>
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
    /// Gets or sets the sequence.
    /// </summary>
    /// <value>The sequence.</value>
    [EntityElement("SEQUENCIA")]
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
    /// Gets or sets the event.
    /// </summary>
    /// <value>The event.</value>
    [EntityIgnore]
    public OrderHistoryEvent Event
    {
        get => _event;
        set
        {
            _event = value;
            _eventSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the event internal.
    /// </summary>
    /// <value>The event internal.</value>
    [EntityElement("EVENTO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string EventInternal
    {
        get => _event.GetInternalValue();
        set
        {
            _event = EnumExtensions.GetEnumByInternalValueAttribute<OrderHistoryEvent>(value);
            _eventSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date changed.
    /// </summary>
    /// <value>The date changed.</value>
    [EntityElement("DHALTER")]
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
    /// Gets or sets the control.
    /// </summary>
    /// <value>The control.</value>
    [EntityElement("CONTROLE")]
    public string Control
    {
        get => _control;
        set
        {
            _control = value;
            _controlSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the traded quantity.
    /// </summary>
    /// <value>The traded quantity.</value>
    [EntityElement("QTDNEG")]
    public decimal TradedQuantity
    {
        get => _tradedQuantity;
        set
        {
            _tradedQuantity = value;
            _tradedQuantitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the delivered quantity.
    /// </summary>
    /// <value>The delivered quantity.</value>
    [EntityElement("QTDENTREGUE")]
    public decimal DeliveredQuantity
    {
        get => _deliveredQuantity;
        set
        {
            _deliveredQuantity = value;
            _deliveredQuantitySet = true;
        }
    }

    /// <summary>
    /// Gets or sets the unit value.
    /// </summary>
    /// <value>The unit value.</value>
    [EntityElement("VLRUNIT")]
    public decimal UnitValue
    {
        get => _unitValue;
        set
        {
            _unitValue = value;
            _unitValueSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the discount percent.
    /// </summary>
    /// <value>The discount percent.</value>
    [EntityElement("PERCDESC")]
    public decimal DiscountPercent
    {
        get => _discountPercent;
        set
        {
            _discountPercent = value;
            _discountPercentSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code event source.
    /// </summary>
    /// <value>The code event source.</value>
    [EntityElement("NUEVENTOORIG")]
    public int CodeEventSource
    {
        get => _codeEventSource;
        set
        {
            _codeEventSource = value;
            _codeEventSourceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the pending quantity.
    /// </summary>
    /// <value>The pending quantity.</value>
    [EntityElement("QTDPENDENTE")]
    public decimal PendingQuantity
    {
        get => _pendingQuantity;
        set
        {
            _pendingQuantity = value;
            _pendingQuantitySet = true;
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

    /// <summary>
    /// Gets or sets the product.
    /// </summary>
    /// <value>The product.</value>
    [EntityReference]
    public Product Product
    {
        get => _product;
        set
        {
            _product = value;
            _productSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// The should serialize event number serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEventNumber() => _eventNumberSet;

    /// <summary>
    /// The should serialize single number serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSingleNumber() => _singleNumberSet;

    /// <summary>
    /// The should serialize sequence serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSequence() => _sequenceSet;

    /// <summary>
    /// The should serialize event serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEvent() => _eventSet;

    /// <summary>
    /// The should serialize date changed serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDateChanged() => _dateChangedSet;

    /// <summary>
    /// The should serialize code user serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeUser() => _codeUserSet;

    /// <summary>
    /// The should serialize code product serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeProduct() => _codeProductSet;

    /// <summary>
    /// The should serialize control serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeControl() => _controlSet;

    /// <summary>
    /// The should serialize traded quantity serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTradedQuantity() => _tradedQuantitySet;

    /// <summary>
    /// The should serialize delivered quantity serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDeliveredQuantity() => _deliveredQuantitySet;

    /// <summary>
    /// The should serialize unit value serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUnitValue() => _unitValueSet;

    /// <summary>
    /// The should serialize discount percent serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDiscountPercent() => _discountPercentSet;

    /// <summary>
    /// The should serialize code event source serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeEventSource() => _codeEventSourceSet;

    /// <summary>
    /// The should serialize pending quantity serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePendingQuantity() => _pendingQuantitySet;

    /// <summary>
    /// The should serialize user serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUser() => _userSet;

    /// <summary>
    /// The should serialize product serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeProduct() => _productSet;

    #endregion
}
