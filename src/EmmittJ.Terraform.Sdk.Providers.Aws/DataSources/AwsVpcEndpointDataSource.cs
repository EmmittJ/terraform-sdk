using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("cidr_blocks");
        this.DeclareOutput("dns_entry");
        this.DeclareOutput("dns_options");
        this.DeclareOutput("ip_address_type");
        this.DeclareOutput("network_interface_ids");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("policy");
        this.DeclareOutput("prefix_list_id");
        this.DeclareOutput("private_dns_enabled");
        this.DeclareOutput("requester_managed");
        this.DeclareOutput("route_table_ids");
        this.DeclareOutput("security_group_ids");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("vpc_endpoint_type");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
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
