using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsNetworkInterfaceDataSourceFilterBlock : TerraformBlock
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
public class AwsNetworkInterfaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a aws_network_interface.
/// </summary>
public class AwsNetworkInterfaceDataSource : TerraformDataSource
{
    public AwsNetworkInterfaceDataSource(string name) : base("aws_network_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("association");
        this.WithOutput("attachment");
        this.WithOutput("availability_zone");
        this.WithOutput("description");
        this.WithOutput("interface_type");
        this.WithOutput("ipv6_addresses");
        this.WithOutput("mac_address");
        this.WithOutput("outpost_arn");
        this.WithOutput("owner_id");
        this.WithOutput("private_dns_name");
        this.WithOutput("private_ip");
        this.WithOutput("private_ips");
        this.WithOutput("requester_id");
        this.WithOutput("security_groups");
        this.WithOutput("subnet_id");
        this.WithOutput("vpc_id");
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
    public HashSet<AwsNetworkInterfaceDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsNetworkInterfaceDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkInterfaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkInterfaceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association attribute.
    /// </summary>
    public TerraformExpression Association => this["association"];

    /// <summary>
    /// The attachment attribute.
    /// </summary>
    public TerraformExpression Attachment => this["attachment"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The interface_type attribute.
    /// </summary>
    public TerraformExpression InterfaceType => this["interface_type"];

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformExpression Ipv6Addresses => this["ipv6_addresses"];

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformExpression MacAddress => this["mac_address"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The private_dns_name attribute.
    /// </summary>
    public TerraformExpression PrivateDnsName => this["private_dns_name"];

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public TerraformExpression PrivateIps => this["private_ips"];

    /// <summary>
    /// The requester_id attribute.
    /// </summary>
    public TerraformExpression RequesterId => this["requester_id"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
