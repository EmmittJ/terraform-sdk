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
        this.DeclareOutput("arn");
        this.DeclareOutput("cidr_block");
        this.DeclareOutput("default_network_acl_id");
        this.DeclareOutput("default_route_table_id");
        this.DeclareOutput("default_security_group_id");
        this.DeclareOutput("dhcp_options_id");
        this.DeclareOutput("existing_default_vpc");
        this.DeclareOutput("instance_tenancy");
        this.DeclareOutput("ipv6_association_id");
        this.DeclareOutput("main_route_table_id");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The assign_generated_ipv6_cidr_block attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AssignGeneratedIpv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("assign_generated_ipv6_cidr_block");
        set => this.WithProperty("assign_generated_ipv6_cidr_block", value);
    }

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableDnsHostnames
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_dns_hostnames");
        set => this.WithProperty("enable_dns_hostnames", value);
    }

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableDnsSupport
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_dns_support");
        set => this.WithProperty("enable_dns_support", value);
    }

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableNetworkAddressUsageMetrics
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_network_address_usage_metrics");
        set => this.WithProperty("enable_network_address_usage_metrics", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block");
        set => this.WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_cidr_block_network_border_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ipv6CidrBlockNetworkBorderGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block_network_border_group");
        set => this.WithProperty("ipv6_cidr_block_network_border_group", value);
    }

    /// <summary>
    /// The ipv6_ipam_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ipv6IpamPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_ipam_pool_id");
        set => this.WithProperty("ipv6_ipam_pool_id", value);
    }

    /// <summary>
    /// The ipv6_netmask_length attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Ipv6NetmaskLength
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_netmask_length");
        set => this.WithProperty("ipv6_netmask_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
