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
        get => GetProperty<TerraformProperty<string>>("build");
        set => WithProperty("build", value);
    }

    /// <summary>
    /// User managed repository created in Artifact Registry optionally with a customer managed encryption key.
    /// </summary>
    public TerraformProperty<string>? DockerRepository
    {
        get => GetProperty<TerraformProperty<string>>("docker_repository");
        set => WithProperty("docker_repository", value);
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
        get => GetProperty<TerraformProperty<string>>("entry_point");
        set => WithProperty("entry_point", value);
    }

    /// <summary>
    /// User-provided build-time environment variables for the function.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        get => GetProperty<TerraformProperty<string>>("runtime");
        set => WithProperty("runtime", value);
    }

    /// <summary>
    /// The fully-qualified name of the service account to be used for building the container.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => WithProperty("service_account", value);
    }

    /// <summary>
    /// Name of the Cloud Build Custom Worker Pool that should be used to build the function.
    /// </summary>
    public TerraformProperty<string>? WorkerPool
    {
        get => GetProperty<TerraformProperty<string>>("worker_pool");
        set => WithProperty("worker_pool", value);
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
        get => GetProperty<TerraformProperty<string>>("event_type");
        set => WithProperty("event_type", value);
    }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    public TerraformProperty<string>? PubsubTopic
    {
        get => GetProperty<TerraformProperty<string>>("pubsub_topic");
        set => WithProperty("pubsub_topic", value);
    }

    /// <summary>
    /// Describes the retry policy in case of function&#39;s execution failure.
    /// Retried execution is charged as any other execution. Possible values: [&amp;quot;RETRY_POLICY_UNSPECIFIED&amp;quot;, &amp;quot;RETRY_POLICY_DO_NOT_RETRY&amp;quot;, &amp;quot;RETRY_POLICY_RETRY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RetryPolicy
    {
        get => GetProperty<TerraformProperty<string>>("retry_policy");
        set => WithProperty("retry_policy", value);
    }

    /// <summary>
    /// Optional. The email of the trigger&#39;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("service_account_email");
        set => WithProperty("service_account_email", value);
    }

    /// <summary>
    /// Output only. The resource name of the Eventarc trigger.
    /// </summary>
    public TerraformProperty<string>? Trigger
    {
        get => GetProperty<TerraformProperty<string>>("trigger");
        set => WithProperty("trigger", value);
    }

    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    public TerraformProperty<string>? TriggerRegion
    {
        get => GetProperty<TerraformProperty<string>>("trigger_region");
        set => WithProperty("trigger_region", value);
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
        get => GetProperty<TerraformProperty<bool>>("all_traffic_on_latest_revision");
        set => WithProperty("all_traffic_on_latest_revision", value);
    }

    /// <summary>
    /// The number of CPUs used in a single container instance. Default value is calculated from available memory.
    /// </summary>
    public TerraformProperty<string>? AvailableCpu
    {
        get => GetProperty<TerraformProperty<string>>("available_cpu");
        set => WithProperty("available_cpu", value);
    }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    public TerraformProperty<string>? AvailableMemory
    {
        get => GetProperty<TerraformProperty<string>>("available_memory");
        set => WithProperty("available_memory", value);
    }

    /// <summary>
    /// The binary authorization policy to be checked when deploying the Cloud Run service.
    /// </summary>
    public TerraformProperty<string>? BinaryAuthorizationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("binary_authorization_policy");
        set => WithProperty("binary_authorization_policy", value);
    }

    /// <summary>
    /// Environment variables that shall be available during function execution.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => WithProperty("environment_variables", value);
    }

    /// <summary>
    /// URIs of the Service deployed
    /// </summary>
    public TerraformProperty<string>? GcfUri
    {
        get => GetProperty<TerraformProperty<string>>("gcf_uri");
        set => WithProperty("gcf_uri", value);
    }

    /// <summary>
    /// Available ingress settings. Defaults to &amp;quot;ALLOW_ALL&amp;quot; if unspecified. Default value: &amp;quot;ALLOW_ALL&amp;quot; Possible values: [&amp;quot;ALLOW_ALL&amp;quot;, &amp;quot;ALLOW_INTERNAL_ONLY&amp;quot;, &amp;quot;ALLOW_INTERNAL_AND_GCLB&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IngressSettings
    {
        get => GetProperty<TerraformProperty<string>>("ingress_settings");
        set => WithProperty("ingress_settings", value);
    }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("max_instance_count");
        set => WithProperty("max_instance_count", value);
    }

    /// <summary>
    /// Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.
    /// </summary>
    public TerraformProperty<double>? MaxInstanceRequestConcurrency
    {
        get => GetProperty<TerraformProperty<double>>("max_instance_request_concurrency");
        set => WithProperty("max_instance_request_concurrency", value);
    }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    public TerraformProperty<double>? MinInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("min_instance_count");
        set => WithProperty("min_instance_count", value);
    }

    /// <summary>
    /// Name of the service associated with a Function.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => WithProperty("service", value);
    }

    /// <summary>
    /// The email of the service account for this function.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("service_account_email");
        set => WithProperty("service_account_email", value);
    }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    public TerraformProperty<double>? TimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_seconds");
        set => WithProperty("timeout_seconds", value);
    }

    /// <summary>
    /// URI of the Service deployed.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

    /// <summary>
    /// The Serverless VPC Access connector that this cloud function can connect to.
    /// </summary>
    public TerraformProperty<string>? VpcConnector
    {
        get => GetProperty<TerraformProperty<string>>("vpc_connector");
        set => WithProperty("vpc_connector", value);
    }

    /// <summary>
    /// Available egress settings. Possible values: [&amp;quot;VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED&amp;quot;, &amp;quot;PRIVATE_RANGES_ONLY&amp;quot;, &amp;quot;ALL_TRAFFIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? VpcConnectorEgressSettings
    {
        get => GetProperty<TerraformProperty<string>>("vpc_connector_egress_settings");
        set => WithProperty("vpc_connector_egress_settings", value);
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
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("environment");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// User-provided description of a function.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// A set of key/value label pairs associated with this Cloud Function.
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
    /// The location of this cloud function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// A user-defined name of the function. Function names must
    /// be unique globally and match pattern &#39;projects/*/locations/*/functions/*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for build_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BuildConfig block(s) allowed")]
    public List<GoogleCloudfunctions2FunctionBuildConfigBlock>? BuildConfig
    {
        get => GetProperty<List<GoogleCloudfunctions2FunctionBuildConfigBlock>>("build_config");
        set => this.WithProperty("build_config", value);
    }

    /// <summary>
    /// Block for event_trigger.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventTrigger block(s) allowed")]
    public List<GoogleCloudfunctions2FunctionEventTriggerBlock>? EventTrigger
    {
        get => GetProperty<List<GoogleCloudfunctions2FunctionEventTriggerBlock>>("event_trigger");
        set => this.WithProperty("event_trigger", value);
    }

    /// <summary>
    /// Block for service_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceConfig block(s) allowed")]
    public List<GoogleCloudfunctions2FunctionServiceConfigBlock>? ServiceConfig
    {
        get => GetProperty<List<GoogleCloudfunctions2FunctionServiceConfigBlock>>("service_config");
        set => this.WithProperty("service_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudfunctions2FunctionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudfunctions2FunctionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
