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
        get => GetArgument<TerraformValue<string>>("dns_record_ip_type") ?? AsReference("dns_record_ip_type");
        set => SetArgument("dns_record_ip_type", value);
    }

    /// <summary>
    /// The private_dns_only_for_inbound_resolver_endpoint attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateDnsOnlyForInboundResolverEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("private_dns_only_for_inbound_resolver_endpoint");
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
        get => GetArgument<TerraformValue<string>>("ipv4");
        set => SetArgument("ipv4", value);
    }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6
    {
        get => GetArgument<TerraformValue<string>>("ipv6");
        set => SetArgument("ipv6", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<bool>>("auto_accept");
        set => SetArgument("auto_accept", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type") ?? AsReference("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => GetArgument<TerraformValue<string>>("policy") ?? AsReference("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateDnsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_dns_enabled") ?? AsReference("private_dns_enabled");
        set => SetArgument("private_dns_enabled", value);
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
    /// The resource_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string>? ResourceConfigurationArn
    {
        get => GetArgument<TerraformValue<string>>("resource_configuration_arn");
        set => SetArgument("resource_configuration_arn", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformSet<string> RouteTableIds
    {
        get => GetArgument<TerraformSet<string>>("route_table_ids") ?? AsReference("route_table_ids");
        set => SetArgument("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? AsReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformValue<string>? ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The service_network_arn attribute.
    /// </summary>
    public TerraformValue<string>? ServiceNetworkArn
    {
        get => GetArgument<TerraformValue<string>>("service_network_arn");
        set => SetArgument("service_network_arn", value);
    }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    public TerraformValue<string> ServiceRegion
    {
        get => GetArgument<TerraformValue<string>>("service_region") ?? AsReference("service_region");
        set => SetArgument("service_region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids") ?? AsReference("subnet_ids");
        set => SetArgument("subnet_ids", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointType
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_type");
        set => SetArgument("vpc_endpoint_type", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformList<string> CidrBlocks
        => AsReference("cidr_blocks");

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DnsEntry
        => AsReference("dns_entry");

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformSet<string> NetworkInterfaceIds
        => AsReference("network_interface_ids");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformValue<string> PrefixListId
        => AsReference("prefix_list_id");

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    public TerraformValue<bool> RequesterManaged
        => AsReference("requester_managed");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

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
