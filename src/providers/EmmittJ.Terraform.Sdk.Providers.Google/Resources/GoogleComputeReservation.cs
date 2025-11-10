using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for delete_after_duration in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationDeleteAfterDurationBlock : ITerraformBlock
{
    /// <summary>
    /// Number of nanoseconds for the auto-delete duration.
    /// </summary>
    [TerraformPropertyName("nanos")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Nanos { get; set; }

    /// <summary>
    /// Number of seconds for the auto-delete duration.
    /// </summary>
    [TerraformPropertyName("seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Seconds { get; set; }

}

/// <summary>
/// Block type for reservation_sharing_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationReservationSharingPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Sharing config for all Google Cloud services. Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;DISALLOW_ALL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("service_share_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceShareType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "service_share_type");

}

/// <summary>
/// Block type for share_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationShareSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// Type of sharing for this shared-reservation Possible values: [&amp;quot;LOCAL&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("share_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ShareType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "share_type");

}

/// <summary>
/// Block type for specific_reservation in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeReservationSpecificReservationBlock : ITerraformBlock
{
    /// <summary>
    /// The number of resources that are allocated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformPropertyName("count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Count { get; set; }

    /// <summary>
    /// How many instances are in use.
    /// </summary>
    [TerraformPropertyName("in_use_count")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InUseCount => new TerraformReferenceProperty<TerraformProperty<double>>("", "in_use_count");

    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    [TerraformPropertyName("source_instance_template")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceInstanceTemplate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeReservationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_reservation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeReservation : TerraformResource
{
    public GoogleComputeReservation(string name) : base("google_compute_reservation", name)
    {
    }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    [TerraformPropertyName("delete_at_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DeleteAtTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delete_at_time");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    [TerraformPropertyName("specific_reservation_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SpecificReservationRequired { get; set; }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformPropertyName("zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Zone { get; set; }

    /// <summary>
    /// Block for delete_after_duration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteAfterDuration block(s) allowed")]
    [TerraformPropertyName("delete_after_duration")]
    public TerraformList<TerraformBlock<GoogleComputeReservationDeleteAfterDurationBlock>>? DeleteAfterDuration { get; set; } = new();

    /// <summary>
    /// Block for reservation_sharing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationSharingPolicy block(s) allowed")]
    [TerraformPropertyName("reservation_sharing_policy")]
    public TerraformList<TerraformBlock<GoogleComputeReservationReservationSharingPolicyBlock>>? ReservationSharingPolicy { get; set; } = new();

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    [TerraformPropertyName("share_settings")]
    public TerraformList<TerraformBlock<GoogleComputeReservationShareSettingsBlock>>? ShareSettings { get; set; } = new();

    /// <summary>
    /// Block for specific_reservation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpecificReservation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpecificReservation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    [TerraformPropertyName("specific_reservation")]
    public TerraformList<TerraformBlock<GoogleComputeReservationSpecificReservationBlock>>? SpecificReservation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeReservationTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
