using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_event_configurations resource.
/// </summary>
public class AwsIotEventConfigurations : TerraformResource
{
    public AwsIotEventConfigurations(string name) : base("aws_iot_event_configurations", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The event_configurations attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, bool>>? EventConfigurations
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, bool>>>("event_configurations");
        set => this.WithProperty("event_configurations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
