using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for build_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctions2FunctionBuildConfigBlock : TerraformBlockBase
{

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key.
    /// </summary>
    [TerraformProperty("docker_repository")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DockerRepository { get; set; }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &amp;quot;function&amp;quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    [TerraformProperty("entry_point")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EntryPoint { get; set; }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> EnvironmentVariables { get; set; }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    [TerraformProperty("runtime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Runtime { get; set; }

    /// <summary>
    /// The fully-qualified name of the service account to be used for building the container.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    [TerraformProperty("worker_pool")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkerPool { get; set; }

}

/// <summary>
/// Block type for event_trigger in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctions2FunctionEventTriggerBlock : TerraformBlockBase
{
    /// <summary>
    /// Required. The type of event to observe.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    [TerraformProperty("event_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EventType { get; set; }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    [TerraformProperty("pubsub_topic")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PubsubTopic { get; set; }

    /// <summary>
    /// Describes the retry policy in case of function&#39;s execution failure.
    /// Retried execution is charged as any other execution. Possible values: [&amp;quot;RETRY_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RETRY_POLICY_DO_NOT_RETRY&amp;quot;, &amp;quot;RETRY_POLICY_RETRY&amp;quot;]
    /// </summary>
    [TerraformProperty("retry_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RetryPolicy { get; set; }

    /// <summary>
    /// Optional. The email of the trigger&#39;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccountEmail { get; set; }


    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    [TerraformProperty("trigger_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TriggerRegion { get; set; }

}

/// <summary>
/// Block type for service_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudfunctions2FunctionServiceConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether 100% of traffic is routed to the latest revision. Defaults to true.
    /// </summary>
    [TerraformProperty("all_traffic_on_latest_revision")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllTrafficOnLatestRevision { get; set; }

    /// <summary>
    /// The number of CPUs used in a single container instance. Default value is calculated from available memory.
    /// </summary>
    [TerraformProperty("available_cpu")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailableCpu { get; set; }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    [TerraformProperty("available_memory")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailableMemory { get; set; }

    /// <summary>
    /// The binary authorization policy to be checked when deploying the Cloud Run service.
    /// </summary>
    [TerraformProperty("binary_authorization_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BinaryAuthorizationPolicy { get; set; }

    /// <summary>
    /// Environment variables that shall be available during function execution.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> EnvironmentVariables { get; set; }


    /// <summary>
    /// Available ingress settings. Defaults to &amp;quot;ALLOW_ALL&amp;quot; if unspecified. Default value: &amp;quot;ALLOW_ALL&amp;quot; Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;ALLOW_INTERNAL_ONLY&amp;quot;, &amp;quot;ALLOW_INTERNAL_AND_GCLB&amp;quot;]
    /// </summary>
    [TerraformProperty("ingress_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IngressSettings { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [TerraformProperty("max_instance_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxInstanceCount { get; set; }

    /// <summary>
    /// Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.
    /// </summary>
    [TerraformProperty("max_instance_request_concurrency")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxInstanceRequestConcurrency { get; set; }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [TerraformProperty("min_instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinInstanceCount { get; set; }


    /// <summary>
    /// The email of the service account for this function.
    /// </summary>
    [TerraformProperty("service_account_email")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccountEmail { get; set; }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    [TerraformProperty("timeout_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TimeoutSeconds { get; set; }


    /// <summary>
    /// The Serverless VPC Access connector that this cloud function can connect to.
    /// </summary>
    [TerraformProperty("vpc_connector")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcConnector { get; set; }

    /// <summary>
    /// Available egress settings. Possible values: [&amp;quot;VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED&amp;quot;, &amp;quot;PRIVATE_RANGES_ONLY&amp;quot;, &amp;quot;ALL_TRAFFIC&amp;quot;]
    /// </summary>
    [TerraformProperty("vpc_connector_egress_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcConnectorEgressSettings { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudfunctions2FunctionTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_cloudfunctions2_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudfunctions2Function : TerraformResource
{
    public GoogleCloudfunctions2Function(string name) : base("google_cloudfunctions2_function", name)
    {
    }

    /// <summary>
    /// User-provided description of a function.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// A set of key/value label pairs associated with this Cloud Function.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of this cloud function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// A user-defined name of the function. Function names must
    /// be unique globally and match pattern &#39;projects/*/locations/*/functions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for build_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    [TerraformProperty("build_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctions2FunctionBuildConfigBlock>>? BuildConfig { get; set; }

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    [TerraformProperty("event_trigger")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctions2FunctionEventTriggerBlock>>? EventTrigger { get; set; }

    /// <summary>
    /// Block for service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConfig block(s) allowed")]
    [TerraformProperty("service_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudfunctions2FunctionServiceConfigBlock>>? ServiceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleCloudfunctions2FunctionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The environment the function is hosted on.
    /// </summary>
    [TerraformProperty("environment")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Environment { get; }

    /// <summary>
    /// Describes the current state of the function.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// The last update timestamp of a Cloud Function.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Output only. The deployed url for the function.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
