using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_scaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionAutomaticScalingBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance.
    /// 
    /// Defaults to a runtime-specific value.
    /// </summary>
    [TerraformProperty("max_concurrent_requests")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxConcurrentRequests { get; set; }

    /// <summary>
    /// Maximum number of idle instances that should be maintained for this version.
    /// </summary>
    [TerraformProperty("max_idle_instances")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxIdleInstances { get; set; }

    /// <summary>
    /// Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("max_pending_latency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxPendingLatency { get; set; }

    /// <summary>
    /// Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.
    /// </summary>
    [TerraformProperty("min_idle_instances")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinIdleInstances { get; set; }

    /// <summary>
    /// Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("min_pending_latency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinPendingLatency { get; set; }

}

/// <summary>
/// Block type for basic_scaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionBasicScalingBlock : TerraformBlockBase
{
    /// <summary>
    /// Duration of time after the last request that an instance must wait before the instance is shut down.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Defaults to 900s.
    /// </summary>
    [TerraformProperty("idle_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IdleTimeout { get; set; }

    /// <summary>
    /// Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    [TerraformProperty("max_instances")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxInstances { get; set; }

}

/// <summary>
/// Block type for deployment in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionDeploymentBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for entrypoint in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionEntrypointBlock : TerraformBlockBase
{
    /// <summary>
    /// The format should be a shell command that can be fed to bash -c.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shell is required")]
    [TerraformProperty("shell")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Shell { get; set; }

}

/// <summary>
/// Block type for handlers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionHandlersBlock : TerraformBlockBase
{
    /// <summary>
    /// Actions to take when the user is not logged in. Possible values: [&amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot;, &amp;quot;AUTH_FAIL_ACTION_UNAUTHORIZED&amp;quot;]
    /// </summary>
    [TerraformProperty("auth_fail_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthFailAction { get; set; }

    /// <summary>
    /// Methods to restrict access to a URL based on login status. Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    [TerraformProperty("login")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Login { get; set; }

    /// <summary>
    /// 30x code to use when performing redirects for the secure field. Possible values: [&amp;quot;REDIRECT_HTTP_RESPONSE_CODE_301&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_302&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_303&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_307&amp;quot;]
    /// </summary>
    [TerraformProperty("redirect_http_response_code")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RedirectHttpResponseCode { get; set; }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    [TerraformProperty("security_level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecurityLevel { get; set; }

    /// <summary>
    /// URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings.
    /// All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.
    /// </summary>
    [TerraformProperty("url_regex")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UrlRegex { get; set; }

}

/// <summary>
/// Block type for libraries in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionLibrariesBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the library. Example &amp;quot;django&amp;quot;.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Version of the library to select, or &amp;quot;latest&amp;quot;.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for manual_scaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionManualScalingBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of instances to assign to the service at the start.
    /// 
    /// **Note:** When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2
    /// Modules API set_num_instances() you must use &#39;lifecycle.ignore_changes = [&amp;quot;manual_scaling&amp;quot;[0].instances]&#39; to prevent drift detection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instances is required")]
    [TerraformProperty("instances")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Instances { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineStandardAppVersionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_access_connector in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock : TerraformBlockBase
{
    /// <summary>
    /// The egress setting for the connector, controlling what traffic is diverted through it.
    /// </summary>
    [TerraformProperty("egress_setting")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EgressSetting { get; set; }

    /// <summary>
    /// Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a google_app_engine_standard_app_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAppEngineStandardAppVersion : TerraformResource
{
    public GoogleAppEngineStandardAppVersion(string name) : base("google_app_engine_standard_app_version", name)
    {
    }

    /// <summary>
    /// Allows App Engine second generation runtimes to access the legacy bundled services.
    /// </summary>
    [TerraformProperty("app_engine_apis")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AppEngineApis { get; set; }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    [TerraformProperty("delete_service_on_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteServiceOnDestroy { get; set; }

    /// <summary>
    /// Environment variables available to the application.
    /// </summary>
    [TerraformProperty("env_variables")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? EnvVariables { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    [TerraformProperty("inbound_services")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? InboundServices { get; set; }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8
    /// Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.
    /// </summary>
    [TerraformProperty("instance_class")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> InstanceClass { get; set; }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    [TerraformProperty("noop_on_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? NoopOnDestroy { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Desired runtime. Example python27.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    [TerraformProperty("runtime")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Runtime { get; set; }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    [TerraformProperty("runtime_api_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RuntimeApiVersion { get; set; }

    /// <summary>
    /// AppEngine service resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Whether multiple requests can be dispatched to this version at once.
    /// </summary>
    [TerraformProperty("threadsafe")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Threadsafe { get; set; }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionId { get; set; }

    /// <summary>
    /// Block for automatic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticScaling block(s) allowed")]
    [TerraformProperty("automatic_scaling")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionAutomaticScalingBlock>>? AutomaticScaling { get; set; }

    /// <summary>
    /// Block for basic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicScaling block(s) allowed")]
    [TerraformProperty("basic_scaling")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionBasicScalingBlock>>? BasicScaling { get; set; }

    /// <summary>
    /// Block for deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Deployment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Deployment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deployment block(s) allowed")]
    [TerraformProperty("deployment")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionDeploymentBlock>>? Deployment { get; set; }

    /// <summary>
    /// Block for entrypoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entrypoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entrypoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Entrypoint block(s) allowed")]
    [TerraformProperty("entrypoint")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionEntrypointBlock>>? Entrypoint { get; set; }

    /// <summary>
    /// Block for handlers.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("handlers")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionHandlersBlock>>? Handlers { get; set; }

    /// <summary>
    /// Block for libraries.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("libraries")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionLibrariesBlock>>? Libraries { get; set; }

    /// <summary>
    /// Block for manual_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualScaling block(s) allowed")]
    [TerraformProperty("manual_scaling")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionManualScalingBlock>>? ManualScaling { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAppEngineStandardAppVersionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_access_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessConnector block(s) allowed")]
    [TerraformProperty("vpc_access_connector")]
    public TerraformList<TerraformBlock<GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock>>? VpcAccessConnector { get; set; }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
