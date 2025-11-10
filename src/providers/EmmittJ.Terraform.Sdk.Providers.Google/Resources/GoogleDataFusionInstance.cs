using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for accelerators in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceAcceleratorsBlock : ITerraformBlock
{
    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;CDC&amp;quot;, &amp;quot;HEALTHCARE&amp;quot;, &amp;quot;CCAI_INSIGHTS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceleratorType is required")]
    [TerraformPropertyName("accelerator_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AcceleratorType { get; set; }

    /// <summary>
    /// The type of an accelator for a CDF instance. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "State is required")]
    [TerraformPropertyName("state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> State { get; set; }

}

/// <summary>
/// Block type for crypto_key_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceCryptoKeyConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the key which is used to encrypt/decrypt customer data. For key in Cloud KMS, the key should be in the format of projects/*/locations/*/keyRings/*/cryptoKeys/*.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyReference is required")]
    [TerraformPropertyName("key_reference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyReference { get; set; }

}

/// <summary>
/// Block type for event_publish_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceEventPublishConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Option to enable Event Publishing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The resource name of the Pub/Sub topic. Format: projects/{projectId}/topics/{topic_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformPropertyName("topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Topic { get; set; }

}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleDataFusionInstanceNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Type of connection for establishing private IP connectivity between the Data Fusion customer project VPC and
    /// the corresponding tenant project from a predefined list of available connection modes.
    /// If this field is unspecified for a private instance, VPC peering is used. Possible values: [&amp;quot;VPC_PEERING&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT_INTERFACES&amp;quot;]
    /// </summary>
    [TerraformPropertyName("connection_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConnectionType { get; set; }

    /// <summary>
    /// The IP range in CIDR notation to use for the managed Data Fusion instance
    /// nodes. This range must not overlap with any other ranges used in the Data Fusion instance network.
    /// </summary>
    [TerraformPropertyName("ip_allocation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAllocation { get; set; }

    /// <summary>
    /// Name of the network in the project with which the tenant project
    /// will be peered for executing pipelines. In case of shared VPC where the network resides in another host
    /// project the network should specified in the form of projects/{host-project-id}/global/networks/{network}
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataFusionInstanceTimeoutsBlock : ITerraformBlock
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
/// Manages a google_data_fusion_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataFusionInstance : TerraformResource
{
    public GoogleDataFusionInstance(string name) : base("google_data_fusion_instance", name)
    {
    }

    /// <summary>
    /// User-managed service account to set on Dataproc when Cloud Data Fusion creates Dataproc to run data processing pipelines.
    /// </summary>
    [TerraformPropertyName("dataproc_service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataprocServiceAccount { get; set; }

    /// <summary>
    /// An optional description of the instance.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Display name for an instance.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// Option to enable granular role-based access control.
    /// </summary>
    [TerraformPropertyName("enable_rbac")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableRbac { get; set; }

    /// <summary>
    /// Option to enable Stackdriver Logging.
    /// </summary>
    [TerraformPropertyName("enable_stackdriver_logging")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Option to enable Stackdriver Monitoring.
    /// </summary>
    [TerraformPropertyName("enable_stackdriver_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableStackdriverMonitoring { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource labels for instance to use to annotate any related underlying resources,
    /// such as Compute Engine VMs.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Map of additional options used to configure the behavior of Data Fusion instance.
    /// </summary>
    [TerraformPropertyName("options")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Options { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "options");

    /// <summary>
    /// Specifies whether the Data Fusion instance should be private. If set to
    /// true, all Data Fusion nodes will have private IP addresses and will not be
    /// able to access the public internet.
    /// </summary>
    [TerraformPropertyName("private_instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrivateInstance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region of the Data Fusion instance.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

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
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Current version of the Data Fusion.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Version { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// Name of the zone in which the Data Fusion instance will be created. Only DEVELOPER instances use this field.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// Block for accelerators.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("accelerators")]
    public TerraformList<TerraformBlock<GoogleDataFusionInstanceAcceleratorsBlock>>? Accelerators { get; set; } = new();

    /// <summary>
    /// Block for crypto_key_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CryptoKeyConfig block(s) allowed")]
    [TerraformPropertyName("crypto_key_config")]
    public TerraformList<TerraformBlock<GoogleDataFusionInstanceCryptoKeyConfigBlock>>? CryptoKeyConfig { get; set; } = new();

    /// <summary>
    /// Block for event_publish_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventPublishConfig block(s) allowed")]
    [TerraformPropertyName("event_publish_config")]
    public TerraformList<TerraformBlock<GoogleDataFusionInstanceEventPublishConfigBlock>>? EventPublishConfig { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleDataFusionInstanceNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataFusionInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Endpoint on which the REST APIs is accessible.
    /// </summary>
    [TerraformPropertyName("api_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "api_endpoint");

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
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
    /// Cloud Storage bucket generated by Data Fusion in the customer project.
    /// </summary>
    [TerraformPropertyName("gcs_bucket")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GcsBucket => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gcs_bucket");

    /// <summary>
    /// P4 service account for the customer project.
    /// </summary>
    [TerraformPropertyName("p4_service_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> P4ServiceAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "p4_service_account");

    /// <summary>
    /// Endpoint on which the Data Fusion UI and REST APIs are accessible.
    /// </summary>
    [TerraformPropertyName("service_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_endpoint");

    /// <summary>
    /// The current state of this Data Fusion instance.
    /// - CREATING: Instance is being created
    /// - RUNNING: Instance is running and ready for requests
    /// - FAILED: Instance creation failed
    /// - DELETING: Instance is being deleted
    /// - UPGRADING: Instance is being upgraded
    /// - RESTARTING: Instance is being restarted
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Additional information about the current state of this Data Fusion instance if available.
    /// </summary>
    [TerraformPropertyName("state_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state_message");

    /// <summary>
    /// The name of the tenant project.
    /// </summary>
    [TerraformPropertyName("tenant_project_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantProjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_project_id");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// The time the instance was last updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
