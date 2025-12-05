using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for snapshot_delivery_properties in AwsConfigDeliveryChannel.
/// Nesting mode: list
/// </summary>
public class AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snapshot_delivery_properties";

    /// <summary>
    /// The delivery_frequency attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryFrequency
    {
        get => GetArgument<TerraformValue<string>>("delivery_frequency");
        set => SetArgument("delivery_frequency", value);
    }

}


/// <summary>
/// Represents a aws_config_delivery_channel Terraform resource.
/// Manages a aws_config_delivery_channel resource.
/// </summary>
public partial class AwsConfigDeliveryChannel(string name) : TerraformResource("aws_config_delivery_channel", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("s3_key_prefix");
        set => SetArgument("s3_key_prefix", value);
    }

    /// <summary>
    /// The s3_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? S3KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("s3_kms_key_arn");
        set => SetArgument("s3_kms_key_arn", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? SnsTopicArn
    {
        get => GetArgument<TerraformValue<string>>("sns_topic_arn");
        set => SetArgument("sns_topic_arn", value);
    }

    /// <summary>
    /// SnapshotDeliveryProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotDeliveryProperties block(s) allowed")]
    public TerraformList<AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock>? SnapshotDeliveryProperties
    {
        get => GetArgument<TerraformList<AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock>>("snapshot_delivery_properties");
        set => SetArgument("snapshot_delivery_properties", value);
    }

}
