using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_peering_attachment.
/// </summary>
public class AwsEc2TransitGatewayPeeringAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayPeeringAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_peering_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("peer_account_id");
        this.DeclareOutput("peer_region");
        this.DeclareOutput("peer_transit_gateway_id");
        this.DeclareOutput("state");
        this.DeclareOutput("transit_gateway_id");
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The peer_account_id attribute.
    /// </summary>
    public TerraformExpression PeerAccountId => this["peer_account_id"];

    /// <summary>
    /// The peer_region attribute.
    /// </summary>
    public TerraformExpression PeerRegion => this["peer_region"];

    /// <summary>
    /// The peer_transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression PeerTransitGatewayId => this["peer_transit_gateway_id"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

}
