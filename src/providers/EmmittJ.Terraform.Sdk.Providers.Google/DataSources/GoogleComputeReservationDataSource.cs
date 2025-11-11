using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_reservation.
/// </summary>
public partial class GoogleComputeReservationDataSource : TerraformDataSource
{
    public GoogleComputeReservationDataSource(string name) : base("google_compute_reservation", name)
    {
    }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The zone where the reservation is made.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformProperty("zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Zone { get; set; }

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
    /// Duration after which the reservation will be auto-deleted by Compute Engine. Cannot be used with delete_at_time.
    /// </summary>
    [TerraformProperty("delete_after_duration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DeleteAfterDuration { get; }

    /// <summary>
    /// Absolute time in future when the reservation will be auto-deleted by Compute Engine. Timestamp is represented in RFC3339 text format.
    /// Cannot be used with delete_after_duration.
    /// </summary>
    [TerraformProperty("delete_at_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeleteAtTime { get; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// Sharing policy for reservations with Google Cloud managed services.
    /// </summary>
    [TerraformProperty("reservation_sharing_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ReservationSharingPolicy { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The share setting for reservations.
    /// </summary>
    [TerraformProperty("share_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ShareSettings { get; }

    /// <summary>
    /// Reservation for instances with specific machine shapes.
    /// </summary>
    [TerraformProperty("specific_reservation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SpecificReservation { get; }

    /// <summary>
    /// When set to true, only VMs that target this reservation by name can
    /// consume this reservation. Otherwise, it can be consumed by VMs with
    /// affinity for any reservation. Defaults to false.
    /// </summary>
    [TerraformProperty("specific_reservation_required")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> SpecificReservationRequired { get; }

    /// <summary>
    /// The status of the reservation.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
