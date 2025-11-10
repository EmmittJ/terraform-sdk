using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceEncryptionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The fully qualified customer provided Cloud KMS key name to use for customer data encryption.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKey { get; set; }

}

/// <summary>
/// Block type for hive_metastore_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock : ITerraformBlock
{
    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    [TerraformPropertyName("config_overrides")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ConfigOverrides { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>("", "config_overrides");

    /// <summary>
    /// The protocol to use for the metastore service endpoint. If unspecified, defaults to &#39;THRIFT&#39;. Default value: &amp;quot;THRIFT&amp;quot; Possible values: [&amp;quot;THRIFT&amp;quot;, &amp;quot;GRPC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("endpoint_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndpointProtocol { get; set; }

    /// <summary>
    /// The Hive metastore schema version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceMaintenanceWindowBlock : ITerraformBlock
{
    /// <summary>
    /// The day of week, when the window starts. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DayOfWeek { get; set; }

    /// <summary>
    /// The hour of day (0-23) when the window starts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    [TerraformPropertyName("hour_of_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> HourOfDay { get; set; }

}

/// <summary>
/// Block type for metadata_integration in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceMetadataIntegrationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceNetworkConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScalingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Metastore instance sizes. Possible values: [&amp;quot;EXTRA_SMALL&amp;quot;, &amp;quot;SMALL&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LARGE&amp;quot;, &amp;quot;EXTRA_LARGE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("instance_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceSize { get; set; }

    /// <summary>
    /// Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.
    /// </summary>
    [TerraformPropertyName("scaling_factor")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ScalingFactor { get; set; }

}

/// <summary>
/// Block type for scheduled_backup in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScheduledBackupBlock : ITerraformBlock
{
    /// <summary>
    /// A Cloud Storage URI of a folder, in the format gs://&amp;lt;bucket_name&amp;gt;/&amp;lt;path_inside_bucket&amp;gt;. A sub-folder &amp;lt;backup_folder&amp;gt; containing backup files will be stored below it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupLocation is required")]
    [TerraformPropertyName("backup_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupLocation { get; set; }

    /// <summary>
    /// The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.
    /// </summary>
    [TerraformPropertyName("cron_schedule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CronSchedule { get; set; }

    /// <summary>
    /// Defines whether the scheduled backup is enabled. The default value is false.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

    /// <summary>
    /// Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TimeZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "time_zone");

}

/// <summary>
/// Block type for telemetry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceTelemetryConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The output format of the Dataproc Metastore service&#39;s logs. Default value: &amp;quot;JSON&amp;quot; Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    [TerraformPropertyName("log_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogFormat { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocMetastoreServiceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataproc_metastore_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocMetastoreService : TerraformResource
{
    public GoogleDataprocMetastoreService(string name) : base("google_dataproc_metastore_service", name)
    {
    }

    /// <summary>
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    [TerraformPropertyName("database_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatabaseType { get; set; }

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// User-defined labels for the metastore service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Network { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Port { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("release_channel")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReleaseChannel { get; set; }

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
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("tier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Tier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tier");

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformPropertyName("encryption_config")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceEncryptionConfigBlock>>? EncryptionConfig { get; set; } = new();

    /// <summary>
    /// Block for hive_metastore_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveMetastoreConfig block(s) allowed")]
    [TerraformPropertyName("hive_metastore_config")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock>>? HiveMetastoreConfig { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceMaintenanceWindowBlock>>? MaintenanceWindow { get; set; } = new();

    /// <summary>
    /// Block for metadata_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataIntegration block(s) allowed")]
    [TerraformPropertyName("metadata_integration")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceMetadataIntegrationBlock>>? MetadataIntegration { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    [TerraformPropertyName("scaling_config")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceScalingConfigBlock>>? ScalingConfig { get; set; } = new();

    /// <summary>
    /// Block for scheduled_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledBackup block(s) allowed")]
    [TerraformPropertyName("scheduled_backup")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceScheduledBackupBlock>>? ScheduledBackup { get; set; } = new();

    /// <summary>
    /// Block for telemetry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelemetryConfig block(s) allowed")]
    [TerraformPropertyName("telemetry_config")]
    public TerraformList<TerraformBlock<GoogleDataprocMetastoreServiceTelemetryConfigBlock>>? TelemetryConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataprocMetastoreServiceTimeoutsBlock>? Timeouts { get; set; } = new();

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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    [TerraformPropertyName("endpoint_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_uri");

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

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
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

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
