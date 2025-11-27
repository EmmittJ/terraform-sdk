using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dataproc_metastore_service Terraform data source.
/// Retrieves information about a google_dataproc_metastore_service.
/// </summary>
public partial class GoogleDataprocMetastoreServiceDataSource(string name) : TerraformDataSource("google_dataproc_metastore_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ID of the metastore service. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformValue<string> ServiceId
    {
        get => new TerraformReference<string>(this, "service_id");
        set => SetArgument("service_id", value);
    }

    /// <summary>
    /// A Cloud Storage URI (starting with gs://) that specifies where artifacts related to the metastore service are stored.
    /// </summary>
    public TerraformValue<string> ArtifactGcsUri
    {
        get => new TerraformReference<string>(this, "artifact_gcs_uri");
    }

    /// <summary>
    /// Output only. The time when the metastore service was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    public TerraformValue<string> DatabaseType
    {
        get => new TerraformReference<string>(this, "database_type");
    }

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Information used to configure the Dataproc Metastore service to encrypt
    /// customer data at rest.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    public TerraformValue<string> EndpointUri
    {
        get => new TerraformReference<string>(this, "endpoint_uri");
    }

    /// <summary>
    /// Configuration information specific to running Hive metastore software as the metastore service.
    /// </summary>
    public TerraformList<TerraformMap<object>> HiveMetastoreConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "hive_metastore_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// User-defined labels for the metastore service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The one hour maintenance window of the metastore service.
    /// This specifies when the service can be restarted for maintenance purposes in UTC time.
    /// Maintenance window is not needed for services with the &#39;SPANNER&#39; database type.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceWindow
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_window").ResolveNodes(ctx));
    }

    /// <summary>
    /// The setting that defines how metastore metadata should be integrated with external services and systems.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataIntegration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "metadata_integration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    public TerraformValue<string> Network
    {
        get => new TerraformReference<string>(this, "network");
    }

    /// <summary>
    /// The configuration specifying the network settings for the Dataproc Metastore service.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
    }

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    public TerraformValue<string> ReleaseChannel
    {
        get => new TerraformReference<string>(this, "release_channel");
    }

    /// <summary>
    /// Represents the scaling configuration of a metastore service.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScalingConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scaling_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The configuration of scheduled backup for the metastore service.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScheduledBackup
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scheduled_backup").ResolveNodes(ctx));
    }

    /// <summary>
    /// The current state of the metastore service.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// Additional information about the current state of the metastore service, if available.
    /// </summary>
    public TerraformValue<string> StateMessage
    {
        get => new TerraformReference<string>(this, "state_message");
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
    /// </summary>
    public TerraformList<TerraformMap<object>> TelemetryConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "telemetry_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
    }

    /// <summary>
    /// The globally unique resource identifier of the metastore service.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Output only. The time when the metastore service was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}
