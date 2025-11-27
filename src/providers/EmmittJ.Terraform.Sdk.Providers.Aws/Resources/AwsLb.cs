using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in AwsLb.
/// Nesting mode: list
/// </summary>
public class AwsLbAccessLogsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for connection_logs in AwsLb.
/// Nesting mode: list
/// </summary>
public class AwsLbConnectionLogsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for ipam_pools in AwsLb.
/// Nesting mode: list
/// </summary>
public class AwsLbIpamPoolsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "ipv4_ipam_pool_id");
        set => SetArgument("ipv4_ipam_pool_id", value);
    }

}


/// <summary>
/// Block type for minimum_load_balancer_capacity in AwsLb.
/// Nesting mode: list
/// </summary>
public class AwsLbMinimumLoadBalancerCapacityBlock : TerraformBlock
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
        get => new TerraformReference<double>(this, "capacity_units");
        set => SetArgument("capacity_units", value);
    }

}


/// <summary>
/// Block type for subnet_mapping in AwsLb.
/// Nesting mode: set
/// </summary>
public class AwsLbSubnetMappingBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "allocation_id");
        set => SetArgument("allocation_id", value);
    }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6Address
    {
        get => new TerraformReference<string>(this, "ipv6_address");
        set => SetArgument("ipv6_address", value);
    }

    /// <summary>
    /// The outpost_id attribute.
    /// </summary>
    public TerraformValue<string> OutpostId
    {
        get => new TerraformReference<string>(this, "outpost_id");
    }

    /// <summary>
    /// The private_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpv4Address
    {
        get => new TerraformReference<string>(this, "private_ipv4_address");
        set => SetArgument("private_ipv4_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsLb.
/// Nesting mode: single
/// </summary>
public class AwsLbTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_lb Terraform resource.
/// Manages a aws_lb resource.
/// </summary>
public partial class AwsLb(string name) : TerraformResource("aws_lb", name)
{
    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    public TerraformValue<double>? ClientKeepAlive
    {
        get => new TerraformReference<double>(this, "client_keep_alive");
        set => SetArgument("client_keep_alive", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string>? CustomerOwnedIpv4Pool
    {
        get => new TerraformReference<string>(this, "customer_owned_ipv4_pool");
        set => SetArgument("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformValue<string>? DesyncMitigationMode
    {
        get => new TerraformReference<string>(this, "desync_mitigation_mode");
        set => SetArgument("desync_mitigation_mode", value);
    }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformValue<string>? DnsRecordClientRoutingPolicy
    {
        get => new TerraformReference<string>(this, "dns_record_client_routing_policy");
        set => SetArgument("dns_record_client_routing_policy", value);
    }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformValue<bool>? DropInvalidHeaderFields
    {
        get => new TerraformReference<bool>(this, "drop_invalid_header_fields");
        set => SetArgument("drop_invalid_header_fields", value);
    }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformValue<bool>? EnableCrossZoneLoadBalancing
    {
        get => new TerraformReference<bool>(this, "enable_cross_zone_load_balancing");
        set => SetArgument("enable_cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDeletionProtection
    {
        get => new TerraformReference<bool>(this, "enable_deletion_protection");
        set => SetArgument("enable_deletion_protection", value);
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformValue<bool>? EnableHttp2
    {
        get => new TerraformReference<bool>(this, "enable_http2");
        set => SetArgument("enable_http2", value);
    }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformValue<bool>? EnableTlsVersionAndCipherSuiteHeaders
    {
        get => new TerraformReference<bool>(this, "enable_tls_version_and_cipher_suite_headers");
        set => SetArgument("enable_tls_version_and_cipher_suite_headers", value);
    }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformValue<bool>? EnableWafFailOpen
    {
        get => new TerraformReference<bool>(this, "enable_waf_fail_open");
        set => SetArgument("enable_waf_fail_open", value);
    }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformValue<bool>? EnableXffClientPort
    {
        get => new TerraformReference<bool>(this, "enable_xff_client_port");
        set => SetArgument("enable_xff_client_port", value);
    }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformValue<bool>? EnableZonalShift
    {
        get => new TerraformReference<bool>(this, "enable_zonal_shift");
        set => SetArgument("enable_zonal_shift", value);
    }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
    {
        get => new TerraformReference<string>(this, "enforce_security_group_inbound_rules_on_private_link_traffic");
        set => SetArgument("enforce_security_group_inbound_rules_on_private_link_traffic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeout
    {
        get => new TerraformReference<double>(this, "idle_timeout");
        set => SetArgument("idle_timeout", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformValue<bool> InternalAttribute
    {
        get => new TerraformReference<bool>(this, "internal");
        set => SetArgument("internal", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => new TerraformReference<string>(this, "load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformValue<bool>? PreserveHostHeader
    {
        get => new TerraformReference<bool>(this, "preserve_host_header");
        set => SetArgument("preserve_host_header", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet
    {
        get => new TerraformReference<double>(this, "secondary_ips_auto_assigned_per_subnet");
        set => SetArgument("secondary_ips_auto_assigned_per_subnet", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
        set => SetArgument("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformValue<string>? XffHeaderProcessingMode
    {
        get => new TerraformReference<string>(this, "xff_header_processing_mode");
        set => SetArgument("xff_header_processing_mode", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
    {
        get => new TerraformReference<string>(this, "arn_suffix");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
    }

    /// <summary>
    /// AccessLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public TerraformList<AwsLbAccessLogsBlock>? AccessLogs
    {
        get => GetArgument<TerraformList<AwsLbAccessLogsBlock>>("access_logs");
        set => SetArgument("access_logs", value);
    }

    /// <summary>
    /// ConnectionLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogs block(s) allowed")]
    public TerraformList<AwsLbConnectionLogsBlock>? ConnectionLogs
    {
        get => GetArgument<TerraformList<AwsLbConnectionLogsBlock>>("connection_logs");
        set => SetArgument("connection_logs", value);
    }

    /// <summary>
    /// IpamPools block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpamPools block(s) allowed")]
    public TerraformList<AwsLbIpamPoolsBlock>? IpamPools
    {
        get => GetArgument<TerraformList<AwsLbIpamPoolsBlock>>("ipam_pools");
        set => SetArgument("ipam_pools", value);
    }

    /// <summary>
    /// MinimumLoadBalancerCapacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumLoadBalancerCapacity block(s) allowed")]
    public TerraformList<AwsLbMinimumLoadBalancerCapacityBlock>? MinimumLoadBalancerCapacity
    {
        get => GetArgument<TerraformList<AwsLbMinimumLoadBalancerCapacityBlock>>("minimum_load_balancer_capacity");
        set => SetArgument("minimum_load_balancer_capacity", value);
    }

    /// <summary>
    /// SubnetMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsLbSubnetMappingBlock>? SubnetMapping
    {
        get => GetArgument<TerraformSet<AwsLbSubnetMappingBlock>>("subnet_mapping");
        set => SetArgument("subnet_mapping", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
