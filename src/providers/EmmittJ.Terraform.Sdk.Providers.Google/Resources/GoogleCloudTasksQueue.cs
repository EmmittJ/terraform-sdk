using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_routing_override in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueAppEngineRoutingOverrideBlock : TerraformBlock
{
    /// <summary>
    /// The host that the task is sent to.
    /// </summary>
    public TerraformProperty<string>? Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// App instance.
    /// 
    /// By default, the task is sent to an instance which is available when the task is attempted.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// App service.
    /// 
    /// By default, the task is sent to the service which is the default service when the task is attempted.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        set => SetProperty("service", value);
    }

    /// <summary>
    /// App version.
    /// 
    /// By default, the task is sent to the version which is the default version when the task is attempted.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// The HTTP method to use for the request.
    /// 
    /// When specified, it overrides HttpRequest for the task.
    /// Note that if the value is set to GET the body of the task will be ignored at execution time. Possible values: [&amp;quot;HTTP_METHOD_UNSPECIFIED&amp;quot;, &amp;quot;POST&amp;quot;, &amp;quot;GET&amp;quot;, &amp;quot;HEAD&amp;quot;, &amp;quot;PUT&amp;quot;, &amp;quot;DELETE&amp;quot;, &amp;quot;PATCH&amp;quot;, &amp;quot;OPTIONS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? HttpMethod
    {
        set => SetProperty("http_method", value);
    }

}

/// <summary>
/// Block type for rate_limits in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRateLimitsBlock : TerraformBlock
{
    /// <summary>
    /// The max burst size.
    /// 
    /// Max burst size limits how fast tasks in queue are processed when many tasks are
    /// in the queue and the rate is high. This field allows the queue to have a high
    /// rate so processing starts shortly after a task is enqueued, but still limits
    /// resource usage when many tasks are enqueued in a short period of time.
    /// </summary>
    public TerraformProperty<double>? MaxBurstSize
    {
        set => SetProperty("max_burst_size", value);
    }

    /// <summary>
    /// The maximum number of concurrent tasks that Cloud Tasks allows to
    /// be dispatched for this queue. After this threshold has been
    /// reached, Cloud Tasks stops dispatching tasks until the number of
    /// concurrent requests decreases.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentDispatches
    {
        set => SetProperty("max_concurrent_dispatches", value);
    }

    /// <summary>
    /// The maximum rate at which tasks are dispatched from this queue.
    /// 
    /// If unspecified when the queue is created, Cloud Tasks will pick the default.
    /// </summary>
    public TerraformProperty<double>? MaxDispatchesPerSecond
    {
        set => SetProperty("max_dispatches_per_second", value);
    }

}

/// <summary>
/// Block type for retry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueRetryConfigBlock : TerraformBlock
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
    public TerraformProperty<double>? MaxAttempts
    {
        set => SetProperty("max_attempts", value);
    }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    public TerraformProperty<string>? MaxBackoff
    {
        set => SetProperty("max_backoff", value);
    }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// 
    /// A task&#39;s retry interval starts at minBackoff, then doubles maxDoublings times,
    /// then increases linearly, and finally retries retries at intervals of maxBackoff
    /// up to maxAttempts times.
    /// </summary>
    public TerraformProperty<double>? MaxDoublings
    {
        set => SetProperty("max_doublings", value);
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
    public TerraformProperty<string>? MaxRetryDuration
    {
        set => SetProperty("max_retry_duration", value);
    }

    /// <summary>
    /// A task will be scheduled for retry between minBackoff and
    /// maxBackoff duration after it fails, if the queue&#39;s RetryConfig
    /// specifies that the task should be retried.
    /// </summary>
    public TerraformProperty<string>? MinBackoff
    {
        set => SetProperty("min_backoff", value);
    }

}

/// <summary>
/// Block type for stackdriver_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudTasksQueueStackdriverLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the fraction of operations to write to Stackdriver Logging.
    /// This field may contain any value between 0.0 and 1.0, inclusive. 0.0 is the
    /// default and means that no operations are logged.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SamplingRatio is required")]
    public required TerraformProperty<double> SamplingRatio
    {
        set => SetProperty("sampling_ratio", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudTasksQueueTimeoutsBlock : TerraformBlock
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
/// Manages a google_cloud_tasks_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudTasksQueue : TerraformResource
{
    public GoogleCloudTasksQueue(string name) : base("google_cloud_tasks_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("state");
        SetOutput("desired_state");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// The desired state of the queue. Use this to pause and resume the queue.
    /// 
    /// * RUNNING: The queue is running. Tasks can be dispatched.
    /// * PAUSED: The queue is paused. Tasks are not dispatched but can be added to the queue. Default value: &amp;quot;RUNNING&amp;quot; Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> DesiredState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("desired_state");
        set => SetProperty("desired_state", value);
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
    /// The location of the queue
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The queue name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for app_engine_routing_override.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineRoutingOverride block(s) allowed")]
    public List<GoogleCloudTasksQueueAppEngineRoutingOverrideBlock>? AppEngineRoutingOverride
    {
        set => SetProperty("app_engine_routing_override", value);
    }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    public List<GoogleCloudTasksQueueHttpTargetBlock>? HttpTarget
    {
        set => SetProperty("http_target", value);
    }

    /// <summary>
    /// Block for rate_limits.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RateLimits block(s) allowed")]
    public List<GoogleCloudTasksQueueRateLimitsBlock>? RateLimits
    {
        set => SetProperty("rate_limits", value);
    }

    /// <summary>
    /// Block for retry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    public List<GoogleCloudTasksQueueRetryConfigBlock>? RetryConfig
    {
        set => SetProperty("retry_config", value);
    }

    /// <summary>
    /// Block for stackdriver_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackdriverLoggingConfig block(s) allowed")]
    public List<GoogleCloudTasksQueueStackdriverLoggingConfigBlock>? StackdriverLoggingConfig
    {
        set => SetProperty("stackdriver_logging_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudTasksQueueTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The current state of the queue.
    /// </summary>
    public TerraformExpression State => this["state"];

}
