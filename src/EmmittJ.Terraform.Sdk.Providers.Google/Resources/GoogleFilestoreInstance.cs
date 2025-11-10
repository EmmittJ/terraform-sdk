using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for file_shares in .
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceFileSharesBlock : TerraformBlock
{
    /// <summary>
    /// File share capacity in GiB. This must be at least 1024 GiB
    /// for the standard tier, or 2560 GiB for the premium tier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGb is required")]
    public required TerraformProperty<double> CapacityGb
    {
        get => GetProperty<TerraformProperty<double>>("capacity_gb");
        set => WithProperty("capacity_gb", value);
    }

    /// <summary>
    /// The name of the fileshare (16 characters or less)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The resource name of the backup, in the format
    /// projects/{projectId}/locations/{locationId}/backups/{backupId},
    /// that this file share has been restored from.
    /// </summary>
    public TerraformProperty<string>? SourceBackup
    {
        get => GetProperty<TerraformProperty<string>>("source_backup");
        set => WithProperty("source_backup", value);
    }

}

/// <summary>
/// Block type for initial_replication in .
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceInitialReplicationBlock : TerraformBlock
{
    /// <summary>
    /// The replication role. Default value: &amp;quot;STANDBY&amp;quot; Possible values: [&amp;quot;ROLE_UNSPECIFIED&amp;quot;, &amp;quot;ACTIVE&amp;quot;, &amp;quot;STANDBY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => WithProperty("role", value);
    }

}

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstanceNetworksBlock : TerraformBlock
{
    /// <summary>
    /// The network connect mode of the Filestore instance.
    /// If not provided, the connect mode defaults to
    /// DIRECT_PEERING. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ConnectMode
    {
        get => GetProperty<TerraformProperty<string>>("connect_mode");
        set => WithProperty("connect_mode", value);
    }

    /// <summary>
    /// A list of IPv4 or IPv6 addresses.
    /// </summary>
    public List<TerraformProperty<string>>? IpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("ip_addresses");
        set => WithProperty("ip_addresses", value);
    }

    /// <summary>
    /// IP versions for which the instance has
    /// IP addresses assigned. Possible values: [&amp;quot;ADDRESS_MODE_UNSPECIFIED&amp;quot;, &amp;quot;MODE_IPV4&amp;quot;, &amp;quot;MODE_IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Modes is required")]
    public List<TerraformProperty<string>>? Modes
    {
        get => GetProperty<List<TerraformProperty<string>>>("modes");
        set => WithProperty("modes", value);
    }

    /// <summary>
    /// The name of the GCE VPC network to which the
    /// instance is connected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

    /// <summary>
    /// A /29 CIDR block that identifies the range of IP
    /// addresses reserved for this instance.
    /// </summary>
    public TerraformProperty<string>? ReservedIpRange
    {
        get => GetProperty<TerraformProperty<string>>("reserved_ip_range");
        set => WithProperty("reserved_ip_range", value);
    }

}

/// <summary>
/// Block type for performance_config in .
/// Nesting mode: list
/// </summary>
public class GoogleFilestoreInstancePerformanceConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFilestoreInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a google_filestore_instance resource.
/// </summary>
public class GoogleFilestoreInstance : TerraformResource
{
    public GoogleFilestoreInstance(string name) : base("google_filestore_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("effective_replication");
        this.DeclareOutput("etag");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection_enabled");
        set => this.WithProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    public TerraformProperty<string>? DeletionProtectionReason
    {
        get => GetProperty<TerraformProperty<string>>("deletion_protection_reason");
        set => this.WithProperty("deletion_protection_reason", value);
    }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// KMS key name used for data encryption.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for file_shares.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FileShares block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileShares block(s) allowed")]
    public List<GoogleFilestoreInstanceFileSharesBlock>? FileShares
    {
        get => GetProperty<List<GoogleFilestoreInstanceFileSharesBlock>>("file_shares");
        set => this.WithProperty("file_shares", value);
    }

    /// <summary>
    /// Block for initial_replication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplication block(s) allowed")]
    public List<GoogleFilestoreInstanceInitialReplicationBlock>? InitialReplication
    {
        get => GetProperty<List<GoogleFilestoreInstanceInitialReplicationBlock>>("initial_replication");
        set => this.WithProperty("initial_replication", value);
    }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networks block(s) required")]
    public List<GoogleFilestoreInstanceNetworksBlock>? Networks
    {
        get => GetProperty<List<GoogleFilestoreInstanceNetworksBlock>>("networks");
        set => this.WithProperty("networks", value);
    }

    /// <summary>
    /// Block for performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    public List<GoogleFilestoreInstancePerformanceConfigBlock>? PerformanceConfig
    {
        get => GetProperty<List<GoogleFilestoreInstancePerformanceConfigBlock>>("performance_config");
        set => this.WithProperty("performance_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFilestoreInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFilestoreInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only fields for replication configuration.
    /// </summary>
    public TerraformExpression EffectiveReplication => this["effective_replication"];

    /// <summary>
    /// Server-specified ETag for the instance resource to prevent
    /// simultaneous updates from overwriting each other.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
