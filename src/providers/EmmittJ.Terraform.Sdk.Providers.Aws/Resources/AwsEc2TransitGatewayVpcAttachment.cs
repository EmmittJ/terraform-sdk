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
        SetOutput("arn");
        SetOutput("vpc_owner_id");
        SetOutput("appliance_mode_support");
        SetOutput("dns_support");
        SetOutput("id");
        SetOutput("ipv6_support");
        SetOutput("region");
        SetOutput("security_group_referencing_support");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("transit_gateway_default_route_table_association");
        SetOutput("transit_gateway_default_route_table_propagation");
        SetOutput("transit_gateway_id");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformProperty<string> ApplianceModeSupport
    {
        get => GetRequiredOutput<TerraformProperty<string>>("appliance_mode_support");
        set => SetProperty("appliance_mode_support", value);
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
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6Support
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_support");
        set => SetProperty("ipv6_support", value);
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
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
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
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformProperty<string> TransitGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transit_gateway_id");
        set => SetProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
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
