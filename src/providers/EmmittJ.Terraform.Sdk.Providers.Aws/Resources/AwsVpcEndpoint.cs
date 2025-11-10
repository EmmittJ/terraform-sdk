using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dns_options in .
/// Nesting mode: list
/// </summary>
public class AwsVpcEndpointDnsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The dns_record_ip_type attribute.
    /// </summary>
    public TerraformProperty<string>? DnsRecordIpType
    {
        set => SetProperty("dns_record_ip_type", value);
    }

    /// <summary>
    /// The private_dns_only_for_inbound_resolver_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateDnsOnlyForInboundResolverEndpoint
    {
        set => SetProperty("private_dns_only_for_inbound_resolver_endpoint", value);
    }

}

/// <summary>
/// Block type for subnet_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsVpcEndpointSubnetConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The ipv4 attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv4
    {
        set => SetProperty("ipv4", value);
    }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6
    {
        set => SetProperty("ipv6", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVpcEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_vpc_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVpcEndpoint : TerraformResource
{
    public AwsVpcEndpoint(string name) : base("aws_vpc_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("cidr_blocks");
        SetOutput("dns_entry");
        SetOutput("network_interface_ids");
        SetOutput("owner_id");
        SetOutput("prefix_list_id");
        SetOutput("requester_managed");
        SetOutput("state");
        SetOutput("auto_accept");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("policy");
        SetOutput("private_dns_enabled");
        SetOutput("region");
        SetOutput("resource_configuration_arn");
        SetOutput("route_table_ids");
        SetOutput("security_group_ids");
        SetOutput("service_name");
        SetOutput("service_network_arn");
        SetOutput("service_region");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_endpoint_type");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformProperty<bool> AutoAccept
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_accept");
        set => SetProperty("auto_accept", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string> Policy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy");
        set => SetProperty("policy", value);
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateDnsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_dns_enabled");
        set => SetProperty("private_dns_enabled", value);
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
    /// The resource_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string> ResourceConfigurationArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_configuration_arn");
        set => SetProperty("resource_configuration_arn", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> RouteTableIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("route_table_ids");
        set => SetProperty("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
    }

    /// <summary>
    /// The service_network_arn attribute.
    /// </summary>
    public TerraformProperty<string> ServiceNetworkArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_network_arn");
        set => SetProperty("service_network_arn", value);
    }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    public TerraformProperty<string> ServiceRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_region");
        set => SetProperty("service_region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
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
    /// The vpc_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string> VpcEndpointType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_type");
        set => SetProperty("vpc_endpoint_type", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for dns_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsOptions block(s) allowed")]
    public List<AwsVpcEndpointDnsOptionsBlock>? DnsOptions
    {
        set => SetProperty("dns_options", value);
    }

    /// <summary>
    /// Block for subnet_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcEndpointSubnetConfigurationBlock>? SubnetConfiguration
    {
        set => SetProperty("subnet_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcEndpointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
    /// The network_interface_ids attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceIds => this["network_interface_ids"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The prefix_list_id attribute.
    /// </summary>
    public TerraformExpression PrefixListId => this["prefix_list_id"];

    /// <summary>
    /// The requester_managed attribute.
    /// </summary>
    public TerraformExpression RequesterManaged => this["requester_managed"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
