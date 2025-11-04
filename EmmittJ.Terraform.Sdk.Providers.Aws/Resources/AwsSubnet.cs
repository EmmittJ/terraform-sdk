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
    public bool? AssignIpv6AddressOnCreation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("assign_ipv6_address_on_creation")?.Value;
        set => this.WithProperty("assign_ipv6_address_on_creation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public string? AvailabilityZoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone_id")?.Value;
        set => this.WithProperty("availability_zone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public string? CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_block")?.Value;
        set => this.WithProperty("cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public string? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_owned_ipv4_pool")?.Value;
        set => this.WithProperty("customer_owned_ipv4_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    public bool? EnableDns64
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_dns64")?.Value;
        set => this.WithProperty("enable_dns64", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public double? EnableLniAtDeviceIndex
    {
        get => GetProperty<TerraformLiteralProperty<double>>("enable_lni_at_device_index")?.Value;
        set => this.WithProperty("enable_lni_at_device_index", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public bool? EnableResourceNameDnsARecordOnLaunch
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_resource_name_dns_a_record_on_launch")?.Value;
        set => this.WithProperty("enable_resource_name_dns_a_record_on_launch", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_resource_name_dns_aaaa_record_on_launch")?.Value;
        set => this.WithProperty("enable_resource_name_dns_aaaa_record_on_launch", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public string? Ipv6CidrBlock
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ipv6_cidr_block")?.Value;
        set => this.WithProperty("ipv6_cidr_block", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public bool? Ipv6Native
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ipv6_native")?.Value;
        set => this.WithProperty("ipv6_native", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public bool? MapCustomerOwnedIpOnLaunch
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("map_customer_owned_ip_on_launch")?.Value;
        set => this.WithProperty("map_customer_owned_ip_on_launch", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public bool? MapPublicIpOnLaunch
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("map_public_ip_on_launch")?.Value;
        set => this.WithProperty("map_public_ip_on_launch", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public string? OutpostArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("outpost_arn")?.Value;
        set => this.WithProperty("outpost_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public string? PrivateDnsHostnameTypeOnLaunch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_dns_hostname_type_on_launch")?.Value;
        set => this.WithProperty("private_dns_hostname_type_on_launch", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
