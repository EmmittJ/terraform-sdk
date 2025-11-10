using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("amazon_side_asn");
        SetOutput("arn");
        SetOutput("association_default_route_table_id");
        SetOutput("auto_accept_shared_attachments");
        SetOutput("default_route_table_association");
        SetOutput("default_route_table_propagation");
        SetOutput("description");
        SetOutput("dns_support");
        SetOutput("multicast_support");
        SetOutput("owner_id");
        SetOutput("propagation_default_route_table_id");
        SetOutput("security_group_referencing_support");
        SetOutput("transit_gateway_cidr_blocks");
        SetOutput("vpn_ecmp_support");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2TransitGatewayDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2TransitGatewayDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
