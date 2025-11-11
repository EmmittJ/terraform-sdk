using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLbDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    [TerraformPropertyName("access_logs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AccessLogs => new TerraformReference(this, "access_logs");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformPropertyName("arn_suffix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ArnSuffix => new TerraformReference(this, "arn_suffix");

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    [TerraformPropertyName("client_keep_alive")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ClientKeepAlive => new TerraformReference(this, "client_keep_alive");

    /// <summary>
    /// The connection_logs attribute.
    /// </summary>
    [TerraformPropertyName("connection_logs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConnectionLogs => new TerraformReference(this, "connection_logs");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformPropertyName("customer_owned_ipv4_pool")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomerOwnedIpv4Pool => new TerraformReference(this, "customer_owned_ipv4_pool");

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformPropertyName("desync_mitigation_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DesyncMitigationMode => new TerraformReference(this, "desync_mitigation_mode");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    [TerraformPropertyName("dns_record_client_routing_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsRecordClientRoutingPolicy => new TerraformReference(this, "dns_record_client_routing_policy");

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    [TerraformPropertyName("drop_invalid_header_fields")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DropInvalidHeaderFields => new TerraformReference(this, "drop_invalid_header_fields");

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformPropertyName("enable_cross_zone_load_balancing")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableCrossZoneLoadBalancing => new TerraformReference(this, "enable_cross_zone_load_balancing");

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("enable_deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableDeletionProtection => new TerraformReference(this, "enable_deletion_protection");

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformPropertyName("enable_http2")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableHttp2 => new TerraformReference(this, "enable_http2");

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    [TerraformPropertyName("enable_tls_version_and_cipher_suite_headers")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableTlsVersionAndCipherSuiteHeaders => new TerraformReference(this, "enable_tls_version_and_cipher_suite_headers");

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    [TerraformPropertyName("enable_waf_fail_open")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableWafFailOpen => new TerraformReference(this, "enable_waf_fail_open");

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    [TerraformPropertyName("enable_xff_client_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableXffClientPort => new TerraformReference(this, "enable_xff_client_port");

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    [TerraformPropertyName("enable_zonal_shift")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableZonalShift => new TerraformReference(this, "enable_zonal_shift");

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    [TerraformPropertyName("enforce_security_group_inbound_rules_on_private_link_traffic")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic => new TerraformReference(this, "enforce_security_group_inbound_rules_on_private_link_traffic");

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IdleTimeout => new TerraformReference(this, "idle_timeout");

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformPropertyName("internal")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Internal => new TerraformReference(this, "internal");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddressType => new TerraformReference(this, "ip_address_type");

    /// <summary>
    /// The ipam_pools attribute.
    /// </summary>
    [TerraformPropertyName("ipam_pools")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpamPools => new TerraformReference(this, "ipam_pools");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoadBalancerType => new TerraformReference(this, "load_balancer_type");

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    [TerraformPropertyName("preserve_host_header")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PreserveHostHeader => new TerraformReference(this, "preserve_host_header");

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    [TerraformPropertyName("secondary_ips_auto_assigned_per_subnet")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet => new TerraformReference(this, "secondary_ips_auto_assigned_per_subnet");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroups => new TerraformReference(this, "security_groups");

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    [TerraformPropertyName("subnet_mapping")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> SubnetMapping => new TerraformReference(this, "subnet_mapping");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Subnets => new TerraformReference(this, "subnets");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    [TerraformPropertyName("xff_header_processing_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> XffHeaderProcessingMode => new TerraformReference(this, "xff_header_processing_mode");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformPropertyName("zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ZoneId => new TerraformReference(this, "zone_id");

}
