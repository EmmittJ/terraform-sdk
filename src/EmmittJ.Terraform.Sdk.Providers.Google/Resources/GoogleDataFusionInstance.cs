using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceAcceleratorsBlock : TerraformBlock
{
    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;CDC&amp;quot;, &amp;quot;HEALTHCARE&amp;quot;, &amp;quot;CCAI_INSIGHTS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    public required TerraformProperty<string> AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => WithProperty("accelerator_type", value);
    }

    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

}

/// <summary>
/// Block type for crypto_key_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceCryptoKeyConfigBlock : TerraformBlock
{
    /// <summary>
    /// The name of the key which is used to encrypt/decrypt customer data. For key in Cloud KMS, the key should be in the format of projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    public required TerraformProperty<string> KeyReference
    {
        get => GetProperty<TerraformProperty<string>>("key_reference");
        set => WithProperty("key_reference", value);
    }

}

/// <summary>
/// Block type for event_publish_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceEventPublishConfigBlock : TerraformBlock
{
    /// <summary>
    /// Option to enable Event Publishing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The resource name of the Pub/Sub topic. Format: projects/{projectId}/topics/{topic_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
    }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Type of connection for establishing private IP connectivity between the Data Fusion customer project VPC and
    /// the corresponding tenant project from a predefined list of available connection modes.
    /// If this field is unspecified for a private instance, VPC peering is used. Possible values: [&amp;quot;VPC_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT_INTERFACES&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ConnectionType
    {
        get => GetProperty<TerraformProperty<string>>("connection_type");
        set => WithProperty("connection_type", value);
    }

    /// <summary>
    /// The IP range in CIDR notation to use for the managed Data Fusion instance
    /// nodes. This range must not overlap with any other ranges used in the Data Fusion instance network.
    /// </summary>
    public TerraformProperty<string>? IpAllocation
    {
        get => GetProperty<TerraformProperty<string>>("ip_allocation");
        set => WithProperty("ip_allocation", value);
    }

    /// <summary>
    /// Name of the network in the project with which the tenant project
    /// will be peered for executing pipelines. In case of shared VPC where the network resides in another host
    /// project the network should specified in the form of projects/{host-project-id}/global/networks/{network}
    /// </summary>
    public TerraformProperty<string>? Network
    {
        get => GetProperty<TerraformProperty<string>>("network");
        set => WithProperty("network", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataFusionInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Map of additional options used to configure the behavior of Data Fusion instance.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Options
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("options");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
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
    /// Block for accelerators.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataFusionInstanceAcceleratorsBlock>? Accelerators
    {
        get => GetProperty<List<GoogleDataFusionInstanceAcceleratorsBlock>>("accelerators");
        set => this.WithProperty("accelerators", value);
    }

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    public List<GoogleDataFusionInstanceCryptoKeyConfigBlock>? CryptoKeyConfig
    {
        get => GetProperty<List<GoogleDataFusionInstanceCryptoKeyConfigBlock>>("crypto_key_config");
        set => this.WithProperty("crypto_key_config", value);
    }

    /// <summary>
    /// Block for event_publish_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventPublishConfig block(s) allowed")]
    public List<GoogleDataFusionInstanceEventPublishConfigBlock>? EventPublishConfig
    {
        get => GetProperty<List<GoogleDataFusionInstanceEventPublishConfigBlock>>("event_publish_config");
        set => this.WithProperty("event_publish_config", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleDataFusionInstanceNetworkConfigBlock>? NetworkConfig
    {
        get => GetProperty<List<GoogleDataFusionInstanceNetworkConfigBlock>>("network_config");
        set => this.WithProperty("network_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataFusionInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataFusionInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
