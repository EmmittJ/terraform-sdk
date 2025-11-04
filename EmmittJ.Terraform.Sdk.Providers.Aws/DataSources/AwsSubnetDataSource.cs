using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_subnet.
/// </summary>
public class AwsSubnetDataSource : TerraformDataSource
{
    public AwsSubnetDataSource(string name) : base("aws_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("assign_ipv6_address_on_creation");
        this.DeclareOutput("available_ip_address_count");
        this.DeclareOutput("customer_owned_ipv4_pool");
        this.DeclareOutput("enable_dns64");
        this.DeclareOutput("enable_lni_at_device_index");
        this.DeclareOutput("enable_resource_name_dns_a_record_on_launch");
        this.DeclareOutput("enable_resource_name_dns_aaaa_record_on_launch");
        this.DeclareOutput("ipv6_cidr_block_association_id");
        this.DeclareOutput("ipv6_native");
        this.DeclareOutput("map_customer_owned_ip_on_launch");
        this.DeclareOutput("map_public_ip_on_launch");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("private_dns_hostname_type_on_launch");
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
    /// The default_for_az attribute.
    /// </summary>
    public bool? DefaultForAz
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_for_az")?.Value;
        set => this.WithProperty("default_for_az", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The state attribute.
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    public TerraformExpression AssignIpv6AddressOnCreation => this["assign_ipv6_address_on_creation"];

    /// <summary>
    /// The available_ip_address_count attribute.
    /// </summary>
    public TerraformExpression AvailableIpAddressCount => this["available_ip_address_count"];

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformExpression CustomerOwnedIpv4Pool => this["customer_owned_ipv4_pool"];

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    public TerraformExpression EnableDns64 => this["enable_dns64"];

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public TerraformExpression EnableLniAtDeviceIndex => this["enable_lni_at_device_index"];

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public TerraformExpression EnableResourceNameDnsARecordOnLaunch => this["enable_resource_name_dns_a_record_on_launch"];

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public TerraformExpression EnableResourceNameDnsAaaaRecordOnLaunch => this["enable_resource_name_dns_aaaa_record_on_launch"];

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    public TerraformExpression Ipv6CidrBlockAssociationId => this["ipv6_cidr_block_association_id"];

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public TerraformExpression Ipv6Native => this["ipv6_native"];

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public TerraformExpression MapCustomerOwnedIpOnLaunch => this["map_customer_owned_ip_on_launch"];

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public TerraformExpression MapPublicIpOnLaunch => this["map_public_ip_on_launch"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public TerraformExpression PrivateDnsHostnameTypeOnLaunch => this["private_dns_hostname_type_on_launch"];

}
