using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_dedicated_ip_assignment resource.
/// </summary>
public class AwsSesv2DedicatedIpAssignment : TerraformResource
{
    public AwsSesv2DedicatedIpAssignment(string name) : base("aws_sesv2_dedicated_ip_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The destination_pool_name attribute.
    /// </summary>
    public string? DestinationPoolName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_pool_name")?.Value;
        set => this.WithProperty("destination_pool_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip attribute.
    /// </summary>
    public string? Ip
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip")?.Value;
        set => this.WithProperty("ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
