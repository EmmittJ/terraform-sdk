using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryCapacityCommitmentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_bigquery_capacity_commitment resource.
/// </summary>
public partial class GoogleBigqueryCapacityCommitment : TerraformResource
{
    public GoogleBigqueryCapacityCommitment(string name) : base("google_bigquery_capacity_commitment", name)
    {
    }

    /// <summary>
    /// The optional capacity commitment ID. Capacity commitment name will be generated automatically if this field is
    /// empty. This field must only contain lower case alphanumeric characters or dashes. The first and last character
    /// cannot be a dash. Max length is 64 characters. NOTE: this ID won&#39;t be kept if the capacity commitment is split
    /// or merged.
    /// </summary>
    [TerraformProperty("capacity_commitment_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CapacityCommitmentId { get; set; }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    [TerraformProperty("edition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Edition { get; set; }

    /// <summary>
    /// If true, fail the request if another project in the organization has a capacity commitment.
    /// </summary>
    [TerraformProperty("enforce_single_admin_project_per_org")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EnforceSingleAdminProjectPerOrg { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Capacity commitment plan. Valid values are at https://cloud.google.com/bigquery/docs/reference/reservations/rpc/google.cloud.bigquery.reservation.v1#commitmentplan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [TerraformProperty("plan")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Plan { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The plan this capacity commitment is converted to after commitmentEndTime passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable for some commitment plans.
    /// </summary>
    [TerraformProperty("renewal_plan")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RenewalPlan { get; set; }

    /// <summary>
    /// Number of slots in this commitment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCount is required")]
    [TerraformProperty("slot_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SlotCount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigqueryCapacityCommitmentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    [TerraformProperty("commitment_end_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CommitmentEndTime { get; }

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    [TerraformProperty("commitment_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CommitmentStartTime { get; }

    /// <summary>
    /// The resource name of the capacity commitment, e.g., projects/myproject/locations/US/capacityCommitments/123
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// State of the commitment
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
