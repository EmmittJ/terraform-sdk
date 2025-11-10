using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_destination_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The destination_resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceArn is required")]
    [TerraformPropertyName("destination_resource_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationResourceArn { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [TerraformPropertyName("output_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OutputFormat { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for delivery_destination_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("delivery_destination_configuration")]
    public TerraformList<TerraformBlock<AwsCloudwatchLogDeliveryDestinationDeliveryDestinationConfigurationBlock>>? DeliveryDestinationConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The delivery_destination_type attribute.
    /// </summary>
    [TerraformPropertyName("delivery_destination_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeliveryDestinationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "delivery_destination_type");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
