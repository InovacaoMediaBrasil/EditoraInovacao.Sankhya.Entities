// ***********************************************************************
// Assembly         : IntegracaoService.Sankhya
// Author           : Guilherme Branco Stracini
// Created          : 2016-04-11
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 17/01/2023
// ***********************************************************************
// <copyright file="Store.cs" company="Guilherme Branco Stracini ME">
//     © 2012-2023 Guilherme Branco Stracini ME, All Rights Reserved
// </copyright>
// <summary></summary>
// ************************************************************************

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Serialization;
using CrispyWaffle.Utilities;
using Sankhya.Attributes;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// A loja dto.
/// </summary>
/// <seealso cref="IUpdateable" />
/// <seealso cref="IEntity" />
[Serializer]
[Entity("LOJA")]
public class Store : IEntity, IUpdateable, IEquatable<Store>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(Store other)
    {
        if (other is null)
        {
            return false;
        }

        return ReferenceEquals(this, other)
            || _code == other._code
                && _codeSet == other._codeSet
                && string.Equals(_name, other._name, StringComparison.InvariantCultureIgnoreCase)
                && _nameSet == other._nameSet
                && _codePriceTable == other._codePriceTable
                && _codePriceTableSet == other._codePriceTableSet
                && string.Equals(
                    _initials,
                    other._initials,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _initialsSet == other._initialsSet
                && _codeSeller == other._codeSeller
                && _codeSellerSet == other._codeSellerSet
                && string.Equals(_url, other._url, StringComparison.InvariantCultureIgnoreCase)
                && _urlSet == other._urlSet
                && string.Equals(
                    _urlLogo,
                    other._urlLogo,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _urlLogoSet == other._urlLogoSet
                && string.Equals(
                    _smtpServer,
                    other._smtpServer,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _smtpServerSet == other._smtpServerSet
                && _smtpPort == other._smtpPort
                && _smtpPortSet == other._smtpPortSet
                && string.Equals(
                    _smtpUser,
                    other._smtpUser,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _smtpUserSet == other._smtpUserSet
                && string.Equals(
                    _smtpPassword,
                    other._smtpPassword,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _smtpPasswordSet == other._smtpPasswordSet
                && string.Equals(
                    _smtpSenderName,
                    other._smtpSenderName,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _smtpSenderNameSet == other._smtpSenderNameSet
                && string.Equals(
                    _telephoneSales,
                    other._telephoneSales,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _telephoneSalesSet == other._telephoneSalesSet
                && string.Equals(
                    _emailSales,
                    other._emailSales,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _emailSalesSet == other._emailSalesSet
                && string.Equals(
                    _whatsApp,
                    other._whatsApp,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _whatsAppSet == other._whatsAppSet
                && string.Equals(
                    _telephoneCustomerService,
                    other._telephoneCustomerService,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _telephoneCustomerServiceSet == other._telephoneCustomerServiceSet
                && string.Equals(
                    _emailCustomerService,
                    other._emailCustomerService,
                    StringComparison.InvariantCultureIgnoreCase
                )
                && _emailCustomerServiceSet == other._emailCustomerServiceSet
                && Equals(_seller, other._seller)
                && _sellerSet == other._sellerSet;
    }

    /// <summary>
    /// Determines whether the specified <see cref="Object" /> is equal to the current <see cref="Object" />.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object  is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
        if (obj is null)
        {
            return false;
        }

        return ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((Store)obj);
    }

    /// <summary>
    /// Serves as a hash function for a particular type.
    /// </summary>
    /// <returns>A hash code for the current <see cref="Object" />.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once MethodTooLong
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = _code;
            hashCode = (hashCode * 397) ^ _codeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _name != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_name) : 0
                );
            hashCode = (hashCode * 397) ^ _nameSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codePriceTable;
            hashCode = (hashCode * 397) ^ _codePriceTableSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _initials != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_initials)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _initialsSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeSeller;
            hashCode = (hashCode * 397) ^ _codeSellerSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (_url != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_url) : 0);
            hashCode = (hashCode * 397) ^ _urlSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _urlLogo != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_urlLogo)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _urlLogoSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _smtpServer != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_smtpServer)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _smtpServerSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _smtpPort;
            hashCode = (hashCode * 397) ^ _smtpPortSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _smtpUser != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_smtpUser)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _smtpUserSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _smtpPassword != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_smtpPassword)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _smtpPasswordSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _smtpSenderName != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_smtpSenderName)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _smtpSenderNameSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _telephoneSales != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_telephoneSales)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _telephoneSalesSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _emailSales != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_emailSales)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _emailSalesSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _whatsApp != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_whatsApp)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _whatsAppSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _telephoneCustomerService != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(
                            _telephoneCustomerService
                        )
                        : 0
                );
            hashCode = (hashCode * 397) ^ _telephoneCustomerServiceSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _emailCustomerService != null
                        ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(
                            _emailCustomerService
                        )
                        : 0
                );
            hashCode = (hashCode * 397) ^ _emailCustomerServiceSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (_seller != null ? _seller.GetHashCode() : 0);
            hashCode = (hashCode * 397) ^ _sellerSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(Store left, Store right) => Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(Store left, Store right) => !Equals(left, right);

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
    /// The name
    /// </summary>
    private string _name;

    /// <summary>
    /// The name set
    /// </summary>
    private bool _nameSet;

    /// <summary>
    /// The code price table
    /// </summary>
    private int _codePriceTable;

    /// <summary>
    /// The code price table set
    /// </summary>
    private bool _codePriceTableSet;

    /// <summary>
    /// The initials
    /// </summary>
    private string _initials;

    /// <summary>
    /// The initials set
    /// </summary>
    private bool _initialsSet;

    /// <summary>
    /// The code seller
    /// </summary>
    private int _codeSeller;

    /// <summary>
    /// The code seller set
    /// </summary>
    private bool _codeSellerSet;

    /// <summary>
    /// The URL
    /// </summary>
    private string _url;

    /// <summary>
    /// The URL set
    /// </summary>
    private bool _urlSet;

    /// <summary>
    /// The URL logo
    /// </summary>
    private string _urlLogo;

    /// <summary>
    /// The URL logo set
    /// </summary>
    private bool _urlLogoSet;

    /// <summary>
    /// The SMTP server
    /// </summary>
    private string _smtpServer;

    /// <summary>
    /// The SMTP server set
    /// </summary>
    private bool _smtpServerSet;

    /// <summary>
    /// The SMTP port
    /// </summary>
    private int _smtpPort;

    /// <summary>
    /// The SMTP port set
    /// </summary>
    private bool _smtpPortSet;

    /// <summary>
    /// The SMTP user
    /// </summary>
    private string _smtpUser;

    /// <summary>
    /// The SMTP user set
    /// </summary>
    private bool _smtpUserSet;

    /// <summary>
    /// The SMTP password
    /// </summary>
    private string _smtpPassword;

    /// <summary>
    /// The SMTP password set
    /// </summary>
    private bool _smtpPasswordSet;

    /// <summary>
    /// The SMTP sender name
    /// </summary>
    private string _smtpSenderName;

    /// <summary>
    /// The SMTP sender name set
    /// </summary>
    private bool _smtpSenderNameSet;

    /// <summary>
    /// The telephone sales
    /// </summary>
    private string _telephoneSales;

    /// <summary>
    /// The telephone sales set
    /// </summary>
    private bool _telephoneSalesSet;

    /// <summary>
    /// The email sales
    /// </summary>
    private string _emailSales;

    /// <summary>
    /// The email sales set
    /// </summary>
    private bool _emailSalesSet;

    /// <summary>
    /// The whats application
    /// </summary>
    private string _whatsApp;

    /// <summary>
    /// The whats application set
    /// </summary>
    private bool _whatsAppSet;

    /// <summary>
    /// The telephone customer service
    /// </summary>
    private string _telephoneCustomerService;

    /// <summary>
    /// The telephone customer service set
    /// </summary>
    private bool _telephoneCustomerServiceSet;

    /// <summary>
    /// The email customer service
    /// </summary>
    private string _emailCustomerService;

    /// <summary>
    /// The email customer service set
    /// </summary>
    private bool _emailCustomerServiceSet;

    /// <summary>
    /// The seller
    /// </summary>
    private Seller _seller;

    /// <summary>
    /// The seller set
    /// </summary>
    private bool _sellerSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    [EntityKey]
    [EntityElement("CODLOJA")]
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
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [EntityElement("NOMELOJA")]
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
    /// Gets or sets the code price table.
    /// </summary>
    /// <value>The code price table.</value>
    [EntityElement("CODTAB")]
    public int CodePriceTable
    {
        get => _codePriceTable;
        set
        {
            _codePriceTable = value;
            _codePriceTableSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the initials.
    /// </summary>
    /// <value>The initials.</value>
    [EntityElement("PREFIXO")]
    public string Initials
    {
        get => _initials;
        set
        {
            _initials = value;
            _initialsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code seller.
    /// </summary>
    /// <value>The code seller.</value>
    [EntityElement("CODVEND")]
    public int CodeSeller
    {
        get => _codeSeller;
        set
        {
            _codeSeller = value;
            _codeSellerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the URL.
    /// </summary>
    /// <value>The URL.</value>
    [EntityElement("URL")]
    public string Url
    {
        get => _url;
        set
        {
            _url = value;
            _urlSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the URL logo.
    /// </summary>
    /// <value>The URL logo.</value>
    [EntityElement("URLLOGO")]
    public string UrlLogo
    {
        get => _urlLogo;
        set
        {
            _urlLogo = value;
            _urlLogoSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the SMTP server.
    /// </summary>
    /// <value>The SMTP server.</value>
    [EntityElement("SERVIDORSMTP")]
    public string SmtpServer
    {
        get => _smtpServer;
        set
        {
            _smtpServer = value;
            _smtpServerSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the SMTP port.
    /// </summary>
    /// <value>The SMTP port.</value>
    [EntityElement("PORTASMTP")]
    public int SmtpPort
    {
        get => _smtpPort;
        set
        {
            _smtpPort = value;
            _smtpPortSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the SMTP user.
    /// </summary>
    /// <value>The SMTP user.</value>
    [EntityElement("USUARIOSMTP")]
    public string SmtpUser
    {
        get => _smtpUser;
        set
        {
            _smtpUser = value;
            _smtpUserSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the SMTP password.
    /// </summary>
    /// <value>The SMTP password.</value>
    [EntityElement("SENHASMTP")]
    public string SmtpPassword
    {
        get => _smtpPassword;
        set
        {
            _smtpPassword = value;
            _smtpPasswordSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the name of the SMTP sender.
    /// </summary>
    /// <value>The name of the SMTP sender.</value>
    [EntityElement("REMETENTENOME")]
    public string SmtpSenderName
    {
        get => _smtpSenderName;
        set
        {
            _smtpSenderName = value;
            _smtpSenderNameSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the telephone sales.
    /// </summary>
    /// <value>The telephone sales.</value>
    [EntityElement("TELEFONEVENDAS")]
    public string TelephoneSales
    {
        get => _telephoneSales;
        set
        {
            _telephoneSales = value;
            _telephoneSalesSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the email sales.
    /// </summary>
    /// <value>The email sales.</value>
    [EntityElement("EMAILVENDAS")]
    public string EmailSales
    {
        get => _emailSales;
        set
        {
            _emailSales = value;
            _emailSalesSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the telephone customer service.
    /// </summary>
    /// <value>The telephone customer service.</value>
    [EntityElement("TELEFONESAC")]
    public string TelephoneCustomerService
    {
        get => _telephoneCustomerService;
        set
        {
            _telephoneCustomerService = value;
            _telephoneCustomerServiceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the email customer service.
    /// </summary>
    /// <value>The email customer service.</value>
    [EntityElement("EMAILSAC")]
    public string EmailCustomerService
    {
        get => _emailCustomerService;
        set
        {
            _emailCustomerService = value;
            _emailCustomerServiceSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the whatsApp.
    /// </summary>
    /// <value>The whatsApp.</value>
    [EntityElement("WHATSAPP")]
    public string WhatsApp
    {
        get => _whatsApp;
        set
        {
            _whatsApp = value;
            _whatsAppSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the seller.
    /// </summary>
    /// <value>The seller.</value>
    [EntityReference]
    public Seller Seller
    {
        get => _seller;
        set
        {
            _seller = value;
            _sellerSet = true;
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
    /// Should the name of the serialize.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeName() => _nameSet;

    /// <summary>
    /// Should the serialize code price table.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePriceTable() => _codePriceTableSet;

    /// <summary>
    /// Should the serialize initials.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeInitials() => _initialsSet;

    /// <summary>
    /// Should the serialize code seller.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeSeller() => _codeSellerSet;

    /// <summary>
    /// Should the serialize URL.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUrl() => _urlSet;

    /// <summary>
    /// The should serialize url logo serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUrlLogo() => _urlLogoSet;

    /// <summary>
    /// Should the serialize SMTP server.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSmtpServer() => _smtpServerSet;

    /// <summary>
    /// Should the serialize SMTP port.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSmtpPort() => _smtpPortSet;

    /// <summary>
    /// Should the serialize SMTP user.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSmtpUser() => _smtpUserSet;

    /// <summary>
    /// Should the serialize SMTP password.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSmtpPassword() => _smtpPasswordSet;

    /// <summary>
    /// Should the name of the serialize SMTP sender.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSmtpSenderName() => _smtpSenderNameSet;

    /// <summary>
    /// Should the serialize telephone sales.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTelephoneSales() => _telephoneSalesSet;

    /// <summary>
    /// The should serialize email sales serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEmailSales() => _emailSalesSet;

    /// <summary>
    /// Should the serialize telephone customer service.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTelephoneCustomerService() => _telephoneCustomerServiceSet;

    /// <summary>
    /// Should the serialize email customer service.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEmailCustomerService() => _emailCustomerServiceSet;

    /// <summary>
    /// The should serialize whatsApp serialization helper method
    /// </summary>
    /// <returns>Returns <c>true</c> when the field should be serialized, false otherwise</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeWhatsApp() => _whatsAppSet;

    /// <summary>
    /// Should the serialize seller.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSeller() => _sellerSet;

    #endregion
}
