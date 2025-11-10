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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("association_default_route_table_id");
        SetOutput("owner_id");
        SetOutput("propagation_default_route_table_id");
        SetOutput("amazon_side_asn");
        SetOutput("auto_accept_shared_attachments");
        SetOutput("default_route_table_association");
        SetOutput("default_route_table_propagation");
        SetOutput("description");
        SetOutput("dns_support");
        SetOutput("id");
        SetOutput("multicast_support");
        SetOutput("region");
        SetOutput("security_group_referencing_support");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_gateway_cidr_blocks");
        SetOutput("vpn_ecmp_support");
    }

    /// <summary>
    /// The amazon_side_asn attribute.
    /// </summary>
    public TerraformProperty<double> AmazonSideAsn
    {
        get => GetRequiredOutput<TerraformProperty<double>>("amazon_side_asn");
        set => SetProperty("amazon_side_asn", value);
    }

    /// <summary>
    /// The auto_accept_shared_attachments attribute.
    /// </summary>
    public TerraformProperty<string> AutoAcceptSharedAttachments
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_accept_shared_attachments");
        set => SetProperty("auto_accept_shared_attachments", value);
    }

    /// <summary>
    /// The default_route_table_association attribute.
    /// </summary>
    public TerraformProperty<string> DefaultRouteTableAssociation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_route_table_association");
        set => SetProperty("default_route_table_association", value);
    }

    /// <summary>
    /// The default_route_table_propagation attribute.
    /// </summary>
    public TerraformProperty<string> DefaultRouteTablePropagation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_route_table_propagation");
        set => SetProperty("default_route_table_propagation", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformProperty<string> DnsSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_support");
        set => SetProperty("dns_support", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The multicast_support attribute.
    /// </summary>
    public TerraformProperty<string> MulticastSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("multicast_support");
        set => SetProperty("multicast_support", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformProperty<string> SecurityGroupReferencingSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_group_referencing_support");
        set => SetProperty("security_group_referencing_support", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_cidr_blocks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> TransitGatewayCidrBlocks
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("transit_gateway_cidr_blocks");
        set => SetProperty("transit_gateway_cidr_blocks", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformProperty<string> VpnEcmpSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_ecmp_support");
        set => SetProperty("vpn_ecmp_support", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2TransitGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
