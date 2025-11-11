using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataFusionInstanceAcceleratorsBlock : TerraformBlockBase
{
    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;CDC&amp;quot;, &amp;quot;HEALTHCARE&amp;quot;, &amp;quot;CCAI_INSIGHTS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    [TerraformProperty("accelerator_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AcceleratorType { get; set; }

    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformProperty("state")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> State { get; set; }

}

/// <summary>
/// Block type for crypto_key_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataFusionInstanceCryptoKeyConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the key which is used to encrypt/decrypt customer data. For key in Cloud KMS, the key should be in the format of projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    [TerraformProperty("key_reference")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyReference { get; set; }

}

/// <summary>
/// Block type for event_publish_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataFusionInstanceEventPublishConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Option to enable Event Publishing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The resource name of the Pub/Sub topic. Format: projects/{projectId}/topics/{topic_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataFusionInstanceNetworkConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Type of connection for establishing private IP connectivity between the Data Fusion customer project VPC and
    /// the corresponding tenant project from a predefined list of available connection modes.
    /// If this field is unspecified for a private instance, VPC peering is used. Possible values: [&amp;quot;VPC_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT_INTERFACES&amp;quot;]
    /// </summary>
    [TerraformProperty("connection_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionType { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the managed Data Fusion instance
    /// nodes. This range must not overlap with any other ranges used in the Data Fusion instance network.
    /// </summary>
    [TerraformProperty("ip_allocation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAllocation { get; set; }

    /// <summary>
    /// Name of the network in the project with which the tenant project
    /// will be peered for executing pipelines. In case of shared VPC where the network resides in another host
    /// project the network should specified in the form of projects/{host-project-id}/global/networks/{network}
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataFusionInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_data_fusion_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataFusionInstance : TerraformResource
{
    public GoogleDataFusionInstance(string name) : base("google_data_fusion_instance", name)
    {
    }

    /// <summary>
    /// User-managed service account to set on Dataproc when Cloud Data Fusion creates Dataproc to run data processing pipelines.
    /// </summary>
    [TerraformProperty("dataproc_service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataprocServiceAccount { get; set; }

    /// <summary>
    /// An optional description of the instance.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Display name for an instance.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Option to enable granular role-based access control.
    /// </summary>
    [TerraformProperty("enable_rbac")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableRbac { get; set; }

    /// <summary>
    /// Option to enable Stackdriver Logging.
    /// </summary>
    [TerraformProperty("enable_stackdriver_logging")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Option to enable Stackdriver Monitoring.
    /// </summary>
    [TerraformProperty("enable_stackdriver_monitoring")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableStackdriverMonitoring { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource labels for instance to use to annotate any related underlying resources,
    /// such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Map of additional options used to configure the behavior of Data Fusion instance.
    /// </summary>
    [TerraformProperty("options")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Options { get; set; }

    /// <summary>
    /// Specifies whether the Data Fusion instance should be private. If set to
    /// true, all Data Fusion nodes will have private IP addresses and will not be
    /// able to access the public internet.
    /// </summary>
    [TerraformProperty("private_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateInstance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region of the Data Fusion instance.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

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
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Current version of the Data Fusion.
    /// </summary>
    [TerraformProperty("version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Name of the zone in which the Data Fusion instance will be created. Only DEVELOPER instances use this field.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for accelerators.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("accelerators")]
    public partial TerraformList<TerraformBlock<GoogleDataFusionInstanceAcceleratorsBlock>>? Accelerators { get; set; }

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    [TerraformProperty("crypto_key_config")]
    public partial TerraformList<TerraformBlock<GoogleDataFusionInstanceCryptoKeyConfigBlock>>? CryptoKeyConfig { get; set; }

    /// <summary>
    /// Block for event_publish_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventPublishConfig block(s) allowed")]
    [TerraformProperty("event_publish_config")]
    public partial TerraformList<TerraformBlock<GoogleDataFusionInstanceEventPublishConfigBlock>>? EventPublishConfig { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public partial TerraformList<TerraformBlock<GoogleDataFusionInstanceNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleDataFusionInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Endpoint on which the REST APIs is accessible.
    /// </summary>
    [TerraformProperty("api_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApiEndpoint { get; }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
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
    /// Cloud Storage bucket generated by Data Fusion in the customer project.
    /// </summary>
    [TerraformProperty("gcs_bucket")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GcsBucket { get; }

    /// <summary>
    /// P4 service account for the customer project.
    /// </summary>
    [TerraformProperty("p4_service_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> P4ServiceAccount { get; }

    /// <summary>
    /// Endpoint on which the Data Fusion UI and REST APIs are accessible.
    /// </summary>
    [TerraformProperty("service_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceEndpoint { get; }

    /// <summary>
    /// The current state of this Data Fusion instance.
    /// - CREATING: Instance is being created
    /// - RUNNING: Instance is running and ready for requests
    /// - FAILED: Instance creation failed
    /// - DELETING: Instance is being deleted
    /// - UPGRADING: Instance is being upgraded
    /// - RESTARTING: Instance is being restarted
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Additional information about the current state of this Data Fusion instance if available.
    /// </summary>
    [TerraformProperty("state_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateMessage { get; }

    /// <summary>
    /// The name of the tenant project.
    /// </summary>
    [TerraformProperty("tenant_project_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantProjectId { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The time the instance was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
