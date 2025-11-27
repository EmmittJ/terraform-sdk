using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_configuration in AwsIvsRecordingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsIvsRecordingConfigurationDestinationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_configuration";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public required TerraformList<AwsIvsRecordingConfigurationDestinationConfigurationBlockS3Block> S3
    {
        get => GetRequiredArgument<TerraformList<AwsIvsRecordingConfigurationDestinationConfigurationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsIvsRecordingConfigurationDestinationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsIvsRecordingConfigurationDestinationConfigurationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

}


/// <summary>
/// Block type for thumbnail_configuration in AwsIvsRecordingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsIvsRecordingConfigurationThumbnailConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "thumbnail_configuration";

    /// <summary>
    /// The recording_mode attribute.
    /// </summary>
    public TerraformValue<string> RecordingMode
    {
        get => new TerraformReference<string>(this, "recording_mode");
        set => SetArgument("recording_mode", value);
    }

    /// <summary>
    /// The target_interval_seconds attribute.
    /// </summary>
    public TerraformValue<double> TargetIntervalSeconds
    {
        get => new TerraformReference<double>(this, "target_interval_seconds");
        set => SetArgument("target_interval_seconds", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsIvsRecordingConfiguration.
/// Nesting mode: single
/// </summary>
public class AwsIvsRecordingConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ivs_recording_configuration Terraform resource.
/// Manages a aws_ivs_recording_configuration resource.
/// </summary>
public partial class AwsIvsRecordingConfiguration(string name) : TerraformResource("aws_ivs_recording_configuration", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The recording_reconnect_window_seconds attribute.
    /// </summary>
    public TerraformValue<double> RecordingReconnectWindowSeconds
    {
        get => new TerraformReference<double>(this, "recording_reconnect_window_seconds");
        set => SetArgument("recording_reconnect_window_seconds", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// DestinationConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConfiguration block(s) allowed")]
    public required TerraformList<AwsIvsRecordingConfigurationDestinationConfigurationBlock> DestinationConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsIvsRecordingConfigurationDestinationConfigurationBlock>>("destination_configuration");
        set => SetArgument("destination_configuration", value);
    }

    /// <summary>
    /// ThumbnailConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThumbnailConfiguration block(s) allowed")]
    public TerraformList<AwsIvsRecordingConfigurationThumbnailConfigurationBlock>? ThumbnailConfiguration
    {
        get => GetArgument<TerraformList<AwsIvsRecordingConfigurationThumbnailConfigurationBlock>>("thumbnail_configuration");
        set => SetArgument("thumbnail_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsIvsRecordingConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsIvsRecordingConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
