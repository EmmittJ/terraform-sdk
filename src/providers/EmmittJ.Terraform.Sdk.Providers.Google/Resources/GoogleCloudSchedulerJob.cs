using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for app_engine_http_target in GoogleCloudSchedulerJob.
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobAppEngineHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_engine_http_target";

    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST or PUT.
    /// It will result in invalid argument error to set a body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// HTTP request headers.
    /// This map contains the header field names and values.
    /// Headers can be set when the job is created.
    /// </summary>
    public TerraformMap<string>? Headers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "headers").ResolveNodes(ctx));
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    public TerraformValue<string>? HttpMethod
    {
        get => new TerraformReference<string>(this, "http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// The relative URI.
    /// The relative URL must begin with &amp;quot;/&amp;quot; and must be a valid HTTP relative URL.
    /// It can contain a path, query string arguments, and \# fragments.
    /// If the relative URL is empty, then the root path &amp;quot;/&amp;quot; will be used.
    /// No spaces are allowed, and the maximum length allowed is 2083 characters
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeUri is required")]
    public required TerraformValue<string> RelativeUri
    {
        get => new TerraformReference<string>(this, "relative_uri");
        set => SetArgument("relative_uri", value);
    }

    /// <summary>
    /// AppEngineRouting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineRouting block(s) allowed")]
    public TerraformList<GoogleCloudSchedulerJobAppEngineHttpTargetBlockAppEngineRoutingBlock>? AppEngineRouting
    {
        get => GetArgument<TerraformList<GoogleCloudSchedulerJobAppEngineHttpTargetBlockAppEngineRoutingBlock>>("app_engine_routing");
        set => SetArgument("app_engine_routing", value);
    }

}

/// <summary>
/// Block type for app_engine_routing in GoogleCloudSchedulerJobAppEngineHttpTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobAppEngineHttpTargetBlockAppEngineRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_engine_routing";

    /// <summary>
    /// App instance.
    /// By default, the job is sent to an instance which is available when the job is attempted.
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// App service.
    /// By default, the job is sent to the service which is the default service when the job is attempted.
    /// </summary>
    public TerraformValue<string>? Service
    {
        get => new TerraformReference<string>(this, "service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// App version.
    /// By default, the job is sent to the version which is the default version when the job is attempted.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for http_target in GoogleCloudSchedulerJob.
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobHttpTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_target";

    /// <summary>
    /// HTTP request body.
    /// A request body is allowed only if the HTTP method is POST, PUT, or PATCH.
    /// It is an error to set body on a job with an incompatible HttpMethod.
    /// 
    /// A base64-encoded string.
    /// </summary>
    public TerraformValue<string>? Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// This map contains the header field names and values.
    /// Repeated headers are not supported, but a header value can contain commas.
    /// </summary>
    public TerraformMap<string>? Headers
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "headers").ResolveNodes(ctx));
        set => SetArgument("headers", value);
    }

    /// <summary>
    /// Which HTTP method to use for the request.
    /// </summary>
    public TerraformValue<string>? HttpMethod
    {
        get => new TerraformReference<string>(this, "http_method");
        set => SetArgument("http_method", value);
    }

    /// <summary>
    /// The full URI path that the request will be sent to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

    /// <summary>
    /// OauthToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthToken block(s) allowed")]
    public TerraformList<GoogleCloudSchedulerJobHttpTargetBlockOauthTokenBlock>? OauthToken
    {
        get => GetArgument<TerraformList<GoogleCloudSchedulerJobHttpTargetBlockOauthTokenBlock>>("oauth_token");
        set => SetArgument("oauth_token", value);
    }

    /// <summary>
    /// OidcToken block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcToken block(s) allowed")]
    public TerraformList<GoogleCloudSchedulerJobHttpTargetBlockOidcTokenBlock>? OidcToken
    {
        get => GetArgument<TerraformList<GoogleCloudSchedulerJobHttpTargetBlockOidcTokenBlock>>("oidc_token");
        set => SetArgument("oidc_token", value);
    }

}

/// <summary>
/// Block type for oauth_token in GoogleCloudSchedulerJobHttpTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobHttpTargetBlockOauthTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_token";

    /// <summary>
    /// OAuth scope to be used for generating OAuth access token. If not specified,
    /// &amp;quot;https://www.googleapis.com/auth/cloud-platform&amp;quot; will be used.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => new TerraformReference<string>(this, "service_account_email");
        set => SetArgument("service_account_email", value);
    }

}

/// <summary>
/// Block type for oidc_token in GoogleCloudSchedulerJobHttpTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobHttpTargetBlockOidcTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_token";

    /// <summary>
    /// Audience to be used when generating OIDC token. If not specified,
    /// the URI specified in target will be used.
    /// </summary>
    public TerraformValue<string>? Audience
    {
        get => new TerraformReference<string>(this, "audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// Service account email to be used for generating OAuth token.
    /// The service account must be within the same project as the job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccountEmail is required")]
    public required TerraformValue<string> ServiceAccountEmail
    {
        get => new TerraformReference<string>(this, "service_account_email");
        set => SetArgument("service_account_email", value);
    }

}


/// <summary>
/// Block type for pubsub_target in GoogleCloudSchedulerJob.
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobPubsubTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub_target";

    /// <summary>
    /// Attributes for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// </summary>
    public TerraformMap<string>? Attributes
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "attributes").ResolveNodes(ctx));
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// The message payload for PubsubMessage.
    /// Pubsub message must contain either non-empty data, or at least one attribute.
    /// 
    ///  A base64-encoded string.
    /// </summary>
    public TerraformValue<string>? Data
    {
        get => new TerraformReference<string>(this, "data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The full resource name for the Cloud Pub/Sub topic to which
    /// messages will be published when a job is delivered. ~&amp;gt;**NOTE:**
    /// The topic name must be in the same format as required by PubSub&#39;s
    /// PublishRequest.name, e.g. &#39;projects/my-project/topics/my-topic&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformValue<string> TopicName
    {
        get => new TerraformReference<string>(this, "topic_name");
        set => SetArgument("topic_name", value);
    }

}


/// <summary>
/// Block type for retry_config in GoogleCloudSchedulerJob.
/// Nesting mode: list
/// </summary>
public class GoogleCloudSchedulerJobRetryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_config";

    /// <summary>
    /// The maximum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    public TerraformValue<string> MaxBackoffDuration
    {
        get => new TerraformReference<string>(this, "max_backoff_duration");
        set => SetArgument("max_backoff_duration", value);
    }

    /// <summary>
    /// The time between retries will double maxDoublings times.
    /// A job&#39;s retry interval starts at minBackoffDuration,
    /// then doubles maxDoublings times, then increases linearly,
    /// and finally retries retries at intervals of maxBackoffDuration up to retryCount times.
    /// </summary>
    public TerraformValue<double> MaxDoublings
    {
        get => new TerraformReference<double>(this, "max_doublings");
        set => SetArgument("max_doublings", value);
    }

    /// <summary>
    /// The time limit for retrying a failed job, measured from time when an execution was first attempted.
    /// If specified with retryCount, the job will be retried until both limits are reached.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    public TerraformValue<string> MaxRetryDuration
    {
        get => new TerraformReference<string>(this, "max_retry_duration");
        set => SetArgument("max_retry_duration", value);
    }

    /// <summary>
    /// The minimum amount of time to wait before retrying a job after it fails.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;.
    /// </summary>
    public TerraformValue<string> MinBackoffDuration
    {
        get => new TerraformReference<string>(this, "min_backoff_duration");
        set => SetArgument("min_backoff_duration", value);
    }

    /// <summary>
    /// The number of attempts that the system will make to run a
    /// job using the exponential backoff procedure described by maxDoublings.
    /// Values greater than 5 and negative values are not allowed.
    /// </summary>
    public TerraformValue<double> RetryCount
    {
        get => new TerraformReference<double>(this, "retry_count");
        set => SetArgument("retry_count", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudSchedulerJob.
/// Nesting mode: single
/// </summary>
public class GoogleCloudSchedulerJobTimeoutsBlock : TerraformBlock
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
/// Represents a google_cloud_scheduler_job Terraform resource.
/// Manages a google_cloud_scheduler_job resource.
/// </summary>
public partial class GoogleCloudSchedulerJob(string name) : TerraformResource("google_cloud_scheduler_job", name)
{
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
    public TerraformValue<string>? AttemptDeadline
    {
        get => new TerraformReference<string>(this, "attempt_deadline");
        set => SetArgument("attempt_deadline", value);
    }

    /// <summary>
    /// A human-readable description for the job.
    /// This string must not contain more than 500 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The name of the job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Sets the job to a paused state. Jobs default to being enabled when this property is not set.
    /// </summary>
    public TerraformValue<bool> Paused
    {
        get => new TerraformReference<bool>(this, "paused");
        set => SetArgument("paused", value);
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
    /// Region where the scheduler job resides. If it is not provided, Terraform will use the provider default.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Describes the schedule on which the job will be executed.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Specifies the time zone to be used in interpreting schedule.
    /// The value of this field must be a time zone name from the tz database.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// State of the job.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// AppEngineHttpTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppEngineHttpTarget block(s) allowed")]
    public TerraformList<GoogleCloudSchedulerJobAppEngineHttpTargetBlock>? AppEngineHttpTarget
    {
        get => GetArgument<TerraformList<GoogleCloudSchedulerJobAppEngineHttpTargetBlock>>("app_engine_http_target");
        set => SetArgument("app_engine_http_target", value);
    }

    /// <summary>
    /// HttpTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpTarget block(s) allowed")]
    public TerraformList<GoogleCloudSchedulerJobHttpTargetBlock>? HttpTarget
    {
        get => GetArgument<TerraformList<GoogleCloudSchedulerJobHttpTargetBlock>>("http_target");
        set => SetArgument("http_target", value);
    }

    /// <summary>
    /// PubsubTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubTarget block(s) allowed")]
    public TerraformList<GoogleCloudSchedulerJobPubsubTargetBlock>? PubsubTarget
    {
        get => GetArgument<TerraformList<GoogleCloudSchedulerJobPubsubTargetBlock>>("pubsub_target");
        set => SetArgument("pubsub_target", value);
    }

    /// <summary>
    /// RetryConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryConfig block(s) allowed")]
    public TerraformList<GoogleCloudSchedulerJobRetryConfigBlock>? RetryConfig
    {
        get => GetArgument<TerraformList<GoogleCloudSchedulerJobRetryConfigBlock>>("retry_config");
        set => SetArgument("retry_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudSchedulerJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudSchedulerJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
