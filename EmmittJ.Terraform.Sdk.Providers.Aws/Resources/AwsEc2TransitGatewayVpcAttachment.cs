using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_vpc_attachment resource.
/// </summary>
public class AwsEc2TransitGatewayVpcAttachment : TerraformResource
{
    public AwsEc2TransitGatewayVpcAttachment(string name) : base("aws_ec2_transit_gateway_vpc_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("vpc_owner_id");
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public string? ApplianceModeSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("appliance_mode_support")?.Value;
        set => this.WithProperty("appliance_mode_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public string? DnsSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_support")?.Value;
        set => this.WithProperty("dns_support", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ipv6_support attribute.
    /// </summary>
    public string? Ipv6Support
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_support")?.Value;
        set => this.WithProperty("ipv6_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public string? SecurityGroupReferencingSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_referencing_support")?.Value;
        set => this.WithProperty("security_group_referencing_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<string>? SubnetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnet_ids")?.Value;
        set => this.WithProperty("subnet_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The transit_gateway_id attribute.
    /// </summary>
    public string? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id")?.Value;
        set => this.WithProperty("transit_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    public TerraformExpression VpcOwnerId => this["vpc_owner_id"];

}
