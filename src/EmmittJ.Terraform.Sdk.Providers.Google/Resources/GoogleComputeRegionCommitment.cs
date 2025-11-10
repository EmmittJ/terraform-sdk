using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for license_resource in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionCommitmentLicenseResourceBlock : TerraformBlock
{
    /// <summary>
    /// The number of licenses purchased.
    /// </summary>
    public TerraformProperty<string>? Amount
    {
        get => GetProperty<TerraformProperty<string>>("amount");
        set => WithProperty("amount", value);
    }

    /// <summary>
    /// Specifies the core range of the instance for which this license applies.
    /// </summary>
    public TerraformProperty<string>? CoresPerLicense
    {
        get => GetProperty<TerraformProperty<string>>("cores_per_license");
        set => WithProperty("cores_per_license", value);
    }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "License is required")]
    public required TerraformProperty<string> License
    {
        get => GetProperty<TerraformProperty<string>>("license");
        set => WithProperty("license", value);
    }

}

/// <summary>
/// Block type for resources in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionCommitmentResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Name of the accelerator type resource. Applicable only when the type is ACCELERATOR.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => WithProperty("accelerator_type", value);
    }

    /// <summary>
    /// The amount of the resource purchased (in a type-dependent unit,
    /// such as bytes). For vCPUs, this can just be an integer. For memory,
    /// this must be provided in MB. Memory must be a multiple of 256 MB,
    /// with up to 6.5GB of memory per every vCPU.
    /// </summary>
    public TerraformProperty<string>? Amount
    {
        get => GetProperty<TerraformProperty<string>>("amount");
        set => WithProperty("amount", value);
    }

    /// <summary>
    /// Type of resource for which this commitment applies.
    /// Possible values are VCPU, MEMORY, LOCAL_SSD, and ACCELERATOR.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionCommitmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_compute_region_commitment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<bool>? AutoRenew
    {
        get => GetProperty<TerraformProperty<bool>>("auto_renew");
        set => this.WithProperty("auto_renew", value);
    }

    /// <summary>
    /// The category of the commitment. Category MACHINE specifies commitments composed of
    /// machine resources such as VCPU or MEMORY, listed in resources. Category LICENSE
    /// specifies commitments composed of software licenses, listed in licenseResources.
    /// Note that only MACHINE commitments should have a Type specified. Possible values: [&amp;quot;LICENSE&amp;quot;, &amp;quot;MACHINE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Category
    {
        get => GetProperty<TerraformProperty<string>>("category");
        set => this.WithProperty("category", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Specifies the already existing reservations to attach to the Commitment.
    /// </summary>
    public TerraformProperty<string>? ExistingReservations
    {
        get => GetProperty<TerraformProperty<string>>("existing_reservations");
        set => this.WithProperty("existing_reservations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The plan for this commitment, which determines duration and discount rate.
    /// The currently supported plans are TWELVE_MONTH (1 year), and THIRTY_SIX_MONTH (3 years). Possible values: [&amp;quot;TWELVE_MONTH&amp;quot;, &amp;quot;THIRTY_SIX_MONTH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformProperty<string> Plan
    {
        get => GetProperty<TerraformProperty<string>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// URL of the region where this commitment may be used.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The type of commitment, which affects the discount rate and the eligible resources.
    /// The type could be one of the following value: &#39;MEMORY_OPTIMIZED&#39;, &#39;ACCELERATOR_OPTIMIZED&#39;,
    /// &#39;GENERAL_PURPOSE_N1&#39;, &#39;GENERAL_PURPOSE_N2&#39;, &#39;GENERAL_PURPOSE_N2D&#39;, &#39;GENERAL_PURPOSE_E2&#39;,
    /// &#39;GENERAL_PURPOSE_T2D&#39;, &#39;GENERAL_PURPOSE_C3&#39;, &#39;COMPUTE_OPTIMIZED_C2&#39;, &#39;COMPUTE_OPTIMIZED_C2D&#39; and
    /// &#39;GRAPHICS_OPTIMIZED_G2&#39;
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for license_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LicenseResource block(s) allowed")]
    public List<GoogleComputeRegionCommitmentLicenseResourceBlock>? LicenseResource
    {
        get => GetProperty<List<GoogleComputeRegionCommitmentLicenseResourceBlock>>("license_resource");
        set => this.WithProperty("license_resource", value);
    }

    /// <summary>
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeRegionCommitmentResourcesBlock>? Resources
    {
        get => GetProperty<List<GoogleComputeRegionCommitmentResourcesBlock>>("resources");
        set => this.WithProperty("resources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionCommitmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeRegionCommitmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
