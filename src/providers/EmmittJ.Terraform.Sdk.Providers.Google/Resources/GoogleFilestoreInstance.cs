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
        set => SetProperty("capacity_gb", value);
    }

    /// <summary>
    /// The name of the fileshare (16 characters or less)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource name of the backup, in the format
    /// projects/{projectId}/locations/{locationId}/backups/{backupId},
    /// that this file share has been restored from.
    /// </summary>
    public TerraformProperty<string>? SourceBackup
    {
        set => SetProperty("source_backup", value);
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
        set => SetProperty("role", value);
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
        set => SetProperty("connect_mode", value);
    }

    /// <summary>
    /// A list of IPv4 or IPv6 addresses.
    /// </summary>
    public List<TerraformProperty<string>>? IpAddresses
    {
        set => SetProperty("ip_addresses", value);
    }

    /// <summary>
    /// IP versions for which the instance has
    /// IP addresses assigned. Possible values: [&amp;quot;ADDRESS_MODE_UNSPECIFIED&amp;quot;, &amp;quot;MODE_IPV4&amp;quot;, &amp;quot;MODE_IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Modes is required")]
    public List<TerraformProperty<string>>? Modes
    {
        set => SetProperty("modes", value);
    }

    /// <summary>
    /// The name of the GCE VPC network to which the
    /// instance is connected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformProperty<string> Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// A /29 CIDR block that identifies the range of IP
    /// addresses reserved for this instance.
    /// </summary>
    public TerraformProperty<string>? ReservedIpRange
    {
        set => SetProperty("reserved_ip_range", value);
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
/// Manages a google_filestore_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFilestoreInstance : TerraformResource
{
    public GoogleFilestoreInstance(string name) : base("google_filestore_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("effective_replication");
        SetOutput("etag");
        SetOutput("terraform_labels");
        SetOutput("deletion_protection_enabled");
        SetOutput("deletion_protection_reason");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kms_key_name");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("protocol");
        SetOutput("tags");
        SetOutput("tier");
        SetOutput("zone");
    }

    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    public TerraformProperty<bool> DeletionProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection_enabled");
        set => SetProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    public TerraformProperty<string> DeletionProtectionReason
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_protection_reason");
        set => SetProperty("deletion_protection_reason", value);
    }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// KMS key name used for data encryption.
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
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
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for file_shares.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileShares is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FileShares block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileShares block(s) allowed")]
    public List<GoogleFilestoreInstanceFileSharesBlock>? FileShares
    {
        set => SetProperty("file_shares", value);
    }

    /// <summary>
    /// Block for initial_replication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplication block(s) allowed")]
    public List<GoogleFilestoreInstanceInitialReplicationBlock>? InitialReplication
    {
        set => SetProperty("initial_replication", value);
    }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networks is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networks block(s) required")]
    public List<GoogleFilestoreInstanceNetworksBlock>? Networks
    {
        set => SetProperty("networks", value);
    }

    /// <summary>
    /// Block for performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    public List<GoogleFilestoreInstancePerformanceConfigBlock>? PerformanceConfig
    {
        set => SetProperty("performance_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFilestoreInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
