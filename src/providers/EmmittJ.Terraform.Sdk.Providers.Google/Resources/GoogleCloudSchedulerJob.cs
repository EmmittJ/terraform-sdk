using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_http_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobAppEngineHttpTargetBlock : ITerraformBlock
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST or PUT.
    /// It will result in invalid argument error to set a body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Body { get; set; }

    /// <summary>
    /// HTTP request headers.
    /// This map contains the header field names and values.
    /// Headers can be set when the job is created.
    /// </summary>
    [TerraformPropertyName("headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Headers { get; set; }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    [TerraformPropertyName("http_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpMethod { get; set; }

    /// <summary>
    /// The relative URI.
    /// The relative URL must begin with &amp;quot;/&amp;quot; and must be a valid HTTP relative URL.
    /// It can contain a path, query string arguments, and \# fragments.
    /// If the relative URL is empty, then the root path &amp;quot;/&amp;quot; will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUri is required")]
    [TerraformPropertyName("relative_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RelativeUri { get; set; }

}

/// <summary>
/// Block type for http_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobHttpTargetBlock : ITerraformBlock
{
    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST, PUT, or PATCH.
    /// It is an error to set body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Body { get; set; }

    /// <summary>
    /// This map contains the header field names and values.
    /// Repeated headers are not supported, but a header value can contain commas.
    /// </summary>
    [TerraformPropertyName("headers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Headers { get; set; }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    [TerraformPropertyName("http_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpMethod { get; set; }

    /// <summary>
    /// The full URI path that the request will be sent to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformPropertyName("uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Uri { get; set; }

}

/// <summary>
/// Block type for pubsub_target in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobPubsubTargetBlock : ITerraformBlock
{
    /// <summary>
    /// Attributes for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// </summary>
    [TerraformPropertyName("attributes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Attributes { get; set; }

    /// <summary>
    /// The message payload for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// 
    ///  A base64-encoded string.
    /// </summary>
    [TerraformPropertyName("data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Data { get; set; }

    /// <summary>
    /// The full resource name for the Cloud Pub/Sub topic to which
    /// messages will be published when a job is delivered. ~&amp;gt;**NOTE:**
    /// The topic name must be in the same format as required by PubSub&#39;s
    /// PublishRequest.name, e.g. &#39;projects/my-project/topics/my-topic&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    [TerraformPropertyName("topic_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TopicName { get; set; }

}

/// <summary>
/// Block type for retry_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobRetryConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    [TerraformPropertyName("max_backoff_duration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaxBackoffDuration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "max_backoff_duration");

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A job&#39;s retry interval starts at minBackoffDuration,
    /// then doubles maxDoublings times, then increases linearly,
    /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
    /// </summary>
    [TerraformPropertyName("max_doublings")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxDoublings { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_doublings");

    /// <summary>
    /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
    /// If specified with retryCount, the job will be retried until both limits are reached.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    [TerraformPropertyName("max_retry_duration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MaxRetryDuration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "max_retry_duration");

    /// <summary>
    /// The minimum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    [TerraformPropertyName("min_backoff_duration")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MinBackoffDuration { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "min_backoff_duration");

    /// <summary>
    /// The number of attempts that the system will make to run a
    /// job using the exponential backoff procedure described by maxDoublings.
    /// Values greater than 5 and negative values are not allowed.
    /// </summary>
    [TerraformPropertyName("retry_count")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> RetryCount { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "retry_count");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudSchedulerJobTimeoutsBlock : ITerraformBlock
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
/// Manages a google_cloud_scheduler_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudSchedulerJob : TerraformResource
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
    [TerraformPropertyName("attempt_deadline")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AttemptDeadline { get; set; }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Sets the job to a paused state. Jobs default to being enabled when this property is not set.
    /// </summary>
    [TerraformPropertyName("paused")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Paused { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "paused");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Region where the scheduler job resides. If it is not provided, Terraform will use the provider default.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Describes the schedule on which the job will be executed.
    /// </summary>
    [TerraformPropertyName("schedule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Schedule { get; set; }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    [TerraformPropertyName("time_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TimeZone { get; set; }

    /// <summary>
    /// Block for app_engine_http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineHttpTarget block(s) allowed")]
    [TerraformPropertyName("app_engine_http_target")]
    public TerraformList<TerraformBlock<GoogleCloudSchedulerJobAppEngineHttpTargetBlock>>? AppEngineHttpTarget { get; set; } = new();

    /// <summary>
    /// Block for http_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    [TerraformPropertyName("http_target")]
    public TerraformList<TerraformBlock<GoogleCloudSchedulerJobHttpTargetBlock>>? HttpTarget { get; set; } = new();

    /// <summary>
    /// Block for pubsub_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTarget block(s) allowed")]
    [TerraformPropertyName("pubsub_target")]
    public TerraformList<TerraformBlock<GoogleCloudSchedulerJobPubsubTargetBlock>>? PubsubTarget { get; set; } = new();

    /// <summary>
    /// Block for retry_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    [TerraformPropertyName("retry_config")]
    public TerraformList<TerraformBlock<GoogleCloudSchedulerJobRetryConfigBlock>>? RetryConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudSchedulerJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// State of the job.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
