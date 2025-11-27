using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_vpc Terraform resource.
/// Manages a aws_vpc resource.
/// </summary>
public partial class AwsVpc(string name) : TerraformResource("aws_vpc", name)
{
    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<bool>? AssignGeneratedIpv6CidrBlock
    {
        get => new TerraformReference<bool>(this, "assign_generated_ipv6_cidr_block");
        set => SetArgument("assign_generated_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
    {
        get => new TerraformReference<string>(this, "cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public TerraformValue<bool> EnableDnsHostnames
    {
        get => new TerraformReference<bool>(this, "enable_dns_hostnames");
        set => SetArgument("enable_dns_hostnames", value);
    }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDnsSupport
    {
        get => new TerraformReference<bool>(this, "enable_dns_support");
        set => SetArgument("enable_dns_support", value);
    }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public TerraformValue<bool> EnableNetworkAddressUsageMetrics
    {
        get => new TerraformReference<bool>(this, "enable_network_address_usage_metrics");
        set => SetArgument("enable_network_address_usage_metrics", value);
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
    /// The instance_tenancy attribute.
    /// </summary>
    public TerraformValue<string>? InstanceTenancy
    {
        get => new TerraformReference<string>(this, "instance_tenancy");
        set => SetArgument("instance_tenancy", value);
    }

    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? Ipv4IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipv4_ipam_pool_id");
        set => SetArgument("ipv4_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv4_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? Ipv4NetmaskLength
    {
        get => new TerraformReference<double>(this, "ipv4_netmask_length");
        set => SetArgument("ipv4_netmask_length", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
    {
        get => new TerraformReference<string>(this, "ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlockNetworkBorderGroup
    {
        get => new TerraformReference<string>(this, "ipv6_cidr_block_network_border_group");
        set => SetArgument("ipv6_cidr_block_network_border_group", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6IpamPoolId
    {
        get => new TerraformReference<string>(this, "ipv6_ipam_pool_id");
        set => SetArgument("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformValue<double>? Ipv6NetmaskLength
    {
        get => new TerraformReference<double>(this, "ipv6_netmask_length");
        set => SetArgument("ipv6_netmask_length", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultNetworkAclId
    {
        get => new TerraformReference<string>(this, "default_network_acl_id");
    }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRouteTableId
    {
        get => new TerraformReference<string>(this, "default_route_table_id");
    }

    /// <summary>
    /// The default_security_group_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultSecurityGroupId
    {
        get => new TerraformReference<string>(this, "default_security_group_id");
    }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public TerraformValue<string> DhcpOptionsId
    {
        get => new TerraformReference<string>(this, "dhcp_options_id");
    }

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    public TerraformValue<string> Ipv6AssociationId
    {
        get => new TerraformReference<string>(this, "ipv6_association_id");
    }

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> MainRouteTableId
    {
        get => new TerraformReference<string>(this, "main_route_table_id");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

}
