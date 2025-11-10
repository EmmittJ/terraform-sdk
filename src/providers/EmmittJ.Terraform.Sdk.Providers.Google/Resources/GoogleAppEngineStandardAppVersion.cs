using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_scaling in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionAutomaticScalingBlock : TerraformBlock
{
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
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MaxPendingLatency
    {
        set => SetProperty("max_pending_latency", value);
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
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MinPendingLatency
    {
        set => SetProperty("min_pending_latency", value);
    }

}

/// <summary>
/// Block type for basic_scaling in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionBasicScalingBlock : TerraformBlock
{
    /// <summary>
    /// Duration of time after the last request that an instance must wait before the instance is shut down.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Defaults to 900s.
    /// </summary>
    public TerraformProperty<string>? IdleTimeout
    {
        set => SetProperty("idle_timeout", value);
    }

    /// <summary>
    /// Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    public required TerraformProperty<double> MaxInstances
    {
        set => SetProperty("max_instances", value);
    }

}

/// <summary>
/// Block type for deployment in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionDeploymentBlock : TerraformBlock
{
}

/// <summary>
/// Block type for entrypoint in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionEntrypointBlock : TerraformBlock
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
/// Block type for handlers in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionHandlersBlock : TerraformBlock
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
/// Block type for libraries in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionLibrariesBlock : TerraformBlock
{
    /// <summary>
    /// Name of the library. Example &amp;quot;django&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Version of the library to select, or &amp;quot;latest&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for manual_scaling in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionManualScalingBlock : TerraformBlock
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineStandardAppVersionTimeoutsBlock : TerraformBlock
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
public class GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock : TerraformBlock
{
    /// <summary>
    /// The egress setting for the connector, controlling what traffic is diverted through it.
    /// </summary>
    public TerraformProperty<string>? EgressSetting
    {
        set => SetProperty("egress_setting", value);
    }

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
/// Manages a google_app_engine_standard_app_version resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineStandardAppVersion : TerraformResource
{
    public GoogleAppEngineStandardAppVersion(string name) : base("google_app_engine_standard_app_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("app_engine_apis");
        SetOutput("delete_service_on_destroy");
        SetOutput("env_variables");
        SetOutput("id");
        SetOutput("inbound_services");
        SetOutput("instance_class");
        SetOutput("noop_on_destroy");
        SetOutput("project");
        SetOutput("runtime");
        SetOutput("runtime_api_version");
        SetOutput("service");
        SetOutput("service_account");
        SetOutput("threadsafe");
        SetOutput("version_id");
    }

    /// <summary>
    /// Allows App Engine second generation runtimes to access the legacy bundled services.
    /// </summary>
    public TerraformProperty<bool> AppEngineApis
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("app_engine_apis");
        set => SetProperty("app_engine_apis", value);
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
    /// Environment variables available to the application.
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
    /// BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8
    /// Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.
    /// </summary>
    public TerraformProperty<string> InstanceClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_class");
        set => SetProperty("instance_class", value);
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
    /// AppEngine service resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformProperty<string> ServiceAccount
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_account");
        set => SetProperty("service_account", value);
    }

    /// <summary>
    /// Whether multiple requests can be dispatched to this version at once.
    /// </summary>
    public TerraformProperty<bool> Threadsafe
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("threadsafe");
        set => SetProperty("threadsafe", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public TerraformProperty<string> VersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_id");
        set => SetProperty("version_id", value);
    }

    /// <summary>
    /// Block for automatic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticScaling block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionAutomaticScalingBlock>? AutomaticScaling
    {
        set => SetProperty("automatic_scaling", value);
    }

    /// <summary>
    /// Block for basic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicScaling block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionBasicScalingBlock>? BasicScaling
    {
        set => SetProperty("basic_scaling", value);
    }

    /// <summary>
    /// Block for deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Deployment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Deployment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deployment block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionDeploymentBlock>? Deployment
    {
        set => SetProperty("deployment", value);
    }

    /// <summary>
    /// Block for entrypoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entrypoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entrypoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Entrypoint block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionEntrypointBlock>? Entrypoint
    {
        set => SetProperty("entrypoint", value);
    }

    /// <summary>
    /// Block for handlers.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAppEngineStandardAppVersionHandlersBlock>? Handlers
    {
        set => SetProperty("handlers", value);
    }

    /// <summary>
    /// Block for libraries.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAppEngineStandardAppVersionLibrariesBlock>? Libraries
    {
        set => SetProperty("libraries", value);
    }

    /// <summary>
    /// Block for manual_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualScaling block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionManualScalingBlock>? ManualScaling
    {
        set => SetProperty("manual_scaling", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineStandardAppVersionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_access_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessConnector block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock>? VpcAccessConnector
    {
        set => SetProperty("vpc_access_connector", value);
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
