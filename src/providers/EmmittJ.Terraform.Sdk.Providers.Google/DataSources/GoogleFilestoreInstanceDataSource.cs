using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_filestore_instance.
/// </summary>
public partial class GoogleFilestoreInstanceDataSource : TerraformDataSource
{
    public GoogleFilestoreInstanceDataSource(string name) : base("google_filestore_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

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
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtectionEnabled { get; }

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    [TerraformProperty("deletion_protection_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeletionProtectionReason { get; }

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

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
    /// File system shares on the instance. For this version, only a
    /// single file share is supported.
    /// </summary>
    [TerraformProperty("file_shares")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FileShares { get; }

    /// <summary>
    /// Replication configuration, once set, this cannot be updated.
    /// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
    /// </summary>
    [TerraformProperty("initial_replication")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InitialReplication { get; }

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyName { get; }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// VPC networks to which the instance is connected. For this version,
    /// only a single network is supported.
    /// </summary>
    [TerraformProperty("networks")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Networks { get; }

    /// <summary>
    /// Performance configuration for the instance. If not provided,
    /// the default performance settings will be used.
    /// </summary>
    [TerraformProperty("performance_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PerformanceConfig { get; }

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Protocol { get; }

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
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [TerraformProperty("tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tier { get; }

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    [TerraformProperty("zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Zone { get; }

}
