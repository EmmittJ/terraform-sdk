using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_signer_signing_job Terraform data source.
/// Retrieves information about a aws_signer_signing_job.
/// </summary>
public partial class AwsSignerSigningJobDataSource(string name) : TerraformDataSource("aws_signer_signing_job", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformValue<string> JobId
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_id");
        set => SetArgument("job_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    public TerraformValue<string> CompletedAt
        => CreateReference("completed_at");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    public TerraformValue<string> JobInvoker
        => CreateReference("job_invoker");

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    public TerraformValue<string> JobOwner
        => CreateReference("job_owner");

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformValue<string> PlatformDisplayName
        => CreateReference("platform_display_name");

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    public TerraformValue<string> PlatformId
        => CreateReference("platform_id");

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public TerraformValue<string> ProfileName
        => CreateReference("profile_name");

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    public TerraformValue<string> ProfileVersion
        => CreateReference("profile_version");

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    public TerraformValue<string> RequestedBy
        => CreateReference("requested_by");

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RevocationRecord
        => CreateReference("revocation_record");

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    public TerraformValue<string> SignatureExpiresAt
        => CreateReference("signature_expires_at");

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SignedObject
        => CreateReference("signed_object");

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Source
        => CreateReference("source");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

}
