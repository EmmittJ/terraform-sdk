using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for file_shares in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFilestoreInstanceFileSharesBlock() : TerraformBlock("file_shares")
{
    /// <summary>
    /// File share capacity in GiB. This must be at least 1024 GiB
    /// for the standard tier, or 2560 GiB for the premium tier.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityGb is required")]
    [TerraformProperty("capacity_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> CapacityGb { get; set; }

    /// <summary>
    /// The name of the fileshare (16 characters or less)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource name of the backup, in the format
    /// projects/{projectId}/locations/{locationId}/backups/{backupId},
    /// that this file share has been restored from.
    /// </summary>
    [TerraformProperty("source_backup")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceBackup { get; set; }

}

/// <summary>
/// Block type for initial_replication in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFilestoreInstanceInitialReplicationBlock() : TerraformBlock("initial_replication")
{
    /// <summary>
    /// The replication role. Default value: &amp;quot;STANDBY&amp;quot; Possible values: [&amp;quot;ROLE_UNSPECIFIED&amp;quot;, &amp;quot;ACTIVE&amp;quot;, &amp;quot;STANDBY&amp;quot;]
    /// </summary>
    [TerraformProperty("role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Role { get; set; }

}

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFilestoreInstanceNetworksBlock() : TerraformBlock("networks")
{
    /// <summary>
    /// The network connect mode of the Filestore instance.
    /// If not provided, the connect mode defaults to
    /// DIRECT_PEERING. Default value: &amp;quot;DIRECT_PEERING&amp;quot; Possible values: [&amp;quot;DIRECT_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_ACCESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;]
    /// </summary>
    [TerraformProperty("connect_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectMode { get; set; }


    /// <summary>
    /// IP versions for which the instance has
    /// IP addresses assigned. Possible values: [&amp;quot;ADDRESS_MODE_UNSPECIFIED&amp;quot;, &amp;quot;MODE_IPV4&amp;quot;, &amp;quot;MODE_IPV6&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Modes is required")]
    [TerraformProperty("modes")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Modes { get; set; }

    /// <summary>
    /// The name of the GCE VPC network to which the
    /// instance is connected.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// A /29 CIDR block that identifies the range of IP
    /// addresses reserved for this instance.
    /// </summary>
    [TerraformProperty("reserved_ip_range")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReservedIpRange { get; set; }

}

/// <summary>
/// Block type for performance_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFilestoreInstancePerformanceConfigBlock() : TerraformBlock("performance_config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFilestoreInstanceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_filestore_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleFilestoreInstance : TerraformResource
{
    public GoogleFilestoreInstance(string name) : base("google_filestore_instance", name)
    {
    }

    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtectionEnabled { get; set; }

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    [TerraformProperty("deletion_protection_reason")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionProtectionReason { get; set; }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

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
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for file_shares.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileShares is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FileShares block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FileShares block(s) allowed")]
    [TerraformProperty("file_shares")]
    public required TerraformList<GoogleFilestoreInstanceFileSharesBlock> FileShares { get; set; } = new();

    /// <summary>
    /// Block for initial_replication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialReplication block(s) allowed")]
    [TerraformProperty("initial_replication")]
    public TerraformList<GoogleFilestoreInstanceInitialReplicationBlock> InitialReplication { get; set; } = new();

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Networks is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Networks block(s) required")]
    [TerraformProperty("networks")]
    public required TerraformList<GoogleFilestoreInstanceNetworksBlock> Networks { get; set; } = new();

    /// <summary>
    /// Block for performance_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerformanceConfig block(s) allowed")]
    [TerraformProperty("performance_config")]
    public TerraformList<GoogleFilestoreInstancePerformanceConfigBlock> PerformanceConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFilestoreInstanceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Output only fields for replication configuration.
    /// </summary>
    [TerraformProperty("effective_replication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EffectiveReplication { get; }

    /// <summary>
    /// Server-specified ETag for the instance resource to prevent
    /// simultaneous updates from overwriting each other.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
