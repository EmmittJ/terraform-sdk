using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for api_config in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionApiConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_config";

    /// <summary>
    /// Action to take when users access resources that require authentication. Default value: &amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot; Possible values: [&amp;quot;AUTH_FAIL_ACTION_REDIRECT&amp;quot;, &amp;quot;AUTH_FAIL_ACTION_UNAUTHORIZED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? AuthFailAction
    {
        get => GetArgument<TerraformValue<string>>("auth_fail_action");
        set => SetArgument("auth_fail_action", value);
    }

    /// <summary>
    /// Level of login required to access this resource. Default value: &amp;quot;LOGIN_OPTIONAL&amp;quot; Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Login
    {
        get => GetArgument<TerraformValue<string>>("login");
        set => SetArgument("login", value);
    }

    /// <summary>
    /// Path to the script from the application root directory.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Script is required")]
    public required TerraformValue<string> Script
    {
        get => GetArgument<TerraformValue<string>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SecurityLevel
    {
        get => GetArgument<TerraformValue<string>>("security_level");
        set => SetArgument("security_level", value);
    }

    /// <summary>
    /// URL to serve the endpoint at.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for automatic_scaling in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "automatic_scaling";

    /// <summary>
    /// The time period that the Autoscaler should wait before it starts collecting information from a new instance.
    /// This prevents the autoscaler from collecting information when the instance is initializing,
    /// during which the collected usage would not be reliable. Default: 120s
    /// </summary>
    public TerraformValue<string>? CoolDownPeriod
    {
        get => GetArgument<TerraformValue<string>>("cool_down_period");
        set => SetArgument("cool_down_period", value);
    }

    /// <summary>
    /// Number of concurrent requests an automatic scaling instance can accept before the scheduler spawns a new instance.
    /// 
    /// Defaults to a runtime-specific value.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentRequests
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_requests");
        set => SetArgument("max_concurrent_requests", value);
    }

    /// <summary>
    /// Maximum number of idle instances that should be maintained for this version.
    /// </summary>
    public TerraformValue<double>? MaxIdleInstances
    {
        get => GetArgument<TerraformValue<double>>("max_idle_instances");
        set => SetArgument("max_idle_instances", value);
    }

    /// <summary>
    /// Maximum amount of time that a request should wait in the pending queue before starting a new instance to handle it.
    /// </summary>
    public TerraformValue<string>? MaxPendingLatency
    {
        get => GetArgument<TerraformValue<string>>("max_pending_latency");
        set => SetArgument("max_pending_latency", value);
    }

    /// <summary>
    /// Maximum number of instances that should be started to handle requests for this version. Default: 20
    /// </summary>
    public TerraformValue<double>? MaxTotalInstances
    {
        get => GetArgument<TerraformValue<double>>("max_total_instances");
        set => SetArgument("max_total_instances", value);
    }

    /// <summary>
    /// Minimum number of idle instances that should be maintained for this version. Only applicable for the default version of a service.
    /// </summary>
    public TerraformValue<double>? MinIdleInstances
    {
        get => GetArgument<TerraformValue<double>>("min_idle_instances");
        set => SetArgument("min_idle_instances", value);
    }

    /// <summary>
    /// Minimum amount of time a request should wait in the pending queue before starting a new instance to handle it.
    /// </summary>
    public TerraformValue<string>? MinPendingLatency
    {
        get => GetArgument<TerraformValue<string>>("min_pending_latency");
        set => SetArgument("min_pending_latency", value);
    }

    /// <summary>
    /// Minimum number of running instances that should be maintained for this version. Default: 2
    /// </summary>
    public TerraformValue<double>? MinTotalInstances
    {
        get => GetArgument<TerraformValue<double>>("min_total_instances");
        set => SetArgument("min_total_instances", value);
    }

    /// <summary>
    /// CpuUtilization block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CpuUtilization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CpuUtilization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CpuUtilization block(s) allowed")]
    public required TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockCpuUtilizationBlock> CpuUtilization
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockCpuUtilizationBlock>>("cpu_utilization");
        set => SetArgument("cpu_utilization", value);
    }

    /// <summary>
    /// DiskUtilization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiskUtilization block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockDiskUtilizationBlock>? DiskUtilization
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockDiskUtilizationBlock>>("disk_utilization");
        set => SetArgument("disk_utilization", value);
    }

    /// <summary>
    /// NetworkUtilization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkUtilization block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockNetworkUtilizationBlock>? NetworkUtilization
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockNetworkUtilizationBlock>>("network_utilization");
        set => SetArgument("network_utilization", value);
    }

    /// <summary>
    /// RequestUtilization block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestUtilization block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockRequestUtilizationBlock>? RequestUtilization
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockRequestUtilizationBlock>>("request_utilization");
        set => SetArgument("request_utilization", value);
    }

}

/// <summary>
/// Block type for cpu_utilization in GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockCpuUtilizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cpu_utilization";

    /// <summary>
    /// Period of time over which CPU utilization is calculated.
    /// </summary>
    public TerraformValue<string>? AggregationWindowLength
    {
        get => GetArgument<TerraformValue<string>>("aggregation_window_length");
        set => SetArgument("aggregation_window_length", value);
    }

    /// <summary>
    /// Target CPU utilization ratio to maintain when scaling. Must be between 0 and 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUtilization is required")]
    public required TerraformValue<double> TargetUtilization
    {
        get => GetArgument<TerraformValue<double>>("target_utilization");
        set => SetArgument("target_utilization", value);
    }

}

/// <summary>
/// Block type for disk_utilization in GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockDiskUtilizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disk_utilization";

    /// <summary>
    /// Target bytes read per second.
    /// </summary>
    public TerraformValue<double>? TargetReadBytesPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_read_bytes_per_second");
        set => SetArgument("target_read_bytes_per_second", value);
    }

    /// <summary>
    /// Target ops read per seconds.
    /// </summary>
    public TerraformValue<double>? TargetReadOpsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_read_ops_per_second");
        set => SetArgument("target_read_ops_per_second", value);
    }

    /// <summary>
    /// Target bytes written per second.
    /// </summary>
    public TerraformValue<double>? TargetWriteBytesPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_write_bytes_per_second");
        set => SetArgument("target_write_bytes_per_second", value);
    }

    /// <summary>
    /// Target ops written per second.
    /// </summary>
    public TerraformValue<double>? TargetWriteOpsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_write_ops_per_second");
        set => SetArgument("target_write_ops_per_second", value);
    }

}

/// <summary>
/// Block type for network_utilization in GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockNetworkUtilizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_utilization";

    /// <summary>
    /// Target bytes received per second.
    /// </summary>
    public TerraformValue<double>? TargetReceivedBytesPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_received_bytes_per_second");
        set => SetArgument("target_received_bytes_per_second", value);
    }

    /// <summary>
    /// Target packets received per second.
    /// </summary>
    public TerraformValue<double>? TargetReceivedPacketsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_received_packets_per_second");
        set => SetArgument("target_received_packets_per_second", value);
    }

    /// <summary>
    /// Target bytes sent per second.
    /// </summary>
    public TerraformValue<double>? TargetSentBytesPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_sent_bytes_per_second");
        set => SetArgument("target_sent_bytes_per_second", value);
    }

    /// <summary>
    /// Target packets sent per second.
    /// </summary>
    public TerraformValue<double>? TargetSentPacketsPerSecond
    {
        get => GetArgument<TerraformValue<double>>("target_sent_packets_per_second");
        set => SetArgument("target_sent_packets_per_second", value);
    }

}

/// <summary>
/// Block type for request_utilization in GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionAutomaticScalingBlockRequestUtilizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_utilization";

    /// <summary>
    /// Target number of concurrent requests.
    /// </summary>
    public TerraformValue<double>? TargetConcurrentRequests
    {
        get => GetArgument<TerraformValue<double>>("target_concurrent_requests");
        set => SetArgument("target_concurrent_requests", value);
    }

    /// <summary>
    /// Target requests per second.
    /// </summary>
    public TerraformValue<string>? TargetRequestCountPerSecond
    {
        get => GetArgument<TerraformValue<string>>("target_request_count_per_second");
        set => SetArgument("target_request_count_per_second", value);
    }

}


/// <summary>
/// Block type for deployment in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionDeploymentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment";

    /// <summary>
    /// CloudBuildOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudBuildOptions block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlockCloudBuildOptionsBlock>? CloudBuildOptions
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlockCloudBuildOptionsBlock>>("cloud_build_options");
        set => SetArgument("cloud_build_options", value);
    }

    /// <summary>
    /// Container block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Container block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlockContainerBlock>? Container
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlockContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// Files block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleAppEngineFlexibleAppVersionDeploymentBlockFilesBlock>? Files
    {
        get => GetArgument<TerraformSet<GoogleAppEngineFlexibleAppVersionDeploymentBlockFilesBlock>>("files");
        set => SetArgument("files", value);
    }

    /// <summary>
    /// Zip block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zip block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlockZipBlock>? Zip
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlockZipBlock>>("zip");
        set => SetArgument("zip", value);
    }

}

/// <summary>
/// Block type for cloud_build_options in GoogleAppEngineFlexibleAppVersionDeploymentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionDeploymentBlockCloudBuildOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_build_options";

    /// <summary>
    /// Path to the yaml file used in deployment, used to determine runtime configuration details.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppYamlPath is required")]
    public required TerraformValue<string> AppYamlPath
    {
        get => GetArgument<TerraformValue<string>>("app_yaml_path");
        set => SetArgument("app_yaml_path", value);
    }

    /// <summary>
    /// The Cloud Build timeout used as part of any dependent builds performed by version creation. Defaults to 10 minutes.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? CloudBuildTimeout
    {
        get => GetArgument<TerraformValue<string>>("cloud_build_timeout");
        set => SetArgument("cloud_build_timeout", value);
    }

}

/// <summary>
/// Block type for container in GoogleAppEngineFlexibleAppVersionDeploymentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionDeploymentBlockContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// URI to the hosted container image in Google Container Registry. The URI must be fully qualified and include a tag or digest.
    /// Examples: &amp;quot;gcr.io/my-project/image:tag&amp;quot; or &amp;quot;gcr.io/my-project/image@digest&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => GetArgument<TerraformValue<string>>("image");
        set => SetArgument("image", value);
    }

}

/// <summary>
/// Block type for files in GoogleAppEngineFlexibleAppVersionDeploymentBlock.
/// Nesting mode: set
/// </summary>
public class GoogleAppEngineFlexibleAppVersionDeploymentBlockFilesBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// SHA1 checksum of the file
    /// </summary>
    public TerraformValue<string>? Sha1Sum
    {
        get => GetArgument<TerraformValue<string>>("sha1_sum");
        set => SetArgument("sha1_sum", value);
    }

    /// <summary>
    /// Source URL
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUrl is required")]
    public required TerraformValue<string> SourceUrl
    {
        get => GetArgument<TerraformValue<string>>("source_url");
        set => SetArgument("source_url", value);
    }

}

/// <summary>
/// Block type for zip in GoogleAppEngineFlexibleAppVersionDeploymentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionDeploymentBlockZipBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("files_count");
        set => SetArgument("files_count", value);
    }

    /// <summary>
    /// Source URL
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceUrl is required")]
    public required TerraformValue<string> SourceUrl
    {
        get => GetArgument<TerraformValue<string>>("source_url");
        set => SetArgument("source_url", value);
    }

}


/// <summary>
/// Block type for endpoints_api_service in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionEndpointsApiServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoints_api_service";

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
    public TerraformValue<string>? ConfigId
    {
        get => GetArgument<TerraformValue<string>>("config_id");
        set => SetArgument("config_id", value);
    }

    /// <summary>
    /// Enable or disable trace sampling. By default, this is set to false for enabled.
    /// </summary>
    public TerraformValue<bool>? DisableTraceSampling
    {
        get => GetArgument<TerraformValue<bool>>("disable_trace_sampling");
        set => SetArgument("disable_trace_sampling", value);
    }

    /// <summary>
    /// Endpoints service name which is the name of the &amp;quot;service&amp;quot; resource in the Service Management API.
    /// For example &amp;quot;myapi.endpoints.myproject.cloud.goog&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Endpoints rollout strategy. If FIXED, configId must be specified. If MANAGED, configId must be omitted. Default value: &amp;quot;FIXED&amp;quot; Possible values: [&amp;quot;FIXED&amp;quot;, &amp;quot;MANAGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RolloutStrategy
    {
        get => GetArgument<TerraformValue<string>>("rollout_strategy");
        set => SetArgument("rollout_strategy", value);
    }

}


/// <summary>
/// Block type for entrypoint in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionEntrypointBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("shell");
        set => SetArgument("shell", value);
    }

}


/// <summary>
/// Block type for flexible_runtime_settings in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionFlexibleRuntimeSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flexible_runtime_settings";

    /// <summary>
    /// Operating System of the application runtime.
    /// </summary>
    public TerraformValue<string>? OperatingSystem
    {
        get => GetArgument<TerraformValue<string>>("operating_system");
        set => SetArgument("operating_system", value);
    }

    /// <summary>
    /// The runtime version of an App Engine flexible application.
    /// </summary>
    public TerraformValue<string>? RuntimeVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_version");
        set => SetArgument("runtime_version", value);
    }

}


/// <summary>
/// Block type for handlers in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionHandlersBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("auth_fail_action");
        set => SetArgument("auth_fail_action", value);
    }

    /// <summary>
    /// Methods to restrict access to a URL based on login status. Possible values: [&amp;quot;LOGIN_OPTIONAL&amp;quot;, &amp;quot;LOGIN_ADMIN&amp;quot;, &amp;quot;LOGIN_REQUIRED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Login
    {
        get => GetArgument<TerraformValue<string>>("login");
        set => SetArgument("login", value);
    }

    /// <summary>
    /// 30x code to use when performing redirects for the secure field. Possible values: [&amp;quot;REDIRECT_HTTP_RESPONSE_CODE_301&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_302&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_303&amp;quot;, &amp;quot;REDIRECT_HTTP_RESPONSE_CODE_307&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RedirectHttpResponseCode
    {
        get => GetArgument<TerraformValue<string>>("redirect_http_response_code");
        set => SetArgument("redirect_http_response_code", value);
    }

    /// <summary>
    /// Security (HTTPS) enforcement for this URL. Possible values: [&amp;quot;SECURE_DEFAULT&amp;quot;, &amp;quot;SECURE_NEVER&amp;quot;, &amp;quot;SECURE_OPTIONAL&amp;quot;, &amp;quot;SECURE_ALWAYS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SecurityLevel
    {
        get => GetArgument<TerraformValue<string>>("security_level");
        set => SetArgument("security_level", value);
    }

    /// <summary>
    /// URL prefix. Uses regular expression syntax, which means regexp special characters must be escaped, but should not contain groupings.
    /// All URLs that begin with this prefix are handled by this handler, using the portion of the URL after the prefix as part of the file path.
    /// </summary>
    public TerraformValue<string>? UrlRegex
    {
        get => GetArgument<TerraformValue<string>>("url_regex");
        set => SetArgument("url_regex", value);
    }

    /// <summary>
    /// Script block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Script block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionHandlersBlockScriptBlock>? Script
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionHandlersBlockScriptBlock>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// StaticFiles block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StaticFiles block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionHandlersBlockStaticFilesBlock>? StaticFiles
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionHandlersBlockStaticFilesBlock>>("static_files");
        set => SetArgument("static_files", value);
    }

}

/// <summary>
/// Block type for script in GoogleAppEngineFlexibleAppVersionHandlersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionHandlersBlockScriptBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("script_path");
        set => SetArgument("script_path", value);
    }

}

/// <summary>
/// Block type for static_files in GoogleAppEngineFlexibleAppVersionHandlersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionHandlersBlockStaticFilesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_files";

    /// <summary>
    /// Whether files should also be uploaded as code data. By default, files declared in static file handlers are
    /// uploaded as static data and are only served to end users; they cannot be read by the application. If enabled,
    /// uploads are charged against both your code and static data storage resource quotas.
    /// </summary>
    public TerraformValue<bool>? ApplicationReadable
    {
        get => GetArgument<TerraformValue<bool>>("application_readable");
        set => SetArgument("application_readable", value);
    }

    /// <summary>
    /// Time a static file served by this handler should be cached by web proxies and browsers.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example &amp;quot;3.5s&amp;quot;.
    /// Default is &#39;0s&#39;
    /// </summary>
    public TerraformValue<string>? Expiration
    {
        get => GetArgument<TerraformValue<string>>("expiration");
        set => SetArgument("expiration", value);
    }

    /// <summary>
    /// HTTP headers to use for all responses from these URLs.
    /// An object containing a list of &amp;quot;key:value&amp;quot; value pairs.&amp;quot;.
    /// </summary>
    public TerraformMap<string>? HttpHeaders
    {
        get => GetArgument<TerraformMap<string>>("http_headers");
        set => SetArgument("http_headers", value);
    }

    /// <summary>
    /// MIME type used to serve all files served by this handler.
    /// Defaults to file-specific MIME types, which are derived from each file&#39;s filename extension.
    /// </summary>
    public TerraformValue<string>? MimeType
    {
        get => GetArgument<TerraformValue<string>>("mime_type");
        set => SetArgument("mime_type", value);
    }

    /// <summary>
    /// Path to the static files matched by the URL pattern, from the application root directory.
    /// The path can refer to text matched in groupings in the URL pattern.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Whether this handler should match the request if the file referenced by the handler does not exist.
    /// </summary>
    public TerraformValue<bool>? RequireMatchingFile
    {
        get => GetArgument<TerraformValue<bool>>("require_matching_file");
        set => SetArgument("require_matching_file", value);
    }

    /// <summary>
    /// Regular expression that matches the file paths for all files that should be referenced by this handler.
    /// </summary>
    public TerraformValue<string>? UploadPathRegex
    {
        get => GetArgument<TerraformValue<string>>("upload_path_regex");
        set => SetArgument("upload_path_regex", value);
    }

}


/// <summary>
/// Block type for liveness_check in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionLivenessCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "liveness_check";

    /// <summary>
    /// Interval between health checks.
    /// </summary>
    public TerraformValue<string>? CheckInterval
    {
        get => GetArgument<TerraformValue<string>>("check_interval");
        set => SetArgument("check_interval", value);
    }

    /// <summary>
    /// Number of consecutive failed checks required before considering the VM unhealthy. Default: 4.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Host header to send when performing a HTTP Readiness check. Example: &amp;quot;myapp.appspot.com&amp;quot;
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The initial delay before starting to execute the checks. Default: &amp;quot;300s&amp;quot;
    /// </summary>
    public TerraformValue<string>? InitialDelay
    {
        get => GetArgument<TerraformValue<string>>("initial_delay");
        set => SetArgument("initial_delay", value);
    }

    /// <summary>
    /// The request path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Number of consecutive successful checks required before considering the VM healthy. Default: 2.
    /// </summary>
    public TerraformValue<double>? SuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// Time before the check is considered failed. Default: &amp;quot;4s&amp;quot;
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

}


/// <summary>
/// Block type for manual_scaling in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionManualScalingBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<double>>("instances");
        set => SetArgument("instances", value);
    }

}


/// <summary>
/// Block type for network in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionNetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network";

    /// <summary>
    /// List of ports, or port pairs, to forward from the virtual machine to the application container.
    /// </summary>
    public TerraformList<string>? ForwardedPorts
    {
        get => GetArgument<TerraformList<string>>("forwarded_ports");
        set => SetArgument("forwarded_ports", value);
    }

    /// <summary>
    /// Tag to apply to the instance during creation.
    /// </summary>
    public TerraformValue<string>? InstanceTag
    {
        get => GetArgument<TerraformValue<string>>("instance_tag");
        set => SetArgument("instance_tag", value);
    }

    /// <summary>
    /// Google Compute Engine network where the virtual machines are created. Specify the short name, not the resource path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Enable session affinity.
    /// </summary>
    public TerraformValue<bool>? SessionAffinity
    {
        get => GetArgument<TerraformValue<bool>>("session_affinity");
        set => SetArgument("session_affinity", value);
    }

    /// <summary>
    /// Google Cloud Platform sub-network where the virtual machines are created. Specify the short name, not the resource path.
    /// 
    /// If the network that the instance is being created in is a Legacy network, then the IP address is allocated from the IPv4Range.
    /// If the network that the instance is being created in is an auto Subnet Mode Network, then only network name should be specified (not the subnetworkName) and the IP address is created from the IPCidrRange of the subnetwork that exists in that zone for that network.
    /// If the network that the instance is being created in is a custom Subnet Mode Network, then the subnetworkName must be specified and the IP address is created from the IPCidrRange of the subnetwork.
    /// If specified, the subnetwork must exist in the same region as the App Engine flexible environment application.
    /// </summary>
    public TerraformValue<string>? Subnetwork
    {
        get => GetArgument<TerraformValue<string>>("subnetwork");
        set => SetArgument("subnetwork", value);
    }

}


/// <summary>
/// Block type for readiness_check in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionReadinessCheckBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "readiness_check";

    /// <summary>
    /// A maximum time limit on application initialization, measured from moment the application successfully
    /// replies to a healthcheck until it is ready to serve traffic. Default: &amp;quot;300s&amp;quot;
    /// </summary>
    public TerraformValue<string>? AppStartTimeout
    {
        get => GetArgument<TerraformValue<string>>("app_start_timeout");
        set => SetArgument("app_start_timeout", value);
    }

    /// <summary>
    /// Interval between health checks.  Default: &amp;quot;5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? CheckInterval
    {
        get => GetArgument<TerraformValue<string>>("check_interval");
        set => SetArgument("check_interval", value);
    }

    /// <summary>
    /// Number of consecutive failed checks required before removing traffic. Default: 2.
    /// </summary>
    public TerraformValue<double>? FailureThreshold
    {
        get => GetArgument<TerraformValue<double>>("failure_threshold");
        set => SetArgument("failure_threshold", value);
    }

    /// <summary>
    /// Host header to send when performing a HTTP Readiness check. Example: &amp;quot;myapp.appspot.com&amp;quot;
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The request path.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Number of consecutive successful checks required before receiving traffic. Default: 2.
    /// </summary>
    public TerraformValue<double>? SuccessThreshold
    {
        get => GetArgument<TerraformValue<double>>("success_threshold");
        set => SetArgument("success_threshold", value);
    }

    /// <summary>
    /// Time before the check is considered failed. Default: &amp;quot;4s&amp;quot;
    /// </summary>
    public TerraformValue<string>? Timeout
    {
        get => GetArgument<TerraformValue<string>>("timeout");
        set => SetArgument("timeout", value);
    }

}


/// <summary>
/// Block type for resources in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// Number of CPU cores needed.
    /// </summary>
    public TerraformValue<double>? Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// Disk size (GB) needed.
    /// </summary>
    public TerraformValue<double>? DiskGb
    {
        get => GetArgument<TerraformValue<double>>("disk_gb");
        set => SetArgument("disk_gb", value);
    }

    /// <summary>
    /// Memory (GB) needed.
    /// </summary>
    public TerraformValue<double>? MemoryGb
    {
        get => GetArgument<TerraformValue<double>>("memory_gb");
        set => SetArgument("memory_gb", value);
    }

    /// <summary>
    /// Volumes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAppEngineFlexibleAppVersionResourcesBlockVolumesBlock>? Volumes
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionResourcesBlockVolumesBlock>>("volumes");
        set => SetArgument("volumes", value);
    }

}

/// <summary>
/// Block type for volumes in GoogleAppEngineFlexibleAppVersionResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionResourcesBlockVolumesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volumes";

    /// <summary>
    /// Unique name for the volume.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Volume size in gigabytes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeGb is required")]
    public required TerraformValue<double> SizeGb
    {
        get => GetArgument<TerraformValue<double>>("size_gb");
        set => SetArgument("size_gb", value);
    }

    /// <summary>
    /// Underlying volume type, e.g. &#39;tmpfs&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeType is required")]
    public required TerraformValue<string> VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineFlexibleAppVersionTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_access_connector in GoogleAppEngineFlexibleAppVersion.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineFlexibleAppVersionVpcAccessConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_access_connector";

    /// <summary>
    /// Full Serverless VPC Access Connector name e.g. /projects/my-project/locations/us-central1/connectors/c1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Represents a google_app_engine_flexible_app_version Terraform resource.
/// Manages a google_app_engine_flexible_app_version resource.
/// </summary>
public partial class GoogleAppEngineFlexibleAppVersion(string name) : TerraformResource("google_app_engine_flexible_app_version", name)
{
    /// <summary>
    /// Metadata settings that are supplied to this version to enable beta runtime features.
    /// </summary>
    public TerraformMap<string>? BetaSettings
    {
        get => GetArgument<TerraformMap<string>>("beta_settings");
        set => SetArgument("beta_settings", value);
    }

    /// <summary>
    /// Duration that static files should be cached by web proxies and browsers.
    /// Only applicable if the corresponding StaticFilesHandler does not specify its own expiration time.
    /// </summary>
    public TerraformValue<string>? DefaultExpiration
    {
        get => GetArgument<TerraformValue<string>>("default_expiration");
        set => SetArgument("default_expiration", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the service will be deleted if it is the last version.
    /// </summary>
    public TerraformValue<bool>? DeleteServiceOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("delete_service_on_destroy");
        set => SetArgument("delete_service_on_destroy", value);
    }

    /// <summary>
    /// Environment variables available to the application.  As these are not returned in the API request, Terraform will not detect any changes made outside of the Terraform config.
    /// </summary>
    public TerraformMap<string>? EnvVariables
    {
        get => GetArgument<TerraformMap<string>>("env_variables");
        set => SetArgument("env_variables", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A list of the types of messages that this application is able to receive. Possible values: [&amp;quot;INBOUND_SERVICE_MAIL&amp;quot;, &amp;quot;INBOUND_SERVICE_MAIL_BOUNCE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_ERROR&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_MESSAGE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_SUBSCRIBE&amp;quot;, &amp;quot;INBOUND_SERVICE_XMPP_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_CHANNEL_PRESENCE&amp;quot;, &amp;quot;INBOUND_SERVICE_WARMUP&amp;quot;]
    /// </summary>
    public TerraformSet<string>? InboundServices
    {
        get => GetArgument<TerraformSet<string>>("inbound_services");
        set => SetArgument("inbound_services", value);
    }

    /// <summary>
    /// Instance class that is used to run this version. Valid values are
    /// AutomaticScaling: F1, F2, F4, F4_1G
    /// ManualScaling: B1, B2, B4, B8, B4_1G
    /// Defaults to F1 for AutomaticScaling and B1 for ManualScaling.
    /// </summary>
    public TerraformValue<string>? InstanceClass
    {
        get => GetArgument<TerraformValue<string>>("instance_class");
        set => SetArgument("instance_class", value);
    }

    /// <summary>
    /// Files that match this pattern will not be built into this version. Only applicable for Go runtimes.
    /// </summary>
    public TerraformValue<string>? NobuildFilesRegex
    {
        get => GetArgument<TerraformValue<string>>("nobuild_files_regex");
        set => SetArgument("nobuild_files_regex", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, the application version will not be deleted.
    /// </summary>
    public TerraformValue<bool>? NoopOnDestroy
    {
        get => GetArgument<TerraformValue<bool>>("noop_on_destroy");
        set => SetArgument("noop_on_destroy", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Desired runtime. Example python27.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Runtime is required")]
    public required TerraformValue<string> Runtime
    {
        get => GetArgument<TerraformValue<string>>("runtime");
        set => SetArgument("runtime", value);
    }

    /// <summary>
    /// The version of the API in the given runtime environment.
    /// Please see the app.yaml reference for valid values at &#39;https://cloud.google.com/appengine/docs/standard/&amp;lt;language&amp;gt;/config/appref&#39;\
    /// Substitute &#39;&amp;lt;language&amp;gt;&#39; with &#39;python&#39;, &#39;java&#39;, &#39;php&#39;, &#39;ruby&#39;, &#39;go&#39; or &#39;nodejs&#39;.
    /// </summary>
    public TerraformValue<string>? RuntimeApiVersion
    {
        get => GetArgument<TerraformValue<string>>("runtime_api_version");
        set => SetArgument("runtime_api_version", value);
    }

    /// <summary>
    /// The channel of the runtime to use. Only available for some runtimes.
    /// </summary>
    public TerraformValue<string>? RuntimeChannel
    {
        get => GetArgument<TerraformValue<string>>("runtime_channel");
        set => SetArgument("runtime_channel", value);
    }

    /// <summary>
    /// The path or name of the app&#39;s main executable.
    /// </summary>
    public TerraformValue<string>? RuntimeMainExecutablePath
    {
        get => GetArgument<TerraformValue<string>>("runtime_main_executable_path");
        set => SetArgument("runtime_main_executable_path", value);
    }

    /// <summary>
    /// AppEngine service resource. Can contain numbers, letters, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The identity that the deployed version will run as. Admin API will use the App Engine Appspot service account as
    /// default if this field is neither provided in app.yaml file nor through CLI flag.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Current serving status of this version. Only the versions with a SERVING status create instances and can be billed. Default value: &amp;quot;SERVING&amp;quot; Possible values: [&amp;quot;SERVING&amp;quot;, &amp;quot;STOPPED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ServingStatus
    {
        get => GetArgument<TerraformValue<string>>("serving_status");
        set => SetArgument("serving_status", value);
    }

    /// <summary>
    /// Relative name of the version within the service. For example, &#39;v1&#39;. Version names can contain only lowercase letters, numbers, or hyphens.
    /// Reserved names,&amp;quot;default&amp;quot;, &amp;quot;latest&amp;quot;, and any name with the prefix &amp;quot;ah-&amp;quot;.
    /// </summary>
    public TerraformValue<string>? VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// Full path to the Version resource in the API. Example, &amp;quot;v1&amp;quot;.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// ApiConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApiConfig block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionApiConfigBlock>? ApiConfig
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionApiConfigBlock>>("api_config");
        set => SetArgument("api_config", value);
    }

    /// <summary>
    /// AutomaticScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomaticScaling block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock>? AutomaticScaling
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionAutomaticScalingBlock>>("automatic_scaling");
        set => SetArgument("automatic_scaling", value);
    }

    /// <summary>
    /// Deployment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deployment block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlock>? Deployment
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionDeploymentBlock>>("deployment");
        set => SetArgument("deployment", value);
    }

    /// <summary>
    /// EndpointsApiService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointsApiService block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionEndpointsApiServiceBlock>? EndpointsApiService
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionEndpointsApiServiceBlock>>("endpoints_api_service");
        set => SetArgument("endpoints_api_service", value);
    }

    /// <summary>
    /// Entrypoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Entrypoint block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionEntrypointBlock>? Entrypoint
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionEntrypointBlock>>("entrypoint");
        set => SetArgument("entrypoint", value);
    }

    /// <summary>
    /// FlexibleRuntimeSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlexibleRuntimeSettings block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionFlexibleRuntimeSettingsBlock>? FlexibleRuntimeSettings
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionFlexibleRuntimeSettingsBlock>>("flexible_runtime_settings");
        set => SetArgument("flexible_runtime_settings", value);
    }

    /// <summary>
    /// Handlers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAppEngineFlexibleAppVersionHandlersBlock>? Handlers
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionHandlersBlock>>("handlers");
        set => SetArgument("handlers", value);
    }

    /// <summary>
    /// LivenessCheck block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LivenessCheck is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LivenessCheck block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LivenessCheck block(s) allowed")]
    public required TerraformList<GoogleAppEngineFlexibleAppVersionLivenessCheckBlock> LivenessCheck
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineFlexibleAppVersionLivenessCheckBlock>>("liveness_check");
        set => SetArgument("liveness_check", value);
    }

    /// <summary>
    /// ManualScaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManualScaling block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionManualScalingBlock>? ManualScaling
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionManualScalingBlock>>("manual_scaling");
        set => SetArgument("manual_scaling", value);
    }

    /// <summary>
    /// Network block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Network block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionNetworkBlock>? Network
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionNetworkBlock>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// ReadinessCheck block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadinessCheck is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadinessCheck block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadinessCheck block(s) allowed")]
    public required TerraformList<GoogleAppEngineFlexibleAppVersionReadinessCheckBlock> ReadinessCheck
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineFlexibleAppVersionReadinessCheckBlock>>("readiness_check");
        set => SetArgument("readiness_check", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resources block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineFlexibleAppVersionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineFlexibleAppVersionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcAccessConnector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcAccessConnector block(s) allowed")]
    public TerraformList<GoogleAppEngineFlexibleAppVersionVpcAccessConnectorBlock>? VpcAccessConnector
    {
        get => GetArgument<TerraformList<GoogleAppEngineFlexibleAppVersionVpcAccessConnectorBlock>>("vpc_access_connector");
        set => SetArgument("vpc_access_connector", value);
    }

}
