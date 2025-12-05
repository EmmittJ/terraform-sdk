using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for routing_policy in GoogleDnsRecordSet.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_policy";

    /// <summary>
    /// Specifies whether to enable fencing for geo queries.
    /// </summary>
    public TerraformValue<bool>? EnableGeoFencing
    {
        get => GetArgument<TerraformValue<bool>>("enable_geo_fencing");
        set => SetArgument("enable_geo_fencing", value);
    }

    /// <summary>
    /// Specifies the health check.
    /// </summary>
    public TerraformValue<string>? HealthCheck
    {
        get => GetArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// Geo block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockGeoBlock>? Geo
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockGeoBlock>>("geo");
        set => SetArgument("geo", value);
    }

    /// <summary>
    /// PrimaryBackup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrimaryBackup block(s) allowed")]
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlock>? PrimaryBackup
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlock>>("primary_backup");
        set => SetArgument("primary_backup", value);
    }

    /// <summary>
    /// Wrr block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockWrrBlock>? Wrr
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockWrrBlock>>("wrr");
        set => SetArgument("wrr", value);
    }

}

/// <summary>
/// Block type for geo in GoogleDnsRecordSetRoutingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockGeoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "geo";

    /// <summary>
    /// The location name defined in Google Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The rrdatas attribute.
    /// </summary>
    public TerraformList<string>? Rrdatas
    {
        get => GetArgument<TerraformList<string>>("rrdatas");
        set => SetArgument("rrdatas", value);
    }

    /// <summary>
    /// HealthCheckedTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckedTargets block(s) allowed")]
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockGeoBlockHealthCheckedTargetsBlock>? HealthCheckedTargets
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockGeoBlockHealthCheckedTargetsBlock>>("health_checked_targets");
        set => SetArgument("health_checked_targets", value);
    }

}

/// <summary>
/// Block type for health_checked_targets in GoogleDnsRecordSetRoutingPolicyBlockGeoBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockGeoBlockHealthCheckedTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_checked_targets";

    /// <summary>
    /// The Internet IP addresses to be health checked.
    /// </summary>
    public TerraformList<string>? ExternalEndpoints
    {
        get => GetArgument<TerraformList<string>>("external_endpoints");
        set => SetArgument("external_endpoints", value);
    }

    /// <summary>
    /// InternalLoadBalancers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockGeoBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock>? InternalLoadBalancers
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockGeoBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock>>("internal_load_balancers");
        set => SetArgument("internal_load_balancers", value);
    }

}

/// <summary>
/// Block type for internal_load_balancers in GoogleDnsRecordSetRoutingPolicyBlockGeoBlockHealthCheckedTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockGeoBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internal_load_balancers";

    /// <summary>
    /// The frontend IP address of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&amp;quot;tcp&amp;quot;, &amp;quot;udp&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The type of load balancer. This value is case-sensitive. Possible values: [&amp;quot;regionalL4ilb&amp;quot;, &amp;quot;regionalL7ilb&amp;quot;, &amp;quot;globalL7ilb&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// The fully qualified url of the network in which the load balancer belongs. This should be formatted like `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_url");
        set => SetArgument("network_url", value);
    }

    /// <summary>
    /// The configured port of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<string> Port
    {
        get => GetRequiredArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the project in which the load balancer belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the load balancer. Only needed for regional load balancers.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}

/// <summary>
/// Block type for primary_backup in GoogleDnsRecordSetRoutingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary_backup";

    /// <summary>
    /// Specifies whether to enable fencing for backup geo queries.
    /// </summary>
    public TerraformValue<bool>? EnableGeoFencingForBackups
    {
        get => GetArgument<TerraformValue<bool>>("enable_geo_fencing_for_backups");
        set => SetArgument("enable_geo_fencing_for_backups", value);
    }

    /// <summary>
    /// Specifies the percentage of traffic to send to the backup targets even when the primary targets are healthy.
    /// </summary>
    public TerraformValue<double>? TrickleRatio
    {
        get => GetArgument<TerraformValue<double>>("trickle_ratio");
        set => SetArgument("trickle_ratio", value);
    }

    /// <summary>
    /// BackupGeo block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupGeo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackupGeo block(s) required")]
    public required TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlock> BackupGeo
    {
        get => GetRequiredArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlock>>("backup_geo");
        set => SetArgument("backup_geo", value);
    }

    /// <summary>
    /// Primary block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Primary block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Primary block(s) allowed")]
    public required TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockPrimaryBlock> Primary
    {
        get => GetRequiredArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockPrimaryBlock>>("primary");
        set => SetArgument("primary", value);
    }

}

/// <summary>
/// Block type for backup_geo in GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_geo";

    /// <summary>
    /// The location name defined in Google Cloud.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The rrdatas attribute.
    /// </summary>
    public TerraformList<string>? Rrdatas
    {
        get => GetArgument<TerraformList<string>>("rrdatas");
        set => SetArgument("rrdatas", value);
    }

    /// <summary>
    /// HealthCheckedTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckedTargets block(s) allowed")]
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlockHealthCheckedTargetsBlock>? HealthCheckedTargets
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlockHealthCheckedTargetsBlock>>("health_checked_targets");
        set => SetArgument("health_checked_targets", value);
    }

}

/// <summary>
/// Block type for health_checked_targets in GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlockHealthCheckedTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_checked_targets";

    /// <summary>
    /// The Internet IP addresses to be health checked.
    /// </summary>
    public TerraformList<string>? ExternalEndpoints
    {
        get => GetArgument<TerraformList<string>>("external_endpoints");
        set => SetArgument("external_endpoints", value);
    }

    /// <summary>
    /// InternalLoadBalancers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock>? InternalLoadBalancers
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock>>("internal_load_balancers");
        set => SetArgument("internal_load_balancers", value);
    }

}

/// <summary>
/// Block type for internal_load_balancers in GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlockHealthCheckedTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockBackupGeoBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internal_load_balancers";

    /// <summary>
    /// The frontend IP address of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&amp;quot;tcp&amp;quot;, &amp;quot;udp&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The type of load balancer. This value is case-sensitive. Possible values: [&amp;quot;regionalL4ilb&amp;quot;, &amp;quot;regionalL7ilb&amp;quot;, &amp;quot;globalL7ilb&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// The fully qualified url of the network in which the load balancer belongs. This should be formatted like `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_url");
        set => SetArgument("network_url", value);
    }

    /// <summary>
    /// The configured port of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<string> Port
    {
        get => GetRequiredArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the project in which the load balancer belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the load balancer. Only needed for regional load balancers.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}

/// <summary>
/// Block type for primary in GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockPrimaryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "primary";

    /// <summary>
    /// The Internet IP addresses to be health checked.
    /// </summary>
    public TerraformList<string>? ExternalEndpoints
    {
        get => GetArgument<TerraformList<string>>("external_endpoints");
        set => SetArgument("external_endpoints", value);
    }

    /// <summary>
    /// InternalLoadBalancers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockPrimaryBlockInternalLoadBalancersBlock>? InternalLoadBalancers
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockPrimaryBlockInternalLoadBalancersBlock>>("internal_load_balancers");
        set => SetArgument("internal_load_balancers", value);
    }

}

/// <summary>
/// Block type for internal_load_balancers in GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockPrimaryBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockPrimaryBackupBlockPrimaryBlockInternalLoadBalancersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internal_load_balancers";

    /// <summary>
    /// The frontend IP address of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&amp;quot;tcp&amp;quot;, &amp;quot;udp&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The type of load balancer. This value is case-sensitive. Possible values: [&amp;quot;regionalL4ilb&amp;quot;, &amp;quot;regionalL7ilb&amp;quot;, &amp;quot;globalL7ilb&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// The fully qualified url of the network in which the load balancer belongs. This should be formatted like `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_url");
        set => SetArgument("network_url", value);
    }

    /// <summary>
    /// The configured port of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<string> Port
    {
        get => GetRequiredArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the project in which the load balancer belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the load balancer. Only needed for regional load balancers.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}

/// <summary>
/// Block type for wrr in GoogleDnsRecordSetRoutingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockWrrBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "wrr";

    /// <summary>
    /// The rrdatas attribute.
    /// </summary>
    public TerraformList<string>? Rrdatas
    {
        get => GetArgument<TerraformList<string>>("rrdatas");
        set => SetArgument("rrdatas", value);
    }

    /// <summary>
    /// The ratio of traffic routed to the target.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformValue<double> Weight
    {
        get => GetRequiredArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// HealthCheckedTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthCheckedTargets block(s) allowed")]
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockWrrBlockHealthCheckedTargetsBlock>? HealthCheckedTargets
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockWrrBlockHealthCheckedTargetsBlock>>("health_checked_targets");
        set => SetArgument("health_checked_targets", value);
    }

}

/// <summary>
/// Block type for health_checked_targets in GoogleDnsRecordSetRoutingPolicyBlockWrrBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockWrrBlockHealthCheckedTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_checked_targets";

    /// <summary>
    /// The Internet IP addresses to be health checked.
    /// </summary>
    public TerraformList<string>? ExternalEndpoints
    {
        get => GetArgument<TerraformList<string>>("external_endpoints");
        set => SetArgument("external_endpoints", value);
    }

    /// <summary>
    /// InternalLoadBalancers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlockWrrBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock>? InternalLoadBalancers
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlockWrrBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock>>("internal_load_balancers");
        set => SetArgument("internal_load_balancers", value);
    }

}

/// <summary>
/// Block type for internal_load_balancers in GoogleDnsRecordSetRoutingPolicyBlockWrrBlockHealthCheckedTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDnsRecordSetRoutingPolicyBlockWrrBlockHealthCheckedTargetsBlockInternalLoadBalancersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internal_load_balancers";

    /// <summary>
    /// The frontend IP address of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The configured IP protocol of the load balancer. This value is case-sensitive. Possible values: [&amp;quot;tcp&amp;quot;, &amp;quot;udp&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpProtocol is required")]
    public required TerraformValue<string> IpProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_protocol");
        set => SetArgument("ip_protocol", value);
    }

    /// <summary>
    /// The type of load balancer. This value is case-sensitive. Possible values: [&amp;quot;regionalL4ilb&amp;quot;, &amp;quot;regionalL7ilb&amp;quot;, &amp;quot;globalL7ilb&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LoadBalancerType
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_type");
        set => SetArgument("load_balancer_type", value);
    }

    /// <summary>
    /// The fully qualified url of the network in which the load balancer belongs. This should be formatted like `https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_url");
        set => SetArgument("network_url", value);
    }

    /// <summary>
    /// The configured port of the load balancer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<string> Port
    {
        get => GetRequiredArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the project in which the load balancer belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    public required TerraformValue<string> Project
    {
        get => GetRequiredArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region of the load balancer. Only needed for regional load balancers.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Represents a google_dns_record_set Terraform resource.
/// Manages a google_dns_record_set resource.
/// </summary>
public partial class GoogleDnsRecordSet(string name) : TerraformResource("google_dns_record_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the zone in which this record set will reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformValue<string> ManagedZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("managed_zone");
        set => SetArgument("managed_zone", value);
    }

    /// <summary>
    /// The DNS name this record set will apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The string data for the records in this record set whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding \&amp;quot; if you don&#39;t want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add \&amp;quot;\&amp;quot; inside the Terraform configuration string (e.g. &amp;quot;first255characters\&amp;quot;\&amp;quot;morecharacters&amp;quot;).
    /// </summary>
    public TerraformList<string>? Rrdatas
    {
        get => GetArgument<TerraformList<string>>("rrdatas");
        set => SetArgument("rrdatas", value);
    }

    /// <summary>
    /// The time-to-live of this record set (seconds).
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => GetArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The DNS record set type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// RoutingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RoutingPolicy block(s) allowed")]
    public TerraformList<GoogleDnsRecordSetRoutingPolicyBlock>? RoutingPolicy
    {
        get => GetArgument<TerraformList<GoogleDnsRecordSetRoutingPolicyBlock>>("routing_policy");
        set => SetArgument("routing_policy", value);
    }

}
