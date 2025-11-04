using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc resource.
/// </summary>
public class AwsVpc : TerraformResource
{
    public AwsVpc(string name) : base("aws_vpc", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_network_acl_id");
        this.DeclareOutput("default_route_table_id");
        this.DeclareOutput("default_security_group_id");
        this.DeclareOutput("dhcp_options_id");
        this.DeclareOutput("ipv6_association_id");
        this.DeclareOutput("main_route_table_id");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public bool? AssignGeneratedIpv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("assign_generated_ipv6_cidr_block")?.Value;
        set => this.WithProperty("assign_generated_ipv6_cidr_block", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public string? CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_block")?.Value;
        set => this.WithProperty("cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public bool? EnableDnsHostnames
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_dns_hostnames")?.Value;
        set => this.WithProperty("enable_dns_hostnames", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public bool? EnableDnsSupport
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_dns_support")?.Value;
        set => this.WithProperty("enable_dns_support", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public bool? EnableNetworkAddressUsageMetrics
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_network_address_usage_metrics")?.Value;
        set => this.WithProperty("enable_network_address_usage_metrics", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    public string? InstanceTenancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_tenancy")?.Value;
        set => this.WithProperty("instance_tenancy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    public string? Ipv4IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv4_ipam_pool_id")?.Value;
        set => this.WithProperty("ipv4_ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv4_netmask_length attribute.
    /// </summary>
    public double? Ipv4NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv4_netmask_length")?.Value;
        set => this.WithProperty("ipv4_netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public string? Ipv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block")?.Value;
        set => this.WithProperty("ipv6_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    public string? Ipv6CidrBlockNetworkBorderGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block_network_border_group")?.Value;
        set => this.WithProperty("ipv6_cidr_block_network_border_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public string? Ipv6IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_ipam_pool_id")?.Value;
        set => this.WithProperty("ipv6_ipam_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public double? Ipv6NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_netmask_length")?.Value;
        set => this.WithProperty("ipv6_netmask_length", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_network_acl_id attribute.
    /// </summary>
    public TerraformExpression DefaultNetworkAclId => this["default_network_acl_id"];

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformExpression DefaultRouteTableId => this["default_route_table_id"];

    /// <summary>
    /// The default_security_group_id attribute.
    /// </summary>
    public TerraformExpression DefaultSecurityGroupId => this["default_security_group_id"];

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public TerraformExpression DhcpOptionsId => this["dhcp_options_id"];

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    public TerraformExpression Ipv6AssociationId => this["ipv6_association_id"];

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    public TerraformExpression MainRouteTableId => this["main_route_table_id"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
