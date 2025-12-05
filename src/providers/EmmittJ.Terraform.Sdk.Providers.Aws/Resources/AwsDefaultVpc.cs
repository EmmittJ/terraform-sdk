using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_default_vpc Terraform resource.
/// Manages a aws_default_vpc resource.
/// </summary>
public partial class AwsDefaultVpc(string name) : TerraformResource("aws_default_vpc", name)
{
    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<bool>? AssignGeneratedIpv6CidrBlock
    {
        get => GetArgument<TerraformValue<bool>>("assign_generated_ipv6_cidr_block");
        set => SetArgument("assign_generated_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDnsHostnames
    {
        get => GetArgument<TerraformValue<bool>>("enable_dns_hostnames");
        set => SetArgument("enable_dns_hostnames", value);
    }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDnsSupport
    {
        get => GetArgument<TerraformValue<bool>>("enable_dns_support");
        set => SetArgument("enable_dns_support", value);
    }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public TerraformValue<bool> EnableNetworkAddressUsageMetrics
    {
        get => GetArgument<TerraformValue<bool>>("enable_network_address_usage_metrics") ?? CreateReference("enable_network_address_usage_metrics");
        set => SetArgument("enable_network_address_usage_metrics", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => GetArgument<TerraformValue<bool>>("force_destroy");
        set => SetArgument("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block") ?? CreateReference("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlockNetworkBorderGroup
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block_network_border_group") ?? CreateReference("ipv6_cidr_block_network_border_group");
        set => SetArgument("ipv6_cidr_block_network_border_group", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6IpamPoolId
    {
        get => GetArgument<TerraformValue<string>>("ipv6_ipam_pool_id");
        set => SetArgument("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? Ipv6NetmaskLength
    {
        get => GetArgument<TerraformValue<double>>("ipv6_netmask_length");
        set => SetArgument("ipv6_netmask_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
        => CreateReference("cidr_block");

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultNetworkAclId
        => CreateReference("default_network_acl_id");

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRouteTableId
        => CreateReference("default_route_table_id");

    /// <summary>
    /// The default_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecurityGroupId
        => CreateReference("default_security_group_id");

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public TerraformValue<string> DhcpOptionsId
        => CreateReference("dhcp_options_id");

    /// <summary>
    /// The existing_default_vpc attribute.
    /// </summary>
    public TerraformValue<bool> ExistingDefaultVpc
        => CreateReference("existing_default_vpc");

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    public TerraformValue<string> InstanceTenancy
        => CreateReference("instance_tenancy");

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AssociationId
        => CreateReference("ipv6_association_id");

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> MainRouteTableId
        => CreateReference("main_route_table_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

}
