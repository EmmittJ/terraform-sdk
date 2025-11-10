using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_lb.
/// </summary>
public class AwsLbDataSource : TerraformDataSource
{
    public AwsLbDataSource(string name) : base("aws_lb", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLbDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    [TerraformPropertyName("access_logs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AccessLogs => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "access_logs");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnSuffix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_suffix");

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    [TerraformPropertyName("client_keep_alive")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ClientKeepAlive => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "client_keep_alive");

    /// <summary>
    /// The connection_logs attribute.
    /// </summary>
    [TerraformPropertyName("connection_logs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConnectionLogs => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "connection_logs");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerOwnedIpv4Pool => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_owned_ipv4_pool");

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformPropertyName("desync_mitigation_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DesyncMitigationMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "desync_mitigation_mode");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    [TerraformPropertyName("dns_record_client_routing_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsRecordClientRoutingPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_record_client_routing_policy");

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    [TerraformPropertyName("drop_invalid_header_fields")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DropInvalidHeaderFields => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "drop_invalid_header_fields");

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("enable_cross_zone_load_balancing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableCrossZoneLoadBalancing => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_cross_zone_load_balancing");

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("enable_deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableDeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_deletion_protection");

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformPropertyName("enable_http2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableHttp2 => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_http2");

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    [TerraformPropertyName("enable_tls_version_and_cipher_suite_headers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableTlsVersionAndCipherSuiteHeaders => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_tls_version_and_cipher_suite_headers");

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    [TerraformPropertyName("enable_waf_fail_open")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableWafFailOpen => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_waf_fail_open");

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    [TerraformPropertyName("enable_xff_client_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableXffClientPort => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_xff_client_port");

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    [TerraformPropertyName("enable_zonal_shift")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableZonalShift => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_zonal_shift");

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    [TerraformPropertyName("enforce_security_group_inbound_rules_on_private_link_traffic")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "enforce_security_group_inbound_rules_on_private_link_traffic");

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IdleTimeout => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "idle_timeout");

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformPropertyName("internal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Internal => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "internal");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpAddressType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// The ipam_pools attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pools")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpamPools => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ipam_pools");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoadBalancerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_balancer_type");

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    [TerraformPropertyName("preserve_host_header")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PreserveHostHeader => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "preserve_host_header");

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    [TerraformPropertyName("secondary_ips_auto_assigned_per_subnet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SecondaryIpsAutoAssignedPerSubnet => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "secondary_ips_auto_assigned_per_subnet");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> SubnetMapping => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "subnet_mapping");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Subnets => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnets");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    [TerraformPropertyName("xff_header_processing_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> XffHeaderProcessingMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "xff_header_processing_mode");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone_id");

}
