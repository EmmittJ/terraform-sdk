using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryCapacityCommitmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_capacity_commitment resource.
/// </summary>
public class GoogleBigqueryCapacityCommitment : TerraformResource
{
    public GoogleBigqueryCapacityCommitment(string name) : base("google_bigquery_capacity_commitment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("commitment_end_time");
        SetOutput("commitment_start_time");
        SetOutput("name");
        SetOutput("state");
        SetOutput("capacity_commitment_id");
        SetOutput("edition");
        SetOutput("enforce_single_admin_project_per_org");
        SetOutput("id");
        SetOutput("location");
        SetOutput("plan");
        SetOutput("project");
        SetOutput("renewal_plan");
        SetOutput("slot_count");
    }

    /// <summary>
    /// The optional capacity commitment ID. Capacity commitment name will be generated automatically if this field is
    /// empty. This field must only contain lower case alphanumeric characters or dashes. The first and last character
    /// cannot be a dash. Max length is 64 characters. NOTE: this ID won&#39;t be kept if the capacity commitment is split
    /// or merged.
    /// </summary>
    public TerraformProperty<string> CapacityCommitmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_commitment_id");
        set => SetProperty("capacity_commitment_id", value);
    }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    public TerraformProperty<string> Edition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edition");
        set => SetProperty("edition", value);
    }

    /// <summary>
    /// If true, fail the request if another project in the organization has a capacity commitment.
    /// </summary>
    public TerraformProperty<string> EnforceSingleAdminProjectPerOrg
    {
        get => GetRequiredOutput<TerraformProperty<string>>("enforce_single_admin_project_per_org");
        set => SetProperty("enforce_single_admin_project_per_org", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Capacity commitment plan. Valid values are at https://cloud.google.com/bigquery/docs/reference/reservations/rpc/google.cloud.bigquery.reservation.v1#commitmentplan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformProperty<string> Plan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plan");
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The plan this capacity commitment is converted to after commitmentEndTime passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable for some commitment plans.
    /// </summary>
    public TerraformProperty<string> RenewalPlan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("renewal_plan");
        set => SetProperty("renewal_plan", value);
    }

    /// <summary>
    /// Number of slots in this commitment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotCount is required")]
    public required TerraformProperty<double> SlotCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("slot_count");
        set => SetProperty("slot_count", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryCapacityCommitmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    public TerraformExpression CommitmentEndTime => this["commitment_end_time"];

    /// <summary>
    /// The start of the current commitment period. It is applicable only for ACTIVE capacity commitments.
    /// </summary>
    public TerraformExpression CommitmentStartTime => this["commitment_start_time"];

    /// <summary>
    /// The resource name of the capacity commitment, e.g., projects/myproject/locations/US/capacityCommitments/123
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// State of the commitment
    /// </summary>
    public TerraformExpression State => this["state"];

}
