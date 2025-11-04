using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_delivery_destination_policy resource.
/// </summary>
public class AwsCloudwatchLogDeliveryDestinationPolicy : TerraformResource
{
    public AwsCloudwatchLogDeliveryDestinationPolicy(string name) : base("aws_cloudwatch_log_delivery_destination_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The delivery_destination_name attribute.
    /// </summary>
    public string? DeliveryDestinationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_destination_name")?.Value;
        set => this.WithProperty("delivery_destination_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delivery_destination_policy attribute.
    /// </summary>
    public string? DeliveryDestinationPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_destination_policy")?.Value;
        set => this.WithProperty("delivery_destination_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
