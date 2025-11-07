using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lb resource.
/// </summary>
public class AwsLb : TerraformResource
{
    public AwsLb(string name) : base("aws_lb", name)
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
    public TerraformLiteralProperty<double>? ClientKeepAlive
    {
        get => GetProperty<TerraformLiteralProperty<double>>("client_keep_alive");
        set => this.WithProperty("client_keep_alive", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_owned_ipv4_pool");
        set => this.WithProperty("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DesyncMitigationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("desync_mitigation_mode");
        set => this.WithProperty("desync_mitigation_mode", value);
    }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DnsRecordClientRoutingPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_record_client_routing_policy");
        set => this.WithProperty("dns_record_client_routing_policy", value);
    }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DropInvalidHeaderFields
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("drop_invalid_header_fields");
        set => this.WithProperty("drop_invalid_header_fields", value);
    }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableCrossZoneLoadBalancing
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_cross_zone_load_balancing");
        set => this.WithProperty("enable_cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableDeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_deletion_protection");
        set => this.WithProperty("enable_deletion_protection", value);
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableHttp2
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_http2");
        set => this.WithProperty("enable_http2", value);
    }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableTlsVersionAndCipherSuiteHeaders
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_tls_version_and_cipher_suite_headers");
        set => this.WithProperty("enable_tls_version_and_cipher_suite_headers", value);
    }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableWafFailOpen
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_waf_fail_open");
        set => this.WithProperty("enable_waf_fail_open", value);
    }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableXffClientPort
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_xff_client_port");
        set => this.WithProperty("enable_xff_client_port", value);
    }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableZonalShift
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_zonal_shift");
        set => this.WithProperty("enable_zonal_shift", value);
    }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enforce_security_group_inbound_rules_on_private_link_traffic");
        set => this.WithProperty("enforce_security_group_inbound_rules_on_private_link_traffic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IdleTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("idle_timeout");
        set => this.WithProperty("idle_timeout", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Internal
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internal");
        set => this.WithProperty("internal", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LoadBalancerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("load_balancer_type");
        set => this.WithProperty("load_balancer_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PreserveHostHeader
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("preserve_host_header");
        set => this.WithProperty("preserve_host_header", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? SecondaryIpsAutoAssignedPerSubnet
    {
        get => GetProperty<TerraformLiteralProperty<double>>("secondary_ips_auto_assigned_per_subnet");
        set => this.WithProperty("secondary_ips_auto_assigned_per_subnet", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Subnets
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subnets");
        set => this.WithProperty("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XffHeaderProcessingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xff_header_processing_mode");
        set => this.WithProperty("xff_header_processing_mode", value);
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
