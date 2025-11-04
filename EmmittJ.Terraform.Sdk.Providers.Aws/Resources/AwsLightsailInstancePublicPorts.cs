using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_instance_public_ports resource.
/// </summary>
public class AwsLightsailInstancePublicPorts : TerraformResource
{
    public AwsLightsailInstancePublicPorts(string name) : base("aws_lightsail_instance_public_ports", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The instance_name attribute.
    /// </summary>
    public string? InstanceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_name")?.Value;
        set => this.WithProperty("instance_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
