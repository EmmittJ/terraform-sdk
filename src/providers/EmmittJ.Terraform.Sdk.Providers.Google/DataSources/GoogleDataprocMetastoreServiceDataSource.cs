using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dataproc_metastore_service.
/// </summary>
public class GoogleDataprocMetastoreServiceDataSource : TerraformDataSource
{
    public GoogleDataprocMetastoreServiceDataSource(string name) : base("google_dataproc_metastore_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The ID of the metastore service. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    [TerraformPropertyName("service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceId { get; set; }

    /// <summary>
    /// A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the metastore service are stored.
    /// </summary>
    [TerraformPropertyName("artifact_gcs_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArtifactGcsUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "artifact_gcs_uri");

    /// <summary>
    /// Output only. The time when the metastore service was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("database_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DatabaseType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_type");

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Information used to configure the Dataproc Metastore service to encrypt
    /// customer data at rest.
    /// </summary>
    [TerraformPropertyName("encryption_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_config");

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    [TerraformPropertyName("endpoint_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_uri");

    /// <summary>
    /// Configuration information specific to running Hive metastore software as the metastore service.
    /// </summary>
    [TerraformPropertyName("hive_metastore_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HiveMetastoreConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "hive_metastore_config");

    /// <summary>
    /// User-defined labels for the metastore service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The one hour maintenance window of the metastore service.
    /// This specifies when the service can be restarted for maintenance purposes in UTC time.
    /// Maintenance window is not needed for services with the &#39;SPANNER&#39; database type.
    /// </summary>
    [TerraformPropertyName("maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceWindow => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_window");

    /// <summary>
    /// The setting that defines how metastore metadata should be integrated with external services and systems.
    /// </summary>
    [TerraformPropertyName("metadata_integration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MetadataIntegration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "metadata_integration");

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The configuration specifying the network settings for the Dataproc Metastore service.
    /// </summary>
    [TerraformPropertyName("network_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NetworkConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "network_config");

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("release_channel")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReleaseChannel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "release_channel");

    /// <summary>
    /// Represents the scaling configuration of a metastore service.
    /// </summary>
    [TerraformPropertyName("scaling_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScalingConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scaling_config");

    /// <summary>
    /// The configuration of scheduled backup for the metastore service.
    /// </summary>
    [TerraformPropertyName("scheduled_backup")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ScheduledBackup => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "scheduled_backup");

    /// <summary>
    /// The current state of the metastore service.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Additional information about the current state of the metastore service, if available.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_message");

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
    /// </summary>
    [TerraformPropertyName("telemetry_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TelemetryConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "telemetry_config");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Tier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tier");

    /// <summary>
    /// The globally unique resource identifier of the metastore service.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Output only. The time when the metastore service was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
