using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for storage_config in AwsConnectInstanceStorageConfig.
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_config";

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageType is required")]
    public required TerraformValue<string> StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// KinesisFirehoseConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisFirehoseConfig block(s) allowed")]
    public TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisFirehoseConfigBlock>? KinesisFirehoseConfig
    {
        get => GetArgument<TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisFirehoseConfigBlock>>("kinesis_firehose_config");
        set => SetArgument("kinesis_firehose_config", value);
    }

    /// <summary>
    /// KinesisStreamConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStreamConfig block(s) allowed")]
    public TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisStreamConfigBlock>? KinesisStreamConfig
    {
        get => GetArgument<TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisStreamConfigBlock>>("kinesis_stream_config");
        set => SetArgument("kinesis_stream_config", value);
    }

    /// <summary>
    /// KinesisVideoStreamConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisVideoStreamConfig block(s) allowed")]
    public TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisVideoStreamConfigBlock>? KinesisVideoStreamConfig
    {
        get => GetArgument<TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisVideoStreamConfigBlock>>("kinesis_video_stream_config");
        set => SetArgument("kinesis_video_stream_config", value);
    }

    /// <summary>
    /// S3Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Config block(s) allowed")]
    public TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockS3ConfigBlock>? S3Config
    {
        get => GetArgument<TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockS3ConfigBlock>>("s3_config");
        set => SetArgument("s3_config", value);
    }

}

/// <summary>
/// Block type for kinesis_firehose_config in AwsConnectInstanceStorageConfigStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlockKinesisFirehoseConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_firehose_config";

    /// <summary>
    /// The firehose_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirehoseArn is required")]
    public required TerraformValue<string> FirehoseArn
    {
        get => GetArgument<TerraformValue<string>>("firehose_arn");
        set => SetArgument("firehose_arn", value);
    }

}

/// <summary>
/// Block type for kinesis_stream_config in AwsConnectInstanceStorageConfigStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlockKinesisStreamConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_stream_config";

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamArn is required")]
    public required TerraformValue<string> StreamArn
    {
        get => GetArgument<TerraformValue<string>>("stream_arn");
        set => SetArgument("stream_arn", value);
    }

}

/// <summary>
/// Block type for kinesis_video_stream_config in AwsConnectInstanceStorageConfigStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlockKinesisVideoStreamConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_video_stream_config";

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The retention_period_hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionPeriodHours is required")]
    public required TerraformValue<double> RetentionPeriodHours
    {
        get => GetArgument<TerraformValue<double>>("retention_period_hours");
        set => SetArgument("retention_period_hours", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EncryptionConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public required TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisVideoStreamConfigBlockEncryptionConfigBlock> EncryptionConfig
    {
        get => GetRequiredArgument<TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockKinesisVideoStreamConfigBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

}

/// <summary>
/// Block type for encryption_config in AwsConnectInstanceStorageConfigStorageConfigBlockKinesisVideoStreamConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlockKinesisVideoStreamConfigBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionType is required")]
    public required TerraformValue<string> EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

}

/// <summary>
/// Block type for s3_config in AwsConnectInstanceStorageConfigStorageConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlockS3ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketPrefix is required")]
    public required TerraformValue<string> BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockS3ConfigBlockEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlockS3ConfigBlockEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

}

/// <summary>
/// Block type for encryption_config in AwsConnectInstanceStorageConfigStorageConfigBlockS3ConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsConnectInstanceStorageConfigStorageConfigBlockS3ConfigBlockEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionType is required")]
    public required TerraformValue<string> EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type");
        set => SetArgument("encryption_type", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

}


/// <summary>
/// Represents a aws_connect_instance_storage_config Terraform resource.
/// Manages a aws_connect_instance_storage_config resource.
/// </summary>
public partial class AwsConnectInstanceStorageConfig(string name) : TerraformResource("aws_connect_instance_storage_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => AsReference("association_id");

    /// <summary>
    /// StorageConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StorageConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageConfig block(s) allowed")]
    public required TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlock> StorageConfig
    {
        get => GetRequiredArgument<TerraformList<AwsConnectInstanceStorageConfigStorageConfigBlock>>("storage_config");
        set => SetArgument("storage_config", value);
    }

}
