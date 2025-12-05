using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsSubnet.
/// Nesting mode: single
/// </summary>
public class AwsSubnetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_subnet Terraform resource.
/// Manages a aws_subnet resource.
/// </summary>
public partial class AwsSubnet(string name) : TerraformResource("aws_subnet", name)
{
    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    public TerraformValue<bool>? AssignIpv6AddressOnCreation
    {
        get => GetArgument<TerraformValue<bool>>("assign_ipv6_address_on_creation");
        set => SetArgument("assign_ipv6_address_on_creation", value);
    }

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
    public TerraformValue<string>? CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string>? CustomerOwnedIpv4Pool
    {
        get => GetArgument<TerraformValue<string>>("customer_owned_ipv4_pool");
        set => SetArgument("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDns64
    {
        get => GetArgument<TerraformValue<bool>>("enable_dns64");
        set => SetArgument("enable_dns64", value);
    }

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public TerraformValue<double>? EnableLniAtDeviceIndex
    {
        get => GetArgument<TerraformValue<double>>("enable_lni_at_device_index");
        set => SetArgument("enable_lni_at_device_index", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public TerraformValue<bool>? EnableResourceNameDnsARecordOnLaunch
    {
        get => GetArgument<TerraformValue<bool>>("enable_resource_name_dns_a_record_on_launch");
        set => SetArgument("enable_resource_name_dns_a_record_on_launch", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public TerraformValue<bool>? EnableResourceNameDnsAaaaRecordOnLaunch
    {
        get => GetArgument<TerraformValue<bool>>("enable_resource_name_dns_aaaa_record_on_launch");
        set => SetArgument("enable_resource_name_dns_aaaa_record_on_launch", value);
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
    public TerraformValue<string>? Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public TerraformValue<bool>? Ipv6Native
    {
        get => GetArgument<TerraformValue<bool>>("ipv6_native");
        set => SetArgument("ipv6_native", value);
    }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public TerraformValue<bool>? MapCustomerOwnedIpOnLaunch
    {
        get => GetArgument<TerraformValue<bool>>("map_customer_owned_ip_on_launch");
        set => SetArgument("map_customer_owned_ip_on_launch", value);
    }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public TerraformValue<bool>? MapPublicIpOnLaunch
    {
        get => GetArgument<TerraformValue<bool>>("map_public_ip_on_launch");
        set => SetArgument("map_public_ip_on_launch", value);
    }

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformValue<string>? OutpostArn
    {
        get => GetArgument<TerraformValue<string>>("outpost_arn");
        set => SetArgument("outpost_arn", value);
    }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public TerraformValue<string> PrivateDnsHostnameTypeOnLaunch
    {
        get => GetArgument<TerraformValue<string>>("private_dns_hostname_type_on_launch") ?? CreateReference("private_dns_hostname_type_on_launch");
        set => SetArgument("private_dns_hostname_type_on_launch", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetRequiredArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    public TerraformValue<string> Ipv6CidrBlockAssociationId
        => CreateReference("ipv6_cidr_block_association_id");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSubnetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSubnetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
