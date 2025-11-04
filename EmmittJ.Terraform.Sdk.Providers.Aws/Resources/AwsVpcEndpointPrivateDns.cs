using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint_private_dns resource.
/// </summary>
public class AwsVpcEndpointPrivateDns : TerraformResource
{
    public AwsVpcEndpointPrivateDns(string name) : base("aws_vpc_endpoint_private_dns", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public bool? PrivateDnsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_dns_enabled")?.Value;
        set => this.WithProperty("private_dns_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public string? VpcEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_endpoint_id")?.Value;
        set => this.WithProperty("vpc_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
