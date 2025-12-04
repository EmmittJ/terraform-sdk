using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_routing_override in GoogleCloudTasksQueue.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueAppEngineRoutingOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_engine_routing_override";

    /// <summary>
    /// The host that the task is sent to.
    /// </summary>
    public TerraformValue<string> Host
        => AsReference("host");

    /// <summary>
    /// App instance.
    /// 
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => GetArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// App service.
    /// 
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// App version.
    /// 
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for http_target in GoogleCloudTasksQueue.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_target";

    /// <summary>
    /// The HTTP method to use for the request.
    /// 
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time. Possible values: [&amp;quot;HTTP_METHOD_UNSPECIFIED&amp;quot;, &amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? HttpMethod
    {
        get => GetArgument<TerraformValue<string>>("http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// HeaderOverrides block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleCloudTasksQueueHttpTargetBlockHeaderOverridesBlock>? HeaderOverrides
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlockHeaderOverridesBlock>>("header_overrides");
        set => SetArgument("header_overrides", value);
    }

    /// <summary>
    /// OauthToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthToken block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueHttpTargetBlockOauthTokenBlock>? OauthToken
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlockOauthTokenBlock>>("oauth_token");
        set => SetArgument("oauth_token", value);
    }

    /// <summary>
    /// OidcToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcToken block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueHttpTargetBlockOidcTokenBlock>? OidcToken
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlockOidcTokenBlock>>("oidc_token");
        set => SetArgument("oidc_token", value);
    }

    /// <summary>
    /// UriOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UriOverride block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlock>? UriOverride
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlock>>("uri_override");
        set => SetArgument("uri_override", value);
    }

}

/// <summary>
/// Block type for header_overrides in GoogleCloudTasksQueueHttpTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlockHeaderOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_overrides";

    /// <summary>
    /// Header block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Header block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Header block(s) allowed")]
    public required TerraformList<GoogleCloudTasksQueueHttpTargetBlockHeaderOverridesBlockHeaderBlock> Header
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlockHeaderOverridesBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in GoogleCloudTasksQueueHttpTargetBlockHeaderOverridesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlockHeaderOverridesBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The Key of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The Value of the header.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for oauth_token in GoogleCloudTasksQueueHttpTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlockOauthTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_token";

    /// <summary>
    /// OAuth scope to be used for generating OAuth access token.
    /// If not specified, &amp;quot;https://www.googleapis.com/auth/cloud-platform&amp;quot; will be used.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

}

/// <summary>
/// Block type for oidc_token in GoogleCloudTasksQueueHttpTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlockOidcTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_token";

    /// <summary>
    /// Audience to be used when generating OIDC token. If not specified, the URI specified in target will be used.
    /// </summary>
    public TerraformValue<string>? Audience
    {
        get => GetArgument<TerraformValue<string>>("audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// Service account email to be used for generating OIDC token.
    /// The service account must be within the same project as the queue.
    /// The caller must have iam.serviceAccounts.actAs permission for the service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => GetArgument<TerraformValue<string>>("service_account_email");
        set => SetArgument("service_account_email", value);
    }

}

/// <summary>
/// Block type for uri_override in GoogleCloudTasksQueueHttpTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "uri_override";

    /// <summary>
    /// Host override.
    /// 
    /// When specified, replaces the host part of the task URL.
    /// For example, if the task URL is &amp;quot;https://www.google.com&amp;quot;, and host value
    /// is set to &amp;quot;example.net&amp;quot;, the overridden URI will be changed to &amp;quot;https://example.net&amp;quot;.
    /// Host value cannot be an empty string (INVALID_ARGUMENT).
    /// </summary>
    public TerraformValue<string>? Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// Port override.
    /// 
    /// When specified, replaces the port part of the task URI.
    /// For instance, for a URI http://www.google.com/foo and port=123, the overridden URI becomes http://www.google.com:123/foo.
    /// Note that the port value must be a positive integer.
    /// Setting the port to 0 (Zero) clears the URI port.
    /// </summary>
    public TerraformValue<string>? Port
    {
        get => GetArgument<TerraformValue<string>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Scheme override.
    /// 
    /// When specified, the task URI scheme is replaced by the provided value (HTTP or HTTPS). Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTPS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Scheme
    {
        get => GetArgument<TerraformValue<string>>("scheme");
        set => SetArgument("scheme", value);
    }

    /// <summary>
    /// URI Override Enforce Mode
    /// 
    /// When specified, determines the Target UriOverride mode. If not specified, it defaults to ALWAYS. Possible values: [&amp;quot;ALWAYS&amp;quot;, &amp;quot;IF_NOT_EXISTS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? UriOverrideEnforceMode
    {
        get => GetArgument<TerraformValue<string>>("uri_override_enforce_mode");
        set => SetArgument("uri_override_enforce_mode", value);
    }

    /// <summary>
    /// PathOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PathOverride block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlockPathOverrideBlock>? PathOverride
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlockPathOverrideBlock>>("path_override");
        set => SetArgument("path_override", value);
    }

    /// <summary>
    /// QueryOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryOverride block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlockQueryOverrideBlock>? QueryOverride
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlockQueryOverrideBlock>>("query_override");
        set => SetArgument("query_override", value);
    }

}

/// <summary>
/// Block type for path_override in GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlockPathOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "path_override";

    /// <summary>
    /// The URI path (e.g., /users/1234). Default is an empty string.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for query_override in GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlockUriOverrideBlockQueryOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_override";

    /// <summary>
    /// The query parameters (e.g., qparam1=123&amp;amp;qparam2=456). Default is an empty string.
    /// </summary>
    public TerraformValue<string>? QueryParams
    {
        get => GetArgument<TerraformValue<string>>("query_params");
        set => SetArgument("query_params", value);
    }

}


/// <summary>
/// Block type for rate_limits in GoogleCloudTasksQueue.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRateLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rate_limits";

    /// <summary>
    /// The max burst size.
    /// 
    /// Max burst size limits how fast tasks in queue are processed when many tasks are
    /// in the queue and the rate is high. This field allows the queue to have a high
    /// rate so processing starts shortly after a task is enqueued, but still limits
    /// resource usage when many tasks are enqueued in a short period of time.
    /// </summary>
    public TerraformValue<double> MaxBurstSize
        => AsReference("max_burst_size");

    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentDispatches
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_dispatches");
        set => SetArgument("max_concurrent_dispatches", value);
    }

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// 
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    public TerraformValue<double>? MaxDispatchesPerSecond
    {
        get => GetArgument<TerraformValue<double>>("max_dispatches_per_second");
        set => SetArgument("max_dispatches_per_second", value);
    }

}


/// <summary>
/// Block type for retry_config in GoogleCloudTasksQueue.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRetryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_config";

    /// <summary>
    /// Number of attempts per task.
    /// 
    /// Cloud Tasks will attempt the task maxAttempts times (that is, if
    /// the first attempt fails, then there will be maxAttempts - 1
    /// retries). Must be &amp;gt;= -1.
    /// 
    /// If unspecified when the queue is created, Cloud Tasks will pick
    /// the default.
    /// 
    /// -1 indicates unlimited attempts.
    /// </summary>
    public TerraformValue<double>? MaxAttempts
    {
        get => GetArgument<TerraformValue<double>>("max_attempts");
        set => SetArgument("max_attempts", value);
    }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    public TerraformValue<string>? MaxBackoff
    {
        get => GetArgument<TerraformValue<string>>("max_backoff");
        set => SetArgument("max_backoff", value);
    }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// 
    /// A task&#39;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    public TerraformValue<double>? MaxDoublings
    {
        get => GetArgument<TerraformValue<double>>("max_doublings");
        set => SetArgument("max_doublings", value);
    }

    /// <summary>
    /// If positive, maxRetryDuration specifies the time limit for
    /// retrying a failed task, measured from when the task was first
    /// attempted. Once maxRetryDuration time has passed and the task has
    /// been attempted maxAttempts times, no further attempts will be
    /// made and the task will be deleted.
    /// 
    /// If zero, then the task age is unlimited.
    /// </summary>
    public TerraformValue<string>? MaxRetryDuration
    {
        get => GetArgument<TerraformValue<string>>("max_retry_duration");
        set => SetArgument("max_retry_duration", value);
    }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    public TerraformValue<string>? MinBackoff
    {
        get => GetArgument<TerraformValue<string>>("min_backoff");
        set => SetArgument("min_backoff", value);
    }

}


/// <summary>
/// Block type for stackdriver_logging_config in GoogleCloudTasksQueue.
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueStackdriverLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stackdriver_logging_config";

    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRatio is required")]
    public required TerraformValue<double> SamplingRatio
    {
        get => GetArgument<TerraformValue<double>>("sampling_ratio");
        set => SetArgument("sampling_ratio", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudTasksQueue.
/// Nesting mode: single
/// </summary>
public class GoogleCloudTasksQueueTimeoutsBlock : TerraformBlock
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
/// Represents a google_cloud_tasks_queue Terraform resource.
/// Manages a google_cloud_tasks_queue resource.
/// </summary>
public partial class GoogleCloudTasksQueue(string name) : TerraformResource("google_cloud_tasks_queue", name)
{
    /// <summary>
    /// The desired state of the queue. Use this to pause and resume the queue.
    /// 
    /// * RUNNING: The queue is running. Tasks can be dispatched.
    /// * PAUSED: The queue is paused. Tasks are not dispatched but can be added to the queue. Default value: &amp;quot;RUNNING&amp;quot; Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
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
    /// The location of the queue
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The queue name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The current state of the queue.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// AppEngineRoutingOverride block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineRoutingOverride block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueAppEngineRoutingOverrideBlock>? AppEngineRoutingOverride
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueAppEngineRoutingOverrideBlock>>("app_engine_routing_override");
        set => SetArgument("app_engine_routing_override", value);
    }

    /// <summary>
    /// HttpTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueHttpTargetBlock>? HttpTarget
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueHttpTargetBlock>>("http_target");
        set => SetArgument("http_target", value);
    }

    /// <summary>
    /// RateLimits block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimits block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueRateLimitsBlock>? RateLimits
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueRateLimitsBlock>>("rate_limits");
        set => SetArgument("rate_limits", value);
    }

    /// <summary>
    /// RetryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueRetryConfigBlock>? RetryConfig
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueRetryConfigBlock>>("retry_config");
        set => SetArgument("retry_config", value);
    }

    /// <summary>
    /// StackdriverLoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackdriverLoggingConfig block(s) allowed")]
    public TerraformList<GoogleCloudTasksQueueStackdriverLoggingConfigBlock>? StackdriverLoggingConfig
    {
        get => GetArgument<TerraformList<GoogleCloudTasksQueueStackdriverLoggingConfigBlock>>("stackdriver_logging_config");
        set => SetArgument("stackdriver_logging_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudTasksQueueTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudTasksQueueTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
