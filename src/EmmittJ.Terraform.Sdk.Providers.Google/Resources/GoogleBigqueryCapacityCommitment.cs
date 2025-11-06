using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("commitment_end_time");
        this.DeclareOutput("commitment_start_time");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The optional capacity commitment ID. Capacity commitment name will be generated automatically if this field is
    /// empty. This field must only contain lower case alphanumeric characters or dashes. The first and last character
    /// cannot be a dash. Max length is 64 characters. NOTE: this ID won&#39;t be kept if the capacity commitment is split
    /// or merged.
    /// </summary>
    public string? CapacityCommitmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_commitment_id")?.Value;
        set => this.WithProperty("capacity_commitment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edition type. Valid values are STANDARD, ENTERPRISE, ENTERPRISE_PLUS
    /// </summary>
    public string? Edition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edition")?.Value;
        set => this.WithProperty("edition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, fail the request if another project in the organization has a capacity commitment.
    /// </summary>
    public string? EnforceSingleAdminProjectPerOrg
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enforce_single_admin_project_per_org")?.Value;
        set => this.WithProperty("enforce_single_admin_project_per_org", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Capacity commitment plan. Valid values are at https://cloud.google.com/bigquery/docs/reference/reservations/rpc/google.cloud.bigquery.reservation.v1#commitmentplan
    /// </summary>
    public string? Plan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan")?.Value;
        set => this.WithProperty("plan", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plan this capacity commitment is converted to after commitmentEndTime passes. Once the plan is changed, committed period is extended according to commitment plan. Only applicable for some commitment plans.
    /// </summary>
    public string? RenewalPlan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("renewal_plan")?.Value;
        set => this.WithProperty("renewal_plan", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Number of slots in this commitment.
    /// </summary>
    public double? SlotCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("slot_count")?.Value;
        set => this.WithProperty("slot_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
