using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_alb.
/// </summary>
public class AwsAlbDataSource : TerraformDataSource
{
    public AwsAlbDataSource(string name) : base("aws_alb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        DeclareOutput("access_logs");
        DeclareOutput("arn_suffix");
        DeclareOutput("client_keep_alive");
        DeclareOutput("connection_logs");
        DeclareOutput("customer_owned_ipv4_pool");
        DeclareOutput("desync_mitigation_mode");
        DeclareOutput("dns_name");
        DeclareOutput("dns_record_client_routing_policy");
        DeclareOutput("drop_invalid_header_fields");
        DeclareOutput("enable_cross_zone_load_balancing");
        DeclareOutput("enable_deletion_protection");
        DeclareOutput("enable_http2");
        DeclareOutput("enable_tls_version_and_cipher_suite_headers");
        DeclareOutput("enable_waf_fail_open");
        DeclareOutput("enable_xff_client_port");
        DeclareOutput("enable_zonal_shift");
        DeclareOutput("enforce_security_group_inbound_rules_on_private_link_traffic");
        DeclareOutput("idle_timeout");
        DeclareOutput("internal");
        DeclareOutput("ip_address_type");
        DeclareOutput("ipam_pools");
        DeclareOutput("load_balancer_type");
        DeclareOutput("preserve_host_header");
        DeclareOutput("security_groups");
        DeclareOutput("subnet_mapping");
        DeclareOutput("subnets");
        DeclareOutput("vpc_id");
        DeclareOutput("xff_header_processing_mode");
        DeclareOutput("zone_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("arn")?.Value;
        set => WithPropertyInternal("arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("name")?.Value;
        set => WithPropertyInternal("name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
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
