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
        set => SetProperty("accelerator_type", value);
    }

    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    public required TerraformProperty<string> State
    {
        set => SetProperty("state", value);
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
        set => SetProperty("key_reference", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The resource name of the Pub/Sub topic. Format: projects/{projectId}/topics/{topic_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        set => SetProperty("topic", value);
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
        set => SetProperty("connection_type", value);
    }

    /// <summary>
    /// The IP range in CIDR notation to use for the managed Data Fusion instance
    /// nodes. This range must not overlap with any other ranges used in the Data Fusion instance network.
    /// </summary>
    public TerraformProperty<string>? IpAllocation
    {
        set => SetProperty("ip_allocation", value);
    }

    /// <summary>
    /// Name of the network in the project with which the tenant project
    /// will be peered for executing pipelines. In case of shared VPC where the network resides in another host
    /// project the network should specified in the form of projects/{host-project-id}/global/networks/{network}
    /// </summary>
    public TerraformProperty<string>? Network
    {
        set => SetProperty("network", value);
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
/// Manages a google_data_fusion_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataFusionInstance : TerraformResource
{
    public GoogleDataFusionInstance(string name) : base("google_data_fusion_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("api_endpoint");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("gcs_bucket");
        SetOutput("p4_service_account");
        SetOutput("service_endpoint");
        SetOutput("state");
        SetOutput("state_message");
        SetOutput("tenant_project_id");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("dataproc_service_account");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("enable_rbac");
        SetOutput("enable_stackdriver_logging");
        SetOutput("enable_stackdriver_monitoring");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("options");
        SetOutput("private_instance");
        SetOutput("project");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("type");
        SetOutput("version");
        SetOutput("zone");
    }

    /// <summary>
    /// User-managed service account to set on Dataproc when Cloud Data Fusion creates Dataproc to run data processing pipelines.
    /// </summary>
    public TerraformProperty<string> DataprocServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataproc_service_account");
        set => SetProperty("dataproc_service_account", value);
    }

    /// <summary>
    /// An optional description of the instance.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Display name for an instance.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Option to enable granular role-based access control.
    /// </summary>
    public TerraformProperty<bool> EnableRbac
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_rbac");
        set => SetProperty("enable_rbac", value);
    }

    /// <summary>
    /// Option to enable Stackdriver Logging.
    /// </summary>
    public TerraformProperty<bool> EnableStackdriverLogging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_stackdriver_logging");
        set => SetProperty("enable_stackdriver_logging", value);
    }

    /// <summary>
    /// Option to enable Stackdriver Monitoring.
    /// </summary>
    public TerraformProperty<bool> EnableStackdriverMonitoring
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_stackdriver_monitoring");
        set => SetProperty("enable_stackdriver_monitoring", value);
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
    /// The resource labels for instance to use to annotate any related underlying resources,
    /// such as Compute Engine VMs.
    /// 
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
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Map of additional options used to configure the behavior of Data Fusion instance.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Options
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("options");
        set => SetProperty("options", value);
    }

    /// <summary>
    /// Specifies whether the Data Fusion instance should be private. If set to
    /// true, all Data Fusion nodes will have private IP addresses and will not be
    /// able to access the public internet.
    /// </summary>
    public TerraformProperty<bool> PrivateInstance
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_instance");
        set => SetProperty("private_instance", value);
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
    /// The region of the Data Fusion instance.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Current version of the Data Fusion.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Name of the zone in which the Data Fusion instance will be created. Only DEVELOPER instances use this field.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for accelerators.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataFusionInstanceAcceleratorsBlock>? Accelerators
    {
        set => SetProperty("accelerators", value);
    }

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    public List<GoogleDataFusionInstanceCryptoKeyConfigBlock>? CryptoKeyConfig
    {
        set => SetProperty("crypto_key_config", value);
    }

    /// <summary>
    /// Block for event_publish_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventPublishConfig block(s) allowed")]
    public List<GoogleDataFusionInstanceEventPublishConfigBlock>? EventPublishConfig
    {
        set => SetProperty("event_publish_config", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleDataFusionInstanceNetworkConfigBlock>? NetworkConfig
    {
        set => SetProperty("network_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataFusionInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
