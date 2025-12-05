using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_filestore_instance Terraform data source.
/// Retrieves information about a google_filestore_instance.
/// </summary>
public partial class GoogleFilestoreInstanceDataSource(string name) : TerraformDataSource("google_filestore_instance", name)
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
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    public TerraformValue<bool> DeletionProtectionEnabled
        => CreateReference("deletion_protection_enabled");

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    public TerraformValue<string> DeletionProtectionReason
        => CreateReference("deletion_protection_reason");

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// Output only fields for replication configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> EffectiveReplication
        => CreateReference("effective_replication");

    /// <summary>
    /// Server-specified ETag for the instance resource to prevent
    /// simultaneous updates from overwriting each other.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// File system shares on the instance. For this version, only a
    /// single file share is supported.
    /// </summary>
    public TerraformList<TerraformMap<object>> FileShares
        => CreateReference("file_shares");

    /// <summary>
    /// Replication configuration, once set, this cannot be updated.
    /// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
    /// </summary>
    public TerraformList<TerraformMap<object>> InitialReplication
        => CreateReference("initial_replication");

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    public TerraformValue<string> KmsKeyName
        => CreateReference("kms_key_name");

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => CreateReference("labels");

    /// <summary>
    /// VPC networks to which the instance is connected. For this version,
    /// only a single network is supported.
    /// </summary>
    public TerraformList<TerraformMap<object>> Networks
        => CreateReference("networks");

    /// <summary>
    /// Performance configuration for the instance. If not provided,
    /// the default performance settings will be used.
    /// </summary>
    public TerraformList<TerraformMap<object>> PerformanceConfig
        => CreateReference("performance_config");

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    public TerraformValue<string> Protocol
        => CreateReference("protocol");

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
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    public TerraformValue<string> Tier
        => CreateReference("tier");

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    public TerraformValue<string> Zone
        => CreateReference("zone");

}
