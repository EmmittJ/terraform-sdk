using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_subnet resource.
/// </summary>
public class AwsDefaultSubnet : TerraformResource
{
    public AwsDefaultSubnet(string name) : base("aws_default_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("availability_zone_id");
        this.DeclareOutput("cidr_block");
        this.DeclareOutput("enable_lni_at_device_index");
        this.DeclareOutput("existing_default_subnet");
        this.DeclareOutput("ipv6_cidr_block_association_id");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("vpc_id");
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
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneId => this["availability_zone_id"];

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformExpression CidrBlock => this["cidr_block"];

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public TerraformExpression EnableLniAtDeviceIndex => this["enable_lni_at_device_index"];

    /// <summary>
    /// The existing_default_subnet attribute.
    /// </summary>
    public TerraformExpression ExistingDefaultSubnet => this["existing_default_subnet"];

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    public TerraformExpression Ipv6CidrBlockAssociationId => this["ipv6_cidr_block_association_id"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
