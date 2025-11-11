using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_signer_signing_job.
/// </summary>
public partial class AwsSignerSigningJobDataSource : TerraformDataSource
{
    public AwsSignerSigningJobDataSource(string name) : base("aws_signer_signing_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    [TerraformProperty("job_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> JobId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    [TerraformProperty("completed_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CompletedAt { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    [TerraformProperty("job_invoker")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> JobInvoker { get; }

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    [TerraformProperty("job_owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> JobOwner { get; }

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformProperty("platform_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlatformDisplayName { get; }

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [TerraformProperty("platform_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PlatformId { get; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [TerraformProperty("profile_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProfileName { get; }

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    [TerraformProperty("profile_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProfileVersion { get; }

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    [TerraformProperty("requested_by")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RequestedBy { get; }

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformProperty("revocation_record")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RevocationRecord { get; }

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    [TerraformProperty("signature_expires_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SignatureExpiresAt { get; }

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    [TerraformProperty("signed_object")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SignedObject { get; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Source { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StatusReason { get; }

}
