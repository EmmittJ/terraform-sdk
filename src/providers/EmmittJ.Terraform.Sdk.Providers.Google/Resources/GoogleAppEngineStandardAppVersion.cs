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
        get => GetProperty<TerraformProperty<double>>("max_concurrent_requests");
        set => WithProperty("max_concurrent_requests", value);
    }

    /// <summary>
    /// Maximum number of idle instances that should be maintained for this version.
    /// </summary>
    public TerraformProperty<double>? MaxIdleInstances
    {
        get => GetProperty<TerraformProperty<double>>("max_idle_instances");
        set => WithProperty("max_idle_instances", value);
    }

    /// <summary>
    /// Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MaxPendingLatency
    {
        get => GetProperty<TerraformProperty<string>>("max_pending_latency");
        set => WithProperty("max_pending_latency", value);
    }

    /// <summary>
    /// Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.
    /// </summary>
    public TerraformProperty<double>? MinIdleInstances
    {
        get => GetProperty<TerraformProperty<double>>("min_idle_instances");
        set => WithProperty("min_idle_instances", value);
    }

    /// <summary>
    /// Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? MinPendingLatency
    {
        get => GetProperty<TerraformProperty<string>>("min_pending_latency");
        set => WithProperty("min_pending_latency", value);
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
        get => GetProperty<TerraformProperty<string>>("idle_timeout");
        set => WithProperty("idle_timeout", value);
    }

    /// <summary>
    /// Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    public required TerraformProperty<double> MaxInstances
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_instances");
        set => WithProperty("max_instances", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("shell");
        set => WithProperty("shell", value);
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
        get => GetProperty<TerraformProperty<string>>("auth_fail_action");
        set => WithProperty("auth_fail_action", value);
    }

    /// <summary>
    /// Methods to restrict access to a URL based on login status. Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Login
    {
        get => GetProperty<TerraformProperty<string>>("login");
        set => WithProperty("login", value);
    }

    /// <summary>
    /// 30x code to use when performing redirects for the secure field. Possible values: [&amp;quot;REDIRECT_HTTP_RESPONSE_CODE_301&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_302&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_303&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_307&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? RedirectHttpResponseCode
    {
        get => GetProperty<TerraformProperty<string>>("redirect_http_response_code");
        set => WithProperty("redirect_http_response_code", value);
    }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SecurityLevel
    {
        get => GetProperty<TerraformProperty<string>>("security_level");
        set => WithProperty("security_level", value);
    }

    /// <summary>
    /// URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings.
    /// All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.
    /// </summary>
    public TerraformProperty<string>? UrlRegex
    {
        get => GetProperty<TerraformProperty<string>>("url_regex");
        set => WithProperty("url_regex", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Version of the library to select, or &amp;quot;latest&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("instances");
        set => WithProperty("instances", value);
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
        get => GetProperty<TerraformProperty<string>>("egress_setting");
        set => WithProperty("egress_setting", value);
    }

    /// <summary>
    /// Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        this.WithOutput("name");
    }

    /// <summary>
    /// Allows App Engine second generation runtimes to access the legacy bundled services.
    /// </summary>
    public TerraformProperty<bool>? AppEngineApis
    {
        get => GetProperty<TerraformProperty<bool>>("app_engine_apis");
        set => this.WithProperty("app_engine_apis", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    public TerraformProperty<bool>? DeleteServiceOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("delete_service_on_destroy");
        set => this.WithProperty("delete_service_on_destroy", value);
    }

    /// <summary>
    /// Environment variables available to the application.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("env_variables");
        set => this.WithProperty("env_variables", value);
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
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    public HashSet<TerraformProperty<string>>? InboundServices
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("inbound_services");
        set => this.WithProperty("inbound_services", value);
    }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8
    /// Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.
    /// </summary>
    public TerraformProperty<string>? InstanceClass
    {
        get => GetProperty<TerraformProperty<string>>("instance_class");
        set => this.WithProperty("instance_class", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    public TerraformProperty<bool>? NoopOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("noop_on_destroy");
        set => this.WithProperty("noop_on_destroy", value);
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
    /// Desired runtime. Example python27.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformProperty<string> Runtime
    {
        get => GetRequiredProperty<TerraformProperty<string>>("runtime");
        set => this.WithProperty("runtime", value);
    }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    public TerraformProperty<string>? RuntimeApiVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_api_version");
        set => this.WithProperty("runtime_api_version", value);
    }

    /// <summary>
    /// AppEngine service resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Whether multiple requests can be dispatched to this version at once.
    /// </summary>
    public TerraformProperty<bool>? Threadsafe
    {
        get => GetProperty<TerraformProperty<bool>>("threadsafe");
        set => this.WithProperty("threadsafe", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
    }

    /// <summary>
    /// Block for automatic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticScaling block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionAutomaticScalingBlock>? AutomaticScaling
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionAutomaticScalingBlock>>("automatic_scaling");
        set => this.WithProperty("automatic_scaling", value);
    }

    /// <summary>
    /// Block for basic_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicScaling block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionBasicScalingBlock>? BasicScaling
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionBasicScalingBlock>>("basic_scaling");
        set => this.WithProperty("basic_scaling", value);
    }

    /// <summary>
    /// Block for deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Deployment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deployment block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionDeploymentBlock>? Deployment
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionDeploymentBlock>>("deployment");
        set => this.WithProperty("deployment", value);
    }

    /// <summary>
    /// Block for entrypoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entrypoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Entrypoint block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionEntrypointBlock>? Entrypoint
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionEntrypointBlock>>("entrypoint");
        set => this.WithProperty("entrypoint", value);
    }

    /// <summary>
    /// Block for handlers.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAppEngineStandardAppVersionHandlersBlock>? Handlers
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionHandlersBlock>>("handlers");
        set => this.WithProperty("handlers", value);
    }

    /// <summary>
    /// Block for libraries.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAppEngineStandardAppVersionLibrariesBlock>? Libraries
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionLibrariesBlock>>("libraries");
        set => this.WithProperty("libraries", value);
    }

    /// <summary>
    /// Block for manual_scaling.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualScaling block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionManualScalingBlock>? ManualScaling
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionManualScalingBlock>>("manual_scaling");
        set => this.WithProperty("manual_scaling", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineStandardAppVersionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAppEngineStandardAppVersionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_access_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessConnector block(s) allowed")]
    public List<GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock>? VpcAccessConnector
    {
        get => GetProperty<List<GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock>>("vpc_access_connector");
        set => this.WithProperty("vpc_access_connector", value);
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
