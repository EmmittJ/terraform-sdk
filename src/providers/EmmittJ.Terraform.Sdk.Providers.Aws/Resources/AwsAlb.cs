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
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => WithProperty("prefix", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => WithProperty("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => WithProperty("prefix", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("ipv4_ipam_pool_id");
        set => WithProperty("ipv4_ipam_pool_id", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("capacity_units");
        set => WithProperty("capacity_units", value);
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
        get => GetProperty<TerraformProperty<string>>("allocation_id");
        set => WithProperty("allocation_id", value);
    }

    /// <summary>
    /// The ipv6_address attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6Address
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_address");
        set => WithProperty("ipv6_address", value);
    }

    /// <summary>
    /// The outpost_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutpostId
    {
        get => GetProperty<TerraformProperty<string>>("outpost_id");
        set => WithProperty("outpost_id", value);
    }

    /// <summary>
    /// The private_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpv4Address
    {
        get => GetProperty<TerraformProperty<string>>("private_ipv4_address");
        set => WithProperty("private_ipv4_address", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.WithOutput("arn");
        this.WithOutput("arn_suffix");
        this.WithOutput("dns_name");
        this.WithOutput("vpc_id");
        this.WithOutput("zone_id");
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
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => this.WithProperty("subnets", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
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
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public List<AwsAlbAccessLogsBlock>? AccessLogs
    {
        get => GetProperty<List<AwsAlbAccessLogsBlock>>("access_logs");
        set => this.WithProperty("access_logs", value);
    }

    /// <summary>
    /// Block for connection_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionLogs block(s) allowed")]
    public List<AwsAlbConnectionLogsBlock>? ConnectionLogs
    {
        get => GetProperty<List<AwsAlbConnectionLogsBlock>>("connection_logs");
        set => this.WithProperty("connection_logs", value);
    }

    /// <summary>
    /// Block for ipam_pools.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpamPools block(s) allowed")]
    public List<AwsAlbIpamPoolsBlock>? IpamPools
    {
        get => GetProperty<List<AwsAlbIpamPoolsBlock>>("ipam_pools");
        set => this.WithProperty("ipam_pools", value);
    }

    /// <summary>
    /// Block for minimum_load_balancer_capacity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinimumLoadBalancerCapacity block(s) allowed")]
    public List<AwsAlbMinimumLoadBalancerCapacityBlock>? MinimumLoadBalancerCapacity
    {
        get => GetProperty<List<AwsAlbMinimumLoadBalancerCapacityBlock>>("minimum_load_balancer_capacity");
        set => this.WithProperty("minimum_load_balancer_capacity", value);
    }

    /// <summary>
    /// Block for subnet_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAlbSubnetMappingBlock>? SubnetMapping
    {
        get => GetProperty<HashSet<AwsAlbSubnetMappingBlock>>("subnet_mapping");
        set => this.WithProperty("subnet_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsAlbTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsAlbTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
