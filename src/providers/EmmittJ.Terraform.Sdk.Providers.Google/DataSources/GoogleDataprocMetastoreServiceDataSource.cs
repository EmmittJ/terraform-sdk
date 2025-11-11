using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dataproc_metastore_service.
/// </summary>
public partial class GoogleDataprocMetastoreServiceDataSource : TerraformDataSource
{
    public GoogleDataprocMetastoreServiceDataSource(string name) : base("google_dataproc_metastore_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The ID of the metastore service. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    [TerraformProperty("service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceId { get; set; }

    /// <summary>
    /// A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the metastore service are stored.
    /// </summary>
    [TerraformProperty("artifact_gcs_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArtifactGcsUri { get; }

    /// <summary>
    /// Output only. The time when the metastore service was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    [TerraformProperty("database_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DatabaseType { get; }

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Information used to configure the Dataproc Metastore service to encrypt
    /// customer data at rest.
    /// </summary>
    [TerraformProperty("encryption_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EncryptionConfig { get; }

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    [TerraformProperty("endpoint_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointUri { get; }

    /// <summary>
    /// Configuration information specific to running Hive metastore software as the metastore service.
    /// </summary>
    [TerraformProperty("hive_metastore_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HiveMetastoreConfig { get; }

    /// <summary>
    /// User-defined labels for the metastore service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// The one hour maintenance window of the metastore service.
    /// This specifies when the service can be restarted for maintenance purposes in UTC time.
    /// Maintenance window is not needed for services with the &#39;SPANNER&#39; database type.
    /// </summary>
    [TerraformProperty("maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenanceWindow { get; }

    /// <summary>
    /// The setting that defines how metastore metadata should be integrated with external services and systems.
    /// </summary>
    [TerraformProperty("metadata_integration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MetadataIntegration { get; }

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Network { get; }

    /// <summary>
    /// The configuration specifying the network settings for the Dataproc Metastore service.
    /// </summary>
    [TerraformProperty("network_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkConfig { get; }

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    [TerraformProperty("release_channel")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReleaseChannel { get; }

    /// <summary>
    /// Represents the scaling configuration of a metastore service.
    /// </summary>
    [TerraformProperty("scaling_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ScalingConfig { get; }

    /// <summary>
    /// The configuration of scheduled backup for the metastore service.
    /// </summary>
    [TerraformProperty("scheduled_backup")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ScheduledBackup { get; }

    /// <summary>
    /// The current state of the metastore service.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Additional information about the current state of the metastore service, if available.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
    /// </summary>
    [TerraformProperty("telemetry_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TelemetryConfig { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    [TerraformProperty("tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Tier { get; }

    /// <summary>
    /// The globally unique resource identifier of the metastore service.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. The time when the metastore service was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
