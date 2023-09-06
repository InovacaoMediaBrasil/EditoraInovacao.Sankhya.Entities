using System;
using EditoraInovacao.Sankhya.Entities.Enums;

namespace EditoraInovacao.Sankhya.Entities.Attributes;

/// <summary>
/// The tracking status returning attribute class.
/// Use this attribute to flag an <see cref="TrackingStatus"/> field as a reason for returning the shipment
/// </summary>
/// <seealso cref="Attribute" />
[AttributeUsage(AttributeTargets.Field)]
public sealed class TrackingStatusReturningReasonAttribute : Attribute { }
