using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsS3controlBucketLifecycleConfiguration.
/// Nesting mode: set
/// </summary>
public class AwsS3controlBucketLifecycleConfigurationRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// AbortIncompleteMultipartUpload block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AbortIncompleteMultipartUpload block(s) allowed")]
    public TerraformList<AwsS3controlBucketLifecycleConfigurationRuleBlockAbortIncompleteMultipartUploadBlock>? AbortIncompleteMultipartUpload
    {
        get => GetArgument<TerraformList<AwsS3controlBucketLifecycleConfigurationRuleBlockAbortIncompleteMultipartUploadBlock>>("abort_incomplete_multipart_upload");
        set => SetArgument("abort_incomplete_multipart_upload", value);
    }

    /// <summary>
    /// Expiration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expiration block(s) allowed")]
    public TerraformList<AwsS3controlBucketLifecycleConfigurationRuleBlockExpirationBlock>? Expiration
    {
        get => GetArgument<TerraformList<AwsS3controlBucketLifecycleConfigurationRuleBlockExpirationBlock>>("expiration");
        set => SetArgument("expiration", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsS3controlBucketLifecycleConfigurationRuleBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsS3controlBucketLifecycleConfigurationRuleBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for abort_incomplete_multipart_upload in AwsS3controlBucketLifecycleConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlBucketLifecycleConfigurationRuleBlockAbortIncompleteMultipartUploadBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "abort_incomplete_multipart_upload";

    /// <summary>
    /// The days_after_initiation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysAfterInitiation is required")]
    public required TerraformValue<double> DaysAfterInitiation
    {
        get => GetRequiredArgument<TerraformValue<double>>("days_after_initiation");
        set => SetArgument("days_after_initiation", value);
    }

}

/// <summary>
/// Block type for expiration in AwsS3controlBucketLifecycleConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlBucketLifecycleConfigurationRuleBlockExpirationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expiration";

    /// <summary>
    /// The date attribute.
    /// </summary>
    public TerraformValue<string>? Date
    {
        get => GetArgument<TerraformValue<string>>("date");
        set => SetArgument("date", value);
    }

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The expired_object_delete_marker attribute.
    /// </summary>
    public TerraformValue<bool>? ExpiredObjectDeleteMarker
    {
        get => GetArgument<TerraformValue<bool>>("expired_object_delete_marker");
        set => SetArgument("expired_object_delete_marker", value);
    }

}

/// <summary>
/// Block type for filter in AwsS3controlBucketLifecycleConfigurationRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlBucketLifecycleConfigurationRuleBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Represents a aws_s3control_bucket_lifecycle_configuration Terraform resource.
/// Manages a aws_s3control_bucket_lifecycle_configuration resource.
/// </summary>
public partial class AwsS3controlBucketLifecycleConfiguration(string name) : TerraformResource("aws_s3control_bucket_lifecycle_configuration", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Rule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    public required TerraformSet<AwsS3controlBucketLifecycleConfigurationRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformSet<AwsS3controlBucketLifecycleConfigurationRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
