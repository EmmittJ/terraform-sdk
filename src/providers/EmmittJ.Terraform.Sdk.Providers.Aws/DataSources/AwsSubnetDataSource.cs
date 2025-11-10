using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsSubnetDataSourceFilterBlock : TerraformBlock
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
public class AwsSubnetDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("arn");
        SetOutput("assign_ipv6_address_on_creation");
        SetOutput("available_ip_address_count");
        SetOutput("customer_owned_ipv4_pool");
        SetOutput("enable_dns64");
        SetOutput("enable_lni_at_device_index");
        SetOutput("enable_resource_name_dns_a_record_on_launch");
        SetOutput("enable_resource_name_dns_aaaa_record_on_launch");
        SetOutput("ipv6_cidr_block_association_id");
        SetOutput("ipv6_native");
        SetOutput("map_customer_owned_ip_on_launch");
        SetOutput("map_public_ip_on_launch");
        SetOutput("outpost_arn");
        SetOutput("owner_id");
        SetOutput("private_dns_hostname_type_on_launch");
        SetOutput("availability_zone");
        SetOutput("availability_zone_id");
        SetOutput("cidr_block");
        SetOutput("default_for_az");
        SetOutput("id");
        SetOutput("ipv6_cidr_block");
        SetOutput("region");
        SetOutput("state");
        SetOutput("tags");
        SetOutput("vpc_id");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_id");
        set => SetProperty("availability_zone_id", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cidr_block");
        set => SetProperty("cidr_block", value);
    }

    /// <summary>
    /// The default_for_az attribute.
    /// </summary>
    public TerraformProperty<bool> DefaultForAz
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("default_for_az");
        set => SetProperty("default_for_az", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_cidr_block");
        set => SetProperty("ipv6_cidr_block", value);
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
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_id");
        set => SetProperty("vpc_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSubnetDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsSubnetDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
