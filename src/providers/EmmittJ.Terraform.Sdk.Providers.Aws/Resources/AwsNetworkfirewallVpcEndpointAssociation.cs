using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for subnet_mapping in AwsNetworkfirewallVpcEndpointAssociation.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet_mapping";

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type") ?? AsReference("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNetworkfirewallVpcEndpointAssociation.
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_networkfirewall_vpc_endpoint_association Terraform resource.
/// Manages a aws_networkfirewall_vpc_endpoint_association resource.
/// </summary>
public partial class AwsNetworkfirewallVpcEndpointAssociation(string name) : TerraformResource("aws_networkfirewall_vpc_endpoint_association", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    public required TerraformValue<string> FirewallArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("firewall_arn");
        set => SetArgument("firewall_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// The vpc_endpoint_association_arn attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointAssociationArn
        => AsReference("vpc_endpoint_association_arn");

    /// <summary>
    /// The vpc_endpoint_association_id attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointAssociationId
        => AsReference("vpc_endpoint_association_id");

    /// <summary>
    /// The vpc_endpoint_association_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcEndpointAssociationStatus
        => AsReference("vpc_endpoint_association_status");

    /// <summary>
    /// SubnetMapping block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock>? SubnetMapping
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallVpcEndpointAssociationSubnetMappingBlock>>("subnet_mapping");
        set => SetArgument("subnet_mapping", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkfirewallVpcEndpointAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
