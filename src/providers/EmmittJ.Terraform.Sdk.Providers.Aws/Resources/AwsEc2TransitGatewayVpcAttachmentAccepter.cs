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
        SetOutput("appliance_mode_support");
        SetOutput("dns_support");
        SetOutput("ipv6_support");
        SetOutput("security_group_referencing_support");
        SetOutput("subnet_ids");
        SetOutput("transit_gateway_id");
        SetOutput("vpc_id");
        SetOutput("vpc_owner_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_gateway_attachment_id");
        SetOutput("transit_gateway_default_route_table_association");
        SetOutput("transit_gateway_default_route_table_propagation");
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformProperty<string> TransitGatewayAttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => SetProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_association attribute.
    /// </summary>
    public TerraformProperty<bool> TransitGatewayDefaultRouteTableAssociation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("transit_gateway_default_route_table_association");
        set => SetProperty("transit_gateway_default_route_table_association", value);
    }

    /// <summary>
    /// The transit_gateway_default_route_table_propagation attribute.
    /// </summary>
    public TerraformProperty<bool> TransitGatewayDefaultRouteTablePropagation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("transit_gateway_default_route_table_propagation");
        set => SetProperty("transit_gateway_default_route_table_propagation", value);
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
