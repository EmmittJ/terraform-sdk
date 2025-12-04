using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for encryption_config in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// The fully qualified customer provided Cloud KMS key name to use for customer data encryption.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for hive_metastore_config in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hive_metastore_config";

    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the Hive metastore (configured in hive-site.xml).
    /// The mappings override system defaults (some keys cannot be overridden)
    /// </summary>
    public TerraformMap<string> ConfigOverrides
    {
        get => GetArgument<TerraformMap<string>>("config_overrides") ?? AsReference("config_overrides");
        set => SetArgument("config_overrides", value);
    }

    /// <summary>
    /// The protocol to use for the metastore service endpoint. If unspecified, defaults to &#39;THRIFT&#39;. Default value: &amp;quot;THRIFT&amp;quot; Possible values: [&amp;quot;THRIFT&amp;quot;, &amp;quot;GRPC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EndpointProtocol
    {
        get => GetArgument<TerraformValue<string>>("endpoint_protocol");
        set => SetArgument("endpoint_protocol", value);
    }

    /// <summary>
    /// The Hive metastore schema version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// AuxiliaryVersions block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockAuxiliaryVersionsBlock>? AuxiliaryVersions
    {
        get => GetArgument<TerraformSet<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockAuxiliaryVersionsBlock>>("auxiliary_versions");
        set => SetArgument("auxiliary_versions", value);
    }

    /// <summary>
    /// KerberosConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockKerberosConfigBlock>? KerberosConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockKerberosConfigBlock>>("kerberos_config");
        set => SetArgument("kerberos_config", value);
    }

}

/// <summary>
/// Block type for auxiliary_versions in GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock.
/// Nesting mode: set
/// </summary>
public class GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockAuxiliaryVersionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auxiliary_versions";

    /// <summary>
    /// A mapping of Hive metastore configuration key-value pairs to apply to the auxiliary Hive metastore (configured in hive-site.xml) in addition to the primary version&#39;s overrides.
    /// If keys are present in both the auxiliary version&#39;s overrides and the primary version&#39;s overrides, the value from the auxiliary version&#39;s overrides takes precedence.
    /// </summary>
    public TerraformMap<string>? ConfigOverrides
    {
        get => GetArgument<TerraformMap<string>>("config_overrides");
        set => SetArgument("config_overrides", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The Hive metastore version of the auxiliary service. It must be less than the primary Hive metastore service&#39;s version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for kerberos_config in GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockKerberosConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kerberos_config";

    /// <summary>
    /// A Cloud Storage URI that specifies the path to a krb5.conf file. It is of the form gs://{bucket_name}/path/to/krb5.conf, although the file does not need to be named krb5.conf explicitly.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Krb5ConfigGcsUri is required")]
    public required TerraformValue<string> Krb5ConfigGcsUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("krb5_config_gcs_uri");
        set => SetArgument("krb5_config_gcs_uri", value);
    }

    /// <summary>
    /// A Kerberos principal that exists in the both the keytab the KDC to authenticate as. A typical principal is of the form &amp;quot;primary/instance@REALM&amp;quot;, but there is no exact format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// Keytab block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keytab is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Keytab block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Keytab block(s) allowed")]
    public required TerraformList<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockKerberosConfigBlockKeytabBlock> Keytab
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockKerberosConfigBlockKeytabBlock>>("keytab");
        set => SetArgument("keytab", value);
    }

}

/// <summary>
/// Block type for keytab in GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockKerberosConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceHiveMetastoreConfigBlockKerberosConfigBlockKeytabBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "keytab";

    /// <summary>
    /// The relative resource name of a Secret Manager secret version, in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/secrets/{secret_id}/versions/{version_id}&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudSecret is required")]
    public required TerraformValue<string> CloudSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_secret");
        set => SetArgument("cloud_secret", value);
    }

}


/// <summary>
/// Block type for maintenance_window in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// The day of week, when the window starts. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The hour of day (0-23) when the window starts.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HourOfDay is required")]
    public required TerraformValue<double> HourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("hour_of_day");
        set => SetArgument("hour_of_day", value);
    }

}


/// <summary>
/// Block type for metadata_integration in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceMetadataIntegrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_integration";

    /// <summary>
    /// DataCatalogConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataCatalogConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataCatalogConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataCatalogConfig block(s) allowed")]
    public required TerraformList<GoogleDataprocMetastoreServiceMetadataIntegrationBlockDataCatalogConfigBlock> DataCatalogConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocMetastoreServiceMetadataIntegrationBlockDataCatalogConfigBlock>>("data_catalog_config");
        set => SetArgument("data_catalog_config", value);
    }

}

/// <summary>
/// Block type for data_catalog_config in GoogleDataprocMetastoreServiceMetadataIntegrationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceMetadataIntegrationBlockDataCatalogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_catalog_config";

    /// <summary>
    /// Defines whether the metastore metadata should be synced to Data Catalog. The default value is to disable syncing metastore metadata to Data Catalog.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for network_config in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// Consumers block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Consumers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Consumers block(s) required")]
    public required TerraformList<GoogleDataprocMetastoreServiceNetworkConfigBlockConsumersBlock> Consumers
    {
        get => GetRequiredArgument<TerraformList<GoogleDataprocMetastoreServiceNetworkConfigBlockConsumersBlock>>("consumers");
        set => SetArgument("consumers", value);
    }

}

/// <summary>
/// Block type for consumers in GoogleDataprocMetastoreServiceNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceNetworkConfigBlockConsumersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "consumers";

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    public TerraformValue<string> EndpointUri
        => AsReference("endpoint_uri");

    /// <summary>
    /// The subnetwork of the customer project from which an IP address is reserved and used as the Dataproc Metastore service&#39;s endpoint.
    /// It is accessible to hosts in the subnet and to all hosts in a subnet in the same region and same network.
    /// There must be at least one IP address available in the subnet&#39;s primary range. The subnet is specified in the following form:
    /// &#39;projects/{projectNumber}/regions/{region_id}/subnetworks/{subnetwork_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnetwork is required")]
    public required TerraformValue<string> Subnetwork
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

}


/// <summary>
/// Block type for scaling_config in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_config";

    /// <summary>
    /// Metastore instance sizes. Possible values: [&amp;quot;EXTRA_SMALL&amp;quot;, &amp;quot;SMALL&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;LARGE&amp;quot;, &amp;quot;EXTRA_LARGE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? InstanceSize
    {
        get => GetArgument<TerraformValue<string>>("instance_size");
        set => SetArgument("instance_size", value);
    }

    /// <summary>
    /// Scaling factor, in increments of 0.1 for values less than 1.0, and increments of 1.0 for values greater than 1.0.
    /// </summary>
    public TerraformValue<double>? ScalingFactor
    {
        get => GetArgument<TerraformValue<double>>("scaling_factor");
        set => SetArgument("scaling_factor", value);
    }

    /// <summary>
    /// AutoscalingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoscalingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceScalingConfigBlockAutoscalingConfigBlock>? AutoscalingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceScalingConfigBlockAutoscalingConfigBlock>>("autoscaling_config");
        set => SetArgument("autoscaling_config", value);
    }

}

/// <summary>
/// Block type for autoscaling_config in GoogleDataprocMetastoreServiceScalingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScalingConfigBlockAutoscalingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling_config";

    /// <summary>
    /// Defines whether autoscaling is enabled. The default value is false.
    /// </summary>
    public TerraformValue<bool>? AutoscalingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("autoscaling_enabled");
        set => SetArgument("autoscaling_enabled", value);
    }

    /// <summary>
    /// Output only. The scaling factor of a service with autoscaling enabled.
    /// </summary>
    public TerraformValue<double> AutoscalingFactor
        => AsReference("autoscaling_factor");

    /// <summary>
    /// LimitConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LimitConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceScalingConfigBlockAutoscalingConfigBlockLimitConfigBlock>? LimitConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceScalingConfigBlockAutoscalingConfigBlockLimitConfigBlock>>("limit_config");
        set => SetArgument("limit_config", value);
    }

}

/// <summary>
/// Block type for limit_config in GoogleDataprocMetastoreServiceScalingConfigBlockAutoscalingConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScalingConfigBlockAutoscalingConfigBlockLimitConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "limit_config";

    /// <summary>
    /// The maximum scaling factor that the service will autoscale to. The default value is 6.0.
    /// </summary>
    public TerraformValue<double> MaxScalingFactor
    {
        get => GetArgument<TerraformValue<double>>("max_scaling_factor") ?? AsReference("max_scaling_factor");
        set => SetArgument("max_scaling_factor", value);
    }

    /// <summary>
    /// The minimum scaling factor that the service will autoscale to. The default value is 0.1.
    /// </summary>
    public TerraformValue<double> MinScalingFactor
    {
        get => GetArgument<TerraformValue<double>>("min_scaling_factor") ?? AsReference("min_scaling_factor");
        set => SetArgument("min_scaling_factor", value);
    }

}


/// <summary>
/// Block type for scheduled_backup in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceScheduledBackupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduled_backup";

    /// <summary>
    /// A Cloud Storage URI of a folder, in the format gs://&amp;lt;bucket_name&amp;gt;/&amp;lt;path_inside_bucket&amp;gt;. A sub-folder &amp;lt;backup_folder&amp;gt; containing backup files will be stored below it.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupLocation is required")]
    public required TerraformValue<string> BackupLocation
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_location");
        set => SetArgument("backup_location", value);
    }

    /// <summary>
    /// The scheduled interval in Cron format, see https://en.wikipedia.org/wiki/Cron The default is empty: scheduled backup is not enabled. Must be specified to enable scheduled backups.
    /// </summary>
    public TerraformValue<string>? CronSchedule
    {
        get => GetArgument<TerraformValue<string>>("cron_schedule");
        set => SetArgument("cron_schedule", value);
    }

    /// <summary>
    /// Defines whether the scheduled backup is enabled. The default value is false.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? AsReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Specifies the time zone to be used when interpreting cronSchedule. Must be a time zone name from the time zone database (https://en.wikipedia.org/wiki/List_of_tz_database_time_zones), e.g. America/Los_Angeles or Africa/Abidjan. If left unspecified, the default is UTC.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone") ?? AsReference("time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for telemetry_config in GoogleDataprocMetastoreService.
/// Nesting mode: list
/// </summary>
public class GoogleDataprocMetastoreServiceTelemetryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "telemetry_config";

    /// <summary>
    /// The output format of the Dataproc Metastore service&#39;s logs. Default value: &amp;quot;JSON&amp;quot; Possible values: [&amp;quot;LEGACY&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LogFormat
    {
        get => GetArgument<TerraformValue<string>>("log_format");
        set => SetArgument("log_format", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataprocMetastoreService.
/// Nesting mode: single
/// </summary>
public class GoogleDataprocMetastoreServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dataproc_metastore_service Terraform resource.
/// Manages a google_dataproc_metastore_service resource.
/// </summary>
public partial class GoogleDataprocMetastoreService(string name) : TerraformResource("google_dataproc_metastore_service", name)
{
    /// <summary>
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DatabaseType
    {
        get => GetArgument<TerraformValue<string>>("database_type");
        set => SetArgument("database_type", value);
    }

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-defined labels for the metastore service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => GetArgument<TerraformValue<string>>("network") ?? AsReference("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ReleaseChannel
    {
        get => GetArgument<TerraformValue<string>>("release_channel");
        set => SetArgument("release_channel", value);
    }

    /// <summary>
    /// The ID of the metastore service. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier") ?? AsReference("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the metastore service are stored.
    /// </summary>
    public TerraformValue<string> ArtifactGcsUri
        => AsReference("artifact_gcs_uri");

    /// <summary>
    /// Output only. The time when the metastore service was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    public TerraformValue<string> EndpointUri
        => AsReference("endpoint_uri");

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The current state of the metastore service.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Additional information about the current state of the metastore service, if available.
    /// </summary>
    public TerraformValue<string> StateMessage
        => AsReference("state_message");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The globally unique resource identifier of the metastore service.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

    /// <summary>
    /// Output only. The time when the metastore service was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// HiveMetastoreConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveMetastoreConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock>? HiveMetastoreConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceHiveMetastoreConfigBlock>>("hive_metastore_config");
        set => SetArgument("hive_metastore_config", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// MetadataIntegration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataIntegration block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceMetadataIntegrationBlock>? MetadataIntegration
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceMetadataIntegrationBlock>>("metadata_integration");
        set => SetArgument("metadata_integration", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// ScalingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceScalingConfigBlock>? ScalingConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceScalingConfigBlock>>("scaling_config");
        set => SetArgument("scaling_config", value);
    }

    /// <summary>
    /// ScheduledBackup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduledBackup block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceScheduledBackupBlock>? ScheduledBackup
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceScheduledBackupBlock>>("scheduled_backup");
        set => SetArgument("scheduled_backup", value);
    }

    /// <summary>
    /// TelemetryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TelemetryConfig block(s) allowed")]
    public TerraformList<GoogleDataprocMetastoreServiceTelemetryConfigBlock>? TelemetryConfig
    {
        get => GetArgument<TerraformList<GoogleDataprocMetastoreServiceTelemetryConfigBlock>>("telemetry_config");
        set => SetArgument("telemetry_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataprocMetastoreServiceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataprocMetastoreServiceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
