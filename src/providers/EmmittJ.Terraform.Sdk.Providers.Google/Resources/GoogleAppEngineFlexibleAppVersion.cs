using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for api_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionApiConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Action to take when users access resources that require authentication. Default value: &amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot; Possible values: [&amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot;, &amp;quot;AUTH_FAIL_ACTION_UNAUTHORIZED&amp;quot;]
    /// </summary>
    [TerraformProperty("auth_fail_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthFailAction { get; set; }

    /// <summary>
    /// Level of login required to access this resource. Default value: &amp;quot;LOGIN_OPTIONAL&amp;quot; Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    [TerraformProperty("login")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Login { get; set; }

    /// <summary>
    /// Path to the script from the application root directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Script is required")]
    [TerraformProperty("script")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Script { get; set; }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    [TerraformProperty("security_level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecurityLevel { get; set; }

    /// <summary>
    /// URL to serve the endpoint at.
    /// </summary>
    [TerraformProperty("url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Url { get; set; }

}

/// <summary>
/// Block type for automatic_scaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock : TerraformBlockBase
{
    /// <summary>
    /// The time period that the Autoscaler should wait before it starts collecting information from a new instance.
    /// This prevents the autoscaler from collecting information when the instance is initializing,
    /// during which the collected usage would not be reliable. Default: 120s
    /// </summary>
    [TerraformProperty("cool_down_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CoolDownPeriod { get; set; }

    /// <summary>
    /// Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance.
    /// 
    /// Defaults to a runtime-specific value.
    /// </summary>
    [TerraformProperty("max_concurrent_requests")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaxConcurrentRequests { get; set; }

    /// <summary>
    /// Maximum number of idle instances that should be maintained for this version.
    /// </summary>
    [TerraformProperty("max_idle_instances")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxIdleInstances { get; set; }

    /// <summary>
    /// Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it.
    /// </summary>
    [TerraformProperty("max_pending_latency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MaxPendingLatency { get; set; }

    /// <summary>
    /// Maximum number of instances that should be started to handle requests for this version. Default: 20
    /// </summary>
    [TerraformProperty("max_total_instances")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxTotalInstances { get; set; }

    /// <summary>
    /// Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.
    /// </summary>
    [TerraformProperty("min_idle_instances")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinIdleInstances { get; set; }

    /// <summary>
    /// Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it.
    /// </summary>
    [TerraformProperty("min_pending_latency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinPendingLatency { get; set; }

    /// <summary>
    /// Minimum number of running instances that should be maintained for this version. Default: 2
    /// </summary>
    [TerraformProperty("min_total_instances")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinTotalInstances { get; set; }

}

/// <summary>
/// Block type for deployment in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionDeploymentBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for endpoints_api_service in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionEndpointsApiServiceBlock : TerraformBlockBase
{
    /// <summary>
    /// Endpoints service configuration ID as specified by the Service Management API. For example &amp;quot;2016-09-19r1&amp;quot;.
    /// 
    /// By default, the rollout strategy for Endpoints is &amp;quot;FIXED&amp;quot;. This means that Endpoints starts up with a particular configuration ID.
    /// When a new configuration is rolled out, Endpoints must be given the new configuration ID. The configId field is used to give the configuration ID
    /// and is required in this case.
    /// 
    /// Endpoints also has a rollout strategy called &amp;quot;MANAGED&amp;quot;. When using this, Endpoints fetches the latest configuration and does not need
    /// the configuration ID. In this case, configId must be omitted.
    /// </summary>
    [TerraformProperty("config_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConfigId { get; set; }

    /// <summary>
    /// Enable or disable trace sampling. By default, this is set to false for enabled.
    /// </summary>
    [TerraformProperty("disable_trace_sampling")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableTraceSampling { get; set; }

    /// <summary>
    /// Endpoints service name which is the name of the &amp;quot;service&amp;quot; resource in the Service Management API.
    /// For example &amp;quot;myapi.endpoints.myproject.cloud.goog&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Endpoints rollout strategy. If FIXED, configId must be specified. If MANAGED, configId must be omitted. Default value: &amp;quot;FIXED&amp;quot; Possible values: [&amp;quot;FIXED&amp;quot;, &amp;quot;MANAGED&amp;quot;]
    /// </summary>
    [TerraformProperty("rollout_strategy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RolloutStrategy { get; set; }

}

/// <summary>
/// Block type for entrypoint in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionEntrypointBlock : TerraformBlockBase
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
/// Block type for flexible_runtime_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionFlexibleRuntimeSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Operating System of the application runtime.
    /// </summary>
    [TerraformProperty("operating_system")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OperatingSystem { get; set; }

    /// <summary>
    /// The runtime version of an App Engine flexible application.
    /// </summary>
    [TerraformProperty("runtime_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RuntimeVersion { get; set; }

}

/// <summary>
/// Block type for handlers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionHandlersBlock : TerraformBlockBase
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
/// Block type for liveness_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionLivenessCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// Interval between health checks.
    /// </summary>
    [TerraformProperty("check_interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CheckInterval { get; set; }

    /// <summary>
    /// Number of consecutive failed checks required before considering the VM unhealthy. Default: 4.
    /// </summary>
    [TerraformProperty("failure_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FailureThreshold { get; set; }

    /// <summary>
    /// Host header to send when performing a HTTP Readiness check. Example: &amp;quot;myapp.appspot.com&amp;quot;
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Host { get; set; }

    /// <summary>
    /// The initial delay before starting to execute the checks. Default: &amp;quot;300s&amp;quot;
    /// </summary>
    [TerraformProperty("initial_delay")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InitialDelay { get; set; }

    /// <summary>
    /// The request path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// Number of consecutive successful checks required before considering the VM healthy. Default: 2.
    /// </summary>
    [TerraformProperty("success_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SuccessThreshold { get; set; }

    /// <summary>
    /// Time before the check is considered failed. Default: &amp;quot;4s&amp;quot;
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for manual_scaling in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionManualScalingBlock : TerraformBlockBase
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
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionNetworkBlock : TerraformBlockBase
{
    /// <summary>
    /// List of ports, or port pairs, to forward from the virtual machine to the application container.
    /// </summary>
    [TerraformProperty("forwarded_ports")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ForwardedPorts { get; set; }

    /// <summary>
    /// Tag to apply to the instance during creation.
    /// </summary>
    [TerraformProperty("instance_tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceTag { get; set; }

    /// <summary>
    /// Google Compute Engine network where the virtual machines are created. Specify the short name, not the resource path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Enable session affinity.
    /// </summary>
    [TerraformProperty("session_affinity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SessionAffinity { get; set; }

    /// <summary>
    /// Google Cloud Platform sub-network where the virtual machines are created. Specify the short name, not the resource path.
    /// 
    /// If the network that the instance is being created in is a Legacy network, then the IP address is allocated from the IPv4Range.
    /// If the network that the instance is being created in is an auto Subnet Mode Network, then only network name should be specified (not the subnetworkName) and the IP address is created from the IPCidrRange of the subnetwork that exists in that zone for that network.
    /// If the network that the instance is being created in is a custom Subnet Mode Network, then the subnetworkName must be specified and the IP address is created from the IPCidrRange of the subnetwork.
    /// If specified, the subnetwork must exist in the same region as the App Engine flexible environment application.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Subnetwork { get; set; }

}

/// <summary>
/// Block type for readiness_check in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionReadinessCheckBlock : TerraformBlockBase
{
    /// <summary>
    /// A maximum time limit on application initialization, measured from moment the application successfully
    /// replies to a healthcheck until it is ready to serve traffic. Default: &amp;quot;300s&amp;quot;
    /// </summary>
    [TerraformProperty("app_start_timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppStartTimeout { get; set; }

    /// <summary>
    /// Interval between health checks.  Default: &amp;quot;5s&amp;quot;.
    /// </summary>
    [TerraformProperty("check_interval")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CheckInterval { get; set; }

    /// <summary>
    /// Number of consecutive failed checks required before removing traffic. Default: 2.
    /// </summary>
    [TerraformProperty("failure_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FailureThreshold { get; set; }

    /// <summary>
    /// Host header to send when performing a HTTP Readiness check. Example: &amp;quot;myapp.appspot.com&amp;quot;
    /// </summary>
    [TerraformProperty("host")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Host { get; set; }

    /// <summary>
    /// The request path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Path { get; set; }

    /// <summary>
    /// Number of consecutive successful checks required before receiving traffic. Default: 2.
    /// </summary>
    [TerraformProperty("success_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SuccessThreshold { get; set; }

    /// <summary>
    /// Time before the check is considered failed. Default: &amp;quot;4s&amp;quot;
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Timeout { get; set; }

}

/// <summary>
/// Block type for resources in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionResourcesBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of CPU cores needed.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Cpu { get; set; }

    /// <summary>
    /// Disk size (GB) needed.
    /// </summary>
    [TerraformProperty("disk_gb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DiskGb { get; set; }

    /// <summary>
    /// Memory (GB) needed.
    /// </summary>
    [TerraformProperty("memory_gb")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MemoryGb { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersionTimeoutsBlock : TerraformBlockBase
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
public partial class GoogleAppEngineFlexibleAppVersionVpcAccessConnectorBlock : TerraformBlockBase
{
    /// <summary>
    /// Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a google_app_engine_flexible_app_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAppEngineFlexibleAppVersion : TerraformResource
{
    public GoogleAppEngineFlexibleAppVersion(string name) : base("google_app_engine_flexible_app_version", name)
    {
    }

    /// <summary>
    /// Metadata settings that are supplied to this version to enable beta runtime features.
    /// </summary>
    [TerraformProperty("beta_settings")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? BetaSettings { get; set; }

    /// <summary>
    /// Duration that static files should be cached by web proxies and browsers.
    /// Only applicable if the corresponding StaticFilesHandler does not specify its own expiration time.
    /// </summary>
    [TerraformProperty("default_expiration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultExpiration { get; set; }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    [TerraformProperty("delete_service_on_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeleteServiceOnDestroy { get; set; }

    /// <summary>
    /// Environment variables available to the application.  As these are not returned in the API request, Terraform will not detect any changes made outside of the Terraform config.
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
    /// ManualScaling: B1, B2, B4, B8, B4_1G
    /// Defaults to F1 for AutomaticScaling and B1 for ManualScaling.
    /// </summary>
    [TerraformProperty("instance_class")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstanceClass { get; set; }

    /// <summary>
    /// Files that match this pattern will not be built into this version. Only applicable for Go runtimes.
    /// </summary>
    [TerraformProperty("nobuild_files_regex")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NobuildFilesRegex { get; set; }

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
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RuntimeApiVersion { get; set; }

    /// <summary>
    /// The channel of the runtime to use. Only available for some runtimes.
    /// </summary>
    [TerraformProperty("runtime_channel")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RuntimeChannel { get; set; }

    /// <summary>
    /// The path or name of the app&#39;s main executable.
    /// </summary>
    [TerraformProperty("runtime_main_executable_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RuntimeMainExecutablePath { get; set; }

    /// <summary>
    /// AppEngine service resource. Can contain numbers, letters, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as
    /// default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// Current serving status of this version. Only the versions with a SERVING status create instances and can be billed. Default value: &amp;quot;SERVING&amp;quot; Possible values: [&amp;quot;SERVING&amp;quot;, &amp;quot;STOPPED&amp;quot;]
    /// </summary>
    [TerraformProperty("serving_status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServingStatus { get; set; }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens.
    /// Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VersionId { get; set; }

    /// <summary>
    /// Block for api_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiConfig block(s) allowed")]
    [TerraformProperty("api_config")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionApiConfigBlock>>? ApiConfig { get; set; }

    /// <summary>
    /// Block for automatic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticScaling block(s) allowed")]
    [TerraformProperty("automatic_scaling")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock>>? AutomaticScaling { get; set; }

    /// <summary>
    /// Block for deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deployment block(s) allowed")]
    [TerraformProperty("deployment")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionDeploymentBlock>>? Deployment { get; set; }

    /// <summary>
    /// Block for endpoints_api_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointsApiService block(s) allowed")]
    [TerraformProperty("endpoints_api_service")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionEndpointsApiServiceBlock>>? EndpointsApiService { get; set; }

    /// <summary>
    /// Block for entrypoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Entrypoint block(s) allowed")]
    [TerraformProperty("entrypoint")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionEntrypointBlock>>? Entrypoint { get; set; }

    /// <summary>
    /// Block for flexible_runtime_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexibleRuntimeSettings block(s) allowed")]
    [TerraformProperty("flexible_runtime_settings")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionFlexibleRuntimeSettingsBlock>>? FlexibleRuntimeSettings { get; set; }

    /// <summary>
    /// Block for handlers.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("handlers")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionHandlersBlock>>? Handlers { get; set; }

    /// <summary>
    /// Block for liveness_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LivenessCheck is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LivenessCheck block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessCheck block(s) allowed")]
    [TerraformProperty("liveness_check")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionLivenessCheckBlock>>? LivenessCheck { get; set; }

    /// <summary>
    /// Block for manual_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualScaling block(s) allowed")]
    [TerraformProperty("manual_scaling")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionManualScalingBlock>>? ManualScaling { get; set; }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    [TerraformProperty("network")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionNetworkBlock>>? Network { get; set; }

    /// <summary>
    /// Block for readiness_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadinessCheck is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadinessCheck block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadinessCheck block(s) allowed")]
    [TerraformProperty("readiness_check")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionReadinessCheckBlock>>? ReadinessCheck { get; set; }

    /// <summary>
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    [TerraformProperty("resources")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionResourcesBlock>>? Resources { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAppEngineFlexibleAppVersionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_access_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessConnector block(s) allowed")]
    [TerraformProperty("vpc_access_connector")]
    public TerraformList<TerraformBlock<GoogleAppEngineFlexibleAppVersionVpcAccessConnectorBlock>>? VpcAccessConnector { get; set; }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
