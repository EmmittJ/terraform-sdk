using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public class AwsAlbAccessLogsBlock : TerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        set => SetProperty("prefix", value);
    }

}

/// <summary>
/// Block type for connection_logs in .
/// Nesting mode: list
/// </summary>
public class AwsAlbConnectionLogsBlock : TerraformBlock
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        set => SetProperty("prefix", value);
    }

}

/// <summary>
/// Block type for ipam_pools in .
/// Nesting mode: list
/// </summary>
public class AwsAlbIpamPoolsBlock : TerraformBlock
{
    /// <summary>
    /// The ipv4_ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ipv4IpamPoolId is required")]
    public required TerraformProperty<string> Ipv4IpamPoolId
    {
        set => SetProperty("ipv4_ipam_pool_id", value);
    }

}

/// <summary>
/// Block type for minimum_load_balancer_capacity in .
/// Nesting mode: list
/// </summary>
public class AwsAlbMinimumLoadBalancerCapacityBlock : TerraformBlock
{
    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityUnits is required")]
    public required TerraformProperty<double> CapacityUnits
    {
        set => SetProperty("capacity_units", value);
    }

}

/// <summary>
/// Block type for subnet_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsAlbSubnetMappingBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationId
    {
        set => SetProperty("allocation_id", value);
    }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6Address
    {
        set => SetProperty("ipv6_address", value);
    }

    /// <summary>
    /// The outpost_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostId
    {
        set => SetProperty("outpost_id", value);
    }

    /// <summary>
    /// The private_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpv4Address
    {
        set => SetProperty("private_ipv4_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAlbTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_alb resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAlb : TerraformResource
{
    public AwsAlb(string name) : base("aws_alb", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("arn_suffix");
        SetOutput("dns_name");
        SetOutput("vpc_id");
        SetOutput("zone_id");
        SetOutput("client_keep_alive");
        SetOutput("customer_owned_ipv4_pool");
        SetOutput("desync_mitigation_mode");
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
        SetOutput("id");
        SetOutput("idle_timeout");
        SetOutput("internal");
        SetOutput("ip_address_type");
        SetOutput("load_balancer_type");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("preserve_host_header");
        SetOutput("region");
        SetOutput("secondary_ips_auto_assigned_per_subnet");
        SetOutput("security_groups");
        SetOutput("subnets");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("xff_header_processing_mode");
    }

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    public TerraformProperty<double> ClientKeepAlive
    {
        get => GetRequiredOutput<TerraformProperty<double>>("client_keep_alive");
        set => SetProperty("client_keep_alive", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformProperty<string> CustomerOwnedIpv4Pool
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_owned_ipv4_pool");
        set => SetProperty("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformProperty<string> DesyncMitigationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desync_mitigation_mode");
        set => SetProperty("desync_mitigation_mode", value);
    }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformProperty<string> DnsRecordClientRoutingPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_record_client_routing_policy");
        set => SetProperty("dns_record_client_routing_policy", value);
    }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformProperty<bool> DropInvalidHeaderFields
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("drop_invalid_header_fields");
        set => SetProperty("drop_invalid_header_fields", value);
    }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformProperty<bool> EnableCrossZoneLoadBalancing
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_cross_zone_load_balancing");
        set => SetProperty("enable_cross_zone_load_balancing", value);
    }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformProperty<bool> EnableDeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_deletion_protection");
        set => SetProperty("enable_deletion_protection", value);
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformProperty<bool> EnableHttp2
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_http2");
        set => SetProperty("enable_http2", value);
    }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformProperty<bool> EnableTlsVersionAndCipherSuiteHeaders
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_tls_version_and_cipher_suite_headers");
        set => SetProperty("enable_tls_version_and_cipher_suite_headers", value);
    }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformProperty<bool> EnableWafFailOpen
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_waf_fail_open");
        set => SetProperty("enable_waf_fail_open", value);
    }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformProperty<bool> EnableXffClientPort
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_xff_client_port");
        set => SetProperty("enable_xff_client_port", value);
    }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformProperty<bool> EnableZonalShift
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_zonal_shift");
        set => SetProperty("enable_zonal_shift", value);
    }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformProperty<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
    {
        get => GetRequiredOutput<TerraformProperty<string>>("enforce_security_group_inbound_rules_on_private_link_traffic");
        set => SetProperty("enforce_security_group_inbound_rules_on_private_link_traffic", value);
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
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformProperty<double> IdleTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_timeout");
        set => SetProperty("idle_timeout", value);
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformProperty<bool> Internal
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internal");
        set => SetProperty("internal", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformProperty<string> LoadBalancerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("load_balancer_type");
        set => SetProperty("load_balancer_type", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformProperty<bool> PreserveHostHeader
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("preserve_host_header");
        set => SetProperty("preserve_host_header", value);
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
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformProperty<double> SecondaryIpsAutoAssignedPerSubnet
    {
        get => GetRequiredOutput<TerraformProperty<double>>("secondary_ips_auto_assigned_per_subnet");
        set => SetProperty("secondary_ips_auto_assigned_per_subnet", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_groups");
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Subnets
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnets");
        set => SetProperty("subnets", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformProperty<string> XffHeaderProcessingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xff_header_processing_mode");
        set => SetProperty("xff_header_processing_mode", value);
    }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public List<AwsAlbAccessLogsBlock>? AccessLogs
    {
        set => SetProperty("access_logs", value);
    }

    /// <summary>
    /// Block for connection_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogs block(s) allowed")]
    public List<AwsAlbConnectionLogsBlock>? ConnectionLogs
    {
        set => SetProperty("connection_logs", value);
    }

    /// <summary>
    /// Block for ipam_pools.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpamPools block(s) allowed")]
    public List<AwsAlbIpamPoolsBlock>? IpamPools
    {
        set => SetProperty("ipam_pools", value);
    }

    /// <summary>
    /// Block for minimum_load_balancer_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumLoadBalancerCapacity block(s) allowed")]
    public List<AwsAlbMinimumLoadBalancerCapacityBlock>? MinimumLoadBalancerCapacity
    {
        set => SetProperty("minimum_load_balancer_capacity", value);
    }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAlbSubnetMappingBlock>? SubnetMapping
    {
        set => SetProperty("subnet_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAlbTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
