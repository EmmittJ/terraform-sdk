using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for delete_after_duration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeReservationDeleteAfterDurationBlock() : TerraformBlock("delete_after_duration")
{
    /// <summary>
    /// Number of nanoseconds for the auto-delete duration.
    /// </summary>
    [TerraformProperty("nanos")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Nanos { get; set; }

    /// <summary>
    /// Number of seconds for the auto-delete duration.
    /// </summary>
    [TerraformProperty("seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Seconds { get; set; }

}

/// <summary>
/// Block type for reservation_sharing_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeReservationReservationSharingPolicyBlock() : TerraformBlock("reservation_sharing_policy")
{
    /// <summary>
    /// Sharing config for all Google Cloud services. Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;DISALLOW_ALL&amp;quot;]
    /// </summary>
    [TerraformProperty("service_share_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceShareType { get; set; }

}

/// <summary>
/// Block type for share_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeReservationShareSettingsBlock() : TerraformBlock("share_settings")
{
    /// <summary>
    /// Type of sharing for this shared-reservation Possible values: [&amp;quot;LOCAL&amp;quot;, &amp;quot;SPECIFIC_PROJECTS&amp;quot;]
    /// </summary>
    [TerraformProperty("share_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ShareType { get; set; }

}

/// <summary>
/// Block type for specific_reservation in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeReservationSpecificReservationBlock() : TerraformBlock("specific_reservation")
{
    /// <summary>
    /// The number of resources that are allocated.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Count is required")]
    [TerraformProperty("count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Count { get; set; }


    /// <summary>
    /// Specifies the instance template to create the reservation. If you use this field, you must exclude the
    /// instanceProperties field.
    /// </summary>
    [TerraformProperty("source_instance_template")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceInstanceTemplate { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeReservationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_reservation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeReservation : TerraformResource
{
    public GoogleComputeReservation(string name) : base("google_compute_reservation", name)
    {
    }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    [TerraformProperty("delete_at_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeleteAtTime { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    [TerraformProperty("specific_reservation_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SpecificReservationRequired { get; set; }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformProperty("zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for delete_after_duration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteAfterDuration block(s) allowed")]
    [TerraformProperty("delete_after_duration")]
    public TerraformList<GoogleComputeReservationDeleteAfterDurationBlock> DeleteAfterDuration { get; set; } = new();

    /// <summary>
    /// Block for reservation_sharing_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationSharingPolicy block(s) allowed")]
    [TerraformProperty("reservation_sharing_policy")]
    public TerraformList<GoogleComputeReservationReservationSharingPolicyBlock> ReservationSharingPolicy { get; set; } = new();

    /// <summary>
    /// Block for share_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ShareSettings block(s) allowed")]
    [TerraformProperty("share_settings")]
    public TerraformList<GoogleComputeReservationShareSettingsBlock> ShareSettings { get; set; } = new();

    /// <summary>
    /// Block for specific_reservation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpecificReservation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpecificReservation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpecificReservation block(s) allowed")]
    [TerraformProperty("specific_reservation")]
    public required TerraformList<GoogleComputeReservationSpecificReservationBlock> SpecificReservation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeReservationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Full or partial URL to a parent commitment. This field displays for
    /// reservations that are tied to a commitment.
    /// </summary>
    [TerraformProperty("commitment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Commitment { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
