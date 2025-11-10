using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpcDhcpOptionsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcDhcpOptionsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_vpc_dhcp_options.
/// </summary>
public class AwsVpcDhcpOptionsDataSource : TerraformDataSource
{
    public AwsVpcDhcpOptionsDataSource(string name) : base("aws_vpc_dhcp_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("domain_name");
        SetOutput("domain_name_servers");
        SetOutput("ipv6_address_preferred_lease_time");
        SetOutput("netbios_name_servers");
        SetOutput("netbios_node_type");
        SetOutput("ntp_servers");
        SetOutput("owner_id");
        SetOutput("dhcp_options_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The dhcp_options_id attribute.
    /// </summary>
    public TerraformProperty<string> DhcpOptionsId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dhcp_options_id");
        set => SetProperty("dhcp_options_id", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcDhcpOptionsDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcDhcpOptionsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The domain_name_servers attribute.
    /// </summary>
    public TerraformExpression DomainNameServers => this["domain_name_servers"];

    /// <summary>
    /// The ipv6_address_preferred_lease_time attribute.
    /// </summary>
    public TerraformExpression Ipv6AddressPreferredLeaseTime => this["ipv6_address_preferred_lease_time"];

    /// <summary>
    /// The netbios_name_servers attribute.
    /// </summary>
    public TerraformExpression NetbiosNameServers => this["netbios_name_servers"];

    /// <summary>
    /// The netbios_node_type attribute.
    /// </summary>
    public TerraformExpression NetbiosNodeType => this["netbios_node_type"];

    /// <summary>
    /// The ntp_servers attribute.
    /// </summary>
    public TerraformExpression NtpServers => this["ntp_servers"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
