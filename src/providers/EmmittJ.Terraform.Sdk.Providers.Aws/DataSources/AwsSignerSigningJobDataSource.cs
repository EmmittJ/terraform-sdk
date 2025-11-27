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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformValue<string> JobId
    {
        get => new TerraformReference<string>(this, "job_id");
        set => SetArgument("job_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The completed_at attribute.
    /// </summary>
    public TerraformValue<string> CompletedAt
    {
        get => new TerraformReference<string>(this, "completed_at");
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// The job_invoker attribute.
    /// </summary>
    public TerraformValue<string> JobInvoker
    {
        get => new TerraformReference<string>(this, "job_invoker");
    }

    /// <summary>
    /// The job_owner attribute.
    /// </summary>
    public TerraformValue<string> JobOwner
    {
        get => new TerraformReference<string>(this, "job_owner");
    }

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    public TerraformValue<string> PlatformDisplayName
    {
        get => new TerraformReference<string>(this, "platform_display_name");
    }

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    public TerraformValue<string> PlatformId
    {
        get => new TerraformReference<string>(this, "platform_id");
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    public TerraformValue<string> ProfileName
    {
        get => new TerraformReference<string>(this, "profile_name");
    }

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    public TerraformValue<string> ProfileVersion
    {
        get => new TerraformReference<string>(this, "profile_version");
    }

    /// <summary>
    /// The requested_by attribute.
    /// </summary>
    public TerraformValue<string> RequestedBy
    {
        get => new TerraformReference<string>(this, "requested_by");
    }

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RevocationRecord
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "revocation_record").ResolveNodes(ctx));
    }

    /// <summary>
    /// The signature_expires_at attribute.
    /// </summary>
    public TerraformValue<string> SignatureExpiresAt
    {
        get => new TerraformReference<string>(this, "signature_expires_at");
    }

    /// <summary>
    /// The signed_object attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SignedObject
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "signed_object").ResolveNodes(ctx));
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Source
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

}
