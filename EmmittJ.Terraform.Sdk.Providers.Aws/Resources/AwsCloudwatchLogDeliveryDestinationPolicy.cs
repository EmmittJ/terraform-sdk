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

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
