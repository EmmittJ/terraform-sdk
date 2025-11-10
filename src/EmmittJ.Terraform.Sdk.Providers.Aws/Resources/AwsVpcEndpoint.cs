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
        get => GetProperty<TerraformProperty<string>>("dns_record_ip_type");
        set => WithProperty("dns_record_ip_type", value);
    }

    /// <summary>
    /// The private_dns_only_for_inbound_resolver_endpoint attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateDnsOnlyForInboundResolverEndpoint
    {
        get => GetProperty<TerraformProperty<bool>>("private_dns_only_for_inbound_resolver_endpoint");
        set => WithProperty("private_dns_only_for_inbound_resolver_endpoint", value);
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
        get => GetProperty<TerraformProperty<string>>("ipv4");
        set => WithProperty("ipv4", value);
    }

    /// <summary>
    /// The ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6
    {
        get => GetProperty<TerraformProperty<string>>("ipv6");
        set => WithProperty("ipv6", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("cidr_blocks");
        this.DeclareOutput("dns_entry");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("prefix_list_id");
        this.DeclareOutput("requester_managed");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The auto_accept attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoAccept
    {
        get => GetProperty<TerraformProperty<bool>>("auto_accept");
        set => this.WithProperty("auto_accept", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
    }

    /// <summary>
    /// The private_dns_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateDnsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_dns_enabled");
        set => this.WithProperty("private_dns_enabled", value);
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
    /// The resource_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_configuration_arn");
        set => this.WithProperty("resource_configuration_arn", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RouteTableIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("route_table_ids");
        set => this.WithProperty("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
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
    /// The service_network_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceNetworkArn
    {
        get => GetProperty<TerraformProperty<string>>("service_network_arn");
        set => this.WithProperty("service_network_arn", value);
    }

    /// <summary>
    /// The service_region attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceRegion
    {
        get => GetProperty<TerraformProperty<string>>("service_region");
        set => this.WithProperty("service_region", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_endpoint_type attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointType
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_type");
        set => this.WithProperty("vpc_endpoint_type", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for dns_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsOptions block(s) allowed")]
    public List<AwsVpcEndpointDnsOptionsBlock>? DnsOptions
    {
        get => GetProperty<List<AwsVpcEndpointDnsOptionsBlock>>("dns_options");
        set => this.WithProperty("dns_options", value);
    }

    /// <summary>
    /// Block for subnet_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpcEndpointSubnetConfigurationBlock>? SubnetConfiguration
    {
        get => GetProperty<HashSet<AwsVpcEndpointSubnetConfigurationBlock>>("subnet_configuration");
        set => this.WithProperty("subnet_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVpcEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVpcEndpointTimeoutsBlock>("timeouts");
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
