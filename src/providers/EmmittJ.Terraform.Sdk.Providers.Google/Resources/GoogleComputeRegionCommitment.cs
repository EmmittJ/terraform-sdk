using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for license_resource in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionCommitmentLicenseResourceBlock : ITerraformBlock
{
    /// <summary>
    /// The number of licenses purchased.
    /// </summary>
    [TerraformPropertyName("amount")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Amount { get; set; }

    /// <summary>
    /// Specifies the core range of the instance for which this license applies.
    /// </summary>
    [TerraformPropertyName("cores_per_license")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CoresPerLicense { get; set; }

    /// <summary>
    /// Any applicable license URI.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "License is required")]
    [TerraformPropertyName("license")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> License { get; set; }

}

/// <summary>
/// Block type for resources in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionCommitmentResourcesBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the accelerator type resource. Applicable only when the type is ACCELERATOR.
    /// </summary>
    [TerraformPropertyName("accelerator_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceleratorType { get; set; }

    /// <summary>
    /// The amount of the resource purchased (in a type-dependent unit,
    /// such as bytes). For vCPUs, this can just be an integer. For memory,
    /// this must be provided in MB. Memory must be a multiple of 256 MB,
    /// with up to 6.5GB of memory per every vCPU.
    /// </summary>
    [TerraformPropertyName("amount")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Amount { get; set; }

    /// <summary>
    /// Type of resource for which this commitment applies.
    /// Possible values are VCPU, MEMORY, LOCAL_SSD, and ACCELERATOR.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionCommitmentTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a google_compute_region_commitment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionCommitment : TerraformResource
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
    [TerraformPropertyName("auto_renew")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AutoRenew { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_renew");

    /// <summary>
    /// The category of the commitment. Category MACHINE specifies commitments composed of
    /// machine resources such as VCPU or MEMORY, listed in resources. Category LICENSE
    /// specifies commitments composed of software licenses, listed in licenseResources.
    /// Note that only MACHINE commitments should have a Type specified. Possible values: [&amp;quot;LICENSE&amp;quot;, &amp;quot;MACHINE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("category")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Category { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "category");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Specifies the already existing reservations to attach to the Commitment.
    /// </summary>
    [TerraformPropertyName("existing_reservations")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExistingReservations { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "existing_reservations");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the resource. The name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The plan for this commitment, which determines duration and discount rate.
    /// The currently supported plans are TWELVE_MONTH (1 year), and THIRTY_SIX_MONTH (3 years). Possible values: [&amp;quot;TWELVE_MONTH&amp;quot;, &amp;quot;THIRTY_SIX_MONTH&amp;quot;]
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
    /// URL of the region where this commitment may be used.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type of commitment, which affects the discount rate and the eligible resources.
    /// The type could be one of the following value: &#39;MEMORY_OPTIMIZED&#39;, &#39;ACCELERATOR_OPTIMIZED&#39;,
    /// &#39;GENERAL_PURPOSE_N1&#39;, &#39;GENERAL_PURPOSE_N2&#39;, &#39;GENERAL_PURPOSE_N2D&#39;, &#39;GENERAL_PURPOSE_E2&#39;,
    /// &#39;GENERAL_PURPOSE_T2D&#39;, &#39;GENERAL_PURPOSE_C3&#39;, &#39;COMPUTE_OPTIMIZED_C2&#39;, &#39;COMPUTE_OPTIMIZED_C2D&#39; and
    /// &#39;GRAPHICS_OPTIMIZED_G2&#39;
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Type { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// Block for license_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LicenseResource block(s) allowed")]
    [TerraformPropertyName("license_resource")]
    public TerraformList<TerraformBlock<GoogleComputeRegionCommitmentLicenseResourceBlock>>? LicenseResource { get; set; } = new();

    /// <summary>
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("resources")]
    public TerraformList<TerraformBlock<GoogleComputeRegionCommitmentResourcesBlock>>? Resources { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeRegionCommitmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("commitment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CommitmentId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "commitment_id");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// Commitment end time in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("end_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "end_timestamp");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Commitment start time in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("start_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_timestamp");

    /// <summary>
    /// Status of the commitment with regards to eventual expiration
    /// (each commitment has an end date defined).
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// A human-readable explanation of the status.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_message");

}
