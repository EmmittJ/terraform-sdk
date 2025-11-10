using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_routing_override in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueAppEngineRoutingOverrideBlock : ITerraformBlock
{
    /// <summary>
    /// The host that the task is sent to.
    /// </summary>
    [TerraformPropertyName("host")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Host => new TerraformReferenceProperty<TerraformProperty<string>>("", "host");

    /// <summary>
    /// App instance.
    /// 
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Instance { get; set; }

    /// <summary>
    /// App service.
    /// 
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    [TerraformPropertyName("service")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Service { get; set; }

    /// <summary>
    /// App version.
    /// 
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlock : ITerraformBlock
{
    /// <summary>
    /// The HTTP method to use for the request.
    /// 
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time. Possible values: [&amp;quot;HTTP_METHOD_UNSPECIFIED&amp;quot;, &amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("http_method")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpMethod { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "http_method");

}

/// <summary>
/// Block type for rate_limits in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRateLimitsBlock : ITerraformBlock
{
    /// <summary>
    /// The max burst size.
    /// 
    /// Max burst size limits how fast tasks in queue are processed when many tasks are
    /// in the queue and the rate is high. This field allows the queue to have a high
    /// rate so processing starts shortly after a task is enqueued, but still limits
    /// resource usage when many tasks are enqueued in a short period of time.
    /// </summary>
    [TerraformPropertyName("max_burst_size")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxBurstSize => new TerraformReferenceProperty<TerraformProperty<double>>("", "max_burst_size");

    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    [TerraformPropertyName("max_concurrent_dispatches")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxConcurrentDispatches { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_concurrent_dispatches");

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// 
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    [TerraformPropertyName("max_dispatches_per_second")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxDispatchesPerSecond { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_dispatches_per_second");

}

/// <summary>
/// Block type for retry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRetryConfigBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxAttempts { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_attempts");

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [TerraformPropertyName("max_backoff")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaxBackoff { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "max_backoff");

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// 
    /// A task&#39;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    [TerraformPropertyName("max_doublings")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxDoublings { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_doublings");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaxRetryDuration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "max_retry_duration");

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [TerraformPropertyName("min_backoff")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinBackoff { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "min_backoff");

}

/// <summary>
/// Block type for stackdriver_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueStackdriverLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRatio is required")]
    [TerraformPropertyName("sampling_ratio")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> SamplingRatio { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudTasksQueueTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? DesiredState { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location of the queue
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The queue name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for app_engine_routing_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineRoutingOverride block(s) allowed")]
    [TerraformPropertyName("app_engine_routing_override")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueAppEngineRoutingOverrideBlock>>? AppEngineRoutingOverride { get; set; } = new();

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    [TerraformPropertyName("http_target")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueHttpTargetBlock>>? HttpTarget { get; set; } = new();

    /// <summary>
    /// Block for rate_limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimits block(s) allowed")]
    [TerraformPropertyName("rate_limits")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueRateLimitsBlock>>? RateLimits { get; set; } = new();

    /// <summary>
    /// Block for retry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    [TerraformPropertyName("retry_config")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueRetryConfigBlock>>? RetryConfig { get; set; } = new();

    /// <summary>
    /// Block for stackdriver_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackdriverLoggingConfig block(s) allowed")]
    [TerraformPropertyName("stackdriver_logging_config")]
    public TerraformList<TerraformBlock<GoogleCloudTasksQueueStackdriverLoggingConfigBlock>>? StackdriverLoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudTasksQueueTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The current state of the queue.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
