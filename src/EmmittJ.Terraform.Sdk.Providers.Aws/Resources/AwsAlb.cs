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
    public TerraformProperty<double>? ClientKeepAlive
    {
        get => GetProperty<TerraformProperty<double>>("client_keep_alive");
        set => this.WithProperty("client_keep_alive", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformProperty<string>>("customer_owned_ipv4_pool");
        set => this.WithProperty("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DesyncMitigationMode
    {
        get => GetProperty<TerraformProperty<string>>("desync_mitigation_mode");
        set => this.WithProperty("desync_mitigation_mode", value);
    }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DnsRecordClientRoutingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("dns_record_client_routing_policy");
        set => this.WithProperty("dns_record_client_routing_policy", value);
    }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformProperty<bool>? DropInvalidHeaderFields
    {
        get => GetProperty<TerraformProperty<bool>>("drop_invalid_header_fields");
        set => this.WithProperty("drop_invalid_header_fields", value);
    }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableCrossZoneLoadBalancing
    {
        get => GetProperty<TerraformProperty<bool>>("enable_cross_zone_load_balancing");
        set => this.WithProperty("enable_cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableDeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("enable_deletion_protection");
        set => this.WithProperty("enable_deletion_protection", value);
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableHttp2
    {
        get => GetProperty<TerraformProperty<bool>>("enable_http2");
        set => this.WithProperty("enable_http2", value);
    }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableTlsVersionAndCipherSuiteHeaders
    {
        get => GetProperty<TerraformProperty<bool>>("enable_tls_version_and_cipher_suite_headers");
        set => this.WithProperty("enable_tls_version_and_cipher_suite_headers", value);
    }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableWafFailOpen
    {
        get => GetProperty<TerraformProperty<bool>>("enable_waf_fail_open");
        set => this.WithProperty("enable_waf_fail_open", value);
    }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableXffClientPort
    {
        get => GetProperty<TerraformProperty<bool>>("enable_xff_client_port");
        set => this.WithProperty("enable_xff_client_port", value);
    }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableZonalShift
    {
        get => GetProperty<TerraformProperty<bool>>("enable_zonal_shift");
        set => this.WithProperty("enable_zonal_shift", value);
    }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformProperty<string>? EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
    {
        get => GetProperty<TerraformProperty<string>>("enforce_security_group_inbound_rules_on_private_link_traffic");
        set => this.WithProperty("enforce_security_group_inbound_rules_on_private_link_traffic", value);
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
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? IdleTimeout
    {
        get => GetProperty<TerraformProperty<double>>("idle_timeout");
        set => this.WithProperty("idle_timeout", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformProperty<bool>? Internal
    {
        get => GetProperty<TerraformProperty<bool>>("internal");
        set => this.WithProperty("internal", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformProperty<string>? LoadBalancerType
    {
        get => GetProperty<TerraformProperty<string>>("load_balancer_type");
        set => this.WithProperty("load_balancer_type", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformProperty<bool>? PreserveHostHeader
    {
        get => GetProperty<TerraformProperty<bool>>("preserve_host_header");
        set => this.WithProperty("preserve_host_header", value);
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
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformProperty<double>? SecondaryIpsAutoAssignedPerSubnet
    {
        get => GetProperty<TerraformProperty<double>>("secondary_ips_auto_assigned_per_subnet");
        set => this.WithProperty("secondary_ips_auto_assigned_per_subnet", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Subnets
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnets");
        set => this.WithProperty("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformProperty<string>? XffHeaderProcessingMode
    {
        get => GetProperty<TerraformProperty<string>>("xff_header_processing_mode");
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
