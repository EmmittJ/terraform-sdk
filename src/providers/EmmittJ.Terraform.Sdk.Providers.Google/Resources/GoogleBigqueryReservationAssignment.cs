using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryReservationAssignmentTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_bigquery_reservation_assignment resource.
/// </summary>
public partial class GoogleBigqueryReservationAssignment : TerraformResource
{
    public GoogleBigqueryReservationAssignment(string name) : base("google_bigquery_reservation_assignment", name)
    {
    }

    /// <summary>
    /// The resource which will use the reservation. E.g. projects/myproject, folders/123, organizations/456.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Assignee is required")]
    [TerraformProperty("assignee")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Assignee { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Types of job, which could be specified when using the reservation. Possible values: JOB_TYPE_UNSPECIFIED, PIPELINE, QUERY, CONTINUOUS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobType is required")]
    [TerraformProperty("job_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> JobType { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The reservation for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Reservation is required")]
    [TerraformProperty("reservation")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Reservation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBigqueryReservationAssignmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. The resource name of the assignment.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Assignment will remain in PENDING state if no active capacity commitment is present. It will become ACTIVE when some capacity commitment becomes active.
    /// Possible values: STATE_UNSPECIFIED, PENDING, ACTIVE
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
