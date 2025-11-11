using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for license_resource in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionCommitmentLicenseResourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The number of licenses purchased.
    /// </summary>
    [TerraformProperty("amount")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Amount { get; set; }

    /// <summary>
    /// Specifies the core range of the instance for which this license applies.
    /// </summary>
    [TerraformProperty("cores_per_license")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CoresPerLicense { get; set; }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "License is required")]
    [TerraformProperty("license")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> License { get; set; }

}

/// <summary>
/// Block type for resources in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionCommitmentResourcesBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the accelerator type resource. Applicable only when the type is ACCELERATOR.
    /// </summary>
    [TerraformProperty("accelerator_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceleratorType { get; set; }

    /// <summary>
    /// The amount of the resource purchased (in a type-dependent unit,
    /// such as bytes). For vCPUs, this can just be an integer. For memory,
    /// this must be provided in MB. Memory must be a multiple of 256 MB,
    /// with up to 6.5GB of memory per every vCPU.
    /// </summary>
    [TerraformProperty("amount")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Amount { get; set; }

    /// <summary>
    /// Type of resource for which this commitment applies.
    /// Possible values are VCPU, MEMORY, LOCAL_SSD, and ACCELERATOR.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionCommitmentTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_compute_region_commitment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRegionCommitment : TerraformResource
{
    public GoogleComputeRegionCommitment(string name) : base("google_compute_region_commitment", name)
    {
    }

    /// <summary>
    /// Specifies whether to enable automatic renewal for the commitment.
    /// The default value is false if not specified.
    /// If the field is set to true, the commitment will be automatically renewed for either
    /// one or three years according to the terms of the existing commitment.
    /// </summary>
    [TerraformProperty("auto_renew")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AutoRenew { get; set; }

    /// <summary>
    /// The category of the commitment. Category MACHINE specifies commitments composed of
    /// machine resources such as VCPU or MEMORY, listed in resources. Category LICENSE
    /// specifies commitments composed of software licenses, listed in licenseResources.
    /// Note that only MACHINE commitments should have a Type specified. Possible values: [&amp;quot;LICENSE&amp;quot;, &amp;quot;MACHINE&amp;quot;]
    /// </summary>
    [TerraformProperty("category")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Category { get; set; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Specifies the already existing reservations to attach to the Commitment.
    /// </summary>
    [TerraformProperty("existing_reservations")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExistingReservations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long and match
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
    /// The plan for this commitment, which determines duration and discount rate.
    /// The currently supported plans are TWELVE_MONTH (1 year), and THIRTY_SIX_MONTH (3 years). Possible values: [&amp;quot;TWELVE_MONTH&amp;quot;, &amp;quot;THIRTY_SIX_MONTH&amp;quot;]
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
    /// URL of the region where this commitment may be used.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type of commitment, which affects the discount rate and the eligible resources.
    /// The type could be one of the following value: &#39;MEMORY_OPTIMIZED&#39;, &#39;ACCELERATOR_OPTIMIZED&#39;,
    /// &#39;GENERAL_PURPOSE_N1&#39;, &#39;GENERAL_PURPOSE_N2&#39;, &#39;GENERAL_PURPOSE_N2D&#39;, &#39;GENERAL_PURPOSE_E2&#39;,
    /// &#39;GENERAL_PURPOSE_T2D&#39;, &#39;GENERAL_PURPOSE_C3&#39;, &#39;COMPUTE_OPTIMIZED_C2&#39;, &#39;COMPUTE_OPTIMIZED_C2D&#39; and
    /// &#39;GRAPHICS_OPTIMIZED_G2&#39;
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for license_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LicenseResource block(s) allowed")]
    [TerraformProperty("license_resource")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionCommitmentLicenseResourceBlock>>? LicenseResource { get; set; }

    /// <summary>
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("resources")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionCommitmentResourcesBlock>>? Resources { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeRegionCommitmentTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Unique identifier for the resource.
    /// </summary>
    [TerraformProperty("commitment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CommitmentId { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// Commitment end time in RFC3339 text format.
    /// </summary>
    [TerraformProperty("end_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndTimestamp { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Commitment start time in RFC3339 text format.
    /// </summary>
    [TerraformProperty("start_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartTimestamp { get; }

    /// <summary>
    /// Status of the commitment with regards to eventual expiration
    /// (each commitment has an end date defined).
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// A human-readable explanation of the status.
    /// </summary>
    [TerraformProperty("status_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusMessage { get; }

}
