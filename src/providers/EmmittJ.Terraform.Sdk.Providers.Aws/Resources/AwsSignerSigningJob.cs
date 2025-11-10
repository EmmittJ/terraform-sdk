using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobDestinationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobSourceBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_signer_signing_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSignerSigningJob : TerraformResource
{
    public AwsSignerSigningJob(string name) : base("aws_signer_signing_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ignore_signing_job_failure attribute.
    /// </summary>
    [TerraformPropertyName("ignore_signing_job_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreSigningJobFailure { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformPropertyName("profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProfileName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformPropertyName("destination")]
    public TerraformList<TerraformBlock<AwsSignerSigningJobDestinationBlock>>? Destination { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AwsSignerSigningJobSourceBlock>>? Source { get; set; } = new();

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    [TerraformPropertyName("completed_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompletedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "completed_at");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_id");

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    [TerraformPropertyName("job_invoker")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobInvoker => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_invoker");

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    [TerraformPropertyName("job_owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JobOwner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "job_owner");

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformPropertyName("platform_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_display_name");

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [TerraformPropertyName("platform_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PlatformId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform_id");

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    [TerraformPropertyName("profile_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProfileVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "profile_version");

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    [TerraformPropertyName("requested_by")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RequestedBy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "requested_by");

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformPropertyName("revocation_record")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RevocationRecord => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "revocation_record");

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    [TerraformPropertyName("signature_expires_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SignatureExpiresAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "signature_expires_at");

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    [TerraformPropertyName("signed_object")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SignedObject => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "signed_object");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

}
