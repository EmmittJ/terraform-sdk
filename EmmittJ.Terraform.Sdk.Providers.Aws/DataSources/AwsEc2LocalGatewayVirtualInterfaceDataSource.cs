using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_local_gateway_virtual_interface.
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceDataSource : TerraformDataSource
{
    public AwsEc2LocalGatewayVirtualInterfaceDataSource(string name) : base("aws_ec2_local_gateway_virtual_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("local_address");
        this.DeclareOutput("local_bgp_asn");
        this.DeclareOutput("local_gateway_id");
        this.DeclareOutput("local_gateway_virtual_interface_ids");
        this.DeclareOutput("peer_address");
        this.DeclareOutput("peer_bgp_asn");
        this.DeclareOutput("vlan");
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
    /// The local_address attribute.
    /// </summary>
    public TerraformExpression LocalAddress => this["local_address"];

    /// <summary>
    /// The local_bgp_asn attribute.
    /// </summary>
    public TerraformExpression LocalBgpAsn => this["local_bgp_asn"];

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformExpression LocalGatewayId => this["local_gateway_id"];

    /// <summary>
    /// The local_gateway_virtual_interface_ids attribute.
    /// </summary>
    public TerraformExpression LocalGatewayVirtualInterfaceIds => this["local_gateway_virtual_interface_ids"];

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public TerraformExpression PeerAddress => this["peer_address"];

    /// <summary>
    /// The peer_bgp_asn attribute.
    /// </summary>
    public TerraformExpression PeerBgpAsn => this["peer_bgp_asn"];

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    public TerraformExpression Vlan => this["vlan"];

}
