using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsSignerSigningJobDestinationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AwsSignerSigningJobSourceBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_signer_signing_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSignerSigningJob : TerraformResource
{
    public AwsSignerSigningJob(string name) : base("aws_signer_signing_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_signing_job_failure attribute.
    /// </summary>
    [TerraformProperty("ignore_signing_job_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreSigningJobFailure { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformProperty("profile_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProfileName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformProperty("destination")]
    public partial TerraformList<TerraformBlock<AwsSignerSigningJobDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public partial TerraformList<TerraformBlock<AwsSignerSigningJobSourceBlock>>? Source { get; set; }

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    [TerraformProperty("completed_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CompletedAt { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformProperty("job_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobId { get; }

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    [TerraformProperty("job_invoker")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobInvoker { get; }

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    [TerraformProperty("job_owner")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JobOwner { get; }

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformProperty("platform_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformDisplayName { get; }

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [TerraformProperty("platform_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformId { get; }

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    [TerraformProperty("profile_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProfileVersion { get; }

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    [TerraformProperty("requested_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RequestedBy { get; }

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformProperty("revocation_record")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RevocationRecord { get; }

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    [TerraformProperty("signature_expires_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SignatureExpiresAt { get; }

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    [TerraformProperty("signed_object")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SignedObject { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

}
