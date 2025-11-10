using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_filestore_instance.
/// </summary>
public class GoogleFilestoreInstanceDataSource : TerraformDataSource
{
    public GoogleFilestoreInstanceDataSource(string name) : base("google_filestore_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("deletion_protection_enabled");
        SetOutput("deletion_protection_reason");
        SetOutput("description");
        SetOutput("effective_labels");
        SetOutput("effective_replication");
        SetOutput("etag");
        SetOutput("file_shares");
        SetOutput("initial_replication");
        SetOutput("kms_key_name");
        SetOutput("labels");
        SetOutput("networks");
        SetOutput("performance_config");
        SetOutput("protocol");
        SetOutput("tags");
        SetOutput("terraform_labels");
        SetOutput("tier");
        SetOutput("zone");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
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
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Indicates whether the instance is protected against deletion.
    /// </summary>
    public TerraformExpression DeletionProtectionEnabled => this["deletion_protection_enabled"];

    /// <summary>
    /// The reason for enabling deletion protection.
    /// </summary>
    public TerraformExpression DeletionProtectionReason => this["deletion_protection_reason"];

    /// <summary>
    /// A description of the instance.
    /// </summary>
    public TerraformExpression Description => this["description"];

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
    /// File system shares on the instance. For this version, only a
    /// single file share is supported.
    /// </summary>
    public TerraformExpression FileShares => this["file_shares"];

    /// <summary>
    /// Replication configuration, once set, this cannot be updated.
    /// Additionally this should be specified on the replica instance only, indicating the active as the peer_instance
    /// </summary>
    public TerraformExpression InitialReplication => this["initial_replication"];

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    public TerraformExpression KmsKeyName => this["kms_key_name"];

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// VPC networks to which the instance is connected. For this version,
    /// only a single network is supported.
    /// </summary>
    public TerraformExpression Networks => this["networks"];

    /// <summary>
    /// Performance configuration for the instance. If not provided,
    /// the default performance settings will be used.
    /// </summary>
    public TerraformExpression PerformanceConfig => this["performance_config"];

    /// <summary>
    /// Either NFSv3, for using NFS version 3 as file sharing protocol,
    /// or NFSv4.1, for using NFS version 4.1 as file sharing protocol.
    /// NFSv4.1 can be used with HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE.
    /// The default is NFSv3. Default value: &amp;quot;NFS_V3&amp;quot; Possible values: [&amp;quot;NFS_V3&amp;quot;, &amp;quot;NFS_V4_1&amp;quot;]
    /// </summary>
    public TerraformExpression Protocol => this["protocol"];

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
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The service tier of the instance.
    /// Possible values include: STANDARD, PREMIUM, BASIC_HDD, BASIC_SSD, HIGH_SCALE_SSD, ZONAL, REGIONAL and ENTERPRISE
    /// </summary>
    public TerraformExpression Tier => this["tier"];

    /// <summary>
    /// The name of the Filestore zone of the instance.
    /// </summary>
    public TerraformExpression Zone => this["zone"];

}
