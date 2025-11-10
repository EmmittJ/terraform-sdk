using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobDestinationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobSourceBlock : TerraformBlock
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("completed_at");
        SetOutput("created_at");
        SetOutput("job_id");
        SetOutput("job_invoker");
        SetOutput("job_owner");
        SetOutput("platform_display_name");
        SetOutput("platform_id");
        SetOutput("profile_version");
        SetOutput("requested_by");
        SetOutput("revocation_record");
        SetOutput("signature_expires_at");
        SetOutput("signed_object");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("id");
        SetOutput("ignore_signing_job_failure");
        SetOutput("profile_name");
        SetOutput("region");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ignore_signing_job_failure attribute.
    /// </summary>
    public TerraformProperty<bool> IgnoreSigningJobFailure
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_signing_job_failure");
        set => SetProperty("ignore_signing_job_failure", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformProperty<string> ProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("profile_name");
        set => SetProperty("profile_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public List<AwsSignerSigningJobDestinationBlock>? Destination
    {
        set => SetProperty("destination", value);
    }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public List<AwsSignerSigningJobSourceBlock>? Source
    {
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    public TerraformExpression CompletedAt => this["completed_at"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    public TerraformExpression JobInvoker => this["job_invoker"];

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    public TerraformExpression JobOwner => this["job_owner"];

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformExpression PlatformDisplayName => this["platform_display_name"];

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    public TerraformExpression PlatformId => this["platform_id"];

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    public TerraformExpression ProfileVersion => this["profile_version"];

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    public TerraformExpression RequestedBy => this["requested_by"];

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformExpression RevocationRecord => this["revocation_record"];

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    public TerraformExpression SignatureExpiresAt => this["signature_expires_at"];

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    public TerraformExpression SignedObject => this["signed_object"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
