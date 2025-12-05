using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLbDataSource.
/// Nesting mode: single
/// </summary>
public class AwsLbDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_lb Terraform data source.
/// Retrieves information about a aws_lb.
/// </summary>
public partial class AwsLbDataSource(string name) : TerraformDataSource("aws_lb", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn") ?? CreateReference("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessLogs
        => CreateReference("access_logs");

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
        => CreateReference("arn_suffix");

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    public TerraformValue<double> ClientKeepAlive
        => CreateReference("client_keep_alive");

    /// <summary>
    /// The connection_logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionLogs
        => CreateReference("connection_logs");

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIpv4Pool
        => CreateReference("customer_owned_ipv4_pool");

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformValue<string> DesyncMitigationMode
        => CreateReference("desync_mitigation_mode");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
        => CreateReference("dns_name");

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformValue<string> DnsRecordClientRoutingPolicy
        => CreateReference("dns_record_client_routing_policy");

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformValue<bool> DropInvalidHeaderFields
        => CreateReference("drop_invalid_header_fields");

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformValue<bool> EnableCrossZoneLoadBalancing
        => CreateReference("enable_cross_zone_load_balancing");

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> EnableDeletionProtection
        => CreateReference("enable_deletion_protection");

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformValue<bool> EnableHttp2
        => CreateReference("enable_http2");

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformValue<bool> EnableTlsVersionAndCipherSuiteHeaders
        => CreateReference("enable_tls_version_and_cipher_suite_headers");

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformValue<bool> EnableWafFailOpen
        => CreateReference("enable_waf_fail_open");

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformValue<bool> EnableXffClientPort
        => CreateReference("enable_xff_client_port");

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformValue<bool> EnableZonalShift
        => CreateReference("enable_zonal_shift");

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
        => CreateReference("enforce_security_group_inbound_rules_on_private_link_traffic");

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeout
        => CreateReference("idle_timeout");

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformValue<bool> InternalAttribute
        => CreateReference("internal");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
        => CreateReference("ip_address_type");

    /// <summary>
    /// The ipam_pools attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpamPools
        => CreateReference("ipam_pools");

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancerType
        => CreateReference("load_balancer_type");

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformValue<bool> PreserveHostHeader
        => CreateReference("preserve_host_header");

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet
        => CreateReference("secondary_ips_auto_assigned_per_subnet");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
        => CreateReference("security_groups");

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> SubnetMapping
        => CreateReference("subnet_mapping");

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string> Subnets
        => CreateReference("subnets");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformValue<string> XffHeaderProcessingMode
        => CreateReference("xff_header_processing_mode");

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
        => CreateReference("zone_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
