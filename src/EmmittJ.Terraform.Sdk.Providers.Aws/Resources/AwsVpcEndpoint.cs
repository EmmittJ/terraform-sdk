using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_endpoint resource.
/// </summary>
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
    public TerraformProperty<HashSet<string>>? RouteTableIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("route_table_ids");
        set => this.WithProperty("route_table_ids", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_group_ids");
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
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
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
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
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
