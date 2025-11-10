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
        set => SetProperty("delivery_frequency", value);
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
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("s3_bucket_name");
        SetOutput("s3_key_prefix");
        SetOutput("s3_kms_key_arn");
        SetOutput("sns_topic_arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformProperty<string> S3BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_bucket_name");
        set => SetProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string> S3KeyPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_key_prefix");
        set => SetProperty("s3_key_prefix", value);
    }

    /// <summary>
    /// The s3_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> S3KmsKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_kms_key_arn");
        set => SetProperty("s3_kms_key_arn", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> SnsTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sns_topic_arn");
        set => SetProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// Block for snapshot_delivery_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotDeliveryProperties block(s) allowed")]
    public List<AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock>? SnapshotDeliveryProperties
    {
        set => SetProperty("snapshot_delivery_properties", value);
    }

}
