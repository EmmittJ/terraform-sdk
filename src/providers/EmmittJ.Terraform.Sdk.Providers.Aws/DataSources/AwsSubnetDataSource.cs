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
        get => GetArgument<TerraformValue<string>>("availability_zone") ?? AsReference("availability_zone");
        set => SetArgument("availability_zone", value);
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string> AvailabilityZoneId
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_id") ?? AsReference("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string> CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block") ?? AsReference("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The default_for_az attribute.
    /// </summary>
    public TerraformValue<bool> DefaultForAz
    {
        get => GetArgument<TerraformValue<bool>>("default_for_az") ?? AsReference("default_for_az");
        set => SetArgument("default_for_az", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block") ?? AsReference("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => GetArgument<TerraformValue<string>>("state") ?? AsReference("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id") ?? AsReference("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    public TerraformValue<bool> AssignIpv6AddressOnCreation
        => AsReference("assign_ipv6_address_on_creation");

    /// <summary>
    /// The available_ip_address_count attribute.
    /// </summary>
    public TerraformValue<double> AvailableIpAddressCount
        => AsReference("available_ip_address_count");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIpv4Pool
        => AsReference("customer_owned_ipv4_pool");

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    public TerraformValue<bool> EnableDns64
        => AsReference("enable_dns64");

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public TerraformValue<double> EnableLniAtDeviceIndex
        => AsReference("enable_lni_at_device_index");

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> EnableResourceNameDnsARecordOnLaunch
        => AsReference("enable_resource_name_dns_a_record_on_launch");

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> EnableResourceNameDnsAaaaRecordOnLaunch
        => AsReference("enable_resource_name_dns_aaaa_record_on_launch");

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlockAssociationId
        => AsReference("ipv6_cidr_block_association_id");

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public TerraformValue<bool> Ipv6Native
        => AsReference("ipv6_native");

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> MapCustomerOwnedIpOnLaunch
        => AsReference("map_customer_owned_ip_on_launch");

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public TerraformValue<bool> MapPublicIpOnLaunch
        => AsReference("map_public_ip_on_launch");

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string> OutpostArn
        => AsReference("outpost_arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsHostnameTypeOnLaunch
        => AsReference("private_dns_hostname_type_on_launch");

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
