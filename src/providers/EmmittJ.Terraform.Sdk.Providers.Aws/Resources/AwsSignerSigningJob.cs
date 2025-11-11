using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobDestinationBlock
{
}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobSourceBlock
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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ignore_signing_job_failure attribute.
    /// </summary>
    [TerraformPropertyName("ignore_signing_job_failure")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreSigningJobFailure { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformPropertyName("profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProfileName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformPropertyName("destination")]
    public TerraformList<TerraformBlock<AwsSignerSigningJobDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AwsSignerSigningJobSourceBlock>>? Source { get; set; }

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    [TerraformPropertyName("completed_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CompletedAt => new TerraformReference(this, "completed_at");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobId => new TerraformReference(this, "job_id");

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    [TerraformPropertyName("job_invoker")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobInvoker => new TerraformReference(this, "job_invoker");

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    [TerraformPropertyName("job_owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> JobOwner => new TerraformReference(this, "job_owner");

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformPropertyName("platform_display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformDisplayName => new TerraformReference(this, "platform_display_name");

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [TerraformPropertyName("platform_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PlatformId => new TerraformReference(this, "platform_id");

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    [TerraformPropertyName("profile_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProfileVersion => new TerraformReference(this, "profile_version");

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    [TerraformPropertyName("requested_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RequestedBy => new TerraformReference(this, "requested_by");

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformPropertyName("revocation_record")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RevocationRecord => new TerraformReference(this, "revocation_record");

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    [TerraformPropertyName("signature_expires_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SignatureExpiresAt => new TerraformReference(this, "signature_expires_at");

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    [TerraformPropertyName("signed_object")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SignedObject => new TerraformReference(this, "signed_object");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusReason => new TerraformReference(this, "status_reason");

}
