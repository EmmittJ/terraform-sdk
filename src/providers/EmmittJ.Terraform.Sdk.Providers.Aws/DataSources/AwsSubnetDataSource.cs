using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsSubnetDataSource.
/// Nesting mode: set
/// </summary>
public class AwsSubnetDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSubnetDataSource.
/// Nesting mode: single
/// </summary>
public class AwsSubnetDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_subnet Terraform data source.
/// Retrieves information about a aws_subnet.
/// </summary>
public partial class AwsSubnetDataSource(string name) : TerraformDataSource("aws_subnet", name)
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZone
    {
        get => GetArgument<TerraformValue<string>>("availability_zone") ?? CreateReference("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_id") ?? CreateReference("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block") ?? CreateReference("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The default_for_az attribute.
    /// </summary>
    public TerraformValue<bool> DefaultForAz
    {
        get => GetArgument<TerraformValue<bool>>("default_for_az") ?? CreateReference("default_for_az");
        set => SetArgument("default_for_az", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block") ?? CreateReference("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state") ?? CreateReference("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id") ?? CreateReference("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    public TerraformValue<bool> AssignIpv6AddressOnCreation
        => CreateReference("assign_ipv6_address_on_creation");

    /// <summary>
    /// The available_ip_address_count attribute.
    /// </summary>
    public TerraformValue<double> AvailableIpAddressCount
        => CreateReference("available_ip_address_count");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIpv4Pool
        => CreateReference("customer_owned_ipv4_pool");

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    public TerraformValue<bool> EnableDns64
        => CreateReference("enable_dns64");

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public TerraformValue<double> EnableLniAtDeviceIndex
        => CreateReference("enable_lni_at_device_index");

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> EnableResourceNameDnsARecordOnLaunch
        => CreateReference("enable_resource_name_dns_a_record_on_launch");

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> EnableResourceNameDnsAaaaRecordOnLaunch
        => CreateReference("enable_resource_name_dns_aaaa_record_on_launch");

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlockAssociationId
        => CreateReference("ipv6_cidr_block_association_id");

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public TerraformValue<bool> Ipv6Native
        => CreateReference("ipv6_native");

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> MapCustomerOwnedIpOnLaunch
        => CreateReference("map_customer_owned_ip_on_launch");

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> MapPublicIpOnLaunch
        => CreateReference("map_public_ip_on_launch");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => CreateReference("outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsHostnameTypeOnLaunch
        => CreateReference("private_dns_hostname_type_on_launch");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSubnetDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsSubnetDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSubnetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSubnetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
