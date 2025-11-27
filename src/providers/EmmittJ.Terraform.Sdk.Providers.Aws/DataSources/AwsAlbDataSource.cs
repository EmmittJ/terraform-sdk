using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsAlbDataSource.
/// Nesting mode: single
/// </summary>
public class AwsAlbDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_alb Terraform data source.
/// Retrieves information about a aws_alb.
/// </summary>
public partial class AwsAlbDataSource(string name) : TerraformDataSource("aws_alb", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccessLogs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "access_logs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn_suffix attribute.
    /// </summary>
    public TerraformValue<string> ArnSuffix
    {
        get => new TerraformReference<string>(this, "arn_suffix");
    }

    /// <summary>
    /// The client_keep_alive attribute.
    /// </summary>
    public TerraformValue<double> ClientKeepAlive
    {
        get => new TerraformReference<double>(this, "client_keep_alive");
    }

    /// <summary>
    /// The connection_logs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionLogs
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connection_logs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformValue<string> CustomerOwnedIpv4Pool
    {
        get => new TerraformReference<string>(this, "customer_owned_ipv4_pool");
    }

    /// <summary>
    /// The desync_mitigation_mode attribute.
    /// </summary>
    public TerraformValue<string> DesyncMitigationMode
    {
        get => new TerraformReference<string>(this, "desync_mitigation_mode");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformValue<string> DnsName
    {
        get => new TerraformReference<string>(this, "dns_name");
    }

    /// <summary>
    /// The dns_record_client_routing_policy attribute.
    /// </summary>
    public TerraformValue<string> DnsRecordClientRoutingPolicy
    {
        get => new TerraformReference<string>(this, "dns_record_client_routing_policy");
    }

    /// <summary>
    /// The drop_invalid_header_fields attribute.
    /// </summary>
    public TerraformValue<bool> DropInvalidHeaderFields
    {
        get => new TerraformReference<bool>(this, "drop_invalid_header_fields");
    }

    /// <summary>
    /// The enable_cross_zone_load_balancing attribute.
    /// </summary>
    public TerraformValue<bool> EnableCrossZoneLoadBalancing
    {
        get => new TerraformReference<bool>(this, "enable_cross_zone_load_balancing");
    }

    /// <summary>
    /// The enable_deletion_protection attribute.
    /// </summary>
    public TerraformValue<bool> EnableDeletionProtection
    {
        get => new TerraformReference<bool>(this, "enable_deletion_protection");
    }

    /// <summary>
    /// The enable_http2 attribute.
    /// </summary>
    public TerraformValue<bool> EnableHttp2
    {
        get => new TerraformReference<bool>(this, "enable_http2");
    }

    /// <summary>
    /// The enable_tls_version_and_cipher_suite_headers attribute.
    /// </summary>
    public TerraformValue<bool> EnableTlsVersionAndCipherSuiteHeaders
    {
        get => new TerraformReference<bool>(this, "enable_tls_version_and_cipher_suite_headers");
    }

    /// <summary>
    /// The enable_waf_fail_open attribute.
    /// </summary>
    public TerraformValue<bool> EnableWafFailOpen
    {
        get => new TerraformReference<bool>(this, "enable_waf_fail_open");
    }

    /// <summary>
    /// The enable_xff_client_port attribute.
    /// </summary>
    public TerraformValue<bool> EnableXffClientPort
    {
        get => new TerraformReference<bool>(this, "enable_xff_client_port");
    }

    /// <summary>
    /// The enable_zonal_shift attribute.
    /// </summary>
    public TerraformValue<bool> EnableZonalShift
    {
        get => new TerraformReference<bool>(this, "enable_zonal_shift");
    }

    /// <summary>
    /// The enforce_security_group_inbound_rules_on_private_link_traffic attribute.
    /// </summary>
    public TerraformValue<string> EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic
    {
        get => new TerraformReference<string>(this, "enforce_security_group_inbound_rules_on_private_link_traffic");
    }

    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeout
    {
        get => new TerraformReference<double>(this, "idle_timeout");
    }

    /// <summary>
    /// The internal attribute.
    /// </summary>
    public TerraformValue<bool> InternalAttribute
    {
        get => new TerraformReference<bool>(this, "internal");
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
    }

    /// <summary>
    /// The ipam_pools attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpamPools
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ipam_pools").ResolveNodes(ctx));
    }

    /// <summary>
    /// The load_balancer_type attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancerType
    {
        get => new TerraformReference<string>(this, "load_balancer_type");
    }

    /// <summary>
    /// The preserve_host_header attribute.
    /// </summary>
    public TerraformValue<bool> PreserveHostHeader
    {
        get => new TerraformReference<bool>(this, "preserve_host_header");
    }

    /// <summary>
    /// The secondary_ips_auto_assigned_per_subnet attribute.
    /// </summary>
    public TerraformValue<double> SecondaryIpsAutoAssignedPerSubnet
    {
        get => new TerraformReference<double>(this, "secondary_ips_auto_assigned_per_subnet");
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> SubnetMapping
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "subnet_mapping").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string> Subnets
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnets").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

    /// <summary>
    /// The xff_header_processing_mode attribute.
    /// </summary>
    public TerraformValue<string> XffHeaderProcessingMode
    {
        get => new TerraformReference<string>(this, "xff_header_processing_mode");
    }

    /// <summary>
    /// The zone_id attribute.
    /// </summary>
    public TerraformValue<string> ZoneId
    {
        get => new TerraformReference<string>(this, "zone_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAlbDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAlbDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
