using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAlbDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_alb.
/// </summary>
public partial class AwsAlbDataSource : TerraformDataSource
{
    public AwsAlbDataSource(string name) : base("aws_alb", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsAlbDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    [TerraformProperty("access_logs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AccessLogs { get; }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    [TerraformProperty("arn_suffix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ArnSuffix { get; }

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    [TerraformProperty("client_keep_alive")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ClientKeepAlive { get; }

    /// <summary>
    /// The connection_logs attribute.
    /// </summary>
    [TerraformProperty("connection_logs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConnectionLogs { get; }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    [TerraformProperty("customer_owned_ipv4_pool")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerOwnedIpv4Pool { get; }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    [TerraformProperty("desync_mitigation_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DesyncMitigationMode { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    [TerraformProperty("dns_record_client_routing_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsRecordClientRoutingPolicy { get; }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    [TerraformProperty("drop_invalid_header_fields")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DropInvalidHeaderFields { get; }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    [TerraformProperty("enable_cross_zone_load_balancing")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableCrossZoneLoadBalancing { get; }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    [TerraformProperty("enable_deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableDeletionProtection { get; }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    [TerraformProperty("enable_http2")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableHttp2 { get; }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    [TerraformProperty("enable_tls_version_and_cipher_suite_headers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableTlsVersionAndCipherSuiteHeaders { get; }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    [TerraformProperty("enable_waf_fail_open")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableWafFailOpen { get; }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    [TerraformProperty("enable_xff_client_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableXffClientPort { get; }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    [TerraformProperty("enable_zonal_shift")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableZonalShift { get; }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    [TerraformProperty("enforce_security_group_inbound_rules_on_private_link_traffic")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic { get; }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformProperty("idle_timeout")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> IdleTimeout { get; }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    [TerraformProperty("internal")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Internal { get; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IpAddressType { get; }

    /// <summary>
    /// The ipam_pools attribute.
    /// </summary>
    [TerraformProperty("ipam_pools")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpamPools { get; }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    [TerraformProperty("load_balancer_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LoadBalancerType { get; }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    [TerraformProperty("preserve_host_header")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PreserveHostHeader { get; }

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    [TerraformProperty("secondary_ips_auto_assigned_per_subnet")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    [TerraformProperty("subnet_mapping")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> SubnetMapping { get; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformProperty("subnets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> Subnets { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    [TerraformProperty("xff_header_processing_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> XffHeaderProcessingMode { get; }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    [TerraformProperty("zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ZoneId { get; }

}
