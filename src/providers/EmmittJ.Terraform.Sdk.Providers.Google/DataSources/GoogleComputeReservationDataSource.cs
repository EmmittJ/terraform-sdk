using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_reservation.
/// </summary>
public class GoogleComputeReservationDataSource : TerraformDataSource
{
    public GoogleComputeReservationDataSource(string name) : base("google_compute_reservation", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformPropertyName("zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Zone { get; set; }

    /// <summary>
    /// Full or partial URL to a parent commitment. This field displays for
    /// reservations that are tied to a commitment.
    /// </summary>
    [TerraformPropertyName("commitment")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Commitment => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "commitment");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
    /// </summary>
    [TerraformPropertyName("delete_after_duration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DeleteAfterDuration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "delete_after_duration");

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    [TerraformPropertyName("delete_at_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeleteAtTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_at_time");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Sharing policy for reservations with Google Cloud managed services.
    /// </summary>
    [TerraformPropertyName("reservation_sharing_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReservationSharingPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "reservation_sharing_policy");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The share setting for reservations.
    /// </summary>
    [TerraformPropertyName("share_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ShareSettings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "share_settings");

    /// <summary>
    /// Reservation for instances with specific machine shapes.
    /// </summary>
    [TerraformPropertyName("specific_reservation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SpecificReservation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "specific_reservation");

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    [TerraformPropertyName("specific_reservation_required")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SpecificReservationRequired => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "specific_reservation_required");

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
