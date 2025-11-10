using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_vpc resource.
/// </summary>
public class AwsDefaultVpc : TerraformResource
{
    public AwsDefaultVpc(string name) : base("aws_default_vpc", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cidr_block");
        SetOutput("default_network_acl_id");
        SetOutput("default_route_table_id");
        SetOutput("default_security_group_id");
        SetOutput("dhcp_options_id");
        SetOutput("existing_default_vpc");
        SetOutput("instance_tenancy");
        SetOutput("ipv6_association_id");
        SetOutput("main_route_table_id");
        SetOutput("owner_id");
        SetOutput("assign_generated_ipv6_cidr_block");
        SetOutput("enable_dns_hostnames");
        SetOutput("enable_dns_support");
        SetOutput("enable_network_address_usage_metrics");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("ipv6_cidr_block");
        SetOutput("ipv6_cidr_block_network_border_group");
        SetOutput("ipv6_ipam_pool_id");
        SetOutput("ipv6_netmask_length");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<bool> AssignGeneratedIpv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("assign_generated_ipv6_cidr_block");
        set => SetProperty("assign_generated_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public TerraformProperty<bool> EnableDnsHostnames
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_dns_hostnames");
        set => SetProperty("enable_dns_hostnames", value);
    }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public TerraformProperty<bool> EnableDnsSupport
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_dns_support");
        set => SetProperty("enable_dns_support", value);
    }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public TerraformProperty<bool> EnableNetworkAddressUsageMetrics
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_network_address_usage_metrics");
        set => SetProperty("enable_network_address_usage_metrics", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_cidr_block");
        set => SetProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6CidrBlockNetworkBorderGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_cidr_block_network_border_group");
        set => SetProperty("ipv6_cidr_block_network_border_group", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6IpamPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_ipam_pool_id");
        set => SetProperty("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformProperty<double> Ipv6NetmaskLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ipv6_netmask_length");
        set => SetProperty("ipv6_netmask_length", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformExpression CidrBlock => this["cidr_block"];

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
    /// The existing_default_vpc attribute.
    /// </summary>
    public TerraformExpression ExistingDefaultVpc => this["existing_default_vpc"];

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    public TerraformExpression InstanceTenancy => this["instance_tenancy"];

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
