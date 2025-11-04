using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway resource.
/// </summary>
public class AwsEc2TransitGateway : TerraformResource
{
    public AwsEc2TransitGateway(string name) : base("aws_ec2_transit_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("association_default_route_table_id");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("propagation_default_route_table_id");
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public double? AmazonSideAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("amazon_side_asn")?.Value;
        set => this.WithProperty("amazon_side_asn", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public string? AutoAcceptSharedAttachments
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_accept_shared_attachments")?.Value;
        set => this.WithProperty("auto_accept_shared_attachments", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public string? DefaultRouteTableAssociation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_route_table_association")?.Value;
        set => this.WithProperty("default_route_table_association", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public string? DefaultRouteTablePropagation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_route_table_propagation")?.Value;
        set => this.WithProperty("default_route_table_propagation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The multicast_support attribute.
    /// </summary>
    public string? MulticastSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multicast_support")?.Value;
        set => this.WithProperty("multicast_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public HashSet<string>? TransitGatewayCidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("transit_gateway_cidr_blocks")?.Value;
        set => this.WithProperty("transit_gateway_cidr_blocks", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public string? VpnEcmpSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_ecmp_support")?.Value;
        set => this.WithProperty("vpn_ecmp_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_default_route_table_id attribute.
    /// </summary>
    public TerraformExpression AssociationDefaultRouteTableId => this["association_default_route_table_id"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The propagation_default_route_table_id attribute.
    /// </summary>
    public TerraformExpression PropagationDefaultRouteTableId => this["propagation_default_route_table_id"];

}
