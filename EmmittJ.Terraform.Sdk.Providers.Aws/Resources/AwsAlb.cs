using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_alb resource.
/// </summary>
public class AwsAlb : TerraformResource
{
    public AwsAlb(string name) : base("aws_alb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_suffix");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("zone_id");
    }

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    public double? ClientKeepAlive
    {
        get => GetProperty<TerraformLiteralProperty<double>>("client_keep_alive")?.Value;
        set => this.WithProperty("client_keep_alive", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public string? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_owned_ipv4_pool")?.Value;
        set => this.WithProperty("customer_owned_ipv4_pool", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public string? DesyncMitigationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desync_mitigation_mode")?.Value;
        set => this.WithProperty("desync_mitigation_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public string? DnsRecordClientRoutingPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_record_client_routing_policy")?.Value;
        set => this.WithProperty("dns_record_client_routing_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public bool? DropInvalidHeaderFields
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("drop_invalid_header_fields")?.Value;
        set => this.WithProperty("drop_invalid_header_fields", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public bool? EnableCrossZoneLoadBalancing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_cross_zone_load_balancing")?.Value;
        set => this.WithProperty("enable_cross_zone_load_balancing", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public bool? EnableDeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_deletion_protection")?.Value;
        set => this.WithProperty("enable_deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public bool? EnableHttp2
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_http2")?.Value;
        set => this.WithProperty("enable_http2", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public bool? EnableTlsVersionAndCipherSuiteHeaders
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_tls_version_and_cipher_suite_headers")?.Value;
        set => this.WithProperty("enable_tls_version_and_cipher_suite_headers", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public bool? EnableWafFailOpen
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_waf_fail_open")?.Value;
        set => this.WithProperty("enable_waf_fail_open", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public bool? EnableXffClientPort
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_xff_client_port")?.Value;
        set => this.WithProperty("enable_xff_client_port", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public bool? EnableZonalShift
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_zonal_shift")?.Value;
        set => this.WithProperty("enable_zonal_shift", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public string? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enforce_security_group_inbound_rules_on_private_link_traffic")?.Value;
        set => this.WithProperty("enforce_security_group_inbound_rules_on_private_link_traffic", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public double? IdleTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_timeout")?.Value;
        set => this.WithProperty("idle_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public bool? Internal
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internal")?.Value;
        set => this.WithProperty("internal", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public string? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type")?.Value;
        set => this.WithProperty("ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public string? LoadBalancerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_type")?.Value;
        set => this.WithProperty("load_balancer_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public bool? PreserveHostHeader
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preserve_host_header")?.Value;
        set => this.WithProperty("preserve_host_header", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public double? SecondaryIpsAutoAssignedPerSubnet
    {
        get => GetProperty<TerraformLiteralProperty<double>>("secondary_ips_auto_assigned_per_subnet")?.Value;
        set => this.WithProperty("secondary_ips_auto_assigned_per_subnet", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<string>? Subnets
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnets")?.Value;
        set => this.WithProperty("subnets", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public string? XffHeaderProcessingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xff_header_processing_mode")?.Value;
        set => this.WithProperty("xff_header_processing_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformExpression ArnSuffix => this["arn_suffix"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformExpression ZoneId => this["zone_id"];

}
