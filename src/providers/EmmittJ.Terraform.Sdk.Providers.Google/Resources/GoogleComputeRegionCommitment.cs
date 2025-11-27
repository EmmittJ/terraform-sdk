using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for license_resource in GoogleComputeRegionCommitment.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionCommitmentLicenseResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "license_resource";

    /// <summary>
    /// The number of licenses purchased.
    /// </summary>
    public TerraformValue<string>? Amount
    {
        get => new TerraformReference<string>(this, "amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// Specifies the core range of the instance for which this license applies.
    /// </summary>
    public TerraformValue<string>? CoresPerLicense
    {
        get => new TerraformReference<string>(this, "cores_per_license");
        set => SetArgument("cores_per_license", value);
    }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "License is required")]
    public required TerraformValue<string> License
    {
        get => new TerraformReference<string>(this, "license");
        set => SetArgument("license", value);
    }

}


/// <summary>
/// Block type for resources in GoogleComputeRegionCommitment.
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionCommitmentResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// Name of the accelerator type resource. Applicable only when the type is ACCELERATOR.
    /// </summary>
    public TerraformValue<string>? AcceleratorType
    {
        get => new TerraformReference<string>(this, "accelerator_type");
        set => SetArgument("accelerator_type", value);
    }

    /// <summary>
    /// The amount of the resource purchased (in a type-dependent unit,
    /// such as bytes). For vCPUs, this can just be an integer. For memory,
    /// this must be provided in MB. Memory must be a multiple of 256 MB,
    /// with up to 6.5GB of memory per every vCPU.
    /// </summary>
    public TerraformValue<string>? Amount
    {
        get => new TerraformReference<string>(this, "amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// Type of resource for which this commitment applies.
    /// Possible values are VCPU, MEMORY, LOCAL_SSD, and ACCELERATOR.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeRegionCommitment.
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionCommitmentTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_compute_region_commitment Terraform resource.
/// Manages a google_compute_region_commitment resource.
/// </summary>
public partial class GoogleComputeRegionCommitment(string name) : TerraformResource("google_compute_region_commitment", name)
{
    /// <summary>
    /// Specifies whether to enable automatic renewal for the commitment.
    /// The default value is false if not specified.
    /// If the field is set to true, the commitment will be automatically renewed for either
    /// one or three years according to the terms of the existing commitment.
    /// </summary>
    public TerraformValue<bool> AutoRenew
    {
        get => new TerraformReference<bool>(this, "auto_renew");
        set => SetArgument("auto_renew", value);
    }

    /// <summary>
    /// The category of the commitment. Category MACHINE specifies commitments composed of
    /// machine resources such as VCPU or MEMORY, listed in resources. Category LICENSE
    /// specifies commitments composed of software licenses, listed in licenseResources.
    /// Note that only MACHINE commitments should have a Type specified. Possible values: [&amp;quot;LICENSE&amp;quot;, &amp;quot;MACHINE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Specifies the already existing reservations to attach to the Commitment.
    /// </summary>
    public TerraformValue<string> ExistingReservations
    {
        get => new TerraformReference<string>(this, "existing_reservations");
        set => SetArgument("existing_reservations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The plan for this commitment, which determines duration and discount rate.
    /// The currently supported plans are TWELVE_MONTH (1 year), and THIRTY_SIX_MONTH (3 years). Possible values: [&amp;quot;TWELVE_MONTH&amp;quot;, &amp;quot;THIRTY_SIX_MONTH&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformValue<string> Plan
    {
        get => new TerraformReference<string>(this, "plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// URL of the region where this commitment may be used.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type of commitment, which affects the discount rate and the eligible resources.
    /// The type could be one of the following value: &#39;MEMORY_OPTIMIZED&#39;, &#39;ACCELERATOR_OPTIMIZED&#39;,
    /// &#39;GENERAL_PURPOSE_N1&#39;, &#39;GENERAL_PURPOSE_N2&#39;, &#39;GENERAL_PURPOSE_N2D&#39;, &#39;GENERAL_PURPOSE_E2&#39;,
    /// &#39;GENERAL_PURPOSE_T2D&#39;, &#39;GENERAL_PURPOSE_C3&#39;, &#39;COMPUTE_OPTIMIZED_C2&#39;, &#39;COMPUTE_OPTIMIZED_C2D&#39; and
    /// &#39;GRAPHICS_OPTIMIZED_G2&#39;
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> CommitmentId
    {
        get => new TerraformReference<double>(this, "commitment_id");
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// Commitment end time in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> EndTimestamp
    {
        get => new TerraformReference<string>(this, "end_timestamp");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Commitment start time in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> StartTimestamp
    {
        get => new TerraformReference<string>(this, "start_timestamp");
    }

    /// <summary>
    /// Status of the commitment with regards to eventual expiration
    /// (each commitment has an end date defined).
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// A human-readable explanation of the status.
    /// </summary>
    public TerraformValue<string> StatusMessage
    {
        get => new TerraformReference<string>(this, "status_message");
    }

    /// <summary>
    /// LicenseResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LicenseResource block(s) allowed")]
    public TerraformList<GoogleComputeRegionCommitmentLicenseResourceBlock>? LicenseResource
    {
        get => GetArgument<TerraformList<GoogleComputeRegionCommitmentLicenseResourceBlock>>("license_resource");
        set => SetArgument("license_resource", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeRegionCommitmentResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleComputeRegionCommitmentResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeRegionCommitmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeRegionCommitmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
