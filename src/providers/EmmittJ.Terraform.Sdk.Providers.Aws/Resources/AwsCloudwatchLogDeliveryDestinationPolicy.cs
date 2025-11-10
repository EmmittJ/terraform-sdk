using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_delivery_destination_policy resource.
/// </summary>
public class AwsCloudwatchLogDeliveryDestinationPolicy : TerraformResource
{
    public AwsCloudwatchLogDeliveryDestinationPolicy(string name) : base("aws_cloudwatch_log_delivery_destination_policy", name)
    {
    }

    /// <summary>
    /// The delivery_destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryDestinationName is required")]
    [TerraformPropertyName("delivery_destination_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeliveryDestinationName { get; set; }

    /// <summary>
    /// The delivery_destination_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryDestinationPolicy is required")]
    [TerraformPropertyName("delivery_destination_policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeliveryDestinationPolicy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

}
