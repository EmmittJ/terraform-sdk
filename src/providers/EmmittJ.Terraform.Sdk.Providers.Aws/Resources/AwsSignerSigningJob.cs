using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in AwsSignerSigningJob.
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public required TerraformList<AwsSignerSigningJobDestinationBlockS3Block> S3
    {
        get => GetRequiredArgument<TerraformList<AwsSignerSigningJobDestinationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsSignerSigningJobDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobDestinationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for source in AwsSignerSigningJob.
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public required TerraformList<AwsSignerSigningJobSourceBlockS3Block> S3
    {
        get => GetRequiredArgument<TerraformList<AwsSignerSigningJobSourceBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsSignerSigningJobSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSignerSigningJobSourceBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Represents a aws_signer_signing_job Terraform resource.
/// Manages a aws_signer_signing_job resource.
/// </summary>
public partial class AwsSignerSigningJob(string name) : TerraformResource("aws_signer_signing_job", name)
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
    /// The ignore_signing_job_failure attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreSigningJobFailure
    {
        get => new TerraformReference<bool>(this, "ignore_signing_job_failure");
        set => SetArgument("ignore_signing_job_failure", value);
    }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    public required TerraformValue<string> ProfileName
    {
        get => new TerraformReference<string>(this, "profile_name");
        set => SetArgument("profile_name", value);
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
    /// The job_id attribute.
    /// </summary>
    public TerraformValue<string> JobId
    {
        get => new TerraformReference<string>(this, "job_id");
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

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsSignerSigningJobDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsSignerSigningJobDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    public required TerraformList<AwsSignerSigningJobSourceBlock> Source
    {
        get => GetRequiredArgument<TerraformList<AwsSignerSigningJobSourceBlock>>("source");
        set => SetArgument("source", value);
    }

}
