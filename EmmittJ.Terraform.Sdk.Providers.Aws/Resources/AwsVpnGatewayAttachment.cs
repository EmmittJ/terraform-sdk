using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpn_gateway_attachment resource.
/// </summary>
public class AwsVpnGatewayAttachment : TerraformResource
{
    public AwsVpnGatewayAttachment(string name) : base("aws_vpn_gateway_attachment", name)
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
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public string? VpnGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_gateway_id")?.Value;
        set => this.WithProperty("vpn_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
