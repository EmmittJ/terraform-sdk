using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_routing_override in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueAppEngineRoutingOverrideBlock
{

    /// <summary>
    /// App instance.
    /// 
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// App service.
    /// 
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    [TerraformPropertyName("service")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Service { get; set; }

    /// <summary>
    /// App version.
    /// 
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlock
{
    /// <summary>
    /// The HTTP method to use for the request.
    /// 
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time. Possible values: [&amp;quot;HTTP_METHOD_UNSPECIFIED&amp;quot;, &amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("http_method")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> HttpMethod { get; set; } = default!;

}

/// <summary>
/// Block type for rate_limits in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRateLimitsBlock
{

    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    [TerraformPropertyName("max_concurrent_dispatches")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxConcurrentDispatches { get; set; } = default!;

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// 
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    [TerraformPropertyName("max_dispatches_per_second")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxDispatchesPerSecond { get; set; } = default!;

}

/// <summary>
/// Block type for retry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRetryConfigBlock
{
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
    [TerraformPropertyName("max_attempts")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxAttempts { get; set; } = default!;

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [TerraformPropertyName("max_backoff")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaxBackoff { get; set; } = default!;

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// 
    /// A task&#39;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    [TerraformPropertyName("max_doublings")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> MaxDoublings { get; set; } = default!;

    /// <summary>
    /// If positive, maxRetryDuration specifies the time limit for
    /// retrying a failed task, measured from when the task was first
    /// attempted. Once maxRetryDuration time has passed and the task has
    /// been attempted maxAttempts times, no further attempts will be
    /// made and the task will be deleted.
    /// 
    /// If zero, then the task age is unlimited.
    /// </summary>
    [TerraformPropertyName("max_retry_duration")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaxRetryDuration { get; set; } = default!;

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [TerraformPropertyName("min_backoff")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MinBackoff { get; set; } = default!;

}

/// <summary>
/// Block type for stackdriver_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueStackdriverLoggingConfigBlock
{
    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRatio is required")]
    [TerraformPropertyName("sampling_ratio")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> SamplingRatio { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudTasksQueueTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloud_tasks_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudTasksQueue : TerraformResource
{
    public GoogleCloudTasksQueue(string name) : base("google_cloud_tasks_queue", name)
    {
    }

    /// <summary>
    /// The desired state of the queue. Use this to pause and resume the queue.
    /// 
    /// * RUNNING: The queue is running. Tasks can be dispatched.
    /// * PAUSED: The queue is paused. Tasks are not dispatched but can be added to the queue. Default value: &amp;quot;RUNNING&amp;quot; Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("desired_state")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location of the queue
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The queue name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for app_engine_routing_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineRoutingOverride block(s) allowed")]
    [TerraformPropertyName("app_engine_routing_override")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueAppEngineRoutingOverrideBlock>>? AppEngineRoutingOverride { get; set; }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    [TerraformPropertyName("http_target")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueHttpTargetBlock>>? HttpTarget { get; set; }

    /// <summary>
    /// Block for rate_limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimits block(s) allowed")]
    [TerraformPropertyName("rate_limits")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueRateLimitsBlock>>? RateLimits { get; set; }

    /// <summary>
    /// Block for retry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    [TerraformPropertyName("retry_config")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueRetryConfigBlock>>? RetryConfig { get; set; }

    /// <summary>
    /// Block for stackdriver_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackdriverLoggingConfig block(s) allowed")]
    [TerraformPropertyName("stackdriver_logging_config")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueStackdriverLoggingConfigBlock>>? StackdriverLoggingConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudTasksQueueTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The current state of the queue.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
