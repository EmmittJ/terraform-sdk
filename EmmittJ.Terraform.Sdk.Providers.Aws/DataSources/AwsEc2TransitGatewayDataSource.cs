using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway.
/// </summary>
public class AwsEc2TransitGatewayDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayDataSource(string name) : base("aws_ec2_transit_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("amazon_side_asn");
        this.DeclareOutput("arn");
        this.DeclareOutput("association_default_route_table_id");
        this.DeclareOutput("auto_accept_shared_attachments");
        this.DeclareOutput("default_route_table_association");
        this.DeclareOutput("default_route_table_propagation");
        this.DeclareOutput("description");
        this.DeclareOutput("dns_support");
        this.DeclareOutput("multicast_support");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("propagation_default_route_table_id");
        this.DeclareOutput("security_group_referencing_support");
        this.DeclareOutput("transit_gateway_cidr_blocks");
        this.DeclareOutput("vpn_ecmp_support");
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
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformExpression AmazonSideAsn => this["amazon_side_asn"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_default_route_table_id attribute.
    /// </summary>
    public TerraformExpression AssociationDefaultRouteTableId => this["association_default_route_table_id"];

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public TerraformExpression AutoAcceptSharedAttachments => this["auto_accept_shared_attachments"];

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public TerraformExpression DefaultRouteTableAssociation => this["default_route_table_association"];

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public TerraformExpression DefaultRouteTablePropagation => this["default_route_table_propagation"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformExpression DnsSupport => this["dns_support"];

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    public TerraformExpression MulticastSupport => this["multicast_support"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The propagation_default_route_table_id attribute.
    /// </summary>
    public TerraformExpression PropagationDefaultRouteTableId => this["propagation_default_route_table_id"];

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformExpression SecurityGroupReferencingSupport => this["security_group_referencing_support"];

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public TerraformExpression TransitGatewayCidrBlocks => this["transit_gateway_cidr_blocks"];

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformExpression VpnEcmpSupport => this["vpn_ecmp_support"];

}
