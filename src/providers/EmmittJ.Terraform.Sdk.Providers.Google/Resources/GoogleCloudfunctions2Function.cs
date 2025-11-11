using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for build_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlock
{

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key.
    /// </summary>
    [TerraformPropertyName("docker_repository")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DockerRepository { get; set; } = default!;

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &amp;quot;function&amp;quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    [TerraformPropertyName("entry_point")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EntryPoint { get; set; }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> EnvironmentVariables { get; set; } = default!;

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    [TerraformPropertyName("runtime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Runtime { get; set; }

    /// <summary>
    /// The fully-qualified name of the service account to be used for building the container.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccount { get; set; } = default!;

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    [TerraformPropertyName("worker_pool")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WorkerPool { get; set; }

}

/// <summary>
/// Block type for event_trigger in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionEventTriggerBlock
{
    /// <summary>
    /// Required. The type of event to observe.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    [TerraformPropertyName("event_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EventType { get; set; }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    [TerraformPropertyName("pubsub_topic")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PubsubTopic { get; set; } = default!;

    /// <summary>
    /// Describes the retry policy in case of function&#39;s execution failure.
    /// Retried execution is charged as any other execution. Possible values: [&amp;quot;RETRY_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RETRY_POLICY_DO_NOT_RETRY&amp;quot;, &amp;quot;RETRY_POLICY_RETRY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("retry_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RetryPolicy { get; set; }

    /// <summary>
    /// Optional. The email of the trigger&#39;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    [TerraformPropertyName("service_account_email")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccountEmail { get; set; } = default!;


    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    [TerraformPropertyName("trigger_region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TriggerRegion { get; set; } = default!;

}

/// <summary>
/// Block type for service_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionServiceConfigBlock
{
    /// <summary>
    /// Whether 100% of traffic is routed to the latest revision. Defaults to true.
    /// </summary>
    [TerraformPropertyName("all_traffic_on_latest_revision")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllTrafficOnLatestRevision { get; set; }

    /// <summary>
    /// The number of CPUs used in a single container instance. Default value is calculated from available memory.
    /// </summary>
    [TerraformPropertyName("available_cpu")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailableCpu { get; set; } = default!;

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    [TerraformPropertyName("available_memory")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailableMemory { get; set; } = default!;

    /// <summary>
    /// The binary authorization policy to be checked when deploying the Cloud Run service.
    /// </summary>
    [TerraformPropertyName("binary_authorization_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BinaryAuthorizationPolicy { get; set; }

    /// <summary>
    /// Environment variables that shall be available during function execution.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> EnvironmentVariables { get; set; } = default!;


    /// <summary>
    /// Available ingress settings. Defaults to &amp;quot;ALLOW_ALL&amp;quot; if unspecified. Default value: &amp;quot;ALLOW_ALL&amp;quot; Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;ALLOW_INTERNAL_ONLY&amp;quot;, &amp;quot;ALLOW_INTERNAL_AND_GCLB&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ingress_settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IngressSettings { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [TerraformPropertyName("max_instance_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxInstanceCount { get; set; } = default!;

    /// <summary>
    /// Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.
    /// </summary>
    [TerraformPropertyName("max_instance_request_concurrency")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxInstanceRequestConcurrency { get; set; } = default!;

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [TerraformPropertyName("min_instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinInstanceCount { get; set; }


    /// <summary>
    /// The email of the service account for this function.
    /// </summary>
    [TerraformPropertyName("service_account_email")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccountEmail { get; set; } = default!;

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    [TerraformPropertyName("timeout_seconds")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> TimeoutSeconds { get; set; } = default!;


    /// <summary>
    /// The Serverless VPC Access connector that this cloud function can connect to.
    /// </summary>
    [TerraformPropertyName("vpc_connector")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcConnector { get; set; }

    /// <summary>
    /// Available egress settings. Possible values: [&amp;quot;VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED&amp;quot;, &amp;quot;PRIVATE_RANGES_ONLY&amp;quot;, &amp;quot;ALL_TRAFFIC&amp;quot;]
    /// </summary>
    [TerraformPropertyName("vpc_connector_egress_settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VpcConnectorEgressSettings { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudfunctions2FunctionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloudfunctions2_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudfunctions2Function : TerraformResource
{
    public GoogleCloudfunctions2Function(string name) : base("google_cloudfunctions2_function", name)
    {
    }

    /// <summary>
    /// User-provided description of a function.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// A set of key/value label pairs associated with this Cloud Function.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of this cloud function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// A user-defined name of the function. Function names must
    /// be unique globally and match pattern &#39;projects/*/locations/*/functions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for build_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    [TerraformPropertyName("build_config")]
    public TerraformList<TerraformBlock<GoogleCloudfunctions2FunctionBuildConfigBlock>>? BuildConfig { get; set; }

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    [TerraformPropertyName("event_trigger")]
    public TerraformList<TerraformBlock<GoogleCloudfunctions2FunctionEventTriggerBlock>>? EventTrigger { get; set; }

    /// <summary>
    /// Block for service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConfig block(s) allowed")]
    [TerraformPropertyName("service_config")]
    public TerraformList<TerraformBlock<GoogleCloudfunctions2FunctionServiceConfigBlock>>? ServiceConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudfunctions2FunctionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The environment the function is hosted on.
    /// </summary>
    [TerraformPropertyName("environment")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Environment => new TerraformReference(this, "environment");

    /// <summary>
    /// Describes the current state of the function.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// The last update timestamp of a Cloud Function.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

    /// <summary>
    /// Output only. The deployed url for the function.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Url => new TerraformReference(this, "url");

}
