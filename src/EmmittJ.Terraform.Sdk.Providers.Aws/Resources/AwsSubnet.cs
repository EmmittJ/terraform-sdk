using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_subnet resource.
/// </summary>
public class AwsSubnet : TerraformResource
{
    public AwsSubnet(string name) : base("aws_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("ipv6_cidr_block_association_id");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    public TerraformProperty<bool>? AssignIpv6AddressOnCreation
    {
        get => GetProperty<TerraformProperty<bool>>("assign_ipv6_address_on_creation");
        set => this.WithProperty("assign_ipv6_address_on_creation", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneId
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_id");
        set => this.WithProperty("availability_zone_id", value);
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
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformProperty<string>>("customer_owned_ipv4_pool");
        set => this.WithProperty("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableDns64
    {
        get => GetProperty<TerraformProperty<bool>>("enable_dns64");
        set => this.WithProperty("enable_dns64", value);
    }

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public TerraformProperty<double>? EnableLniAtDeviceIndex
    {
        get => GetProperty<TerraformProperty<double>>("enable_lni_at_device_index");
        set => this.WithProperty("enable_lni_at_device_index", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceNameDnsARecordOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("enable_resource_name_dns_a_record_on_launch");
        set => this.WithProperty("enable_resource_name_dns_a_record_on_launch", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceNameDnsAaaaRecordOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("enable_resource_name_dns_aaaa_record_on_launch");
        set => this.WithProperty("enable_resource_name_dns_aaaa_record_on_launch", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_cidr_block");
        set => this.WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public TerraformProperty<bool>? Ipv6Native
    {
        get => GetProperty<TerraformProperty<bool>>("ipv6_native");
        set => this.WithProperty("ipv6_native", value);
    }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? MapCustomerOwnedIpOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("map_customer_owned_ip_on_launch");
        set => this.WithProperty("map_customer_owned_ip_on_launch", value);
    }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? MapPublicIpOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("map_public_ip_on_launch");
        set => this.WithProperty("map_public_ip_on_launch", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostArn
    {
        get => GetProperty<TerraformProperty<string>>("outpost_arn");
        set => this.WithProperty("outpost_arn", value);
    }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateDnsHostnameTypeOnLaunch
    {
        get => GetProperty<TerraformProperty<string>>("private_dns_hostname_type_on_launch");
        set => this.WithProperty("private_dns_hostname_type_on_launch", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    public TerraformExpression Ipv6CidrBlockAssociationId => this["ipv6_cidr_block_association_id"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
