using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in AwsAlb.
/// Nesting mode: list
/// </summary>
public class AwsAlbAccessLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_logs";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for connection_logs in AwsAlb.
/// Nesting mode: list
/// </summary>
public class AwsAlbConnectionLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_logs";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for ipam_pools in AwsAlb.
/// Nesting mode: list
/// </summary>
public class AwsAlbIpamPoolsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipam_pools";

    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ipv4IpamPoolId is required")]
    public required TerraformValue<string> Ipv4IpamPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipv4_ipam_pool_id");
        set => SetArgument("ipv4_ipam_pool_id", value);
    }

}


/// <summary>
/// Block type for minimum_load_balancer_capacity in AwsAlb.
/// Nesting mode: list
/// </summary>
public class AwsAlbMinimumLoadBalancerCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "minimum_load_balancer_capacity";

    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityUnits is required")]
    public required TerraformValue<double> CapacityUnits
    {
        get => GetRequiredArgument<TerraformValue<double>>("capacity_units");
        set => SetArgument("capacity_units", value);
    }

}


/// <summary>
/// Block type for subnet_mapping in AwsAlb.
/// Nesting mode: set
/// </summary>
public class AwsAlbSubnetMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet_mapping";

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformValue<string>? AllocationId
    {
        get => GetArgument<TerraformValue<string>>("allocation_id");
        set => SetArgument("allocation_id", value);
    }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6Address
    {
        get => GetArgument<TerraformValue<string>>("ipv6_address");
        set => SetArgument("ipv6_address", value);
    }

    /// <summary>
    /// The outpost_id attribute.
    /// </summary>
    public TerraformValue<string> OutpostId
        => CreateReference("outpost_id");

    /// <summary>
    /// The private_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpv4Address
    {
        get => GetArgument<TerraformValue<string>>("private_ipv4_address");
        set => SetArgument("private_ipv4_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAlb.
/// Nesting mode: single
/// </summary>
public class AwsAlbTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_alb Terraform resource.
/// Manages a aws_alb resource.
/// </summary>
public partial class AwsAlb(string name) : TerraformResource("aws_alb", name)
{
    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    public TerraformValue<double>? ClientKeepAlive
    {
        get => GetArgument<TerraformValue<double>>("client_keep_alive");
        set => SetArgument("client_keep_alive", value);
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
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformValue<string>? DesyncMitigationMode
    {
        get => GetArgument<TerraformValue<string>>("desync_mitigation_mode");
        set => SetArgument("desync_mitigation_mode", value);
    }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformValue<string>? DnsRecordClientRoutingPolicy
    {
        get => GetArgument<TerraformValue<string>>("dns_record_client_routing_policy");
        set => SetArgument("dns_record_client_routing_policy", value);
    }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformValue<bool>? DropInvalidHeaderFields
    {
        get => GetArgument<TerraformValue<bool>>("drop_invalid_header_fields");
        set => SetArgument("drop_invalid_header_fields", value);
    }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformValue<bool>? EnableCrossZoneLoadBalancing
    {
        get => GetArgument<TerraformValue<bool>>("enable_cross_zone_load_balancing");
        set => SetArgument("enable_cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("enable_deletion_protection");
        set => SetArgument("enable_deletion_protection", value);
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformValue<bool>? EnableHttp2
    {
        get => GetArgument<TerraformValue<bool>>("enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformValue<bool>? EnableTlsVersionAndCipherSuiteHeaders
    {
        get => GetArgument<TerraformValue<bool>>("enable_tls_version_and_cipher_suite_headers");
        set => SetArgument("enable_tls_version_and_cipher_suite_headers", value);
    }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformValue<bool>? EnableWafFailOpen
    {
        get => GetArgument<TerraformValue<bool>>("enable_waf_fail_open");
        set => SetArgument("enable_waf_fail_open", value);
    }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformValue<bool>? EnableXffClientPort
    {
        get => GetArgument<TerraformValue<bool>>("enable_xff_client_port");
        set => SetArgument("enable_xff_client_port", value);
    }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformValue<bool>? EnableZonalShift
    {
        get => GetArgument<TerraformValue<bool>>("enable_zonal_shift");
        set => SetArgument("enable_zonal_shift", value);
    }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
    {
        get => GetArgument<TerraformValue<string>>("enforce_security_group_inbound_rules_on_private_link_traffic") ?? CreateReference("enforce_security_group_inbound_rules_on_private_link_traffic");
        set => SetArgument("enforce_security_group_inbound_rules_on_private_link_traffic", value);
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
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeout
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout");
        set => SetArgument("idle_timeout", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformValue<bool> InternalAttribute
    {
        get => GetArgument<TerraformValue<bool>>("internal") ?? CreateReference("internal");
        set => SetArgument("internal", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type") ?? CreateReference("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformValue<bool>? PreserveHostHeader
    {
        get => GetArgument<TerraformValue<bool>>("preserve_host_header");
        set => SetArgument("preserve_host_header", value);
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
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet
    {
        get => GetArgument<TerraformValue<double>>("secondary_ips_auto_assigned_per_subnet") ?? CreateReference("secondary_ips_auto_assigned_per_subnet");
        set => SetArgument("secondary_ips_auto_assigned_per_subnet", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups") ?? CreateReference("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string> Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets") ?? CreateReference("subnets");
        set => SetArgument("subnets", value);
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
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformValue<string>? XffHeaderProcessingMode
    {
        get => GetArgument<TerraformValue<string>>("xff_header_processing_mode");
        set => SetArgument("xff_header_processing_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
        => CreateReference("arn_suffix");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
        => CreateReference("zone_id");

    /// <summary>
    /// AccessLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public TerraformList<AwsAlbAccessLogsBlock>? AccessLogs
    {
        get => GetArgument<TerraformList<AwsAlbAccessLogsBlock>>("access_logs");
        set => SetArgument("access_logs", value);
    }

    /// <summary>
    /// ConnectionLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogs block(s) allowed")]
    public TerraformList<AwsAlbConnectionLogsBlock>? ConnectionLogs
    {
        get => GetArgument<TerraformList<AwsAlbConnectionLogsBlock>>("connection_logs");
        set => SetArgument("connection_logs", value);
    }

    /// <summary>
    /// IpamPools block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpamPools block(s) allowed")]
    public TerraformList<AwsAlbIpamPoolsBlock>? IpamPools
    {
        get => GetArgument<TerraformList<AwsAlbIpamPoolsBlock>>("ipam_pools");
        set => SetArgument("ipam_pools", value);
    }

    /// <summary>
    /// MinimumLoadBalancerCapacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumLoadBalancerCapacity block(s) allowed")]
    public TerraformList<AwsAlbMinimumLoadBalancerCapacityBlock>? MinimumLoadBalancerCapacity
    {
        get => GetArgument<TerraformList<AwsAlbMinimumLoadBalancerCapacityBlock>>("minimum_load_balancer_capacity");
        set => SetArgument("minimum_load_balancer_capacity", value);
    }

    /// <summary>
    /// SubnetMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAlbSubnetMappingBlock>? SubnetMapping
    {
        get => GetArgument<TerraformSet<AwsAlbSubnetMappingBlock>>("subnet_mapping");
        set => SetArgument("subnet_mapping", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAlbTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAlbTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
