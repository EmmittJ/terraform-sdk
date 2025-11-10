using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_networkfirewall_vpc_endpoint_association resource.
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociation : TerraformResource
{
    public AwsNetworkfirewallVpcEndpointAssociation(string name) : base("aws_networkfirewall_vpc_endpoint_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vpc_endpoint_association_arn");
        this.DeclareOutput("vpc_endpoint_association_id");
        this.DeclareOutput("vpc_endpoint_association_status");
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
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    public required TerraformProperty<string> FirewallArn
    {
        get => GetProperty<TerraformProperty<string>>("firewall_arn");
        set => this.WithProperty("firewall_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock>? SubnetMapping
    {
        get => GetProperty<List<AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock>>("subnet_mapping");
        set => this.WithProperty("subnet_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_endpoint_association_arn attribute.
    /// </summary>
    public TerraformExpression VpcEndpointAssociationArn => this["vpc_endpoint_association_arn"];

    /// <summary>
    /// The vpc_endpoint_association_id attribute.
    /// </summary>
    public TerraformExpression VpcEndpointAssociationId => this["vpc_endpoint_association_id"];

    /// <summary>
    /// The vpc_endpoint_association_status attribute.
    /// </summary>
    public TerraformExpression VpcEndpointAssociationStatus => this["vpc_endpoint_association_status"];

}
