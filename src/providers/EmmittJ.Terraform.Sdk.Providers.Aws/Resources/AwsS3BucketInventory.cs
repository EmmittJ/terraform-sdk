using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in AwsS3BucketInventory.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketInventoryDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// Bucket block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Bucket block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bucket block(s) allowed")]
    public required TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlock> Bucket
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlock>>("bucket");
        set => SetArgument("bucket", value);
    }

}

/// <summary>
/// Block type for bucket in AwsS3BucketInventoryDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketInventoryDestinationBlockBucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucket";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// Encryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Encryption block(s) allowed")]
    public TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlock>? Encryption
    {
        get => GetArgument<TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlock>>("encryption");
        set => SetArgument("encryption", value);
    }

}

/// <summary>
/// Block type for encryption in AwsS3BucketInventoryDestinationBlockBucketBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption";

    /// <summary>
    /// SseKms block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseKms block(s) allowed")]
    public TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlockSseKmsBlock>? SseKms
    {
        get => GetArgument<TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlockSseKmsBlock>>("sse_kms");
        set => SetArgument("sse_kms", value);
    }

    /// <summary>
    /// SseS3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseS3 block(s) allowed")]
    public TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlockSseS3Block>? SseS3
    {
        get => GetArgument<TerraformList<AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlockSseS3Block>>("sse_s3");
        set => SetArgument("sse_s3", value);
    }

}

/// <summary>
/// Block type for sse_kms in AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlockSseKmsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_kms";

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

}

/// <summary>
/// Block type for sse_s3 in AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketInventoryDestinationBlockBucketBlockEncryptionBlockSseS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_s3";

}


/// <summary>
/// Block type for filter in AwsS3BucketInventory.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketInventoryFilterBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for schedule in AwsS3BucketInventory.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketInventoryScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_inventory Terraform resource.
/// Manages a aws_s3_bucket_inventory resource.
/// </summary>
public partial class AwsS3BucketInventory(string name) : TerraformResource("aws_s3_bucket_inventory", name)
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
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The included_object_versions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncludedObjectVersions is required")]
    public required TerraformValue<string> IncludedObjectVersions
    {
        get => new TerraformReference<string>(this, "included_object_versions");
        set => SetArgument("included_object_versions", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The optional_fields attribute.
    /// </summary>
    public TerraformSet<string>? OptionalFields
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "optional_fields").ResolveNodes(ctx));
        set => SetArgument("optional_fields", value);
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
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    public required TerraformList<AwsS3BucketInventoryDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketInventoryDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AwsS3BucketInventoryFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsS3BucketInventoryFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public required TerraformList<AwsS3BucketInventoryScheduleBlock> Schedule
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketInventoryScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

}
