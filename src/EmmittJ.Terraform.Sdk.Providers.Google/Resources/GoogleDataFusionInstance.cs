using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_data_fusion_instance resource.
/// </summary>
public class GoogleDataFusionInstance : TerraformResource
{
    public GoogleDataFusionInstance(string name) : base("google_data_fusion_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_endpoint");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("gcs_bucket");
        this.DeclareOutput("p4_service_account");
        this.DeclareOutput("service_endpoint");
        this.DeclareOutput("state");
        this.DeclareOutput("state_message");
        this.DeclareOutput("tenant_project_id");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// User-managed service account to set on Dataproc when Cloud Data Fusion creates Dataproc to run data processing pipelines.
    /// </summary>
    public TerraformProperty<string>? DataprocServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("dataproc_service_account");
        set => this.WithProperty("dataproc_service_account", value);
    }

    /// <summary>
    /// An optional description of the instance.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Display name for an instance.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Option to enable granular role-based access control.
    /// </summary>
    public TerraformProperty<bool>? EnableRbac
    {
        get => GetProperty<TerraformProperty<bool>>("enable_rbac");
        set => this.WithProperty("enable_rbac", value);
    }

    /// <summary>
    /// Option to enable Stackdriver Logging.
    /// </summary>
    public TerraformProperty<bool>? EnableStackdriverLogging
    {
        get => GetProperty<TerraformProperty<bool>>("enable_stackdriver_logging");
        set => this.WithProperty("enable_stackdriver_logging", value);
    }

    /// <summary>
    /// Option to enable Stackdriver Monitoring.
    /// </summary>
    public TerraformProperty<bool>? EnableStackdriverMonitoring
    {
        get => GetProperty<TerraformProperty<bool>>("enable_stackdriver_monitoring");
        set => this.WithProperty("enable_stackdriver_monitoring", value);
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
    /// The resource labels for instance to use to annotate any related underlying resources,
    /// such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Map of additional options used to configure the behavior of Data Fusion instance.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Options
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("options");
        set => this.WithProperty("options", value);
    }

    /// <summary>
    /// Specifies whether the Data Fusion instance should be private. If set to
    /// true, all Data Fusion nodes will have private IP addresses and will not be
    /// able to access the public internet.
    /// </summary>
    public TerraformProperty<bool>? PrivateInstance
    {
        get => GetProperty<TerraformProperty<bool>>("private_instance");
        set => this.WithProperty("private_instance", value);
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
    /// The region of the Data Fusion instance.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Represents the type of Data Fusion instance. Each type is configured with
    /// the default settings for processing and memory.
    /// - BASIC: Basic Data Fusion instance. In Basic type, the user will be able to create data pipelines
    /// using point and click UI. However, there are certain limitations, such as fewer number
    /// of concurrent pipelines, no support for streaming pipelines, etc.
    /// - ENTERPRISE: Enterprise Data Fusion instance. In Enterprise type, the user will have more features
    /// available, such as support for streaming pipelines, higher number of concurrent pipelines, etc.
    /// - DEVELOPER: Developer Data Fusion instance. In Developer type, the user will have all features available but
    /// with restrictive capabilities. This is to help enterprises design and develop their data ingestion and integration
    /// pipelines at low cost. Possible values: [&amp;quot;BASIC&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;, &amp;quot;DEVELOPER&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Current version of the Data Fusion.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Name of the zone in which the Data Fusion instance will be created. Only DEVELOPER instances use this field.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Endpoint on which the REST APIs is accessible.
    /// </summary>
    public TerraformExpression ApiEndpoint => this["api_endpoint"];

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Cloud Storage bucket generated by Data Fusion in the customer project.
    /// </summary>
    public TerraformExpression GcsBucket => this["gcs_bucket"];

    /// <summary>
    /// P4 service account for the customer project.
    /// </summary>
    public TerraformExpression P4ServiceAccount => this["p4_service_account"];

    /// <summary>
    /// Endpoint on which the Data Fusion UI and REST APIs are accessible.
    /// </summary>
    public TerraformExpression ServiceEndpoint => this["service_endpoint"];

    /// <summary>
    /// The current state of this Data Fusion instance.
    /// - CREATING: Instance is being created
    /// - RUNNING: Instance is running and ready for requests
    /// - FAILED: Instance creation failed
    /// - DELETING: Instance is being deleted
    /// - UPGRADING: Instance is being upgraded
    /// - RESTARTING: Instance is being restarted
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Additional information about the current state of this Data Fusion instance if available.
    /// </summary>
    public TerraformExpression StateMessage => this["state_message"];

    /// <summary>
    /// The name of the tenant project.
    /// </summary>
    public TerraformExpression TenantProjectId => this["tenant_project_id"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time the instance was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
