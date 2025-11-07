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
    public TerraformProperty<string>? DeliveryDestinationName
    {
        get => GetProperty<TerraformProperty<string>>("delivery_destination_name");
        set => this.WithProperty("delivery_destination_name", value);
    }

    /// <summary>
    /// The delivery_destination_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DeliveryDestinationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("delivery_destination_policy");
        set => this.WithProperty("delivery_destination_policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
