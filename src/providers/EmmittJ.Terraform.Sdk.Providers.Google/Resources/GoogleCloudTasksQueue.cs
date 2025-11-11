using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_routing_override in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudTasksQueueAppEngineRoutingOverrideBlock : TerraformBlockBase
{

    /// <summary>
    /// App instance.
    /// 
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    [TerraformProperty("instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// App service.
    /// 
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    [TerraformProperty("service")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Service { get; set; }

    /// <summary>
    /// App version.
    /// 
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudTasksQueueHttpTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The HTTP method to use for the request.
    /// 
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time. Possible values: [&amp;quot;HTTP_METHOD_UNSPECIFIED&amp;quot;, &amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    [TerraformProperty("http_method")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpMethod { get; set; }

}

/// <summary>
/// Block type for rate_limits in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudTasksQueueRateLimitsBlock : TerraformBlockBase
{

    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    [TerraformProperty("max_concurrent_dispatches")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxConcurrentDispatches { get; set; }

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// 
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    [TerraformProperty("max_dispatches_per_second")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxDispatchesPerSecond { get; set; }

}

/// <summary>
/// Block type for retry_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudTasksQueueRetryConfigBlock : TerraformBlockBase
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
    [TerraformProperty("max_attempts")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxAttempts { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [TerraformProperty("max_backoff")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxBackoff { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// 
    /// A task&#39;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    [TerraformProperty("max_doublings")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxDoublings { get; set; }

    /// <summary>
    /// If positive, maxRetryDuration specifies the time limit for
    /// retrying a failed task, measured from when the task was first
    /// attempted. Once maxRetryDuration time has passed and the task has
    /// been attempted maxAttempts times, no further attempts will be
    /// made and the task will be deleted.
    /// 
    /// If zero, then the task age is unlimited.
    /// </summary>
    [TerraformProperty("max_retry_duration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxRetryDuration { get; set; }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    [TerraformProperty("min_backoff")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinBackoff { get; set; }

}

/// <summary>
/// Block type for stackdriver_logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudTasksQueueStackdriverLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRatio is required")]
    [TerraformProperty("sampling_ratio")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SamplingRatio { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudTasksQueueTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloud_tasks_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudTasksQueue : TerraformResource
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
    [TerraformProperty("desired_state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DesiredState { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the queue
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The queue name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for app_engine_routing_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineRoutingOverride block(s) allowed")]
    [TerraformProperty("app_engine_routing_override")]
    public partial TerraformList<TerraformBlock<GoogleCloudTasksQueueAppEngineRoutingOverrideBlock>>? AppEngineRoutingOverride { get; set; }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    [TerraformProperty("http_target")]
    public partial TerraformList<TerraformBlock<GoogleCloudTasksQueueHttpTargetBlock>>? HttpTarget { get; set; }

    /// <summary>
    /// Block for rate_limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimits block(s) allowed")]
    [TerraformProperty("rate_limits")]
    public partial TerraformList<TerraformBlock<GoogleCloudTasksQueueRateLimitsBlock>>? RateLimits { get; set; }

    /// <summary>
    /// Block for retry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    [TerraformProperty("retry_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudTasksQueueRetryConfigBlock>>? RetryConfig { get; set; }

    /// <summary>
    /// Block for stackdriver_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackdriverLoggingConfig block(s) allowed")]
    [TerraformProperty("stackdriver_logging_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudTasksQueueStackdriverLoggingConfigBlock>>? StackdriverLoggingConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleCloudTasksQueueTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The current state of the queue.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
