using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dataproc_metastore_service.
/// </summary>
public class GoogleDataprocMetastoreServiceDataSource : TerraformDataSource
{
    public GoogleDataprocMetastoreServiceDataSource(string name) : base("google_dataproc_metastore_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("artifact_gcs_uri");
        this.DeclareOutput("create_time");
        this.DeclareOutput("database_type");
        this.DeclareOutput("deletion_protection");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("encryption_config");
        this.DeclareOutput("endpoint_uri");
        this.DeclareOutput("hive_metastore_config");
        this.DeclareOutput("labels");
        this.DeclareOutput("maintenance_window");
        this.DeclareOutput("metadata_integration");
        this.DeclareOutput("name");
        this.DeclareOutput("network");
        this.DeclareOutput("network_config");
        this.DeclareOutput("port");
        this.DeclareOutput("release_channel");
        this.DeclareOutput("scaling_config");
        this.DeclareOutput("scheduled_backup");
        this.DeclareOutput("state");
        this.DeclareOutput("state_message");
        this.DeclareOutput("tags");
        this.DeclareOutput("telemetry_config");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("tier");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location where the metastore service should reside.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ID of the metastore service. The id must contain only letters (a-z, A-Z), numbers (0-9), underscores (_),
    /// and hyphens (-). Cannot begin or end with underscore or hyphen. Must consist of between
    /// 3 and 63 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformProperty<string> ServiceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_id");
        set => this.WithProperty("service_id", value);
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
    /// The database type that the Metastore service stores its data. Default value: &amp;quot;MYSQL&amp;quot; Possible values: [&amp;quot;MYSQL&amp;quot;, &amp;quot;SPANNER&amp;quot;]
    /// </summary>
    public TerraformExpression DatabaseType => this["database_type"];

    /// <summary>
    /// Indicates if the dataproc metastore should be protected against accidental deletions.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Information used to configure the Dataproc Metastore service to encrypt
    /// customer data at rest.
    /// </summary>
    public TerraformExpression EncryptionConfig => this["encryption_config"];

    /// <summary>
    /// The URI of the endpoint used to access the metastore service.
    /// </summary>
    public TerraformExpression EndpointUri => this["endpoint_uri"];

    /// <summary>
    /// Configuration information specific to running Hive metastore software as the metastore service.
    /// </summary>
    public TerraformExpression HiveMetastoreConfig => this["hive_metastore_config"];

    /// <summary>
    /// User-defined labels for the metastore service.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The one hour maintenance window of the metastore service.
    /// This specifies when the service can be restarted for maintenance purposes in UTC time.
    /// Maintenance window is not needed for services with the &#39;SPANNER&#39; database type.
    /// </summary>
    public TerraformExpression MaintenanceWindow => this["maintenance_window"];

    /// <summary>
    /// The setting that defines how metastore metadata should be integrated with external services and systems.
    /// </summary>
    public TerraformExpression MetadataIntegration => this["metadata_integration"];

    /// <summary>
    /// The relative resource name of the metastore service.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The relative resource name of the VPC network on which the instance can be accessed. It is specified in the following form:
    /// 
    /// &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    public TerraformExpression Network => this["network"];

    /// <summary>
    /// The configuration specifying the network settings for the Dataproc Metastore service.
    /// </summary>
    public TerraformExpression NetworkConfig => this["network_config"];

    /// <summary>
    /// The TCP port at which the metastore service is reached. Default: 9083.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// The release channel of the service. If unspecified, defaults to &#39;STABLE&#39;. Default value: &amp;quot;STABLE&amp;quot; Possible values: [&amp;quot;CANARY&amp;quot;, &amp;quot;STABLE&amp;quot;]
    /// </summary>
    public TerraformExpression ReleaseChannel => this["release_channel"];

    /// <summary>
    /// Represents the scaling configuration of a metastore service.
    /// </summary>
    public TerraformExpression ScalingConfig => this["scaling_config"];

    /// <summary>
    /// The configuration of scheduled backup for the metastore service.
    /// </summary>
    public TerraformExpression ScheduledBackup => this["scheduled_backup"];

    /// <summary>
    /// The current state of the metastore service.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Additional information about the current state of the metastore service, if available.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The configuration specifying telemetry settings for the Dataproc Metastore service. If unspecified defaults to JSON.
    /// </summary>
    public TerraformExpression TelemetryConfig => this["telemetry_config"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The tier of the service. Possible values: [&amp;quot;DEVELOPER&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformExpression Tier => this["tier"];

    /// <summary>
    /// The globally unique resource identifier of the metastore service.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the metastore service was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
