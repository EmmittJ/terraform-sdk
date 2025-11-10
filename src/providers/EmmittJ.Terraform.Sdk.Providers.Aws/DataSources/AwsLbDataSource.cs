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
        set => SetProperty("read", value);
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
        SetOutput("access_logs");
        SetOutput("arn_suffix");
        SetOutput("client_keep_alive");
        SetOutput("connection_logs");
        SetOutput("customer_owned_ipv4_pool");
        SetOutput("desync_mitigation_mode");
        SetOutput("dns_name");
        SetOutput("dns_record_client_routing_policy");
        SetOutput("drop_invalid_header_fields");
        SetOutput("enable_cross_zone_load_balancing");
        SetOutput("enable_deletion_protection");
        SetOutput("enable_http2");
        SetOutput("enable_tls_version_and_cipher_suite_headers");
        SetOutput("enable_waf_fail_open");
        SetOutput("enable_xff_client_port");
        SetOutput("enable_zonal_shift");
        SetOutput("enforce_security_group_inbound_rules_on_private_link_traffic");
        SetOutput("idle_timeout");
        SetOutput("internal");
        SetOutput("ip_address_type");
        SetOutput("ipam_pools");
        SetOutput("load_balancer_type");
        SetOutput("preserve_host_header");
        SetOutput("secondary_ips_auto_assigned_per_subnet");
        SetOutput("security_groups");
        SetOutput("subnet_mapping");
        SetOutput("subnets");
        SetOutput("vpc_id");
        SetOutput("xff_header_processing_mode");
        SetOutput("zone_id");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLbDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
