using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for target_grant in AwsS3BucketLogging.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketLoggingTargetGrantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_grant";

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformValue<string> Permission
    {
        get => new TerraformReference<string>(this, "permission");
        set => SetArgument("permission", value);
    }

    /// <summary>
    /// Grantee block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Grantee is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Grantee block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grantee block(s) allowed")]
    public required TerraformList<AwsS3BucketLoggingTargetGrantBlockGranteeBlock> Grantee
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketLoggingTargetGrantBlockGranteeBlock>>("grantee");
        set => SetArgument("grantee", value);
    }

}

/// <summary>
/// Block type for grantee in AwsS3BucketLoggingTargetGrantBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLoggingTargetGrantBlockGranteeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grantee";

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformValue<string>? EmailAddress
    {
        get => new TerraformReference<string>(this, "email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for target_object_key_format in AwsS3BucketLogging.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLoggingTargetObjectKeyFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_object_key_format";

    /// <summary>
    /// PartitionedPrefix block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartitionedPrefix block(s) allowed")]
    public TerraformList<AwsS3BucketLoggingTargetObjectKeyFormatBlockPartitionedPrefixBlock>? PartitionedPrefix
    {
        get => GetArgument<TerraformList<AwsS3BucketLoggingTargetObjectKeyFormatBlockPartitionedPrefixBlock>>("partitioned_prefix");
        set => SetArgument("partitioned_prefix", value);
    }

    /// <summary>
    /// SimplePrefix block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SimplePrefix block(s) allowed")]
    public TerraformList<AwsS3BucketLoggingTargetObjectKeyFormatBlockSimplePrefixBlock>? SimplePrefix
    {
        get => GetArgument<TerraformList<AwsS3BucketLoggingTargetObjectKeyFormatBlockSimplePrefixBlock>>("simple_prefix");
        set => SetArgument("simple_prefix", value);
    }

}

/// <summary>
/// Block type for partitioned_prefix in AwsS3BucketLoggingTargetObjectKeyFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLoggingTargetObjectKeyFormatBlockPartitionedPrefixBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "partitioned_prefix";

    /// <summary>
    /// The partition_date_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionDateSource is required")]
    public required TerraformValue<string> PartitionDateSource
    {
        get => new TerraformReference<string>(this, "partition_date_source");
        set => SetArgument("partition_date_source", value);
    }

}

/// <summary>
/// Block type for simple_prefix in AwsS3BucketLoggingTargetObjectKeyFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketLoggingTargetObjectKeyFormatBlockSimplePrefixBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "simple_prefix";

}


/// <summary>
/// Represents a aws_s3_bucket_logging Terraform resource.
/// Manages a aws_s3_bucket_logging resource.
/// </summary>
public partial class AwsS3BucketLogging(string name) : TerraformResource("aws_s3_bucket_logging", name)
{
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
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => new TerraformReference<string>(this, "expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The target_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetBucket is required")]
    public required TerraformValue<string> TargetBucket
    {
        get => new TerraformReference<string>(this, "target_bucket");
        set => SetArgument("target_bucket", value);
    }

    /// <summary>
    /// The target_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPrefix is required")]
    public required TerraformValue<string> TargetPrefix
    {
        get => new TerraformReference<string>(this, "target_prefix");
        set => SetArgument("target_prefix", value);
    }

    /// <summary>
    /// TargetGrant block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsS3BucketLoggingTargetGrantBlock>? TargetGrant
    {
        get => GetArgument<TerraformSet<AwsS3BucketLoggingTargetGrantBlock>>("target_grant");
        set => SetArgument("target_grant", value);
    }

    /// <summary>
    /// TargetObjectKeyFormat block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetObjectKeyFormat block(s) allowed")]
    public TerraformList<AwsS3BucketLoggingTargetObjectKeyFormatBlock>? TargetObjectKeyFormat
    {
        get => GetArgument<TerraformList<AwsS3BucketLoggingTargetObjectKeyFormatBlock>>("target_object_key_format");
        set => SetArgument("target_object_key_format", value);
    }

}
