using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceEncryptionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The fully qualified customer provided Cloud KMS key name to use for customer data encryption.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformProperty("kms_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for hive_metastore_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [TerraformProperty("config_overrides")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> ConfigOverrides { get; set; }

    /// <summary>
    /// The protocol to use for the metastore service endpoint. If unspecified, defaults to &#39;THRIFT&#39;. Default value: &amp;quot;THRIFT&amp;quot; Possible values: [&amp;quot;THRIFT&amp;quot;, &amp;quot;GRPC&amp;quot;]
    /// </summary>
    [TerraformProperty("endpoint_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EndpointProtocol { get; set; }

    /// <summary>
    /// The Hive metastore schema version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceMaintenanceWindowBlock : TerraformBlockBase
{
    /// <summary>
    /// The day of week, when the window starts. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformProperty("day_of_week")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The hour of day (0-23) when the window starts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    [TerraformProperty("hour_of_day")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> HourOfDay { get; set; }

}

/// <summary>
/// Block type for metadata_integration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceMetadataIntegrationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceNetworkConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceScalingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Metastore instance sizes. Possible values: [&amp;quot;EXTRA_SMALL&amp;quot;, &amp;quot;SMALL&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LARGE&amp;quot;, &amp;quot;EXTRA_LARGE&amp;quot;]
    /// </summary>
    [TerraformProperty("instance_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceSize { get; set; }

    /// <summary>
    /// Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.
    /// </summary>
    [TerraformProperty("scaling_factor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ScalingFactor { get; set; }

}

/// <summary>
/// Block type for scheduled_backup in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceScheduledBackupBlock : TerraformBlockBase
{
    /// <summary>
    /// A Cloud Storage URI of a folder, in the format gs://&amp;lt;bucket_name&amp;gt;/&amp;lt;path_inside_bucket&amp;gt;. A sub-folder &amp;lt;backup_folder&amp;gt; containing backup files will be stored below it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupLocation is required")]
    [TerraformProperty("backup_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackupLocation { get; set; }

    /// <summary>
    /// The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.
    /// </summary>
    [TerraformProperty("cron_schedule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CronSchedule { get; set; }

    /// <summary>
    /// Defines whether the scheduled backup is enabled. The default value is false.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TimeZone { get; set; }

}

/// <summary>
/// Block type for telemetry_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataprocMetastoreServiceTelemetryConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The output format of the Dataproc Metastore service&#39;s logs. Default value: &amp;quot;JSON&amp;quot; Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformProperty("log_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogFormat { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataprocMetastoreServiceTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_dataproc_metastore_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataprocMetastoreService : TerraformResource
{
    public GoogleDataprocMetastoreService(string name) : base("google_dataproc_metastore_service", name)
    {
    }

    /// <summary>
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    [TerraformProperty("database_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DatabaseType { get; set; }

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the metastore service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    [TerraformProperty("release_channel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReleaseChannel { get; set; }

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
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    [TerraformProperty("tier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Tier { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for hive_metastore_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveMetastoreConfig block(s) allowed")]
    [TerraformProperty("hive_metastore_config")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock>>? HiveMetastoreConfig { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformProperty("maintenance_window")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for metadata_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataIntegration block(s) allowed")]
    [TerraformProperty("metadata_integration")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceMetadataIntegrationBlock>>? MetadataIntegration { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    [TerraformProperty("scaling_config")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceScalingConfigBlock>>? ScalingConfig { get; set; }

    /// <summary>
    /// Block for scheduled_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledBackup block(s) allowed")]
    [TerraformProperty("scheduled_backup")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceScheduledBackupBlock>>? ScheduledBackup { get; set; }

    /// <summary>
    /// Block for telemetry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelemetryConfig block(s) allowed")]
    [TerraformProperty("telemetry_config")]
    public partial TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceTelemetryConfigBlock>>? TelemetryConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDataprocMetastoreServiceTimeoutsBlock>? Timeouts { get; set; }

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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    [TerraformProperty("endpoint_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointUri { get; }

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

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
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

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
