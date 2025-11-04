using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_vpn_attachment.
/// </summary>
public class AwsEc2TransitGatewayVpnAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayVpnAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_vpn_attachment", name)
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public string? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id")?.Value;
        set => this.WithProperty("transit_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpn_connection_id attribute.
    /// </summary>
    public string? VpnConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_connection_id")?.Value;
        set => this.WithProperty("vpn_connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
