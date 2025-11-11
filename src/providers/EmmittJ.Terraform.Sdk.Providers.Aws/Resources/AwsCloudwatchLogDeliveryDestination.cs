using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_destination_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock
{
    /// <summary>
    /// The destination_resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceArn is required")]
    [TerraformPropertyName("destination_resource_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DestinationResourceArn { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_log_delivery_destination resource.
/// </summary>
public class AwsCloudwatchLogDeliveryDestination : TerraformResource
{
    public AwsCloudwatchLogDeliveryDestination(string name) : base("aws_cloudwatch_log_delivery_destination", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [TerraformPropertyName("output_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutputFormat { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for delivery_destination_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("delivery_destination_configuration")]
    public TerraformList<TerraformBlock<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>>? DeliveryDestinationConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The delivery_destination_type attribute.
    /// </summary>
    [TerraformPropertyName("delivery_destination_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeliveryDestinationType => new TerraformReference(this, "delivery_destination_type");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
