using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
public class AwsVpcEndpointDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a aws_vpc_endpoint.
/// </summary>
public class AwsVpcEndpointDataSource : TerraformDataSource
{
    public AwsVpcEndpointDataSource(string name) : base("aws_vpc_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("cidr_blocks");
        this.WithOutput("dns_entry");
        this.WithOutput("dns_options");
        this.WithOutput("ip_address_type");
        this.WithOutput("network_interface_ids");
        this.WithOutput("owner_id");
        this.WithOutput("policy");
        this.WithOutput("prefix_list_id");
        this.WithOutput("private_dns_enabled");
        this.WithOutput("requester_managed");
        this.WithOutput("route_table_ids");
        this.WithOutput("security_group_ids");
        this.WithOutput("subnet_ids");
        this.WithOutput("vpc_endpoint_type");
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
    /// The service_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceName
    {
        get => GetProperty<TerraformProperty<string>>("service_name");
        set => this.WithProperty("service_name", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcEndpointDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsVpcEndpointDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcEndpointDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcEndpointDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public TerraformExpression CidrBlocks => this["cidr_blocks"];

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformExpression DnsEntry => this["dns_entry"];

    /// <summary>
    /// The dns_options attribute.
    /// </summary>
    public TerraformExpression DnsOptions => this["dns_options"];

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformExpression IpAddressType => this["ip_address_type"];

    /// <summary>
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformExpression PrefixListId => this["prefix_list_id"];

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public TerraformExpression PrivateDnsEnabled => this["private_dns_enabled"];

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    public TerraformExpression RequesterManaged => this["requester_managed"];

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformExpression RouteTableIds => this["route_table_ids"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    public TerraformExpression VpcEndpointType => this["vpc_endpoint_type"];

}
