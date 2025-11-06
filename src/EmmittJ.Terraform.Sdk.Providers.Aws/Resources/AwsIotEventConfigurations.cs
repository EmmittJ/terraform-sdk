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
    public Dictionary<string, bool>? EventConfigurations
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, bool>>>("event_configurations")?.Value;
        set => this.WithProperty("event_configurations", value == null ? null : new TerraformLiteralProperty<Dictionary<string, bool>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
