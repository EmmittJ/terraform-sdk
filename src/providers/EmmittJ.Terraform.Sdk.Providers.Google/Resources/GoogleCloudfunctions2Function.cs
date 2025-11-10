using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for build_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionBuildConfigBlock : TerraformBlock
{
    /// <summary>
    /// The Cloud Build name of the latest successful
    /// deployment of the function.
    /// </summary>
    public TerraformProperty<string>? Build
    {
        set => SetProperty("build", value);
    }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key.
    /// </summary>
    public TerraformProperty<string>? DockerRepository
    {
        set => SetProperty("docker_repository", value);
    }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &amp;quot;function&amp;quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    public TerraformProperty<string>? EntryPoint
    {
        set => SetProperty("entry_point", value);
    }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        set => SetProperty("runtime", value);
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for building the container.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformProperty<string>? WorkerPool
    {
        set => SetProperty("worker_pool", value);
    }

}

/// <summary>
/// Block type for event_trigger in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionEventTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Required. The type of event to observe.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventType is required")]
    public required TerraformProperty<string> EventType
    {
        set => SetProperty("event_type", value);
    }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    public TerraformProperty<string>? PubsubTopic
    {
        set => SetProperty("pubsub_topic", value);
    }

    /// <summary>
    /// Describes the retry policy in case of function&#39;s execution failure.
    /// Retried execution is charged as any other execution. Possible values: [&amp;quot;RETRY_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RETRY_POLICY_DO_NOT_RETRY&amp;quot;, &amp;quot;RETRY_POLICY_RETRY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RetryPolicy
    {
        set => SetProperty("retry_policy", value);
    }

    /// <summary>
    /// Optional. The email of the trigger&#39;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        set => SetProperty("service_account_email", value);
    }

    /// <summary>
    /// Output only. The resource name of the Eventarc trigger.
    /// </summary>
    public TerraformProperty<string>? Trigger
    {
        set => SetProperty("trigger", value);
    }

    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    public TerraformProperty<string>? TriggerRegion
    {
        set => SetProperty("trigger_region", value);
    }

}

/// <summary>
/// Block type for service_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudfunctions2FunctionServiceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether 100% of traffic is routed to the latest revision. Defaults to true.
    /// </summary>
    public TerraformProperty<bool>? AllTrafficOnLatestRevision
    {
        set => SetProperty("all_traffic_on_latest_revision", value);
    }

    /// <summary>
    /// The number of CPUs used in a single container instance. Default value is calculated from available memory.
    /// </summary>
    public TerraformProperty<string>? AvailableCpu
    {
        set => SetProperty("available_cpu", value);
    }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    public TerraformProperty<string>? AvailableMemory
    {
        set => SetProperty("available_memory", value);
    }

    /// <summary>
    /// The binary authorization policy to be checked when deploying the Cloud Run service.
    /// </summary>
    public TerraformProperty<string>? BinaryAuthorizationPolicy
    {
        set => SetProperty("binary_authorization_policy", value);
    }

    /// <summary>
    /// Environment variables that shall be available during function execution.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// URIs of the Service deployed
    /// </summary>
    public TerraformProperty<string>? GcfUri
    {
        set => SetProperty("gcf_uri", value);
    }

    /// <summary>
    /// Available ingress settings. Defaults to &amp;quot;ALLOW_ALL&amp;quot; if unspecified. Default value: &amp;quot;ALLOW_ALL&amp;quot; Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;ALLOW_INTERNAL_ONLY&amp;quot;, &amp;quot;ALLOW_INTERNAL_AND_GCLB&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IngressSettings
    {
        set => SetProperty("ingress_settings", value);
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceCount
    {
        set => SetProperty("max_instance_count", value);
    }

    /// <summary>
    /// Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceRequestConcurrency
    {
        set => SetProperty("max_instance_request_concurrency", value);
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    public TerraformProperty<double>? MinInstanceCount
    {
        set => SetProperty("min_instance_count", value);
    }

    /// <summary>
    /// Name of the service associated with a Function.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The email of the service account for this function.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        set => SetProperty("service_account_email", value);
    }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    public TerraformProperty<double>? TimeoutSeconds
    {
        set => SetProperty("timeout_seconds", value);
    }

    /// <summary>
    /// URI of the Service deployed.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        set => SetProperty("uri", value);
    }

    /// <summary>
    /// The Serverless VPC Access connector that this cloud function can connect to.
    /// </summary>
    public TerraformProperty<string>? VpcConnector
    {
        set => SetProperty("vpc_connector", value);
    }

    /// <summary>
    /// Available egress settings. Possible values: [&amp;quot;VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED&amp;quot;, &amp;quot;PRIVATE_RANGES_ONLY&amp;quot;, &amp;quot;ALL_TRAFFIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? VpcConnectorEgressSettings
    {
        set => SetProperty("vpc_connector_egress_settings", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudfunctions2FunctionTimeoutsBlock : TerraformBlock
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
/// Manages a google_cloudfunctions2_function resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudfunctions2Function : TerraformResource
{
    public GoogleCloudfunctions2Function(string name) : base("google_cloudfunctions2_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("environment");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("url");
        SetOutput("description");
        SetOutput("id");
        SetOutput("kms_key_name");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// User-provided description of a function.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs associated with this Cloud Function.
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
    /// The location of this cloud function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must
    /// be unique globally and match pattern &#39;projects/*/locations/*/functions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for build_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    public List<GoogleCloudfunctions2FunctionBuildConfigBlock>? BuildConfig
    {
        set => SetProperty("build_config", value);
    }

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    public List<GoogleCloudfunctions2FunctionEventTriggerBlock>? EventTrigger
    {
        set => SetProperty("event_trigger", value);
    }

    /// <summary>
    /// Block for service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConfig block(s) allowed")]
    public List<GoogleCloudfunctions2FunctionServiceConfigBlock>? ServiceConfig
    {
        set => SetProperty("service_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudfunctions2FunctionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The environment the function is hosted on.
    /// </summary>
    public TerraformExpression Environment => this["environment"];

    /// <summary>
    /// Describes the current state of the function.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The last update timestamp of a Cloud Function.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Output only. The deployed url for the function.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
