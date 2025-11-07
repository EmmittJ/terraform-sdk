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
    public TerraformLiteralProperty<double>? AmazonSideAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("amazon_side_asn");
        set => this.WithProperty("amazon_side_asn", value);
    }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AutoAcceptSharedAttachments
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_accept_shared_attachments");
        set => this.WithProperty("auto_accept_shared_attachments", value);
    }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultRouteTableAssociation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_route_table_association");
        set => this.WithProperty("default_route_table_association", value);
    }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultRouteTablePropagation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_route_table_propagation");
        set => this.WithProperty("default_route_table_propagation", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DnsSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_support");
        set => this.WithProperty("dns_support", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MulticastSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("multicast_support");
        set => this.WithProperty("multicast_support", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecurityGroupReferencingSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("security_group_referencing_support");
        set => this.WithProperty("security_group_referencing_support", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? TransitGatewayCidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("transit_gateway_cidr_blocks");
        set => this.WithProperty("transit_gateway_cidr_blocks", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpnEcmpSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_ecmp_support");
        set => this.WithProperty("vpn_ecmp_support", value);
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
