using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automatic_scaling in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionAutomaticScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_scaling";

    /// <summary>
    /// Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance.
    /// 
    /// Defaults to a runtime-specific value.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentRequests
    {
        get => new TerraformReference<double>(this, "max_concurrent_requests");
        set => SetArgument("max_concurrent_requests", value);
    }

    /// <summary>
    /// Maximum number of idle instances that should be maintained for this version.
    /// </summary>
    public TerraformValue<double>? MaxIdleInstances
    {
        get => new TerraformReference<double>(this, "max_idle_instances");
        set => SetArgument("max_idle_instances", value);
    }

    /// <summary>
    /// Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxPendingLatency
    {
        get => new TerraformReference<string>(this, "max_pending_latency");
        set => SetArgument("max_pending_latency", value);
    }

    /// <summary>
    /// Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.
    /// </summary>
    public TerraformValue<double>? MinIdleInstances
    {
        get => new TerraformReference<double>(this, "min_idle_instances");
        set => SetArgument("min_idle_instances", value);
    }

    /// <summary>
    /// Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MinPendingLatency
    {
        get => new TerraformReference<string>(this, "min_pending_latency");
        set => SetArgument("min_pending_latency", value);
    }

    /// <summary>
    /// StandardSchedulerSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardSchedulerSettings block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionAutomaticScalingBlockStandardSchedulerSettingsBlock>? StandardSchedulerSettings
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionAutomaticScalingBlockStandardSchedulerSettingsBlock>>("standard_scheduler_settings");
        set => SetArgument("standard_scheduler_settings", value);
    }

}

/// <summary>
/// Block type for standard_scheduler_settings in GoogleAppEngineStandardAppVersionAutomaticScalingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionAutomaticScalingBlockStandardSchedulerSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_scheduler_settings";

    /// <summary>
    /// Maximum number of instances to run for this version. Set to zero to disable maxInstances configuration.
    /// 
    /// **Note:** Starting from March 2025, App Engine sets the maxInstances default for standard environment deployments to 20. This change doesn&#39;t impact existing apps. To override the default, specify a new value between 0 and 2147483647, and deploy a new version or redeploy over an existing version. To disable the maxInstances default configuration setting, specify the maximum permitted value 2147483647.
    /// </summary>
    public TerraformValue<double> MaxInstances
    {
        get => new TerraformReference<double>(this, "max_instances");
        set => SetArgument("max_instances", value);
    }

    /// <summary>
    /// Minimum number of instances to run for this version. Set to zero to disable minInstances configuration.
    /// </summary>
    public TerraformValue<double>? MinInstances
    {
        get => new TerraformReference<double>(this, "min_instances");
        set => SetArgument("min_instances", value);
    }

    /// <summary>
    /// Target CPU utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.
    /// </summary>
    public TerraformValue<double>? TargetCpuUtilization
    {
        get => new TerraformReference<double>(this, "target_cpu_utilization");
        set => SetArgument("target_cpu_utilization", value);
    }

    /// <summary>
    /// Target throughput utilization ratio to maintain when scaling. Should be a value in the range [0.50, 0.95], zero, or a negative value.
    /// </summary>
    public TerraformValue<double>? TargetThroughputUtilization
    {
        get => new TerraformReference<double>(this, "target_throughput_utilization");
        set => SetArgument("target_throughput_utilization", value);
    }

}


/// <summary>
/// Block type for basic_scaling in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionBasicScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_scaling";

    /// <summary>
    /// Duration of time after the last request that an instance must wait before the instance is shut down.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Defaults to 900s.
    /// </summary>
    public TerraformValue<string>? IdleTimeout
    {
        get => new TerraformReference<string>(this, "idle_timeout");
        set => SetArgument("idle_timeout", value);
    }

    /// <summary>
    /// Maximum number of instances to create for this version. Must be in the range [1.0, 200.0].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxInstances is required")]
    public required TerraformValue<double> MaxInstances
    {
        get => new TerraformReference<double>(this, "max_instances");
        set => SetArgument("max_instances", value);
    }

}


/// <summary>
/// Block type for deployment in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionDeploymentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment";

    /// <summary>
    /// Files block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleAppEngineStandardAppVersionDeploymentBlockFilesBlock>? Files
    {
        get => GetArgument<TerraformSet<GoogleAppEngineStandardAppVersionDeploymentBlockFilesBlock>>("files");
        set => SetArgument("files", value);
    }

    /// <summary>
    /// Zip block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zip block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionDeploymentBlockZipBlock>? Zip
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionDeploymentBlockZipBlock>>("zip");
        set => SetArgument("zip", value);
    }

}

/// <summary>
/// Block type for files in GoogleAppEngineStandardAppVersionDeploymentBlock.
/// Nesting mode: set
/// </summary>
public class GoogleAppEngineStandardAppVersionDeploymentBlockFilesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "files";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// SHA1 checksum of the file
    /// </summary>
    public TerraformValue<string>? Sha1Sum
    {
        get => new TerraformReference<string>(this, "sha1_sum");
        set => SetArgument("sha1_sum", value);
    }

    /// <summary>
    /// Source URL
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUrl is required")]
    public required TerraformValue<string> SourceUrl
    {
        get => new TerraformReference<string>(this, "source_url");
        set => SetArgument("source_url", value);
    }

}

/// <summary>
/// Block type for zip in GoogleAppEngineStandardAppVersionDeploymentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionDeploymentBlockZipBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zip";

    /// <summary>
    /// files count
    /// </summary>
    public TerraformValue<double>? FilesCount
    {
        get => new TerraformReference<double>(this, "files_count");
        set => SetArgument("files_count", value);
    }

    /// <summary>
    /// Source URL
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUrl is required")]
    public required TerraformValue<string> SourceUrl
    {
        get => new TerraformReference<string>(this, "source_url");
        set => SetArgument("source_url", value);
    }

}


/// <summary>
/// Block type for entrypoint in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionEntrypointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entrypoint";

    /// <summary>
    /// The format should be a shell command that can be fed to bash -c.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shell is required")]
    public required TerraformValue<string> Shell
    {
        get => new TerraformReference<string>(this, "shell");
        set => SetArgument("shell", value);
    }

}


/// <summary>
/// Block type for handlers in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionHandlersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "handlers";

    /// <summary>
    /// Actions to take when the user is not logged in. Possible values: [&amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot;, &amp;quot;AUTH_FAIL_ACTION_UNAUTHORIZED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AuthFailAction
    {
        get => new TerraformReference<string>(this, "auth_fail_action");
        set => SetArgument("auth_fail_action", value);
    }

    /// <summary>
    /// Methods to restrict access to a URL based on login status. Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Login
    {
        get => new TerraformReference<string>(this, "login");
        set => SetArgument("login", value);
    }

    /// <summary>
    /// 30x code to use when performing redirects for the secure field. Possible values: [&amp;quot;REDIRECT_HTTP_RESPONSE_CODE_301&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_302&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_303&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_307&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectHttpResponseCode
    {
        get => new TerraformReference<string>(this, "redirect_http_response_code");
        set => SetArgument("redirect_http_response_code", value);
    }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SecurityLevel
    {
        get => new TerraformReference<string>(this, "security_level");
        set => SetArgument("security_level", value);
    }

    /// <summary>
    /// URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings.
    /// All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.
    /// </summary>
    public TerraformValue<string>? UrlRegex
    {
        get => new TerraformReference<string>(this, "url_regex");
        set => SetArgument("url_regex", value);
    }

    /// <summary>
    /// Script block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Script block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionHandlersBlockScriptBlock>? Script
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionHandlersBlockScriptBlock>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// StaticFiles block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticFiles block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionHandlersBlockStaticFilesBlock>? StaticFiles
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionHandlersBlockStaticFilesBlock>>("static_files");
        set => SetArgument("static_files", value);
    }

}

/// <summary>
/// Block type for script in GoogleAppEngineStandardAppVersionHandlersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionHandlersBlockScriptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "script";

    /// <summary>
    /// Path to the script from the application root directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScriptPath is required")]
    public required TerraformValue<string> ScriptPath
    {
        get => new TerraformReference<string>(this, "script_path");
        set => SetArgument("script_path", value);
    }

}

/// <summary>
/// Block type for static_files in GoogleAppEngineStandardAppVersionHandlersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionHandlersBlockStaticFilesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_files";

    /// <summary>
    /// Whether files should also be uploaded as code data. By default, files declared in static file handlers are uploaded as
    /// static data and are only served to end users; they cannot be read by the application. If enabled, uploads are charged
    /// against both your code and static data storage resource quotas.
    /// </summary>
    public TerraformValue<bool>? ApplicationReadable
    {
        get => new TerraformReference<bool>(this, "application_readable");
        set => SetArgument("application_readable", value);
    }

    /// <summary>
    /// Time a static file served by this handler should be cached by web proxies and browsers.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Expiration
    {
        get => new TerraformReference<string>(this, "expiration");
        set => SetArgument("expiration", value);
    }

    /// <summary>
    /// HTTP headers to use for all responses from these URLs.
    /// An object containing a list of &amp;quot;key:value&amp;quot; value pairs.&amp;quot;.
    /// </summary>
    public TerraformMap<string>? HttpHeaders
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "http_headers").ResolveNodes(ctx));
        set => SetArgument("http_headers", value);
    }

    /// <summary>
    /// MIME type used to serve all files served by this handler.
    /// Defaults to file-specific MIME types, which are derived from each file&#39;s filename extension.
    /// </summary>
    public TerraformValue<string>? MimeType
    {
        get => new TerraformReference<string>(this, "mime_type");
        set => SetArgument("mime_type", value);
    }

    /// <summary>
    /// Path to the static files matched by the URL pattern, from the application root directory. The path can refer to text matched in groupings in the URL pattern.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Whether this handler should match the request if the file referenced by the handler does not exist.
    /// </summary>
    public TerraformValue<bool>? RequireMatchingFile
    {
        get => new TerraformReference<bool>(this, "require_matching_file");
        set => SetArgument("require_matching_file", value);
    }

    /// <summary>
    /// Regular expression that matches the file paths for all files that should be referenced by this handler.
    /// </summary>
    public TerraformValue<string>? UploadPathRegex
    {
        get => new TerraformReference<string>(this, "upload_path_regex");
        set => SetArgument("upload_path_regex", value);
    }

}


/// <summary>
/// Block type for libraries in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionLibrariesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "libraries";

    /// <summary>
    /// Name of the library. Example &amp;quot;django&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Version of the library to select, or &amp;quot;latest&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for manual_scaling in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionManualScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual_scaling";

    /// <summary>
    /// Number of instances to assign to the service at the start.
    /// 
    /// **Note:** When managing the number of instances at runtime through the App Engine Admin API or the (now deprecated) Python 2
    /// Modules API set_num_instances() you must use &#39;lifecycle.ignore_changes = [&amp;quot;manual_scaling&amp;quot;[0].instances]&#39; to prevent drift detection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instances is required")]
    public required TerraformValue<double> Instances
    {
        get => new TerraformReference<double>(this, "instances");
        set => SetArgument("instances", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAppEngineStandardAppVersion.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineStandardAppVersionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_access_connector in GoogleAppEngineStandardAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_access_connector";

    /// <summary>
    /// The egress setting for the connector, controlling what traffic is diverted through it.
    /// </summary>
    public TerraformValue<string>? EgressSetting
    {
        get => new TerraformReference<string>(this, "egress_setting");
        set => SetArgument("egress_setting", value);
    }

    /// <summary>
    /// Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a google_app_engine_standard_app_version Terraform resource.
/// Manages a google_app_engine_standard_app_version resource.
/// </summary>
public partial class GoogleAppEngineStandardAppVersion(string name) : TerraformResource("google_app_engine_standard_app_version", name)
{
    /// <summary>
    /// Allows App Engine second generation runtimes to access the legacy bundled services.
    /// </summary>
    public TerraformValue<bool>? AppEngineApis
    {
        get => new TerraformReference<bool>(this, "app_engine_apis");
        set => SetArgument("app_engine_apis", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    public TerraformValue<bool>? DeleteServiceOnDestroy
    {
        get => new TerraformReference<bool>(this, "delete_service_on_destroy");
        set => SetArgument("delete_service_on_destroy", value);
    }

    /// <summary>
    /// Environment variables available to the application.
    /// </summary>
    public TerraformMap<string>? EnvVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "env_variables").ResolveNodes(ctx));
        set => SetArgument("env_variables", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    public TerraformSet<string>? InboundServices
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "inbound_services").ResolveNodes(ctx));
        set => SetArgument("inbound_services", value);
    }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// BasicScaling or ManualScaling: B1, B2, B4, B4_1G, B8
    /// Defaults to F1 for AutomaticScaling and B2 for ManualScaling and BasicScaling. If no scaling is specified, AutomaticScaling is chosen.
    /// </summary>
    public TerraformValue<string> InstanceClass
    {
        get => new TerraformReference<string>(this, "instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    public TerraformValue<bool>? NoopOnDestroy
    {
        get => new TerraformReference<bool>(this, "noop_on_destroy");
        set => SetArgument("noop_on_destroy", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Desired runtime. Example python27.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformValue<string> Runtime
    {
        get => new TerraformReference<string>(this, "runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    public TerraformValue<string>? RuntimeApiVersion
    {
        get => new TerraformReference<string>(this, "runtime_api_version");
        set => SetArgument("runtime_api_version", value);
    }

    /// <summary>
    /// AppEngine service resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformValue<string> ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Whether multiple requests can be dispatched to this version at once.
    /// </summary>
    public TerraformValue<bool>? Threadsafe
    {
        get => new TerraformReference<bool>(this, "threadsafe");
        set => SetArgument("threadsafe", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens. Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public TerraformValue<string>? VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// AutomaticScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticScaling block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionAutomaticScalingBlock>? AutomaticScaling
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionAutomaticScalingBlock>>("automatic_scaling");
        set => SetArgument("automatic_scaling", value);
    }

    /// <summary>
    /// BasicScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicScaling block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionBasicScalingBlock>? BasicScaling
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionBasicScalingBlock>>("basic_scaling");
        set => SetArgument("basic_scaling", value);
    }

    /// <summary>
    /// Deployment block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Deployment is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Deployment block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deployment block(s) allowed")]
    public required TerraformList<GoogleAppEngineStandardAppVersionDeploymentBlock> Deployment
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineStandardAppVersionDeploymentBlock>>("deployment");
        set => SetArgument("deployment", value);
    }

    /// <summary>
    /// Entrypoint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entrypoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entrypoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Entrypoint block(s) allowed")]
    public required TerraformList<GoogleAppEngineStandardAppVersionEntrypointBlock> Entrypoint
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineStandardAppVersionEntrypointBlock>>("entrypoint");
        set => SetArgument("entrypoint", value);
    }

    /// <summary>
    /// Handlers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAppEngineStandardAppVersionHandlersBlock>? Handlers
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionHandlersBlock>>("handlers");
        set => SetArgument("handlers", value);
    }

    /// <summary>
    /// Libraries block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAppEngineStandardAppVersionLibrariesBlock>? Libraries
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionLibrariesBlock>>("libraries");
        set => SetArgument("libraries", value);
    }

    /// <summary>
    /// ManualScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualScaling block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionManualScalingBlock>? ManualScaling
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionManualScalingBlock>>("manual_scaling");
        set => SetArgument("manual_scaling", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineStandardAppVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineStandardAppVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcAccessConnector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessConnector block(s) allowed")]
    public TerraformList<GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock>? VpcAccessConnector
    {
        get => GetArgument<TerraformList<GoogleAppEngineStandardAppVersionVpcAccessConnectorBlock>>("vpc_access_connector");
        set => SetArgument("vpc_access_connector", value);
    }

}
