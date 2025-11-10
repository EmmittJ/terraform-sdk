using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for snapshot_delivery_properties in .
/// Nesting mode: list
/// </summary>
public class AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The delivery_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? DeliveryFrequency
    {
        get => GetProperty<TerraformProperty<string>>("delivery_frequency");
        set => WithProperty("delivery_frequency", value);
    }

}

/// <summary>
/// Manages a aws_config_delivery_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigDeliveryChannel : TerraformResource
{
    public AwsConfigDeliveryChannel(string name) : base("aws_config_delivery_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformProperty<string> S3BucketName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_bucket_name");
        set => this.WithProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? S3KeyPrefix
    {
        get => GetProperty<TerraformProperty<string>>("s3_key_prefix");
        set => this.WithProperty("s3_key_prefix", value);
    }

    /// <summary>
    /// The s3_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? S3KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("s3_kms_key_arn");
        set => this.WithProperty("s3_kms_key_arn", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SnsTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("sns_topic_arn");
        set => this.WithProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// Block for snapshot_delivery_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotDeliveryProperties block(s) allowed")]
    public List<AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock>? SnapshotDeliveryProperties
    {
        get => GetProperty<List<AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock>>("snapshot_delivery_properties");
        set => this.WithProperty("snapshot_delivery_properties", value);
    }

}
