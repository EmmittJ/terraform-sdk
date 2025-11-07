using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("association");
        this.DeclareOutput("attachment");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("description");
        this.DeclareOutput("interface_type");
        this.DeclareOutput("ipv6_addresses");
        this.DeclareOutput("mac_address");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("private_dns_name");
        this.DeclareOutput("private_ip");
        this.DeclareOutput("private_ips");
        this.DeclareOutput("requester_id");
        this.DeclareOutput("security_groups");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("vpc_id");
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
