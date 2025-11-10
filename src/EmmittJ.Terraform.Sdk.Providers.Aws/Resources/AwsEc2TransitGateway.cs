using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<double>? AmazonSideAsn
    {
        get => GetProperty<TerraformProperty<double>>("amazon_side_asn");
        set => this.WithProperty("amazon_side_asn", value);
    }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public TerraformProperty<string>? AutoAcceptSharedAttachments
    {
        get => GetProperty<TerraformProperty<string>>("auto_accept_shared_attachments");
        set => this.WithProperty("auto_accept_shared_attachments", value);
    }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRouteTableAssociation
    {
        get => GetProperty<TerraformProperty<string>>("default_route_table_association");
        set => this.WithProperty("default_route_table_association", value);
    }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRouteTablePropagation
    {
        get => GetProperty<TerraformProperty<string>>("default_route_table_propagation");
        set => this.WithProperty("default_route_table_propagation", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformProperty<string>? DnsSupport
    {
        get => GetProperty<TerraformProperty<string>>("dns_support");
        set => this.WithProperty("dns_support", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    public TerraformProperty<string>? MulticastSupport
    {
        get => GetProperty<TerraformProperty<string>>("multicast_support");
        set => this.WithProperty("multicast_support", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityGroupReferencingSupport
    {
        get => GetProperty<TerraformProperty<string>>("security_group_referencing_support");
        set => this.WithProperty("security_group_referencing_support", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TransitGatewayCidrBlocks
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("transit_gateway_cidr_blocks");
        set => this.WithProperty("transit_gateway_cidr_blocks", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformProperty<string>? VpnEcmpSupport
    {
        get => GetProperty<TerraformProperty<string>>("vpn_ecmp_support");
        set => this.WithProperty("vpn_ecmp_support", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2TransitGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2TransitGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
