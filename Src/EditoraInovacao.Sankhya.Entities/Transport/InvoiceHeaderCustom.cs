using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using CrispyWaffle.Extensions;
using EditoraInovacao.Sankhya.Entities.Enums;
using Sankhya.Attributes;
using Sankhya.Helpers;
using Sankhya.Transport;

namespace EditoraInovacao.Sankhya.Entities.Transport;

/// <summary>
/// Class InvoiceHeader. This class cannot be inherited.
/// </summary>
/// <seealso cref="GenericServiceEntity" />
/// <seealso cref="GenericServiceEntity" />
[Entity("CabecalhoNota")]
public class InvoiceHeaderCustom : InvoiceHeader, IEquatable<InvoiceHeaderCustom>
{
    #region Equality members

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once CyclomaticComplexity
    public bool Equals(InvoiceHeaderCustom other)
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
            && _codeHowKnow == other._codeHowKnow
            && _codeHowKnowSet == other._codeHowKnowSet
            && _codePartnerRoyalties == other._codePartnerRoyalties
            && _codePartnerRoyaltiesSet == other._codePartnerRoyaltiesSet
            && _codeResend == other._codeResend
            && _codeResendSet == other._codeResendSet
            && _codeTransportType == other._codeTransportType
            && _codeTransportTypeSet == other._codeTransportTypeSet
            && string.Equals(
                _creditCardAuthorizationCode,
                other._creditCardAuthorizationCode,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _creditCardAuthorizationCodeSet == other._creditCardAuthorizationCodeSet
            && string.Equals(
                _creditCardLastFourDigits,
                other._creditCardLastFourDigits,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _creditCardLastFourDigitsSet == other._creditCardLastFourDigitsSet
            && string.Equals(
                _creditCardTransaction,
                other._creditCardTransaction,
                StringComparison.InvariantCultureIgnoreCase
            )
            && _creditCardTransactionSet == other._creditCardTransactionSet
            && _originalOrder == other._originalOrder
            && _originalOrderSet == other._originalOrderSet
            && _paymentStatus == other._paymentStatus
            && _paymentStatusSet == other._paymentStatusSet;
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

        return Equals((InvoiceHeaderCustom)obj);
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
    // ReSharper disable once FunctionComplexityOverflow
    // ReSharper disable once MethodTooLong
    [SuppressMessage("ReSharper", "NonReadonlyMemberInGetHashCode")]
    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = base.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeHowKnow;
            hashCode = (hashCode * 397) ^ _codeHowKnowSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codePartnerRoyalties;
            hashCode = (hashCode * 397) ^ _codePartnerRoyaltiesSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeResend;
            hashCode = (hashCode * 397) ^ _codeResendSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _codeTransportType;
            hashCode = (hashCode * 397) ^ _codeTransportTypeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _creditCardAuthorizationCode != null
                        ? StringComparer
                            .InvariantCultureIgnoreCase
                            .GetHashCode(_creditCardAuthorizationCode)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _creditCardAuthorizationCodeSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _creditCardLastFourDigits != null
                        ? StringComparer
                            .InvariantCultureIgnoreCase
                            .GetHashCode(_creditCardLastFourDigits)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _creditCardLastFourDigitsSet.GetHashCode();
            hashCode =
                (hashCode * 397)
                ^ (
                    _creditCardTransaction != null
                        ? StringComparer
                            .InvariantCultureIgnoreCase
                            .GetHashCode(_creditCardTransaction)
                        : 0
                );
            hashCode = (hashCode * 397) ^ _creditCardTransactionSet.GetHashCode();
            hashCode = (hashCode * 397) ^ _originalOrder;
            hashCode = (hashCode * 397) ^ _originalOrderSet.GetHashCode();
            hashCode = (hashCode * 397) ^ (int)_paymentStatus;
            hashCode = (hashCode * 397) ^ _paymentStatusSet.GetHashCode();
            return hashCode;
        }
    }

    /// <summary>
    /// Implements the ==.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator ==(InvoiceHeaderCustom left, InvoiceHeaderCustom right) =>
        Equals(left, right);

    /// <summary>
    /// Implements the !=.
    /// </summary>
    /// <param name="left">The left.</param>
    /// <param name="right">The right.</param>
    /// <returns>The result of the operator.</returns>
    public static bool operator !=(InvoiceHeaderCustom left, InvoiceHeaderCustom right) =>
        !Equals(left, right);

    #endregion

    #region Private Members

    /// <summary>
    /// The original order
    /// </summary>
    private int _originalOrder;

    /// <summary>
    /// The original order set
    /// </summary>
    private bool _originalOrderSet;

    /// <summary>
    /// The code partner royalties
    /// </summary>
    private int _codePartnerRoyalties;

    /// <summary>
    /// The code partner royalties set
    /// </summary>
    private bool _codePartnerRoyaltiesSet;

    /// <summary>
    /// The code how know
    /// </summary>
    private int _codeHowKnow;

    /// <summary>
    /// The code how know set
    /// </summary>
    private bool _codeHowKnowSet;

    /// <summary>
    /// The credit card last four digits
    /// </summary>
    private string _creditCardLastFourDigits;

    /// <summary>
    /// The credit card last four digits set
    /// </summary>
    private bool _creditCardLastFourDigitsSet;

    /// <summary>
    /// The credit card transaction
    /// </summary>
    private string _creditCardTransaction;

    /// <summary>
    /// The credit card transaction set
    /// </summary>
    private bool _creditCardTransactionSet;

    /// <summary>
    /// The credit card authorization code
    /// </summary>
    private string _creditCardAuthorizationCode;

    /// <summary>
    /// The credit card authorization code set
    /// </summary>
    private bool _creditCardAuthorizationCodeSet;

    /// <summary>
    /// The code transport type
    /// </summary>
    private int _codeTransportType;

    /// <summary>
    /// The code transport type set
    /// </summary>
    private bool _codeTransportTypeSet;

    /// <summary>
    /// The code resend
    /// </summary>
    private int _codeResend;

    /// <summary>
    /// The code resend set
    /// </summary>
    private bool _codeResendSet;

    /// <summary>
    /// The payment status
    /// </summary>
    private PaymentStatus _paymentStatus;

    /// <summary>
    /// The payment status set
    /// </summary>
    private bool _paymentStatusSet;

    /// <summary>
    /// The seller
    /// </summary>
    private SellerCustom _seller;

    /// <summary>
    /// The seller set
    /// </summary>
    private bool _sellerSet;

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets or sets the code partner royalties.
    /// </summary>
    /// <value>The code partner royalties.</value>
    [EntityElement("AD_CODPARCROYALTIES")]
    public int CodePartnerRoyalties
    {
        get => _codePartnerRoyalties;
        set
        {
            _codePartnerRoyalties = value;
            _codePartnerRoyaltiesSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the original order.
    /// </summary>
    /// <value>The original order.</value>
    [EntityElement("AD_PEDORIGINAL")]
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
    /// Gets or sets the payment status.
    /// </summary>
    /// <value>The payment status.</value>
    [EntityIgnore]
    public PaymentStatus PaymentStatus
    {
        get => _paymentStatus;
        set
        {
            _paymentStatus = value;
            _paymentStatusSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code how know.
    /// </summary>
    /// <value>The code how know.</value>
    [EntityElement("AD_CODCOMOSOUBE")]
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
    /// Gets or sets the credit card last four digits.
    /// </summary>
    /// <value>The credit card last four digits.</value>
    [EntityElement("AD_NUROCARTAO")]
    public string CreditCardLastFourDigits
    {
        get => _creditCardLastFourDigits;
        set
        {
            _creditCardLastFourDigits = value;
            _creditCardLastFourDigitsSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the credit card transaction.
    /// </summary>
    /// <value>The credit card transaction.</value>
    [EntityElement("AD_DOCCARTAO")]
    public string CreditCardTransaction
    {
        get => _creditCardTransaction;
        set
        {
            _creditCardTransaction = value;
            _creditCardTransactionSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the credit card authorization code.
    /// </summary>
    /// <value>The credit card authorization code.</value>
    [EntityElement("AD_CODAUT")]
    public string CreditCardAuthorizationCode
    {
        get => _creditCardAuthorizationCode;
        set
        {
            _creditCardAuthorizationCode = value;
            _creditCardAuthorizationCodeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the type of the code transport.
    /// </summary>
    /// <value>The type of the code transport.</value>
    [EntityElement("AD_IDMOD")]
    public int CodeTransportType
    {
        get => _codeTransportType;
        set
        {
            _codeTransportType = value;
            _codeTransportTypeSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the code resend.
    /// </summary>
    /// <value>The code resend.</value>
    [EntityElement("AD_CODREENVIO")]
    public int CodeResend
    {
        get => _codeResend;
        set
        {
            _codeResend = value;
            _codeResendSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the payment status internal.
    /// </summary>
    /// <value>The payment status internal.</value>
    [EntityElement("AD_STATUSPGTO")]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string PaymentStatusInternal
    {
        get => _paymentStatus.GetInternalValue();
        set
        {
            _paymentStatus = EnumExtensions.GetEnumByInternalValueAttribute<PaymentStatus>(value);
            _paymentStatusSet = true;
        }
    }

    /// <summary>
    /// Gets or sets the seller.
    /// </summary>
    /// <value>The seller.</value>
    [EntityReference]
    public new SellerCustom Seller
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
    /// Should the serialize code partner royalties.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodePartnerRoyalties() => _codePartnerRoyaltiesSet;

    /// <summary>
    /// Should the serialize original order.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeOriginalOrder() => _originalOrderSet;

    /// <summary>
    /// Should the serialize code how know.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeHowKnow() => _codeHowKnowSet;

    /// <summary>
    /// Should the serialize credit card last four digits.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCreditCardLastFourDigits() => _creditCardLastFourDigitsSet;

    /// <summary>
    /// Should the serialize credit card transaction.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCreditCardTransaction() => _creditCardTransactionSet;

    /// <summary>
    /// Should the serialize credit card authorization code.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCreditCardAuthorizationCode() => _creditCardAuthorizationCodeSet;

    /// <summary>
    /// Should the type of the serialize code transport.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeTransportType() => _codeTransportTypeSet;

    /// <summary>
    /// Should the serialize code resend.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCodeResend() => _codeResendSet;

    /// <summary>
    /// Should the serialize payment status.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePaymentStatus() => _paymentStatusSet;

    /// <summary>
    /// Should the serialize seller.
    /// </summary>
    /// <returns>Boolean.</returns>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new bool ShouldSerializeSeller() => _sellerSet;

    #endregion
}
