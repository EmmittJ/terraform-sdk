using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_filestore_instance.
/// </summary>
public class GoogleFilestoreInstanceDataSource : TerraformDataSource
{
    public GoogleFilestoreInstanceDataSource(string name) : base("google_filestore_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtectionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection_enabled");

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    [TerraformPropertyName("deletion_protection_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeletionProtectionReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_protection_reason");

    /// <summary>
    /// A description of the instance.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Output only fields for replication configuration.
    /// </summary>
    [TerraformPropertyName("effective_replication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EffectiveReplication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "effective_replication");

    /// <summary>
    /// Server-specified ETag for the instance resource to prevent
    /// simultaneous updates from overwriting each other.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// File system shares on the instance. For this version, only a
    /// single file share is supported.
    /// </summary>
    [TerraformPropertyName("file_shares")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FileShares => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "file_shares");

    /// <summary>
    /// Replication configuration, once set, this cannot be updated.
    /// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
    /// </summary>
    [TerraformPropertyName("initial_replication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InitialReplication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "initial_replication");

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_name");

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// VPC networks to which the instance is connected. For this version,
    /// only a single network is supported.
    /// </summary>
    [TerraformPropertyName("networks")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Networks => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "networks");

    /// <summary>
    /// Performance configuration for the instance. If not provided,
    /// the default performance settings will be used.
    /// </summary>
    [TerraformPropertyName("performance_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PerformanceConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "performance_config");

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Protocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol");

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
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    [TerraformPropertyName("tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tier");

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Zone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

}
