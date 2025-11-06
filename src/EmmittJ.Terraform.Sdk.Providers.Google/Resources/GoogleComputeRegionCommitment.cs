using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_commitment resource.
/// </summary>
public class GoogleComputeRegionCommitment : TerraformResource
{
    public GoogleComputeRegionCommitment(string name) : base("google_compute_region_commitment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("commitment_id");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("end_timestamp");
        this.DeclareOutput("self_link");
        this.DeclareOutput("start_timestamp");
        this.DeclareOutput("status");
        this.DeclareOutput("status_message");
    }

    /// <summary>
    /// Specifies whether to enable automatic renewal for the commitment.
    /// The default value is false if not specified.
    /// If the field is set to true, the commitment will be automatically renewed for either
    /// one or three years according to the terms of the existing commitment.
    /// </summary>
    public bool? AutoRenew
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_renew")?.Value;
        set => this.WithProperty("auto_renew", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The category of the commitment. Category MACHINE specifies commitments composed of
    /// machine resources such as VCPU or MEMORY, listed in resources. Category LICENSE
    /// specifies commitments composed of software licenses, listed in licenseResources.
    /// Note that only MACHINE commitments should have a Type specified. Possible values: [&amp;quot;LICENSE&amp;quot;, &amp;quot;MACHINE&amp;quot;]
    /// </summary>
    public string? Category
    {
        get => GetProperty<TerraformLiteralProperty<string>>("category")?.Value;
        set => this.WithProperty("category", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies the already existing reservations to attach to the Commitment.
    /// </summary>
    public string? ExistingReservations
    {
        get => GetProperty<TerraformLiteralProperty<string>>("existing_reservations")?.Value;
        set => this.WithProperty("existing_reservations", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Name of the resource. The name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plan for this commitment, which determines duration and discount rate.
    /// The currently supported plans are TWELVE_MONTH (1 year), and THIRTY_SIX_MONTH (3 years). Possible values: [&amp;quot;TWELVE_MONTH&amp;quot;, &amp;quot;THIRTY_SIX_MONTH&amp;quot;]
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
    /// URL of the region where this commitment may be used.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of commitment, which affects the discount rate and the eligible resources.
    /// The type could be one of the following value: &#39;MEMORY_OPTIMIZED&#39;, &#39;ACCELERATOR_OPTIMIZED&#39;,
    /// &#39;GENERAL_PURPOSE_N1&#39;, &#39;GENERAL_PURPOSE_N2&#39;, &#39;GENERAL_PURPOSE_N2D&#39;, &#39;GENERAL_PURPOSE_E2&#39;,
    /// &#39;GENERAL_PURPOSE_T2D&#39;, &#39;GENERAL_PURPOSE_C3&#39;, &#39;COMPUTE_OPTIMIZED_C2&#39;, &#39;COMPUTE_OPTIMIZED_C2D&#39; and
    /// &#39;GRAPHICS_OPTIMIZED_G2&#39;
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Unique identifier for the resource.
    /// </summary>
    public TerraformExpression CommitmentId => this["commitment_id"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Commitment end time in RFC3339 text format.
    /// </summary>
    public TerraformExpression EndTimestamp => this["end_timestamp"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Commitment start time in RFC3339 text format.
    /// </summary>
    public TerraformExpression StartTimestamp => this["start_timestamp"];

    /// <summary>
    /// Status of the commitment with regards to eventual expiration
    /// (each commitment has an end date defined).
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// A human-readable explanation of the status.
    /// </summary>
    public TerraformExpression StatusMessage => this["status_message"];

}
