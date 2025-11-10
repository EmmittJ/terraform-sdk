using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_vpc.
/// </summary>
public class AwsVpcDataSource : TerraformDataSource
{
    public AwsVpcDataSource(string name) : base("aws_vpc", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cidr_block_associations");
        this.DeclareOutput("enable_dns_hostnames");
        this.DeclareOutput("enable_dns_support");
        this.DeclareOutput("enable_network_address_usage_metrics");
        this.DeclareOutput("instance_tenancy");
        this.DeclareOutput("ipv6_association_id");
        this.DeclareOutput("ipv6_cidr_block");
        this.DeclareOutput("main_route_table_id");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("cidr_block");
        set => this.WithProperty("cidr_block", value);
    }

    /// <summary>
    /// The default attribute.
    /// </summary>
    public TerraformProperty<bool>? Default
    {
        get => GetProperty<TerraformProperty<bool>>("default");
        set => this.WithProperty("default", value);
    }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public TerraformProperty<string>? DhcpOptionsId
    {
        get => GetProperty<TerraformProperty<string>>("dhcp_options_id");
        set => this.WithProperty("dhcp_options_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsVpcDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cidr_block_associations attribute.
    /// </summary>
    public TerraformExpression CidrBlockAssociations => this["cidr_block_associations"];

    /// <summary>
    /// The enable_dns_hostnames attribute.
    /// </summary>
    public TerraformExpression EnableDnsHostnames => this["enable_dns_hostnames"];

    /// <summary>
    /// The enable_dns_support attribute.
    /// </summary>
    public TerraformExpression EnableDnsSupport => this["enable_dns_support"];

    /// <summary>
    /// The enable_network_address_usage_metrics attribute.
    /// </summary>
    public TerraformExpression EnableNetworkAddressUsageMetrics => this["enable_network_address_usage_metrics"];

    /// <summary>
    /// The instance_tenancy attribute.
    /// </summary>
    public TerraformExpression InstanceTenancy => this["instance_tenancy"];

    /// <summary>
    /// The ipv6_association_id attribute.
    /// </summary>
    public TerraformExpression Ipv6AssociationId => this["ipv6_association_id"];

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformExpression Ipv6CidrBlock => this["ipv6_cidr_block"];

    /// <summary>
    /// The main_route_table_id attribute.
    /// </summary>
    public TerraformExpression MainRouteTableId => this["main_route_table_id"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
