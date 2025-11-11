using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_http_target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudSchedulerJobAppEngineHttpTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST or PUT.
    /// It will result in invalid argument error to set a body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [TerraformProperty("body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// HTTP request headers.
    /// This map contains the header field names and values.
    /// Headers can be set when the job is created.
    /// </summary>
    [TerraformProperty("headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Headers { get; set; }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    [TerraformProperty("http_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpMethod { get; set; }

    /// <summary>
    /// The relative URI.
    /// The relative URL must begin with &amp;quot;/&amp;quot; and must be a valid HTTP relative URL.
    /// It can contain a path, query string arguments, and \# fragments.
    /// If the relative URL is empty, then the root path &amp;quot;/&amp;quot; will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUri is required")]
    [TerraformProperty("relative_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RelativeUri { get; set; }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudSchedulerJobHttpTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST, PUT, or PATCH.
    /// It is an error to set body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [TerraformProperty("body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// This map contains the header field names and values.
    /// Repeated headers are not supported, but a header value can contain commas.
    /// </summary>
    [TerraformProperty("headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Headers { get; set; }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    [TerraformProperty("http_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpMethod { get; set; }

    /// <summary>
    /// The full URI path that the request will be sent to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

}

/// <summary>
/// Block type for pubsub_target in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudSchedulerJobPubsubTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// Attributes for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// </summary>
    [TerraformProperty("attributes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Attributes { get; set; }

    /// <summary>
    /// The message payload for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// 
    ///  A base64-encoded string.
    /// </summary>
    [TerraformProperty("data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Data { get; set; }

    /// <summary>
    /// The full resource name for the Cloud Pub/Sub topic to which
    /// messages will be published when a job is delivered. ~&amp;gt;**NOTE:**
    /// The topic name must be in the same format as required by PubSub&#39;s
    /// PublishRequest.name, e.g. &#39;projects/my-project/topics/my-topic&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    [TerraformProperty("topic_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TopicName { get; set; }

}

/// <summary>
/// Block type for retry_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudSchedulerJobRetryConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    [TerraformProperty("max_backoff_duration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxBackoffDuration { get; set; }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A job&#39;s retry interval starts at minBackoffDuration,
    /// then doubles maxDoublings times, then increases linearly,
    /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
    /// </summary>
    [TerraformProperty("max_doublings")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxDoublings { get; set; }

    /// <summary>
    /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
    /// If specified with retryCount, the job will be retried until both limits are reached.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    [TerraformProperty("max_retry_duration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxRetryDuration { get; set; }

    /// <summary>
    /// The minimum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    [TerraformProperty("min_backoff_duration")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MinBackoffDuration { get; set; }

    /// <summary>
    /// The number of attempts that the system will make to run a
    /// job using the exponential backoff procedure described by maxDoublings.
    /// Values greater than 5 and negative values are not allowed.
    /// </summary>
    [TerraformProperty("retry_count")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RetryCount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudSchedulerJobTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_cloud_scheduler_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudSchedulerJob : TerraformResource
{
    public GoogleCloudSchedulerJob(string name) : base("google_cloud_scheduler_job", name)
    {
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
    [TerraformProperty("attempt_deadline")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AttemptDeadline { get; set; }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Sets the job to a paused state. Jobs default to being enabled when this property is not set.
    /// </summary>
    [TerraformProperty("paused")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Paused { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Region where the scheduler job resides. If it is not provided, Terraform will use the provider default.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Describes the schedule on which the job will be executed.
    /// </summary>
    [TerraformProperty("schedule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    [TerraformProperty("time_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TimeZone { get; set; }

    /// <summary>
    /// Block for app_engine_http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineHttpTarget block(s) allowed")]
    [TerraformProperty("app_engine_http_target")]
    public partial TerraformList<TerraformBlock<GoogleCloudSchedulerJobAppEngineHttpTargetBlock>>? AppEngineHttpTarget { get; set; }

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    [TerraformProperty("http_target")]
    public partial TerraformList<TerraformBlock<GoogleCloudSchedulerJobHttpTargetBlock>>? HttpTarget { get; set; }

    /// <summary>
    /// Block for pubsub_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTarget block(s) allowed")]
    [TerraformProperty("pubsub_target")]
    public partial TerraformList<TerraformBlock<GoogleCloudSchedulerJobPubsubTargetBlock>>? PubsubTarget { get; set; }

    /// <summary>
    /// Block for retry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    [TerraformProperty("retry_config")]
    public partial TerraformList<TerraformBlock<GoogleCloudSchedulerJobRetryConfigBlock>>? RetryConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleCloudSchedulerJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// State of the job.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

}
