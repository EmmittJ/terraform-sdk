using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_vpc_attachment_accepter resource.
/// </summary>
public class AwsEc2TransitGatewayVpcAttachmentAccepter : TerraformResource
{
    public AwsEc2TransitGatewayVpcAttachmentAccepter(string name) : base("aws_ec2_transit_gateway_vpc_attachment_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("appliance_mode_support");
        this.DeclareOutput("dns_support");
        this.DeclareOutput("ipv6_support");
        this.DeclareOutput("security_group_referencing_support");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("transit_gateway_id");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("vpc_owner_id");
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public string? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_attachment_id")?.Value;
        set => this.WithProperty("transit_gateway_attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public bool? TransitGatewayDefaultRouteTableAssociation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transit_gateway_default_route_table_association")?.Value;
        set => this.WithProperty("transit_gateway_default_route_table_association", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public bool? TransitGatewayDefaultRouteTablePropagation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("transit_gateway_default_route_table_propagation")?.Value;
        set => this.WithProperty("transit_gateway_default_route_table_propagation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformExpression ApplianceModeSupport => this["appliance_mode_support"];

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformExpression DnsSupport => this["dns_support"];

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformExpression Ipv6Support => this["ipv6_support"];

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformExpression SecurityGroupReferencingSupport => this["security_group_referencing_support"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    public TerraformExpression VpcOwnerId => this["vpc_owner_id"];

}
