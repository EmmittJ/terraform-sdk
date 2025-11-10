using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLbDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_lb.
/// </summary>
public class AwsLbDataSource : TerraformDataSource
{
    public AwsLbDataSource(string name) : base("aws_lb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_logs");
        this.WithOutput("arn_suffix");
        this.WithOutput("client_keep_alive");
        this.WithOutput("connection_logs");
        this.WithOutput("customer_owned_ipv4_pool");
        this.WithOutput("desync_mitigation_mode");
        this.WithOutput("dns_name");
        this.WithOutput("dns_record_client_routing_policy");
        this.WithOutput("drop_invalid_header_fields");
        this.WithOutput("enable_cross_zone_load_balancing");
        this.WithOutput("enable_deletion_protection");
        this.WithOutput("enable_http2");
        this.WithOutput("enable_tls_version_and_cipher_suite_headers");
        this.WithOutput("enable_waf_fail_open");
        this.WithOutput("enable_xff_client_port");
        this.WithOutput("enable_zonal_shift");
        this.WithOutput("enforce_security_group_inbound_rules_on_private_link_traffic");
        this.WithOutput("idle_timeout");
        this.WithOutput("internal");
        this.WithOutput("ip_address_type");
        this.WithOutput("ipam_pools");
        this.WithOutput("load_balancer_type");
        this.WithOutput("preserve_host_header");
        this.WithOutput("secondary_ips_auto_assigned_per_subnet");
        this.WithOutput("security_groups");
        this.WithOutput("subnet_mapping");
        this.WithOutput("subnets");
        this.WithOutput("vpc_id");
        this.WithOutput("xff_header_processing_mode");
        this.WithOutput("zone_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLbDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsLbDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    public TerraformExpression AccessLogs => this["access_logs"];

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformExpression ArnSuffix => this["arn_suffix"];

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    public TerraformExpression ClientKeepAlive => this["client_keep_alive"];

    /// <summary>
    /// The connection_logs attribute.
    /// </summary>
    public TerraformExpression ConnectionLogs => this["connection_logs"];

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformExpression CustomerOwnedIpv4Pool => this["customer_owned_ipv4_pool"];

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformExpression DesyncMitigationMode => this["desync_mitigation_mode"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformExpression DnsRecordClientRoutingPolicy => this["dns_record_client_routing_policy"];

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformExpression DropInvalidHeaderFields => this["drop_invalid_header_fields"];

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformExpression EnableCrossZoneLoadBalancing => this["enable_cross_zone_load_balancing"];

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformExpression EnableDeletionProtection => this["enable_deletion_protection"];

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformExpression EnableHttp2 => this["enable_http2"];

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformExpression EnableTlsVersionAndCipherSuiteHeaders => this["enable_tls_version_and_cipher_suite_headers"];

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformExpression EnableWafFailOpen => this["enable_waf_fail_open"];

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformExpression EnableXffClientPort => this["enable_xff_client_port"];

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformExpression EnableZonalShift => this["enable_zonal_shift"];

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformExpression EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic => this["enforce_security_group_inbound_rules_on_private_link_traffic"];

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformExpression IdleTimeout => this["idle_timeout"];

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformExpression Internal => this["internal"];

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformExpression IpAddressType => this["ip_address_type"];

    /// <summary>
    /// The ipam_pools attribute.
    /// </summary>
    public TerraformExpression IpamPools => this["ipam_pools"];

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformExpression LoadBalancerType => this["load_balancer_type"];

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformExpression PreserveHostHeader => this["preserve_host_header"];

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformExpression SecondaryIpsAutoAssignedPerSubnet => this["secondary_ips_auto_assigned_per_subnet"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    public TerraformExpression SubnetMapping => this["subnet_mapping"];

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformExpression Subnets => this["subnets"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformExpression XffHeaderProcessingMode => this["xff_header_processing_mode"];

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformExpression ZoneId => this["zone_id"];

}
