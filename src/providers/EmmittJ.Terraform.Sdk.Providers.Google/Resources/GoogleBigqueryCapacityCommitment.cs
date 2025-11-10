using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryCapacityCommitmentTimeoutsBlock : ITerraformBlock
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
/// Manages a google_bigquery_capacity_commitment resource.
/// </summary>
public class GoogleBigqueryCapacityCommitment : TerraformResource
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
    [TerraformPropertyName("capacity_commitment_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CapacityCommitmentId { get; set; }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    [TerraformPropertyName("edition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Edition { get; set; }

    /// <summary>
    /// If true, fail the request if another project in the organization has a capacity commitment.
    /// </summary>
    [TerraformPropertyName("enforce_single_admin_project_per_org")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnforceSingleAdminProjectPerOrg { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// Capacity commitment plan. Valid values are at https://cloud.google.com/bigquery/docs/reference/reservations/rpc/google.cloud.bigquery.reservation.v1#commitmentplan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [TerraformPropertyName("plan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Plan { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The plan this capacity commitment is converted to after commitmentEndTime passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable for some commitment plans.
    /// </summary>
    [TerraformPropertyName("renewal_plan")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RenewalPlan { get; set; }

    /// <summary>
    /// Number of slots in this commitment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCount is required")]
    [TerraformPropertyName("slot_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> SlotCount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryCapacityCommitmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    [TerraformPropertyName("commitment_end_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CommitmentEndTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "commitment_end_time");

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    [TerraformPropertyName("commitment_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CommitmentStartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "commitment_start_time");

    /// <summary>
    /// The resource name of the capacity commitment, e.g., projects/myproject/locations/US/capacityCommitments/123
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// State of the commitment
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
