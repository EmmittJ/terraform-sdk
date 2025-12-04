using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBigqueryCapacityCommitment.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryCapacityCommitmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_capacity_commitment Terraform resource.
/// Manages a google_bigquery_capacity_commitment resource.
/// </summary>
public partial class GoogleBigqueryCapacityCommitment(string name) : TerraformResource("google_bigquery_capacity_commitment", name)
{
    /// <summary>
    /// The optional capacity commitment ID. Capacity commitment name will be generated automatically if this field is
    /// empty. This field must only contain lower case alphanumeric characters or dashes. The first and last character
    /// cannot be a dash. Max length is 64 characters. NOTE: this ID won&#39;t be kept if the capacity commitment is split
    /// or merged.
    /// </summary>
    public TerraformValue<string>? CapacityCommitmentId
    {
        get => GetArgument<TerraformValue<string>>("capacity_commitment_id");
        set => SetArgument("capacity_commitment_id", value);
    }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    public TerraformValue<string>? Edition
    {
        get => GetArgument<TerraformValue<string>>("edition");
        set => SetArgument("edition", value);
    }

    /// <summary>
    /// If true, fail the request if another project in the organization has a capacity commitment.
    /// </summary>
    public TerraformValue<string>? EnforceSingleAdminProjectPerOrg
    {
        get => GetArgument<TerraformValue<string>>("enforce_single_admin_project_per_org");
        set => SetArgument("enforce_single_admin_project_per_org", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Capacity commitment plan. Valid values are at https://cloud.google.com/bigquery/docs/reference/reservations/rpc/google.cloud.bigquery.reservation.v1#commitmentplan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformValue<string> Plan
    {
        get => GetArgument<TerraformValue<string>>("plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The plan this capacity commitment is converted to after commitmentEndTime passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable for some commitment plans.
    /// </summary>
    public TerraformValue<string>? RenewalPlan
    {
        get => GetArgument<TerraformValue<string>>("renewal_plan");
        set => SetArgument("renewal_plan", value);
    }

    /// <summary>
    /// Number of slots in this commitment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCount is required")]
    public required TerraformValue<double> SlotCount
    {
        get => GetArgument<TerraformValue<double>>("slot_count");
        set => SetArgument("slot_count", value);
    }

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    public TerraformValue<string> CommitmentEndTime
        => AsReference("commitment_end_time");

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    public TerraformValue<string> CommitmentStartTime
        => AsReference("commitment_start_time");

    /// <summary>
    /// The resource name of the capacity commitment, e.g., projects/myproject/locations/US/capacityCommitments/123
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// State of the commitment
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryCapacityCommitmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryCapacityCommitmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
