using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for snapshot_delivery_properties in .
/// Nesting mode: list
/// </summary>
public class AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The delivery_frequency attribute.
    /// </summary>
    [TerraformPropertyName("delivery_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeliveryFrequency { get; set; }

}

/// <summary>
/// Manages a aws_config_delivery_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConfigDeliveryChannel : TerraformResource
{
    public AwsConfigDeliveryChannel(string name) : base("aws_config_delivery_channel", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformPropertyName("s3_bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_key_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The s3_kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("s3_kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3KmsKeyArn { get; set; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("sns_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnsTopicArn { get; set; }

    /// <summary>
    /// Block for snapshot_delivery_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotDeliveryProperties block(s) allowed")]
    [TerraformPropertyName("snapshot_delivery_properties")]
    public TerraformList<TerraformBlock<AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock>>? SnapshotDeliveryProperties { get; set; } = new();

}
