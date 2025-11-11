using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_delivery resource.
/// </summary>
public partial class AwsCloudwatchLogDelivery : TerraformResource
{
    public AwsCloudwatchLogDelivery(string name) : base("aws_cloudwatch_log_delivery", name)
    {
    }

    /// <summary>
    /// The delivery_destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryDestinationArn is required")]
    [TerraformProperty("delivery_destination_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeliveryDestinationArn { get; set; }

    /// <summary>
    /// The delivery_source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliverySourceName is required")]
    [TerraformProperty("delivery_source_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeliverySourceName { get; set; }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    [TerraformProperty("field_delimiter")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FieldDelimiter { get; set; }

    /// <summary>
    /// The record_fields attribute.
    /// </summary>
    [TerraformProperty("record_fields")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> RecordFields { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The s3_delivery_configuration attribute.
    /// </summary>
    [TerraformProperty("s3_delivery_configuration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> S3DeliveryConfiguration { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
