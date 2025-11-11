using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for snapshot_delivery_properties in .
/// Nesting mode: list
/// </summary>
public partial class AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock : TerraformBlockBase
{
    /// <summary>
    /// The delivery_frequency attribute.
    /// </summary>
    [TerraformProperty("delivery_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeliveryFrequency { get; set; }

}

/// <summary>
/// Manages a aws_config_delivery_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConfigDeliveryChannel : TerraformResource
{
    public AwsConfigDeliveryChannel(string name) : base("aws_config_delivery_channel", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformProperty("s3_bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_key_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The s3_kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("s3_kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3KmsKeyArn { get; set; }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    [TerraformProperty("sns_topic_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SnsTopicArn { get; set; }

    /// <summary>
    /// Block for snapshot_delivery_properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotDeliveryProperties block(s) allowed")]
    [TerraformProperty("snapshot_delivery_properties")]
    public partial TerraformList<TerraformBlock<AwsConfigDeliveryChannelSnapshotDeliveryPropertiesBlock>>? SnapshotDeliveryProperties { get; set; }

}
