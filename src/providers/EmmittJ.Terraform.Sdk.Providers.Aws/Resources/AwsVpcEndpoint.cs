using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_options in AwsVpcEndpoint.
/// Nesting mode: list
/// </summary>
public class AwsVpcEndpointDnsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_options";

    /// <summary>
    /// The dns_record_ip_type attribute.
    /// </summary>
    public TerraformValue<string> DnsRecordIpType
    {
        get => new TerraformReference<string>(this, "dns_record_ip_type");
        set => SetArgument("dns_record_ip_type", value);
    }

    /// <summary>
    /// The private_dns_only_for_inbound_resolver_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateDnsOnlyForInboundResolverEndpoint
    {
        get => new TerraformReference<bool>(this, "private_dns_only_for_inbound_resolver_endpoint");
        set => SetArgument("private_dns_only_for_inbound_resolver_endpoint", value);
    }

}


/// <summary>
/// Block type for subnet_configuration in AwsVpcEndpoint.
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointSubnetConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet_configuration";

    /// <summary>
    /// The ipv4 attribute.
    /// </summary>
    public TerraformValue<string>? Ipv4
    {
        get => new TerraformReference<string>(this, "ipv4");
        set => SetArgument("ipv4", value);
    }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6
    {
        get => new TerraformReference<string>(this, "ipv6");
        set => SetArgument("ipv6", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVpcEndpoint.
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_vpc_endpoint Terraform resource.
/// Manages a aws_vpc_endpoint resource.
/// </summary>
public partial class AwsVpcEndpoint(string name) : TerraformResource("aws_vpc_endpoint", name)
{
    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformValue<bool>? AutoAccept
    {
        get => new TerraformReference<bool>(this, "auto_accept");
        set => SetArgument("auto_accept", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateDnsEnabled
    {
        get => new TerraformReference<bool>(this, "private_dns_enabled");
        set => SetArgument("private_dns_enabled", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string>? ResourceConfigurationArn
    {
        get => new TerraformReference<string>(this, "resource_configuration_arn");
        set => SetArgument("resource_configuration_arn", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformSet<string> RouteTableIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "route_table_ids").ResolveNodes(ctx));
        set => SetArgument("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The service_network_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceNetworkArn
    {
        get => new TerraformReference<string>(this, "service_network_arn");
        set => SetArgument("service_network_arn", value);
    }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    public TerraformValue<string> ServiceRegion
    {
        get => new TerraformReference<string>(this, "service_region");
        set => SetArgument("service_region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointType
    {
        get => new TerraformReference<string>(this, "vpc_endpoint_type");
        set => SetArgument("vpc_endpoint_type", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> CidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cidr_blocks").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsEntry
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dns_entry").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> NetworkInterfaceIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "network_interface_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string> PrefixListId
    {
        get => new TerraformReference<string>(this, "prefix_list_id");
    }

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    public TerraformValue<bool> RequesterManaged
    {
        get => new TerraformReference<bool>(this, "requester_managed");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// DnsOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsOptions block(s) allowed")]
    public TerraformList<AwsVpcEndpointDnsOptionsBlock>? DnsOptions
    {
        get => GetArgument<TerraformList<AwsVpcEndpointDnsOptionsBlock>>("dns_options");
        set => SetArgument("dns_options", value);
    }

    /// <summary>
    /// SubnetConfiguration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcEndpointSubnetConfigurationBlock>? SubnetConfiguration
    {
        get => GetArgument<TerraformSet<AwsVpcEndpointSubnetConfigurationBlock>>("subnet_configuration");
        set => SetArgument("subnet_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVpcEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVpcEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
