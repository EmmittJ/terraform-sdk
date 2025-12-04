using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_delivery_destination_policy Terraform resource.
/// Manages a aws_cloudwatch_log_delivery_destination_policy resource.
/// </summary>
public partial class AwsCloudwatchLogDeliveryDestinationPolicy(string name) : TerraformResource("aws_cloudwatch_log_delivery_destination_policy", name)
{
    /// <summary>
    /// The delivery_destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryDestinationName is required")]
    public required TerraformValue<string> DeliveryDestinationName
    {
        get => GetArgument<TerraformValue<string>>("delivery_destination_name");
        set => SetArgument("delivery_destination_name", value);
    }

    /// <summary>
    /// The delivery_destination_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryDestinationPolicy is required")]
    public required TerraformValue<string> DeliveryDestinationPolicy
    {
        get => GetArgument<TerraformValue<string>>("delivery_destination_policy");
        set => SetArgument("delivery_destination_policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}
