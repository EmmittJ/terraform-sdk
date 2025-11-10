using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The fully qualified customer provided Cloud KMS key name to use for customer data encryption.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformProperty<string> KmsKey
    {
        set => SetProperty("kms_key", value);
    }

}

/// <summary>
/// Block type for hive_metastore_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ConfigOverrides
    {
        set => SetProperty("config_overrides", value);
    }

    /// <summary>
    /// The protocol to use for the metastore service endpoint. If unspecified, defaults to &#39;THRIFT&#39;. Default value: &amp;quot;THRIFT&amp;quot; Possible values: [&amp;quot;THRIFT&amp;quot;, &amp;quot;GRPC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EndpointProtocol
    {
        set => SetProperty("endpoint_protocol", value);
    }

    /// <summary>
    /// The Hive metastore schema version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// The day of week, when the window starts. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformProperty<string> DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The hour of day (0-23) when the window starts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformProperty<double> HourOfDay
    {
        set => SetProperty("hour_of_day", value);
    }

}

/// <summary>
/// Block type for metadata_integration in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceMetadataIntegrationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceNetworkConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for scaling_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Metastore instance sizes. Possible values: [&amp;quot;EXTRA_SMALL&amp;quot;, &amp;quot;SMALL&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LARGE&amp;quot;, &amp;quot;EXTRA_LARGE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? InstanceSize
    {
        set => SetProperty("instance_size", value);
    }

    /// <summary>
    /// Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.
    /// </summary>
    public TerraformProperty<double>? ScalingFactor
    {
        set => SetProperty("scaling_factor", value);
    }

}

/// <summary>
/// Block type for scheduled_backup in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScheduledBackupBlock : TerraformBlock
{
    /// <summary>
    /// A Cloud Storage URI of a folder, in the format gs://&amp;lt;bucket_name&amp;gt;/&amp;lt;path_inside_bucket&amp;gt;. A sub-folder &amp;lt;backup_folder&amp;gt; containing backup files will be stored below it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupLocation is required")]
    public required TerraformProperty<string> BackupLocation
    {
        set => SetProperty("backup_location", value);
    }

    /// <summary>
    /// The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.
    /// </summary>
    public TerraformProperty<string>? CronSchedule
    {
        set => SetProperty("cron_schedule", value);
    }

    /// <summary>
    /// Defines whether the scheduled backup is enabled. The default value is false.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.
    /// </summary>
    public TerraformProperty<string>? TimeZone
    {
        set => SetProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for telemetry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceTelemetryConfigBlock : TerraformBlock
{
    /// <summary>
    /// The output format of the Dataproc Metastore service&#39;s logs. Default value: &amp;quot;JSON&amp;quot; Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LogFormat
    {
        set => SetProperty("log_format", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataprocMetastoreServiceTimeoutsBlock : TerraformBlock
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
/// Manages a google_dataproc_metastore_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataprocMetastoreService : TerraformResource
{
    public GoogleDataprocMetastoreService(string name) : base("google_dataproc_metastore_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("artifact_gcs_uri");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("endpoint_uri");
        SetOutput("name");
        SetOutput("state");
        SetOutput("state_message");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("database_type");
        SetOutput("deletion_protection");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("network");
        SetOutput("port");
        SetOutput("project");
        SetOutput("release_channel");
        SetOutput("service_id");
        SetOutput("tags");
        SetOutput("tier");
    }

    /// <summary>
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DatabaseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_type");
        set => SetProperty("database_type", value);
    }

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
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
    /// User-defined labels for the metastore service.
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
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    public TerraformProperty<string> Network
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network");
        set => SetProperty("network", value);
    }

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
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
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ReleaseChannel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_channel");
        set => SetProperty("release_channel", value);
    }

    /// <summary>
    /// The ID of the metastore service. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformProperty<string> ServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_id");
        set => SetProperty("service_id", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceEncryptionConfigBlock>? EncryptionConfig
    {
        set => SetProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for hive_metastore_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveMetastoreConfig block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock>? HiveMetastoreConfig
    {
        set => SetProperty("hive_metastore_config", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for metadata_integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataIntegration block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceMetadataIntegrationBlock>? MetadataIntegration
    {
        set => SetProperty("metadata_integration", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceNetworkConfigBlock>? NetworkConfig
    {
        set => SetProperty("network_config", value);
    }

    /// <summary>
    /// Block for scaling_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceScalingConfigBlock>? ScalingConfig
    {
        set => SetProperty("scaling_config", value);
    }

    /// <summary>
    /// Block for scheduled_backup.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledBackup block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceScheduledBackupBlock>? ScheduledBackup
    {
        set => SetProperty("scheduled_backup", value);
    }

    /// <summary>
    /// Block for telemetry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelemetryConfig block(s) allowed")]
    public List<GoogleDataprocMetastoreServiceTelemetryConfigBlock>? TelemetryConfig
    {
        set => SetProperty("telemetry_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataprocMetastoreServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the metastore service are stored.
    /// </summary>
    public TerraformExpression ArtifactGcsUri => this["artifact_gcs_uri"];

    /// <summary>
    /// Output only. The time when the metastore service was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    public TerraformExpression EndpointUri => this["endpoint_uri"];

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the metastore service.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Additional information about the current state of the metastore service, if available.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The globally unique resource identifier of the metastore service.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the metastore service was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
