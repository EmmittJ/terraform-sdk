using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public class AwsLbAccessLogsBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Prefix { get; set; }

}

/// <summary>
/// Block type for connection_logs in .
/// Nesting mode: list
/// </summary>
public class AwsLbConnectionLogsBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Prefix { get; set; }

}

/// <summary>
/// Block type for ipam_pools in .
/// Nesting mode: list
/// </summary>
public class AwsLbIpamPoolsBlock
{
    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ipv4IpamPoolId is required")]
    [TerraformPropertyName("ipv4_ipam_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Ipv4IpamPoolId { get; set; }

}

/// <summary>
/// Block type for minimum_load_balancer_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsLbMinimumLoadBalancerCapacityBlock
{
    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityUnits is required")]
    [TerraformPropertyName("capacity_units")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> CapacityUnits { get; set; }

}

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsLbSubnetMappingBlock
{
    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("allocation_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AllocationId { get; set; }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Ipv6Address { get; set; }


    /// <summary>
    /// The private_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ipv4_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateIpv4Address { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lb resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLb : TerraformResource
{
    public AwsLb(string name) : base("aws_lb", name)
    {
    }

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    [TerraformPropertyName("client_keep_alive")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ClientKeepAlive { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformPropertyName("desync_mitigation_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesyncMitigationMode { get; set; }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    [TerraformPropertyName("dns_record_client_routing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsRecordClientRoutingPolicy { get; set; }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    [TerraformPropertyName("drop_invalid_header_fields")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DropInvalidHeaderFields { get; set; }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("enable_cross_zone_load_balancing")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableCrossZoneLoadBalancing { get; set; }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("enable_deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableDeletionProtection { get; set; }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformPropertyName("enable_http2")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableHttp2 { get; set; }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    [TerraformPropertyName("enable_tls_version_and_cipher_suite_headers")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableTlsVersionAndCipherSuiteHeaders { get; set; }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    [TerraformPropertyName("enable_waf_fail_open")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableWafFailOpen { get; set; }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    [TerraformPropertyName("enable_xff_client_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableXffClientPort { get; set; }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    [TerraformPropertyName("enable_zonal_shift")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableZonalShift { get; set; }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    [TerraformPropertyName("enforce_security_group_inbound_rules_on_private_link_traffic")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IdleTimeout { get; set; }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformPropertyName("internal")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Internal { get; set; } = default!;

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IpAddressType { get; set; } = default!;

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LoadBalancerType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NamePrefix { get; set; } = default!;

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    [TerraformPropertyName("preserve_host_header")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PreserveHostHeader { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    [TerraformPropertyName("secondary_ips_auto_assigned_per_subnet")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet { get; set; } = default!;

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SecurityGroups { get; set; } = default!;

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Subnets { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    [TerraformPropertyName("xff_header_processing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? XffHeaderProcessingMode { get; set; }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    [TerraformPropertyName("access_logs")]
    public TerraformList<TerraformBlock<AwsLbAccessLogsBlock>>? AccessLogs { get; set; }

    /// <summary>
    /// Block for connection_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogs block(s) allowed")]
    [TerraformPropertyName("connection_logs")]
    public TerraformList<TerraformBlock<AwsLbConnectionLogsBlock>>? ConnectionLogs { get; set; }

    /// <summary>
    /// Block for ipam_pools.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpamPools block(s) allowed")]
    [TerraformPropertyName("ipam_pools")]
    public TerraformList<TerraformBlock<AwsLbIpamPoolsBlock>>? IpamPools { get; set; }

    /// <summary>
    /// Block for minimum_load_balancer_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumLoadBalancerCapacity block(s) allowed")]
    [TerraformPropertyName("minimum_load_balancer_capacity")]
    public TerraformList<TerraformBlock<AwsLbMinimumLoadBalancerCapacityBlock>>? MinimumLoadBalancerCapacity { get; set; }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    public TerraformSet<TerraformBlock<AwsLbSubnetMappingBlock>>? SubnetMapping { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLbTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ArnSuffix => new TerraformReference(this, "arn_suffix");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZoneId => new TerraformReference(this, "zone_id");

}
