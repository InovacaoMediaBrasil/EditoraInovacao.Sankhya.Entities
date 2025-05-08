// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya.Entities
// Author           : Guilherme Branco Stracini
// Created          : 18/04/2020
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="LabelMercadoLivre.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class LabelMercadoLivre.
/// Implements the <see cref="IEntity" />
/// Implements the <see cref="System.IEquatable{LabelMercadoLivre}" />
/// </summary>
/// <seealso cref="IEntity" />
/// <seealso cref="System.IEquatable{LabelMercadoLivre}" />
[Entity("ETIQUETASMLB")]
public class LabelMercadoLivre : IEntity, IEquatable<LabelMercadoLivre>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns><see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
    public bool Equals(LabelMercadoLivre other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _originalOrder == other._originalOrder
                && _originalOrderSet == other._originalOrderSet
                && _serviceOrder == other._serviceOrder
                && _serviceOrderSet == other._serviceOrderSet
                && _fiscalInvoice == other._fiscalInvoice
                && _fiscalInvoiceSet == other._fiscalInvoiceSet
                && string.Equals(
                    _trackingCode,
                    other._trackingCode,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _trackingCodeSet == other._trackingCodeSet
                && _codeTransportMode == other._codeTransportMode
                && _codeTransportModeSet == other._codeTransportModeSet
                && _date.Equals(other._date)
                && _dateSet == other._dateSet
                && Equals(_transportMode, other._transportMode)
                && _transportModeSet == other._transportModeSet;
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

        return ReferenceEquals(this, obj) || obj is LabelMercadoLivre livre && Equals(livre);
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
            var hashCode = _originalOrder;
            hashCode = (hashCode * 397) ^ _originalOrderSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _serviceOrder;
            hashCode = (hashCode * 397) ^ _serviceOrderSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _fiscalInvoice;
            hashCode = (hashCode * 397) ^ _fiscalInvoiceSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _trackingCode != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_trackingCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _trackingCodeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTransportMode;
            hashCode = (hashCode * 397) ^ _codeTransportModeSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _date.GetHashCode();
            hashCode = (hashCode * 397) ^ _dateSet.GetHashCode();
            hashCode =
                (hashCode * 397) ^ (_transportMode != null ? _transportMode.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _transportModeSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the == operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(LabelMercadoLivre left, LabelMercadoLivre right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the != operator.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(LabelMercadoLivre left, LabelMercadoLivre right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The original order
    /// </summary>
    /// <summary>
    /// The original order
    /// </summary>
    private int _originalOrder;

    /// <summary>
    /// The original order set
    /// </summary>
    /// <summary>
    /// The original order set
    /// </summary>
    private bool _originalOrderSet;

    /// <summary>
    /// The service order
    /// </summary>
    /// <summary>
    /// The service order
    /// </summary>
    private int _serviceOrder;

    /// <summary>
    /// The service order set
    /// </summary>
    /// <summary>
    /// The service order set
    /// </summary>
    private bool _serviceOrderSet;

    /// <summary>
    /// The fiscal invoice
    /// </summary>
    /// <summary>
    /// The fiscal invoice
    /// </summary>
    private int _fiscalInvoice;

    /// <summary>
    /// The fiscal invoice set
    /// </summary>
    /// <summary>
    /// The fiscal invoice set
    /// </summary>
    private bool _fiscalInvoiceSet;

    /// <summary>
    /// The tracking code
    /// </summary>
    /// <summary>
    /// The tracking code
    /// </summary>
    private string _trackingCode;

    /// <summary>
    /// The tracking code set
    /// </summary>
    /// <summary>
    /// The tracking code set
    /// </summary>
    private bool _trackingCodeSet;

    /// <summary>
    /// The code transport mode
    /// </summary>
    /// <summary>
    /// The code transport mode
    /// </summary>
    private int _codeTransportMode;

    /// <summary>
    /// The code transport mode set
    /// </summary>
    /// <summary>
    /// The code transport mode set
    /// </summary>
    private bool _codeTransportModeSet;

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
    /// The transport mode
    /// </summary>
    /// <summary>
    /// The transport mode
    /// </summary>
    private TransportMode _transportMode;

    /// <summary>
    /// The transport mode set
    /// </summary>
    /// <summary>
    /// The transport mode set
    /// </summary>
    private bool _transportModeSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets t he original order identifier
    /// </summary>
    /// <value>
    /// Original order identifier
    /// </value>
    /// <summary>
    /// Gets or sets the original order.
    /// </summary>
    /// <value>The original order.</value>
    [EntityElement("PEDORIGINAL")]
    [EntityKey]
    public int OriginalOrder
    {
        get => _originalOrder;
        set
        {
            _originalOrder = value;
            _originalOrderSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the service order
    /// </summary>
    /// <value>
    /// The service order
    /// </value>
    /// <summary>
    /// Gets or sets the service order.
    /// </summary>
    /// <value>The service order.</value>
    [EntityElement("PLP")]
    public int ServiceOrder
    {
        get => _serviceOrder;
        set
        {
            _serviceOrder = value;
            _serviceOrderSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the fiscal invoice
    /// </summary>
    /// <value>
    /// The fiscal value
    /// </value>
    /// <summary>
    /// Gets or sets the fiscal invoice.
    /// </summary>
    /// <value>The fiscal invoice.</value>
    [EntityElement("NF")]
    public int FiscalInvoice
    {
        get => _fiscalInvoice;
        set
        {
            _fiscalInvoice = value;
            _fiscalInvoiceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the tracking code
    /// </summary>
    /// <value>
    /// The tracking code
    /// </value>
    /// <summary>
    /// Gets or sets the tracking code.
    /// </summary>
    /// <value>The tracking code.</value>
    [EntityElement("CODENVIO")]
    public string TrackingCode
    {
        get => _trackingCode;
        set
        {
            _trackingCode = value;
            _trackingCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code transport mode
    /// </summary>
    /// <value>The code transport mode</value>
    [EntityElement("CODMODTRANSP")]
    public int CodeTransportMode
    {
        get => _codeTransportMode;
        set
        {
            _codeTransportMode = value;
            _codeTransportModeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the date
    /// </summary>
    /// <value>The date</value>
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
    /// Gets or sets the transport mode
    /// </summary>
    /// <value><see cref="TransportMode" /></value>
    [EntityReference]
    public TransportMode TransportMode
    {
        get => _transportMode;
        set
        {
            _transportMode = value;
            _transportModeSet = true;
        }
    }

    #endregion

    #region Serializer Helpers

    /// <summary>
    /// The should serialize original order serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOriginalOrder() => _originalOrderSet;

    /// <summary>
    /// The should serialize service order serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeServiceOrder() => _serviceOrderSet;

    /// <summary>
    /// The should serialize fiscal invoice serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFiscalInvoice() => _fiscalInvoiceSet;

    /// <summary>
    /// The should serialize tracking code serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTrackingCode() => _trackingCodeSet;

    /// <summary>
    /// The should serialize code transport mode serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTransportMode() => _codeTransportModeSet;

    /// <summary>
    /// The should serialize date serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDate() => _dateSet;

    /// <summary>
    /// The should serialize transport mode serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTransportMode() => _transportModeSet;

    #endregion
}
