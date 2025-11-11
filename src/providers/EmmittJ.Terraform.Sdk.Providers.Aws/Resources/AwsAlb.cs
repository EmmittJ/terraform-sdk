using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbAccessLogsBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

}

/// <summary>
/// Block type for connection_logs in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbConnectionLogsBlock : TerraformBlockBase
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Prefix { get; set; }

}

/// <summary>
/// Block type for ipam_pools in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbIpamPoolsBlock : TerraformBlockBase
{
    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ipv4IpamPoolId is required")]
    [TerraformProperty("ipv4_ipam_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Ipv4IpamPoolId { get; set; }

}

/// <summary>
/// Block type for minimum_load_balancer_capacity in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbMinimumLoadBalancerCapacityBlock : TerraformBlockBase
{
    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityUnits is required")]
    [TerraformProperty("capacity_units")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CapacityUnits { get; set; }

}

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: set
/// </summary>
public partial class AwsAlbSubnetMappingBlock : TerraformBlockBase
{
    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformProperty("allocation_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocationId { get; set; }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    [TerraformProperty("ipv6_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ipv6Address { get; set; }


    /// <summary>
    /// The private_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("private_ipv4_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateIpv4Address { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAlbTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_alb resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAlb : TerraformResource
{
    public AwsAlb(string name) : base("aws_alb", name)
    {
    }

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    [TerraformProperty("client_keep_alive")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ClientKeepAlive { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ipv4_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformProperty("desync_mitigation_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DesyncMitigationMode { get; set; }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    [TerraformProperty("dns_record_client_routing_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsRecordClientRoutingPolicy { get; set; }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    [TerraformProperty("drop_invalid_header_fields")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DropInvalidHeaderFields { get; set; }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformProperty("enable_cross_zone_load_balancing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableCrossZoneLoadBalancing { get; set; }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    [TerraformProperty("enable_deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableDeletionProtection { get; set; }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformProperty("enable_http2")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableHttp2 { get; set; }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    [TerraformProperty("enable_tls_version_and_cipher_suite_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableTlsVersionAndCipherSuiteHeaders { get; set; }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    [TerraformProperty("enable_waf_fail_open")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableWafFailOpen { get; set; }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    [TerraformProperty("enable_xff_client_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableXffClientPort { get; set; }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    [TerraformProperty("enable_zonal_shift")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableZonalShift { get; set; }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    [TerraformProperty("enforce_security_group_inbound_rules_on_private_link_traffic")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformProperty("idle_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleTimeout { get; set; }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformProperty("internal")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Internal { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformProperty("load_balancer_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LoadBalancerType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    [TerraformProperty("preserve_host_header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PreserveHostHeader { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    [TerraformProperty("secondary_ips_auto_assigned_per_subnet")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformProperty("subnets")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> Subnets { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    [TerraformProperty("xff_header_processing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? XffHeaderProcessingMode { get; set; }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    [TerraformProperty("access_logs")]
    public partial TerraformList<TerraformBlock<AwsAlbAccessLogsBlock>>? AccessLogs { get; set; }

    /// <summary>
    /// Block for connection_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogs block(s) allowed")]
    [TerraformProperty("connection_logs")]
    public partial TerraformList<TerraformBlock<AwsAlbConnectionLogsBlock>>? ConnectionLogs { get; set; }

    /// <summary>
    /// Block for ipam_pools.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpamPools block(s) allowed")]
    [TerraformProperty("ipam_pools")]
    public partial TerraformList<TerraformBlock<AwsAlbIpamPoolsBlock>>? IpamPools { get; set; }

    /// <summary>
    /// Block for minimum_load_balancer_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumLoadBalancerCapacity block(s) allowed")]
    [TerraformProperty("minimum_load_balancer_capacity")]
    public partial TerraformList<TerraformBlock<AwsAlbMinimumLoadBalancerCapacityBlock>>? MinimumLoadBalancerCapacity { get; set; }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("subnet_mapping")]
    public partial TerraformSet<TerraformBlock<AwsAlbSubnetMappingBlock>>? SubnetMapping { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsAlbTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformProperty("arn_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArnSuffix { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ZoneId { get; }

}
