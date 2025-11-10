using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for api_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionApiConfigBlock : TerraformBlock
{
    /// <summary>
    /// Action to take when users access resources that require authentication. Default value: &amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot; Possible values: [&amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot;, &amp;quot;AUTH_FAIL_ACTION_UNAUTHORIZED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AuthFailAction
    {
        set => SetProperty("auth_fail_action", value);
    }

    /// <summary>
    /// Level of login required to access this resource. Default value: &amp;quot;LOGIN_OPTIONAL&amp;quot; Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Login
    {
        set => SetProperty("login", value);
    }

    /// <summary>
    /// Path to the script from the application root directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Script is required")]
    public required TerraformProperty<string> Script
    {
        set => SetProperty("script", value);
    }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SecurityLevel
    {
        set => SetProperty("security_level", value);
    }

    /// <summary>
    /// URL to serve the endpoint at.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Block type for automatic_scaling in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock : TerraformBlock
{
    /// <summary>
    /// The time period that the Autoscaler should wait before it starts collecting information from a new instance.
    /// This prevents the autoscaler from collecting information when the instance is initializing,
    /// during which the collected usage would not be reliable. Default: 120s
    /// </summary>
    public TerraformProperty<string>? CoolDownPeriod
    {
        set => SetProperty("cool_down_period", value);
    }

    /// <summary>
    /// Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance.
    /// 
    /// Defaults to a runtime-specific value.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentRequests
    {
        set => SetProperty("max_concurrent_requests", value);
    }

    /// <summary>
    /// Maximum number of idle instances that should be maintained for this version.
    /// </summary>
    public TerraformProperty<double>? MaxIdleInstances
    {
        set => SetProperty("max_idle_instances", value);
    }

    /// <summary>
    /// Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it.
    /// </summary>
    public TerraformProperty<string>? MaxPendingLatency
    {
        set => SetProperty("max_pending_latency", value);
    }

    /// <summary>
    /// Maximum number of instances that should be started to handle requests for this version. Default: 20
    /// </summary>
    public TerraformProperty<double>? MaxTotalInstances
    {
        set => SetProperty("max_total_instances", value);
    }

    /// <summary>
    /// Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.
    /// </summary>
    public TerraformProperty<double>? MinIdleInstances
    {
        set => SetProperty("min_idle_instances", value);
    }

    /// <summary>
    /// Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it.
    /// </summary>
    public TerraformProperty<string>? MinPendingLatency
    {
        set => SetProperty("min_pending_latency", value);
    }

    /// <summary>
    /// Minimum number of running instances that should be maintained for this version. Default: 2
    /// </summary>
    public TerraformProperty<double>? MinTotalInstances
    {
        set => SetProperty("min_total_instances", value);
    }

}

/// <summary>
/// Block type for deployment in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionDeploymentBlock : TerraformBlock
{
}

/// <summary>
/// Block type for endpoints_api_service in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionEndpointsApiServiceBlock : TerraformBlock
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
    public TerraformProperty<string>? ConfigId
    {
        set => SetProperty("config_id", value);
    }

    /// <summary>
    /// Enable or disable trace sampling. By default, this is set to false for enabled.
    /// </summary>
    public TerraformProperty<bool>? DisableTraceSampling
    {
        set => SetProperty("disable_trace_sampling", value);
    }

    /// <summary>
    /// Endpoints service name which is the name of the &amp;quot;service&amp;quot; resource in the Service Management API.
    /// For example &amp;quot;myapi.endpoints.myproject.cloud.goog&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Endpoints rollout strategy. If FIXED, configId must be specified. If MANAGED, configId must be omitted. Default value: &amp;quot;FIXED&amp;quot; Possible values: [&amp;quot;FIXED&amp;quot;, &amp;quot;MANAGED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RolloutStrategy
    {
        set => SetProperty("rollout_strategy", value);
    }

}

/// <summary>
/// Block type for entrypoint in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionEntrypointBlock : TerraformBlock
{
    /// <summary>
    /// The format should be a shell command that can be fed to bash -c.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shell is required")]
    public required TerraformProperty<string> Shell
    {
        set => SetProperty("shell", value);
    }

}

/// <summary>
/// Block type for flexible_runtime_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionFlexibleRuntimeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Operating System of the application runtime.
    /// </summary>
    public TerraformProperty<string>? OperatingSystem
    {
        set => SetProperty("operating_system", value);
    }

    /// <summary>
    /// The runtime version of an App Engine flexible application.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        set => SetProperty("runtime_version", value);
    }

}

/// <summary>
/// Block type for handlers in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionHandlersBlock : TerraformBlock
{
    /// <summary>
    /// Actions to take when the user is not logged in. Possible values: [&amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot;, &amp;quot;AUTH_FAIL_ACTION_UNAUTHORIZED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AuthFailAction
    {
        set => SetProperty("auth_fail_action", value);
    }

    /// <summary>
    /// Methods to restrict access to a URL based on login status. Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Login
    {
        set => SetProperty("login", value);
    }

    /// <summary>
    /// 30x code to use when performing redirects for the secure field. Possible values: [&amp;quot;REDIRECT_HTTP_RESPONSE_CODE_301&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_302&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_303&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_307&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RedirectHttpResponseCode
    {
        set => SetProperty("redirect_http_response_code", value);
    }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SecurityLevel
    {
        set => SetProperty("security_level", value);
    }

    /// <summary>
    /// URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings.
    /// All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.
    /// </summary>
    public TerraformProperty<string>? UrlRegex
    {
        set => SetProperty("url_regex", value);
    }

}

/// <summary>
/// Block type for liveness_check in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionLivenessCheckBlock : TerraformBlock
{
    /// <summary>
    /// Interval between health checks.
    /// </summary>
    public TerraformProperty<string>? CheckInterval
    {
        set => SetProperty("check_interval", value);
    }

    /// <summary>
    /// Number of consecutive failed checks required before considering the VM unhealthy. Default: 4.
    /// </summary>
    public TerraformProperty<double>? FailureThreshold
    {
        set => SetProperty("failure_threshold", value);
    }

    /// <summary>
    /// Host header to send when performing a HTTP Readiness check. Example: &amp;quot;myapp.appspot.com&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The initial delay before starting to execute the checks. Default: &amp;quot;300s&amp;quot;
    /// </summary>
    public TerraformProperty<string>? InitialDelay
    {
        set => SetProperty("initial_delay", value);
    }

    /// <summary>
    /// The request path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// Number of consecutive successful checks required before considering the VM healthy. Default: 2.
    /// </summary>
    public TerraformProperty<double>? SuccessThreshold
    {
        set => SetProperty("success_threshold", value);
    }

    /// <summary>
    /// Time before the check is considered failed. Default: &amp;quot;4s&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        set => SetProperty("timeout", value);
    }

}

/// <summary>
/// Block type for manual_scaling in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionManualScalingBlock : TerraformBlock
{
    /// <summary>
    /// Number of instances to assign to the service at the start.
    /// 
    /// **Note:** When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2
    /// Modules API set_num_instances() you must use &#39;lifecycle.ignore_changes = [&amp;quot;manual_scaling&amp;quot;[0].instances]&#39; to prevent drift detection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instances is required")]
    public required TerraformProperty<double> Instances
    {
        set => SetProperty("instances", value);
    }

}

/// <summary>
/// Block type for network in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionNetworkBlock : TerraformBlock
{
    /// <summary>
    /// List of ports, or port pairs, to forward from the virtual machine to the application container.
    /// </summary>
    public List<TerraformProperty<string>>? ForwardedPorts
    {
        set => SetProperty("forwarded_ports", value);
    }

    /// <summary>
    /// Tag to apply to the instance during creation.
    /// </summary>
    public TerraformProperty<string>? InstanceTag
    {
        set => SetProperty("instance_tag", value);
    }

    /// <summary>
    /// Google Compute Engine network where the virtual machines are created. Specify the short name, not the resource path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Enable session affinity.
    /// </summary>
    public TerraformProperty<bool>? SessionAffinity
    {
        set => SetProperty("session_affinity", value);
    }

    /// <summary>
    /// Google Cloud Platform sub-network where the virtual machines are created. Specify the short name, not the resource path.
    /// 
    /// If the network that the instance is being created in is a Legacy network, then the IP address is allocated from the IPv4Range.
    /// If the network that the instance is being created in is an auto Subnet Mode Network, then only network name should be specified (not the subnetworkName) and the IP address is created from the IPCidrRange of the subnetwork that exists in that zone for that network.
    /// If the network that the instance is being created in is a custom Subnet Mode Network, then the subnetworkName must be specified and the IP address is created from the IPCidrRange of the subnetwork.
    /// If specified, the subnetwork must exist in the same region as the App Engine flexible environment application.
    /// </summary>
    public TerraformProperty<string>? Subnetwork
    {
        set => SetProperty("subnetwork", value);
    }

}

/// <summary>
/// Block type for readiness_check in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionReadinessCheckBlock : TerraformBlock
{
    /// <summary>
    /// A maximum time limit on application initialization, measured from moment the application successfully
    /// replies to a healthcheck until it is ready to serve traffic. Default: &amp;quot;300s&amp;quot;
    /// </summary>
    public TerraformProperty<string>? AppStartTimeout
    {
        set => SetProperty("app_start_timeout", value);
    }

    /// <summary>
    /// Interval between health checks.  Default: &amp;quot;5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? CheckInterval
    {
        set => SetProperty("check_interval", value);
    }

    /// <summary>
    /// Number of consecutive failed checks required before removing traffic. Default: 2.
    /// </summary>
    public TerraformProperty<double>? FailureThreshold
    {
        set => SetProperty("failure_threshold", value);
    }

    /// <summary>
    /// Host header to send when performing a HTTP Readiness check. Example: &amp;quot;myapp.appspot.com&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The request path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// Number of consecutive successful checks required before receiving traffic. Default: 2.
    /// </summary>
    public TerraformProperty<double>? SuccessThreshold
    {
        set => SetProperty("success_threshold", value);
    }

    /// <summary>
    /// Time before the check is considered failed. Default: &amp;quot;4s&amp;quot;
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        set => SetProperty("timeout", value);
    }

}

/// <summary>
/// Block type for resources in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Number of CPU cores needed.
    /// </summary>
    public TerraformProperty<double>? Cpu
    {
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// Disk size (GB) needed.
    /// </summary>
    public TerraformProperty<double>? DiskGb
    {
        set => SetProperty("disk_gb", value);
    }

    /// <summary>
    /// Memory (GB) needed.
    /// </summary>
    public TerraformProperty<double>? MemoryGb
    {
        set => SetProperty("memory_gb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineFlexibleAppVersionTimeoutsBlock : TerraformBlock
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
/// Block type for vpc_access_connector in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionVpcAccessConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Manages a google_app_engine_flexible_app_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineFlexibleAppVersion : TerraformResource
{
    public GoogleAppEngineFlexibleAppVersion(string name) : base("google_app_engine_flexible_app_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("beta_settings");
        SetOutput("default_expiration");
        SetOutput("delete_service_on_destroy");
        SetOutput("env_variables");
        SetOutput("id");
        SetOutput("inbound_services");
        SetOutput("instance_class");
        SetOutput("nobuild_files_regex");
        SetOutput("noop_on_destroy");
        SetOutput("project");
        SetOutput("runtime");
        SetOutput("runtime_api_version");
        SetOutput("runtime_channel");
        SetOutput("runtime_main_executable_path");
        SetOutput("service");
        SetOutput("service_account");
        SetOutput("serving_status");
        SetOutput("version_id");
    }

    /// <summary>
    /// Metadata settings that are supplied to this version to enable beta runtime features.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> BetaSettings
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("beta_settings");
        set => SetProperty("beta_settings", value);
    }

    /// <summary>
    /// Duration that static files should be cached by web proxies and browsers.
    /// Only applicable if the corresponding StaticFilesHandler does not specify its own expiration time.
    /// </summary>
    public TerraformProperty<string> DefaultExpiration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_expiration");
        set => SetProperty("default_expiration", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    public TerraformProperty<bool> DeleteServiceOnDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_service_on_destroy");
        set => SetProperty("delete_service_on_destroy", value);
    }

    /// <summary>
    /// Environment variables available to the application.  As these are not returned in the API request, Terraform will not detect any changes made outside of the Terraform config.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> EnvVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("env_variables");
        set => SetProperty("env_variables", value);
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
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    public HashSet<TerraformProperty<string>> InboundServices
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("inbound_services");
        set => SetProperty("inbound_services", value);
    }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// ManualScaling: B1, B2, B4, B8, B4_1G
    /// Defaults to F1 for AutomaticScaling and B1 for ManualScaling.
    /// </summary>
    public TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
    }

    /// <summary>
    /// Files that match this pattern will not be built into this version. Only applicable for Go runtimes.
    /// </summary>
    public TerraformProperty<string> NobuildFilesRegex
    {
        get => GetRequiredOutput<TerraformProperty<string>>("nobuild_files_regex");
        set => SetProperty("nobuild_files_regex", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    public TerraformProperty<bool> NoopOnDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("noop_on_destroy");
        set => SetProperty("noop_on_destroy", value);
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
    /// Desired runtime. Example python27.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformProperty<string> Runtime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime");
        set => SetProperty("runtime", value);
    }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    public TerraformProperty<string> RuntimeApiVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_api_version");
        set => SetProperty("runtime_api_version", value);
    }

    /// <summary>
    /// The channel of the runtime to use. Only available for some runtimes.
    /// </summary>
    public TerraformProperty<string> RuntimeChannel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_channel");
        set => SetProperty("runtime_channel", value);
    }

    /// <summary>
    /// The path or name of the app&#39;s main executable.
    /// </summary>
    public TerraformProperty<string> RuntimeMainExecutablePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_main_executable_path");
        set => SetProperty("runtime_main_executable_path", value);
    }

    /// <summary>
    /// AppEngine service resource. Can contain numbers, letters, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as
    /// default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account");
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Current serving status of this version. Only the versions with a SERVING status create instances and can be billed. Default value: &amp;quot;SERVING&amp;quot; Possible values: [&amp;quot;SERVING&amp;quot;, &amp;quot;STOPPED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ServingStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("serving_status");
        set => SetProperty("serving_status", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens.
    /// Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public TerraformProperty<string> VersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_id");
        set => SetProperty("version_id", value);
    }

    /// <summary>
    /// Block for api_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiConfig block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionApiConfigBlock>? ApiConfig
    {
        set => SetProperty("api_config", value);
    }

    /// <summary>
    /// Block for automatic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticScaling block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock>? AutomaticScaling
    {
        set => SetProperty("automatic_scaling", value);
    }

    /// <summary>
    /// Block for deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deployment block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionDeploymentBlock>? Deployment
    {
        set => SetProperty("deployment", value);
    }

    /// <summary>
    /// Block for endpoints_api_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointsApiService block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionEndpointsApiServiceBlock>? EndpointsApiService
    {
        set => SetProperty("endpoints_api_service", value);
    }

    /// <summary>
    /// Block for entrypoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Entrypoint block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionEntrypointBlock>? Entrypoint
    {
        set => SetProperty("entrypoint", value);
    }

    /// <summary>
    /// Block for flexible_runtime_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexibleRuntimeSettings block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionFlexibleRuntimeSettingsBlock>? FlexibleRuntimeSettings
    {
        set => SetProperty("flexible_runtime_settings", value);
    }

    /// <summary>
    /// Block for handlers.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAppEngineFlexibleAppVersionHandlersBlock>? Handlers
    {
        set => SetProperty("handlers", value);
    }

    /// <summary>
    /// Block for liveness_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LivenessCheck is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LivenessCheck block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessCheck block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionLivenessCheckBlock>? LivenessCheck
    {
        set => SetProperty("liveness_check", value);
    }

    /// <summary>
    /// Block for manual_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualScaling block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionManualScalingBlock>? ManualScaling
    {
        set => SetProperty("manual_scaling", value);
    }

    /// <summary>
    /// Block for network.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionNetworkBlock>? Network
    {
        set => SetProperty("network", value);
    }

    /// <summary>
    /// Block for readiness_check.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadinessCheck is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadinessCheck block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadinessCheck block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionReadinessCheckBlock>? ReadinessCheck
    {
        set => SetProperty("readiness_check", value);
    }

    /// <summary>
    /// Block for resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionResourcesBlock>? Resources
    {
        set => SetProperty("resources", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineFlexibleAppVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_access_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessConnector block(s) allowed")]
    public List<GoogleAppEngineFlexibleAppVersionVpcAccessConnectorBlock>? VpcAccessConnector
    {
        set => SetProperty("vpc_access_connector", value);
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
