using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_destination_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The destination_resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceArn is required")]
    [TerraformProperty("destination_resource_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationResourceArn { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_log_delivery_destination resource.
/// </summary>
public partial class AwsCloudwatchLogDeliveryDestination : TerraformResource
{
    public AwsCloudwatchLogDeliveryDestination(string name) : base("aws_cloudwatch_log_delivery_destination", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [TerraformProperty("output_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutputFormat { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for delivery_destination_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("delivery_destination_configuration")]
    public TerraformList<TerraformBlock<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>>? DeliveryDestinationConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The delivery_destination_type attribute.
    /// </summary>
    [TerraformProperty("delivery_destination_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeliveryDestinationType { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
