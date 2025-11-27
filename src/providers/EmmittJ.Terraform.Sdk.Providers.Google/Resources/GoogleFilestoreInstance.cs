using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for file_shares in GoogleFilestoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceFileSharesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "file_shares";

    /// <summary>
    /// File share capacity in GiB. This must be at least 1024 GiB
    /// for the standard tier, or 2560 GiB for the premium tier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGb is required")]
    public required TerraformValue<double> CapacityGb
    {
        get => new TerraformReference<double>(this, "capacity_gb");
        set => SetArgument("capacity_gb", value);
    }

    /// <summary>
    /// The name of the fileshare (16 characters or less)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource name of the backup, in the format
    /// projects/{projectId}/locations/{locationId}/backups/{backupId},
    /// that this file share has been restored from.
    /// </summary>
    public TerraformValue<string>? SourceBackup
    {
        get => new TerraformReference<string>(this, "source_backup");
        set => SetArgument("source_backup", value);
    }

    /// <summary>
    /// NfsExportOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 NfsExportOptions block(s) allowed")]
    public TerraformList<GoogleFilestoreInstanceFileSharesBlockNfsExportOptionsBlock>? NfsExportOptions
    {
        get => GetArgument<TerraformList<GoogleFilestoreInstanceFileSharesBlockNfsExportOptionsBlock>>("nfs_export_options");
        set => SetArgument("nfs_export_options", value);
    }

}

/// <summary>
/// Block type for nfs_export_options in GoogleFilestoreInstanceFileSharesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceFileSharesBlockNfsExportOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nfs_export_options";

    /// <summary>
    /// Either READ_ONLY, for allowing only read requests on the exported directory,
    /// or READ_WRITE, for allowing both read and write requests. The default is READ_WRITE. Default value: &amp;quot;READ_WRITE&amp;quot; Possible values: [&amp;quot;READ_ONLY&amp;quot;, &amp;quot;READ_WRITE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AccessMode
    {
        get => new TerraformReference<string>(this, "access_mode");
        set => SetArgument("access_mode", value);
    }

    /// <summary>
    /// An integer representing the anonymous group id with a default value of 65534.
    /// Anon_gid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    public TerraformValue<double>? AnonGid
    {
        get => new TerraformReference<double>(this, "anon_gid");
        set => SetArgument("anon_gid", value);
    }

    /// <summary>
    /// An integer representing the anonymous user id with a default value of 65534.
    /// Anon_uid may only be set with squashMode of ROOT_SQUASH. An error will be returned
    /// if this field is specified for other squashMode settings.
    /// </summary>
    public TerraformValue<double>? AnonUid
    {
        get => new TerraformReference<double>(this, "anon_uid");
        set => SetArgument("anon_uid", value);
    }

    /// <summary>
    /// List of either IPv4 addresses, or ranges in CIDR notation which may mount the file share.
    /// Overlapping IP ranges are not allowed, both within and across NfsExportOptions. An error will be returned.
    /// The limit is 64 IP ranges/addresses for each FileShareConfig among all NfsExportOptions.
    /// </summary>
    public TerraformList<string>? IpRanges
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_ranges").ResolveNodes(ctx));
        set => SetArgument("ip_ranges", value);
    }

    /// <summary>
    /// The source VPC network for &#39;ip_ranges&#39;.
    /// Required for instances using Private Service Connect, optional otherwise.
    /// </summary>
    public TerraformValue<string>? Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// Either NO_ROOT_SQUASH, for allowing root access on the exported directory, or ROOT_SQUASH,
    /// for not allowing root access. The default is NO_ROOT_SQUASH. Default value: &amp;quot;NO_ROOT_SQUASH&amp;quot; Possible values: [&amp;quot;NO_ROOT_SQUASH&amp;quot;, &amp;quot;ROOT_SQUASH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SquashMode
    {
        get => new TerraformReference<string>(this, "squash_mode");
        set => SetArgument("squash_mode", value);
    }

}


/// <summary>
/// Block type for initial_replication in GoogleFilestoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceInitialReplicationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_replication";

    /// <summary>
    /// The replication role. Default value: &amp;quot;STANDBY&amp;quot; Possible values: [&amp;quot;ROLE_UNSPECIFIED&amp;quot;, &amp;quot;ACTIVE&amp;quot;, &amp;quot;STANDBY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// Replicas block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleFilestoreInstanceInitialReplicationBlockReplicasBlock>? Replicas
    {
        get => GetArgument<TerraformList<GoogleFilestoreInstanceInitialReplicationBlockReplicasBlock>>("replicas");
        set => SetArgument("replicas", value);
    }

}

/// <summary>
/// Block type for replicas in GoogleFilestoreInstanceInitialReplicationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceInitialReplicationBlockReplicasBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replicas";

    /// <summary>
    /// The peer instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerInstance is required")]
    public required TerraformValue<string> PeerInstance
    {
        get => new TerraformReference<string>(this, "peer_instance");
        set => SetArgument("peer_instance", value);
    }

}


/// <summary>
/// Block type for networks in GoogleFilestoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networks";

    /// <summary>
    /// The network connect mode of the Filestore instance.
    /// If not provided, the connect mode defaults to
    /// DIRECT_PEERING. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ConnectMode
    {
        get => new TerraformReference<string>(this, "connect_mode");
        set => SetArgument("connect_mode", value);
    }

    /// <summary>
    /// A list of IPv4 or IPv6 addresses.
    /// </summary>
    public TerraformList<string> IpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// IP versions for which the instance has
    /// IP addresses assigned. Possible values: [&amp;quot;ADDRESS_MODE_UNSPECIFIED&amp;quot;, &amp;quot;MODE_IPV4&amp;quot;, &amp;quot;MODE_IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Modes is required")]
    public TerraformList<string>? Modes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "modes").ResolveNodes(ctx));
        set => SetArgument("modes", value);
    }

    /// <summary>
    /// The name of the GCE VPC network to which the
    /// instance is connected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// A /29 CIDR block that identifies the range of IP
    /// addresses reserved for this instance.
    /// </summary>
    public TerraformValue<string> ReservedIpRange
    {
        get => new TerraformReference<string>(this, "reserved_ip_range");
        set => SetArgument("reserved_ip_range", value);
    }

    /// <summary>
    /// PscConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public TerraformList<GoogleFilestoreInstanceNetworksBlockPscConfigBlock>? PscConfig
    {
        get => GetArgument<TerraformList<GoogleFilestoreInstanceNetworksBlockPscConfigBlock>>("psc_config");
        set => SetArgument("psc_config", value);
    }

}

/// <summary>
/// Block type for psc_config in GoogleFilestoreInstanceNetworksBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceNetworksBlockPscConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_config";

    /// <summary>
    /// Consumer service project in which the Private Service Connect endpoint
    /// would be set up. This is optional, and only relevant in case the network
    /// is a shared VPC. If this is not specified, the endpoint would be set up
    /// in the VPC host project.
    /// </summary>
    public TerraformValue<string>? EndpointProject
    {
        get => new TerraformReference<string>(this, "endpoint_project");
        set => SetArgument("endpoint_project", value);
    }

}


/// <summary>
/// Block type for performance_config in GoogleFilestoreInstance.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstancePerformanceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "performance_config";

    /// <summary>
    /// FixedIops block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedIops block(s) allowed")]
    public TerraformList<GoogleFilestoreInstancePerformanceConfigBlockFixedIopsBlock>? FixedIops
    {
        get => GetArgument<TerraformList<GoogleFilestoreInstancePerformanceConfigBlockFixedIopsBlock>>("fixed_iops");
        set => SetArgument("fixed_iops", value);
    }

    /// <summary>
    /// IopsPerTb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IopsPerTb block(s) allowed")]
    public TerraformList<GoogleFilestoreInstancePerformanceConfigBlockIopsPerTbBlock>? IopsPerTb
    {
        get => GetArgument<TerraformList<GoogleFilestoreInstancePerformanceConfigBlockIopsPerTbBlock>>("iops_per_tb");
        set => SetArgument("iops_per_tb", value);
    }

}

/// <summary>
/// Block type for fixed_iops in GoogleFilestoreInstancePerformanceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstancePerformanceConfigBlockFixedIopsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_iops";

    /// <summary>
    /// The number of IOPS to provision for the instance.
    /// max_iops must be in multiple of 1000.
    /// </summary>
    public TerraformValue<double>? MaxIops
    {
        get => new TerraformReference<double>(this, "max_iops");
        set => SetArgument("max_iops", value);
    }

}

/// <summary>
/// Block type for iops_per_tb in GoogleFilestoreInstancePerformanceConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstancePerformanceConfigBlockIopsPerTbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iops_per_tb";

    /// <summary>
    /// The instance max IOPS will be calculated by multiplying
    /// the capacity of the instance (TB) by max_iops_per_tb,
    /// and rounding to the nearest 1000. The instance max IOPS
    /// will be changed dynamically based on the instance
    /// capacity.
    /// </summary>
    public TerraformValue<double>? MaxIopsPerTb
    {
        get => new TerraformReference<double>(this, "max_iops_per_tb");
        set => SetArgument("max_iops_per_tb", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFilestoreInstance.
/// Nesting mode: single
/// </summary>
public class GoogleFilestoreInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_filestore_instance Terraform resource.
/// Manages a google_filestore_instance resource.
/// </summary>
public partial class GoogleFilestoreInstance(string name) : TerraformResource("google_filestore_instance", name)
{
    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    public TerraformValue<bool>? DeletionProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "deletion_protection_enabled");
        set => SetArgument("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    public TerraformValue<string>? DeletionProtectionReason
    {
        get => new TerraformReference<string>(this, "deletion_protection_reason");
        set => SetArgument("deletion_protection_reason", value);
    }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// KMS key name used for data encryption.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager
    /// tags. Keys must be in the format tagKeys/{tag_key_id},
    /// and values are in the format tagValues/456. The field is
    /// ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. This field is only set
    /// at create time and modifying this field after creation
    /// will trigger recreation. To apply tags to an existing
    /// resource, see the &#39;google_tags_tag_value&#39; resource.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only fields for replication configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveReplication
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "effective_replication").ResolveNodes(ctx));
    }

    /// <summary>
    /// Server-specified ETag for the instance resource to prevent
    /// simultaneous updates from overwriting each other.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// FileShares block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileShares is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FileShares block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileShares block(s) allowed")]
    public required TerraformList<GoogleFilestoreInstanceFileSharesBlock> FileShares
    {
        get => GetRequiredArgument<TerraformList<GoogleFilestoreInstanceFileSharesBlock>>("file_shares");
        set => SetArgument("file_shares", value);
    }

    /// <summary>
    /// InitialReplication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplication block(s) allowed")]
    public TerraformList<GoogleFilestoreInstanceInitialReplicationBlock>? InitialReplication
    {
        get => GetArgument<TerraformList<GoogleFilestoreInstanceInitialReplicationBlock>>("initial_replication");
        set => SetArgument("initial_replication", value);
    }

    /// <summary>
    /// Networks block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networks is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networks block(s) required")]
    public required TerraformList<GoogleFilestoreInstanceNetworksBlock> Networks
    {
        get => GetRequiredArgument<TerraformList<GoogleFilestoreInstanceNetworksBlock>>("networks");
        set => SetArgument("networks", value);
    }

    /// <summary>
    /// PerformanceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    public TerraformList<GoogleFilestoreInstancePerformanceConfigBlock>? PerformanceConfig
    {
        get => GetArgument<TerraformList<GoogleFilestoreInstancePerformanceConfigBlock>>("performance_config");
        set => SetArgument("performance_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFilestoreInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFilestoreInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
