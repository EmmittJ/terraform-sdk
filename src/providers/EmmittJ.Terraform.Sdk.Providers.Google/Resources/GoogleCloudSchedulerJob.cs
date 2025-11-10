using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_http_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobAppEngineHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST or PUT.
    /// It will result in invalid argument error to set a body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    public TerraformProperty<string>? Body
    {
        set => SetProperty("body", value);
    }

    /// <summary>
    /// HTTP request headers.
    /// This map contains the header field names and values.
    /// Headers can be set when the job is created.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Headers
    {
        set => SetProperty("headers", value);
    }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    public TerraformProperty<string>? HttpMethod
    {
        set => SetProperty("http_method", value);
    }

    /// <summary>
    /// The relative URI.
    /// The relative URL must begin with &amp;quot;/&amp;quot; and must be a valid HTTP relative URL.
    /// It can contain a path, query string arguments, and \# fragments.
    /// If the relative URL is empty, then the root path &amp;quot;/&amp;quot; will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUri is required")]
    public required TerraformProperty<string> RelativeUri
    {
        set => SetProperty("relative_uri", value);
    }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST, PUT, or PATCH.
    /// It is an error to set body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    public TerraformProperty<string>? Body
    {
        set => SetProperty("body", value);
    }

    /// <summary>
    /// This map contains the header field names and values.
    /// Repeated headers are not supported, but a header value can contain commas.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Headers
    {
        set => SetProperty("headers", value);
    }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    public TerraformProperty<string>? HttpMethod
    {
        set => SetProperty("http_method", value);
    }

    /// <summary>
    /// The full URI path that the request will be sent to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for pubsub_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobPubsubTargetBlock : TerraformBlock
{
    /// <summary>
    /// Attributes for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Attributes
    {
        set => SetProperty("attributes", value);
    }

    /// <summary>
    /// The message payload for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// 
    ///  A base64-encoded string.
    /// </summary>
    public TerraformProperty<string>? Data
    {
        set => SetProperty("data", value);
    }

    /// <summary>
    /// The full resource name for the Cloud Pub/Sub topic to which
    /// messages will be published when a job is delivered. ~&amp;gt;**NOTE:**
    /// The topic name must be in the same format as required by PubSub&#39;s
    /// PublishRequest.name, e.g. &#39;projects/my-project/topics/my-topic&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformProperty<string> TopicName
    {
        set => SetProperty("topic_name", value);
    }

}

/// <summary>
/// Block type for retry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobRetryConfigBlock : TerraformBlock
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    public TerraformProperty<string>? MaxBackoffDuration
    {
        set => SetProperty("max_backoff_duration", value);
    }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A job&#39;s retry interval starts at minBackoffDuration,
    /// then doubles maxDoublings times, then increases linearly,
    /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
    /// </summary>
    public TerraformProperty<double>? MaxDoublings
    {
        set => SetProperty("max_doublings", value);
    }

    /// <summary>
    /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
    /// If specified with retryCount, the job will be retried until both limits are reached.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    public TerraformProperty<string>? MaxRetryDuration
    {
        set => SetProperty("max_retry_duration", value);
    }

    /// <summary>
    /// The minimum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    public TerraformProperty<string>? MinBackoffDuration
    {
        set => SetProperty("min_backoff_duration", value);
    }

    /// <summary>
    /// The number of attempts that the system will make to run a
    /// job using the exponential backoff procedure described by maxDoublings.
    /// Values greater than 5 and negative values are not allowed.
    /// </summary>
    public TerraformProperty<double>? RetryCount
    {
        set => SetProperty("retry_count", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudSchedulerJobTimeoutsBlock : TerraformBlock
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
/// Manages a google_cloud_scheduler_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudSchedulerJob : TerraformResource
{
    public GoogleCloudSchedulerJob(string name) : base("google_cloud_scheduler_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("state");
        SetOutput("attempt_deadline");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("paused");
        SetOutput("project");
        SetOutput("region");
        SetOutput("schedule");
        SetOutput("time_zone");
    }

    /// <summary>
    /// The deadline for job attempts. If the request handler does not respond by this deadline then the request is
    /// cancelled and the attempt is marked as a DEADLINE_EXCEEDED failure. The failed attempt can be viewed in
    /// execution logs. Cloud Scheduler will retry the job according to the RetryConfig.
    /// The allowed duration for this deadline is:
    /// * For HTTP targets, between 15 seconds and 30 minutes.
    /// * For App Engine HTTP targets, between 15 seconds and 24 hours.
    /// * **Note**: For PubSub targets, this field is ignored - setting it will introduce an unresolvable diff.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    public TerraformProperty<string> AttemptDeadline
    {
        get => GetRequiredOutput<TerraformProperty<string>>("attempt_deadline");
        set => SetProperty("attempt_deadline", value);
    }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The name of the job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Sets the job to a paused state. Jobs default to being enabled when this property is not set.
    /// </summary>
    public TerraformProperty<bool> Paused
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("paused");
        set => SetProperty("paused", value);
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
    /// Region where the scheduler job resides. If it is not provided, Terraform will use the provider default.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Describes the schedule on which the job will be executed.
    /// </summary>
    public TerraformProperty<string> Schedule
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule");
        set => SetProperty("schedule", value);
    }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    public TerraformProperty<string> TimeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("time_zone");
        set => SetProperty("time_zone", value);
    }

    /// <summary>
    /// Block for app_engine_http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineHttpTarget block(s) allowed")]
    public List<GoogleCloudSchedulerJobAppEngineHttpTargetBlock>? AppEngineHttpTarget
    {
        set => SetProperty("app_engine_http_target", value);
    }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    public List<GoogleCloudSchedulerJobHttpTargetBlock>? HttpTarget
    {
        set => SetProperty("http_target", value);
    }

    /// <summary>
    /// Block for pubsub_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTarget block(s) allowed")]
    public List<GoogleCloudSchedulerJobPubsubTargetBlock>? PubsubTarget
    {
        set => SetProperty("pubsub_target", value);
    }

    /// <summary>
    /// Block for retry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    public List<GoogleCloudSchedulerJobRetryConfigBlock>? RetryConfig
    {
        set => SetProperty("retry_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudSchedulerJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// State of the job.
    /// </summary>
    public TerraformExpression State => this["state"];

}
