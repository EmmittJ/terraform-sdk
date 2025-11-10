using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public class AwsAlbAccessLogsBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

}

/// <summary>
/// Block type for connection_logs in .
/// Nesting mode: list
/// </summary>
public class AwsAlbConnectionLogsBlock : ITerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

}

/// <summary>
/// Block type for ipam_pools in .
/// Nesting mode: list
/// </summary>
public class AwsAlbIpamPoolsBlock : ITerraformBlock
{
    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ipv4IpamPoolId is required")]
    [TerraformPropertyName("ipv4_ipam_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Ipv4IpamPoolId { get; set; }

}

/// <summary>
/// Block type for minimum_load_balancer_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsAlbMinimumLoadBalancerCapacityBlock : ITerraformBlock
{
    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityUnits is required")]
    [TerraformPropertyName("capacity_units")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> CapacityUnits { get; set; }

}

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsAlbSubnetMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    [TerraformPropertyName("allocation_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocationId { get; set; }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ipv6Address { get; set; }

    /// <summary>
    /// The outpost_id attribute.
    /// </summary>
    [TerraformPropertyName("outpost_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutpostId => new TerraformReferenceProperty<TerraformProperty<string>>("", "outpost_id");

    /// <summary>
    /// The private_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ipv4_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateIpv4Address { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAlbTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_alb resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAlb : TerraformResource
{
    public AwsAlb(string name) : base("aws_alb", name)
    {
    }

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    [TerraformPropertyName("client_keep_alive")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ClientKeepAlive { get; set; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerOwnedIpv4Pool { get; set; }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformPropertyName("desync_mitigation_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DesyncMitigationMode { get; set; }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    [TerraformPropertyName("dns_record_client_routing_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsRecordClientRoutingPolicy { get; set; }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    [TerraformPropertyName("drop_invalid_header_fields")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DropInvalidHeaderFields { get; set; }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("enable_cross_zone_load_balancing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableCrossZoneLoadBalancing { get; set; }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("enable_deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableDeletionProtection { get; set; }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformPropertyName("enable_http2")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableHttp2 { get; set; }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    [TerraformPropertyName("enable_tls_version_and_cipher_suite_headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableTlsVersionAndCipherSuiteHeaders { get; set; }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    [TerraformPropertyName("enable_waf_fail_open")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableWafFailOpen { get; set; }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    [TerraformPropertyName("enable_xff_client_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableXffClientPort { get; set; }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    [TerraformPropertyName("enable_zonal_shift")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableZonalShift { get; set; }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    [TerraformPropertyName("enforce_security_group_inbound_rules_on_private_link_traffic")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "enforce_security_group_inbound_rules_on_private_link_traffic");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IdleTimeout { get; set; }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformPropertyName("internal")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Internal { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "internal");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LoadBalancerType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    [TerraformPropertyName("preserve_host_header")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PreserveHostHeader { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    [TerraformPropertyName("secondary_ips_auto_assigned_per_subnet")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> SecondaryIpsAutoAssignedPerSubnet { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "secondary_ips_auto_assigned_per_subnet");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Subnets { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnets");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    [TerraformPropertyName("xff_header_processing_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? XffHeaderProcessingMode { get; set; }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    [TerraformPropertyName("access_logs")]
    public TerraformList<TerraformBlock<AwsAlbAccessLogsBlock>>? AccessLogs { get; set; } = new();

    /// <summary>
    /// Block for connection_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogs block(s) allowed")]
    [TerraformPropertyName("connection_logs")]
    public TerraformList<TerraformBlock<AwsAlbConnectionLogsBlock>>? ConnectionLogs { get; set; } = new();

    /// <summary>
    /// Block for ipam_pools.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpamPools block(s) allowed")]
    [TerraformPropertyName("ipam_pools")]
    public TerraformList<TerraformBlock<AwsAlbIpamPoolsBlock>>? IpamPools { get; set; } = new();

    /// <summary>
    /// Block for minimum_load_balancer_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumLoadBalancerCapacity block(s) allowed")]
    [TerraformPropertyName("minimum_load_balancer_capacity")]
    public TerraformList<TerraformBlock<AwsAlbMinimumLoadBalancerCapacityBlock>>? MinimumLoadBalancerCapacity { get; set; } = new();

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    public TerraformSet<TerraformBlock<AwsAlbSubnetMappingBlock>>? SubnetMapping { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAlbTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_suffix");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_id");

}
